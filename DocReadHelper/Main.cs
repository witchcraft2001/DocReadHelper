using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;

namespace DocReadHelper
{
    public partial class frmMain : Form
    {
        static Word.Application oWord = null;
        static Word.Document oDoc = null;
        static int wLenght = 1;
        static int wSpeed = 100;
        static System.Windows.Forms.Timer timer = null;

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
                        }
                        oDoc = oWord.Documents.Open(textDocumentFile.Text);

                        //Эвенты о закрытии документа
                        ((Word.DocumentEvents_Event)oDoc).Close += delegate
                        {
                            oDoc = null;
                        };

                        oWord.Visible = true;
                        btnStart.Enabled = true;
                        btnToHome.Enabled = true;                        
                        btnOpenFile.Enabled = false;
                    }
                    catch (Exception exc)
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
            ofd.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerWatchDoc.Enabled = false;
            if (timer != null) btnStop_Click(sender, e);
        }

        private void btnOpenDoc_Click(object sender, EventArgs e)
        {
            
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
            }
            if (oWord == null)
            {
                oDoc = null;
                btnOpenFile.Enabled = true;
            }
            if (oDoc == null || oWord == null)
            {
                btnSpeedDown.Enabled = false;
                btnSpeedUp.Enabled = false;
                btnStart.Enabled = false;
                btnStop.Enabled = false;
                btnToHome.Enabled = false;
            }
        }

        private void btnToHome_Click(object sender, EventArgs e)
        {
            if (oDoc != null)
            {
                Word.Range rng = oDoc.Range(0, 0);
                rng.Select();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            wSpeed = (int)textSpeed.Value;
            if (oWord != null)
            {
                oWord.ShowMe();
            }

            if (timer == null)
            {
                timer = new Timer();
                timer.Interval = 100;
                timer.Tick += NextWord;
                timer.Start();
            }
            btnSpeedDown.Enabled = true;
            btnSpeedUp.Enabled = true;
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            this.Opacity = 50;
        }

        private static void NextWord(Object myObject, EventArgs e)
        {
            if (oDoc != null)
            {
                timer.Stop();
                    oWord.Selection.MoveRight(Word.WdUnits.wdWord, 1);
                    oWord.Selection.Expand(Word.WdUnits.wdWord);
                    wLenght = ((3500 / (wSpeed * 6)) * (oWord.Selection.Characters.Count > 1 ? oWord.Selection.Characters.Count : 1)) * 20;
                    timer.Interval = wLenght;
                    timer.Start();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            btnSpeedUp.Enabled = false;
            btnSpeedDown.Enabled = false;
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
                timer = null;
            }
            this.Opacity = 100;
        }

        private void btnSpeedUp_Click(object sender, EventArgs e)
        {
            if (textSpeed.Value < textSpeed.Maximum)
            {
                wSpeed = (int)((textSpeed.Value + 10)>textSpeed.Maximum?textSpeed.Maximum:textSpeed.Value + 10);
                textSpeed.Value = wSpeed;
            }
            if (oWord != null)
            {
                oWord.ShowMe();
            }
        }

        private void btnSpeedDown_Click(object sender, EventArgs e)
        {
            if (textSpeed.Value > textSpeed.Minimum)
            {
                wSpeed = (int)((textSpeed.Value - 10) < textSpeed.Minimum ? textSpeed.Minimum : textSpeed.Value - 10);
                textSpeed.Value = wSpeed;
            }
            if (oWord != null)
            {
                oWord.ShowMe();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            /*
             * To set the version number, create/edit AssemblyInfo.cs

             * [assembly: AssemblyVersion("1.0.*")]
             * [assembly: AssemblyFileVersion("1.0.*")]
             * Also as a side note, the third number is the number of days since 2/1/2000
             * and the fourth number is half of the amount of total seconds in the day.
             * So if you compile at midnight it should be zero.
             */
            DateTime date = new DateTime(2000, 1, 1);
            string[] verinfo = AssemblyVersion.Split('.');
            date = date.AddDays(Convert.ToInt32(verinfo[2]));
            date = date.AddSeconds(Convert.ToInt32(verinfo[3]) * 2);
            MessageBox.Show(string.Format("Document Reading Helper ver.{0}.{1}\r\nВремя сборки: {2}\r\n\r\nРазработчик:\r\n\tМихальченков Дмитрий\r\n\tmikhaltchenkov@gmail.com", verinfo[0], verinfo[1], date), "О программе...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        private void textSpeed_ValueChanged(object sender, EventArgs e)
        {
            wSpeed = (int)textSpeed.Value;
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            string[] verinfo = AssemblyVersion.Split('.');
            this.Text = string.Format("Document Reading Helper v.{0}.{1}",verinfo[0],verinfo[1]);
        }

    }
}
