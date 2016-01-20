using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace DocReadHelper
{
    public partial class frmMain : Form
    {
        Word.Application oWord = null;
        Word.Document oDoc = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Документы Microsoft Word|*.doc;*.docx;*.rtf";
            ofd.RestoreDirectory = true ;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textDocumentFile.Text = ofd.FileName;
            }
            ofd.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerWatchDoc.Enabled = false;
            if (oDoc != null)
            {
                try
                {
                    ((Word._Document)oDoc).Close();
                }
                catch { }
            }/*
            else
            {
                MessageBox.Show("Document is closed");
            }*/
            if (oWord != null)
            {
                try
                {
                    ((Word._Application)oWord).Quit();
                }
                catch { }
            }
        }

        private void btnOpenDoc_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textDocumentFile.Text))
            {
                try
                {
                    if (oWord == null)
                    {
                        oWord = new Word.Application();
                        oWord.Visible = false;
                        ((Word.ApplicationEvents4_Event)oWord).Quit += delegate
                        {
                            oWord = null;
                        };
                    }
                    if (oDoc != null)
                    {
                        ((Word._Document)oDoc).Close();
                        //oDoc.Close();
                    }
                    oDoc = oWord.Documents.Open(textDocumentFile.Text);

                    //Эвенты о закрытии документа
                    ((Word.DocumentEvents_Event)oDoc).Close += delegate
                    {
                        oDoc = null;
                    };

                    oWord.Visible = true;
                    btnOpenDoc.Enabled = false;
                    btnOpenFile.Enabled = false;
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                timerWatchDoc.Enabled = true;
            }
            else
            {
                MessageBox.Show("Выберите документ!");
            }
        }

        private void DocumentClose()
        {
            oDoc = null;
        }

        private void timerWatchDoc_Tick(object sender, EventArgs e)
        {
            if (oDoc == null)
            {
                btnOpenFile.Enabled = true;
                btnOpenDoc.Enabled = true;
            }
            if (oWord == null)
            {
                oDoc = null;
                btnOpenFile.Enabled = true;
                btnOpenDoc.Enabled = true;
            }
        }

    }
}
