namespace DocReadHelper
{
    partial class frmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textDocumentFile = new System.Windows.Forms.TextBox();
            this.timerWatchDoc = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textSpeed = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSpeedDown = new System.Windows.Forms.Button();
            this.btnSpeedUp = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnToHome = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя файла:";
            // 
            // textDocumentFile
            // 
            this.textDocumentFile.Location = new System.Drawing.Point(85, 12);
            this.textDocumentFile.Name = "textDocumentFile";
            this.textDocumentFile.ReadOnly = true;
            this.textDocumentFile.Size = new System.Drawing.Size(240, 20);
            this.textDocumentFile.TabIndex = 0;
            // 
            // timerWatchDoc
            // 
            this.timerWatchDoc.Tick += new System.EventHandler(this.timerWatchDoc_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Скорость чтения:";
            // 
            // textSpeed
            // 
            this.textSpeed.Location = new System.Drawing.Point(113, 42);
            this.textSpeed.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.textSpeed.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.textSpeed.Name = "textSpeed";
            this.textSpeed.Size = new System.Drawing.Size(60, 20);
            this.textSpeed.TabIndex = 3;
            this.textSpeed.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.textSpeed.ValueChanged += new System.EventHandler(this.textSpeed_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "слов/мин.";
            // 
            // btnSpeedDown
            // 
            this.btnSpeedDown.Enabled = false;
            this.btnSpeedDown.Image = global::DocReadHelper.Properties.Resources.control_rewind_blue;
            this.btnSpeedDown.Location = new System.Drawing.Point(276, 39);
            this.btnSpeedDown.Name = "btnSpeedDown";
            this.btnSpeedDown.Size = new System.Drawing.Size(23, 23);
            this.btnSpeedDown.TabIndex = 5;
            this.btnSpeedDown.UseVisualStyleBackColor = true;
            this.btnSpeedDown.Click += new System.EventHandler(this.btnSpeedDown_Click);
            // 
            // btnSpeedUp
            // 
            this.btnSpeedUp.Enabled = false;
            this.btnSpeedUp.Image = global::DocReadHelper.Properties.Resources.control_fastforward_blue;
            this.btnSpeedUp.Location = new System.Drawing.Point(363, 39);
            this.btnSpeedUp.Name = "btnSpeedUp";
            this.btnSpeedUp.Size = new System.Drawing.Size(23, 23);
            this.btnSpeedUp.TabIndex = 8;
            this.btnSpeedUp.UseVisualStyleBackColor = true;
            this.btnSpeedUp.Click += new System.EventHandler(this.btnSpeedUp_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Image = global::DocReadHelper.Properties.Resources.control_pause_blue;
            this.btnStop.Location = new System.Drawing.Point(334, 39);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(23, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Image = global::DocReadHelper.Properties.Resources.control_play_blue;
            this.btnStart.Location = new System.Drawing.Point(305, 39);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(23, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnToHome
            // 
            this.btnToHome.Enabled = false;
            this.btnToHome.Image = global::DocReadHelper.Properties.Resources.control_start_blue;
            this.btnToHome.Location = new System.Drawing.Point(247, 39);
            this.btnToHome.Name = "btnToHome";
            this.btnToHome.Size = new System.Drawing.Size(23, 23);
            this.btnToHome.TabIndex = 4;
            this.btnToHome.UseVisualStyleBackColor = true;
            this.btnToHome.Click += new System.EventHandler(this.btnToHome_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Image = global::DocReadHelper.Properties.Resources._49;
            this.btnHelp.Location = new System.Drawing.Point(363, 10);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 23);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Image = global::DocReadHelper.Properties.Resources.folder_page;
            this.btnOpenFile.Location = new System.Drawing.Point(331, 10);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(26, 23);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 68);
            this.Controls.Add(this.btnSpeedDown);
            this.Controls.Add(this.btnSpeedUp);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnToHome);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.textDocumentFile);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Document Read Helper";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.textSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDocumentFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Timer timerWatchDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown textSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnToHome;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSpeedUp;
        private System.Windows.Forms.Button btnSpeedDown;
    }
}

