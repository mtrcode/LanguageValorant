namespace LanguageValorant
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.start_valorant = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currentLanguage_label = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.start_launcher = new System.Windows.Forms.Button();
            this.RenameAndReplace_checkBox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.chooseRiotFolder_Button = new System.Windows.Forms.Button();
            this.chooseValorantFolder_Button = new System.Windows.Forms.Button();
            this.chooseLangFolder_Button = new System.Windows.Forms.Button();
            this.UpdateMD5File_Button = new System.Windows.Forms.Button();
            this.SaveSettings_Button = new System.Windows.Forms.Button();
            this.openFolderLangFiles = new System.Windows.Forms.LinkLabel();
            this.openFolderRiot = new System.Windows.Forms.LinkLabel();
            this.openFolderValorant = new System.Windows.Forms.LinkLabel();
            this.openFolderValLangFiles = new System.Windows.Forms.LinkLabel();
            this.CopyLangFiles = new System.Windows.Forms.LinkLabel();
            this.timerDelay = new System.Windows.Forms.Timer(this.components);
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.timerToClose = new System.Windows.Forms.Timer(this.components);
            this.AutoStart_checkBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(12, 57);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(397, 19);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // start_valorant
            // 
            this.start_valorant.Location = new System.Drawing.Point(12, 341);
            this.start_valorant.Name = "start_valorant";
            this.start_valorant.Size = new System.Drawing.Size(430, 23);
            this.start_valorant.TabIndex = 2;
            this.start_valorant.Text = "Start Valorant (w/o replacing files)";
            this.start_valorant.UseVisualStyleBackColor = true;
            this.start_valorant.Click += new System.EventHandler(this.start_valorant_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.Location = new System.Drawing.Point(12, 115);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(397, 19);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current language:";
            // 
            // currentLanguage_label
            // 
            this.currentLanguage_label.AutoSize = true;
            this.currentLanguage_label.Location = new System.Drawing.Point(96, 201);
            this.currentLanguage_label.Name = "currentLanguage_label";
            this.currentLanguage_label.Size = new System.Drawing.Size(65, 13);
            this.currentLanguage_label.TabIndex = 5;
            this.currentLanguage_label.Text = "UNKNOWN";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(52, 229);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Delay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "seconds";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 280);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(234, 280);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(204, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "\'VALORANT.exe\' folder:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "\'RiotClientServices.exe\' file:";
            // 
            // start_launcher
            // 
            this.start_launcher.Enabled = false;
            this.start_launcher.Location = new System.Drawing.Point(243, 312);
            this.start_launcher.Name = "start_launcher";
            this.start_launcher.Size = new System.Drawing.Size(199, 23);
            this.start_launcher.TabIndex = 20;
            this.start_launcher.Text = "Start Launcher";
            this.start_launcher.UseVisualStyleBackColor = true;
            this.start_launcher.Click += new System.EventHandler(this.start_launcher_Click);
            // 
            // RenameAndReplace_checkBox
            // 
            this.RenameAndReplace_checkBox.AutoSize = true;
            this.RenameAndReplace_checkBox.Location = new System.Drawing.Point(15, 316);
            this.RenameAndReplace_checkBox.Name = "RenameAndReplace_checkBox";
            this.RenameAndReplace_checkBox.Size = new System.Drawing.Size(146, 17);
            this.RenameAndReplace_checkBox.TabIndex = 21;
            this.RenameAndReplace_checkBox.Text = "Rename and replace files";
            this.RenameAndReplace_checkBox.UseVisualStyleBackColor = true;
            this.RenameAndReplace_checkBox.CheckedChanged += new System.EventHandler(this.RenameAndReplace_checkBox_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "LangFilesFolder:";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.White;
            this.richTextBox3.Location = new System.Drawing.Point(12, 168);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(397, 19);
            this.richTextBox3.TabIndex = 22;
            this.richTextBox3.Text = "";
            // 
            // chooseRiotFolder_Button
            // 
            this.chooseRiotFolder_Button.Location = new System.Drawing.Point(415, 53);
            this.chooseRiotFolder_Button.Name = "chooseRiotFolder_Button";
            this.chooseRiotFolder_Button.Size = new System.Drawing.Size(27, 23);
            this.chooseRiotFolder_Button.TabIndex = 24;
            this.chooseRiotFolder_Button.Text = "...";
            this.chooseRiotFolder_Button.UseVisualStyleBackColor = true;
            this.chooseRiotFolder_Button.Click += new System.EventHandler(this.chooseRiotFolder_Button_Click);
            // 
            // chooseValorantFolder_Button
            // 
            this.chooseValorantFolder_Button.Location = new System.Drawing.Point(415, 111);
            this.chooseValorantFolder_Button.Name = "chooseValorantFolder_Button";
            this.chooseValorantFolder_Button.Size = new System.Drawing.Size(27, 23);
            this.chooseValorantFolder_Button.TabIndex = 25;
            this.chooseValorantFolder_Button.Text = "...";
            this.chooseValorantFolder_Button.UseVisualStyleBackColor = true;
            this.chooseValorantFolder_Button.Click += new System.EventHandler(this.chooseValorantFolder_Button_Click);
            // 
            // chooseLangFolder_Button
            // 
            this.chooseLangFolder_Button.Location = new System.Drawing.Point(415, 164);
            this.chooseLangFolder_Button.Name = "chooseLangFolder_Button";
            this.chooseLangFolder_Button.Size = new System.Drawing.Size(27, 23);
            this.chooseLangFolder_Button.TabIndex = 26;
            this.chooseLangFolder_Button.Text = "...";
            this.chooseLangFolder_Button.UseVisualStyleBackColor = true;
            this.chooseLangFolder_Button.Click += new System.EventHandler(this.chooseLangFolder_Button_Click);
            // 
            // UpdateMD5File_Button
            // 
            this.UpdateMD5File_Button.Location = new System.Drawing.Point(238, 196);
            this.UpdateMD5File_Button.Name = "UpdateMD5File_Button";
            this.UpdateMD5File_Button.Size = new System.Drawing.Size(200, 23);
            this.UpdateMD5File_Button.TabIndex = 27;
            this.UpdateMD5File_Button.Text = "Create/Update .md5 File";
            this.UpdateMD5File_Button.UseVisualStyleBackColor = true;
            this.UpdateMD5File_Button.Click += new System.EventHandler(this.UpdateMD5File_Button_Click);
            // 
            // SaveSettings_Button
            // 
            this.SaveSettings_Button.Location = new System.Drawing.Point(238, 225);
            this.SaveSettings_Button.Name = "SaveSettings_Button";
            this.SaveSettings_Button.Size = new System.Drawing.Size(200, 23);
            this.SaveSettings_Button.TabIndex = 28;
            this.SaveSettings_Button.Text = "Save Settings";
            this.SaveSettings_Button.UseVisualStyleBackColor = true;
            this.SaveSettings_Button.Click += new System.EventHandler(this.SaveSettings_Button_Click);
            // 
            // openFolderLangFiles
            // 
            this.openFolderLangFiles.AutoSize = true;
            this.openFolderLangFiles.Location = new System.Drawing.Point(328, 152);
            this.openFolderLangFiles.Name = "openFolderLangFiles";
            this.openFolderLangFiles.Size = new System.Drawing.Size(81, 13);
            this.openFolderLangFiles.TabIndex = 31;
            this.openFolderLangFiles.TabStop = true;
            this.openFolderLangFiles.Text = "Open this folder";
            this.openFolderLangFiles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openFolderLangFiles_LinkClicked);
            // 
            // openFolderRiot
            // 
            this.openFolderRiot.AutoSize = true;
            this.openFolderRiot.Location = new System.Drawing.Point(328, 41);
            this.openFolderRiot.Name = "openFolderRiot";
            this.openFolderRiot.Size = new System.Drawing.Size(81, 13);
            this.openFolderRiot.TabIndex = 32;
            this.openFolderRiot.TabStop = true;
            this.openFolderRiot.Text = "Open this folder";
            this.openFolderRiot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openFolderRiot_LinkClicked);
            // 
            // openFolderValorant
            // 
            this.openFolderValorant.AutoSize = true;
            this.openFolderValorant.Location = new System.Drawing.Point(328, 99);
            this.openFolderValorant.Name = "openFolderValorant";
            this.openFolderValorant.Size = new System.Drawing.Size(81, 13);
            this.openFolderValorant.TabIndex = 33;
            this.openFolderValorant.TabStop = true;
            this.openFolderValorant.Text = "Open this folder";
            this.openFolderValorant.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openFolderValorant_LinkClicked);
            // 
            // openFolderValLangFiles
            // 
            this.openFolderValLangFiles.AutoSize = true;
            this.openFolderValLangFiles.Location = new System.Drawing.Point(184, 99);
            this.openFolderValLangFiles.Name = "openFolderValLangFiles";
            this.openFolderValLangFiles.Size = new System.Drawing.Size(128, 13);
            this.openFolderValLangFiles.TabIndex = 34;
            this.openFolderValLangFiles.TabStop = true;
            this.openFolderValLangFiles.Text = "Open folder with lang-files";
            this.openFolderValLangFiles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openFolderValLangFiles_LinkClicked);
            // 
            // CopyLangFiles
            // 
            this.CopyLangFiles.AutoSize = true;
            this.CopyLangFiles.Location = new System.Drawing.Point(184, 152);
            this.CopyLangFiles.Name = "CopyLangFiles";
            this.CopyLangFiles.Size = new System.Drawing.Size(112, 13);
            this.CopyLangFiles.TabIndex = 35;
            this.CopyLangFiles.TabStop = true;
            this.CopyLangFiles.Text = "Copy all exist lang-files";
            this.CopyLangFiles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyLangFiles_LinkClicked);
            // 
            // timerDelay
            // 
            this.timerDelay.Tick += new System.EventHandler(this.timerDelay_Tick);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 258);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 17);
            this.checkBox2.TabIndex = 36;
            this.checkBox2.Text = "I need (Audio):";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(234, 258);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(89, 17);
            this.checkBox3.TabIndex = 37;
            this.checkBox3.Text = "I need (Text):";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // timerToClose
            // 
            this.timerToClose.Interval = 3000;
            this.timerToClose.Tick += new System.EventHandler(this.timerToClose_Tick);
            // 
            // AutoStart_checkBox
            // 
            this.AutoStart_checkBox.AutoSize = true;
            this.AutoStart_checkBox.Location = new System.Drawing.Point(167, 316);
            this.AutoStart_checkBox.Name = "AutoStart_checkBox";
            this.AutoStart_checkBox.Size = new System.Drawing.Size(70, 17);
            this.AutoStart_checkBox.TabIndex = 39;
            this.AutoStart_checkBox.Text = "AutoStart";
            this.AutoStart_checkBox.UseVisualStyleBackColor = true;
            this.AutoStart_checkBox.CheckedChanged += new System.EventHandler(this.AutoStart_checkBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(430, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Инструкция / Instruction";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(-3, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 58);
            this.label2.TabIndex = 41;
            this.label2.Text = "WARNING!\r\nYou use this software at your own risk!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AutoStart_checkBox);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.CopyLangFiles);
            this.Controls.Add(this.openFolderValLangFiles);
            this.Controls.Add(this.openFolderValorant);
            this.Controls.Add(this.openFolderRiot);
            this.Controls.Add(this.openFolderLangFiles);
            this.Controls.Add(this.SaveSettings_Button);
            this.Controls.Add(this.UpdateMD5File_Button);
            this.Controls.Add(this.chooseLangFolder_Button);
            this.Controls.Add(this.chooseValorantFolder_Button);
            this.Controls.Add(this.chooseRiotFolder_Button);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.RenameAndReplace_checkBox);
            this.Controls.Add(this.start_launcher);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.currentLanguage_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.start_valorant);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valorant Starter [Language]";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button start_valorant;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentLanguage_label;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button start_launcher;
        private System.Windows.Forms.CheckBox RenameAndReplace_checkBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button chooseRiotFolder_Button;
        private System.Windows.Forms.Button chooseValorantFolder_Button;
        private System.Windows.Forms.Button chooseLangFolder_Button;
        private System.Windows.Forms.Button UpdateMD5File_Button;
        private System.Windows.Forms.Button SaveSettings_Button;
        private System.Windows.Forms.LinkLabel openFolderLangFiles;
        private System.Windows.Forms.LinkLabel openFolderRiot;
        private System.Windows.Forms.LinkLabel openFolderValorant;
        private System.Windows.Forms.LinkLabel openFolderValLangFiles;
        private System.Windows.Forms.LinkLabel CopyLangFiles;
        private System.Windows.Forms.Timer timerDelay;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Timer timerToClose;
        private System.Windows.Forms.CheckBox AutoStart_checkBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

