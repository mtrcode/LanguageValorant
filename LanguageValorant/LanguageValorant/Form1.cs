using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace LanguageValorant
{
    public partial class Form1 : Form
    {
        #region Variables
        
        string md5FilePath = "langFiles.md5", messageError = "", settingsFilePath = "languageValorant.ini";
        List<string> from, to; 
        Settings set;
        
        #region lists
        List<string> langCodes = new List<string>
        {
            "en_US",
            "de_DE",
            "ar_AE",
            "es_ES",
            "es_MX",
            "fr_FR",
            "id_ID",
            "it_IT",
            "ja_JP",
            "ko_KR",
            "pl_PL",
            "pt_BR",
            "ru_RU",
            "th_TH",
            "tr_TR",
            "vi_VN",
            "zh_TW"
        };
        List<string> languages = new List<string>
        {
            "English",
            "Deutsch",
            "Arabic",
            "Spanish (Español) (ES)",
            "Spanish (Español) (LATAM)",
            "French (Français)",
            "Bahasa Indonesia",
            "Italian",
            "Japanese",
            "Korean",
            "Polish (Polski)",
            "Portuguese (Português)",
            "Russian",
            "Thai",
            "Turkish",
            "Vietnamese",
            "Chinese"
        };

        List<string> langFiles, md5Files;

        #endregion
        
        #endregion

        #region events

        #region Form

        public Form1()
        {
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string lang in languages)
            {
                comboBox1.Items.Add(lang);
                comboBox2.Items.Add(lang);
            }
            readMD5File();
            currentLanguage_label.Text = languages[langCodes.IndexOf(GetCurrentGameLanguage())];
            comboBox1.SelectedIndex = langCodes.IndexOf(GetCurrentGameLanguage());
            comboBox2.SelectedIndex = 0;
            if (langFiles.Count > 0)
                start_launcher.Enabled = true;
            ReadSettings();
        }

        #endregion

        #region LinkLabels

        private void openFolderRiot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Directory.Exists(Path.GetDirectoryName(richTextBox1.Text)))
                Process.Start("explorer.exe", Path.GetDirectoryName(richTextBox1.Text));
            else
                MessageBox.Show("Error. This Folder isn't exist");
        }

        private void openFolderValorant_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Directory.Exists(richTextBox2.Text))
                Process.Start("explorer.exe", richTextBox2.Text);
            else
                MessageBox.Show("Error. This Folder isn't exist");
        }

        private void openFolderLangFiles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Directory.Exists(richTextBox3.Text))
                Process.Start("explorer.exe", richTextBox3.Text);
            else
                MessageBox.Show("Error. This Folder isn't exist");
        }

        private void openFolderValLangFiles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Directory.Exists(richTextBox2.Text + @"\ShooterGame\Content\Paks"))
                Process.Start("explorer.exe", richTextBox2.Text + @"\ShooterGame\Content\Paks");
            else
                MessageBox.Show("Error. This Folder isn't exist");
        }

        private void CopyLangFiles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Directory.Exists(richTextBox2.Text + @"\ShooterGame\Content\Paks") && Directory.Exists(richTextBox3.Text))
            {
                string[] files = Directory.GetFiles(richTextBox2.Text + @"\ShooterGame\Content\Paks");
                List<string> fileNames = new List<string>();
                foreach (string s in langCodes)
                {
                    fileNames.Add(s + "_Audio-WindowsClient.pak");
                    fileNames.Add(s + "_Audio-WindowsClient.sig");
                    fileNames.Add(s + "_Text-WindowsClient.pak");
                    fileNames.Add(s + "_Text-WindowsClient.sig");
                }
                foreach (string file in files)
                {
                    foreach (string s in fileNames)
                    {
                        if (Path.GetFileName(file) == s)
                        {
                            File.Copy(file, richTextBox3.Text + @"\" + Path.GetFileName(file));
                            break;
                        }
                    }
                }
            }
            else
                MessageBox.Show("Error. Check folders exists");
        }

        #endregion

        #region Buttons

        private void start_valorant_Click(object sender, EventArgs e)
        {
            Process.Start(richTextBox1.Text, "--launch-product=valorant --launch-patchline=live");
        }

        private void start_launcher_Click(object sender, EventArgs e)
        {
            autoStart();
        }

        private void UpdateMD5File_Button_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(richTextBox3.Text);
            md5Files = new List<string>();
            langFiles = new List<string>();
            foreach (string file in files)
            {
                if (Path.GetFileName(file).Contains("_Audio-WindowsClient.pak") ||
                    Path.GetFileName(file).Contains("_Audio-WindowsClient.sig") ||
                    Path.GetFileName(file).Contains("_Text-WindowsClient.pak") ||
                    Path.GetFileName(file).Contains("_Text-WindowsClient.sig"))
                {
                    langFiles.Add(Path.GetFileName(file));
                    md5Files.Add(md5HashFile(file));
                }
            }
            FileStream fs;
            fs = new FileStream(md5FilePath, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < langFiles.Count; i++)
            {
                sw.WriteLine(langFiles[i] + "-" + md5Files[i]);
            }
            sw.Close();
            fs.Close();
            start_launcher.Enabled = true;
        }

        private void SaveSettings_Button_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void chooseRiotFolder_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                richTextBox1.Text = ofd.FileName;
        }

        private void chooseValorantFolder_Button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                richTextBox2.Text = fbd.SelectedPath;
        }

        private void chooseLangFolder_Button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                richTextBox3.Text = fbd.SelectedPath;
        }

        #endregion

        #region CheckBoxes

        private void RenameAndReplace_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if ((RenameAndReplace_checkBox.Checked && langFiles.Count == 0) || !RenameAndReplace_checkBox.Checked)
                start_launcher.Enabled = true;
            if (RenameAndReplace_checkBox.Checked && langFiles.Count == 0)
                start_launcher.Enabled = false;
        }

        private void AutoStart_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
            Application.Restart();
        }

        #endregion

        #region Timers

        private void timerToClose_Tick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void timerDelay_Tick(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                File.Copy(from[0], to[0], true);
                File.Copy(from[1], to[1], true);
            }
            if (checkBox3.Checked)
            {
                File.Copy(from[2], to[2], true);
                File.Copy(from[3], to[3], true);
            }
            timerToClose.Enabled = true;
            timerDelay.Enabled = false;
            this.TopMost = true;
            MessageBox.Show("Files Copied. Start the game! (Program will closed soon)");
        }

        #endregion

        #endregion

        #region methods

        private string GetCurrentGameLanguage()
        {
            StreamReader sr = new StreamReader(@"C:\ProgramData\Riot Games\Metadata\valorant.live\valorant.live.ok");
            int c = 0;
            string line = "";
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                c++;
                if (c == 3)
                    break;
            }
            sr.Close();
            return line;
        }

        #region MD5

        private string md5HashFile(string filePath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }
        
        private bool readMD5File()
        {
            try
            {
                langFiles = new List<string>();
                md5Files = new List<string>();
                StreamReader sr = new StreamReader(md5FilePath);
                string line;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    string[] lineSplitted = line.Split('-');
                    langFiles.Add(lineSplitted[0] + lineSplitted[1]);
                    md5Files.Add(lineSplitted[2]);
                }
                sr.Close();
                return true;
            }
            catch
            {
                langFiles = new List<string>();
                md5Files = new List<string>();
                if(File.Exists(md5FilePath))
                    MessageBox.Show("error reading md5 file");
                return false;
            };

        }

        private bool compareMD5()
        {
            //returned true = error
            //returned false = all OK
            to = new List<string>
            {
                richTextBox2.Text + @"\ShooterGame\Content\Paks\" + GetCurrentGameLanguage() + "_Audio-WindowsClient.pak",
                richTextBox2.Text + @"\ShooterGame\Content\Paks\" + GetCurrentGameLanguage() + "_Audio-WindowsClient.sig",
                richTextBox2.Text + @"\ShooterGame\Content\Paks\" + GetCurrentGameLanguage() + "_Text-WindowsClient.pak",
                richTextBox2.Text + @"\ShooterGame\Content\Paks\" + GetCurrentGameLanguage() + "_Text-WindowsClient.sig"
            };
            foreach (string t in to)
            {
                string md5 = md5HashFile(t);
                bool contains = false;
                foreach (string md5f in md5Files)
                {
                    if (md5 == md5f)
                    {
                        contains = true;
                        break;
                    }
                }
                if (!contains)
                    return true;
            }
            return false;
        }
       
        #endregion

        #region Settings
        
        private void SaveDefaultSettings()
        {
            set = new Settings();
            XmlSerializer formatter = new XmlSerializer(typeof(Settings));
            using (FileStream fs = new FileStream(settingsFilePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, set);
            }
        }

        private void SaveSettings()
        {
            set = new Settings(richTextBox1.Text, richTextBox2.Text, richTextBox3.Text, Convert.ToInt32(numericUpDown1.Value), comboBox1.SelectedIndex, comboBox2.SelectedIndex,
                checkBox2.Checked, checkBox3.Checked, RenameAndReplace_checkBox.Checked, AutoStart_checkBox.Checked);
            if (File.Exists(settingsFilePath))
                File.Delete(settingsFilePath);
            XmlSerializer formatter = new XmlSerializer(typeof(Settings));
            using (FileStream fs = new FileStream(settingsFilePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, set);
            }
            MessageBox.Show("Settings Saved");
        }

        private void ReadSettings()
        {
            if (File.Exists(settingsFilePath))
            {
                try
                {
                    XmlSerializer formatter = new XmlSerializer(typeof(Settings));
                    using (FileStream fs = new FileStream(settingsFilePath, FileMode.OpenOrCreate))
                    {
                        set = (Settings)formatter.Deserialize(fs);
                    }
                    richTextBox1.Text = set.RiotClientServices_file;
                    richTextBox2.Text = set.VALORANT_folder;
                    richTextBox3.Text = set.langFilesFolder;
                    numericUpDown1.Value = set.delay;
                    checkBox2.Checked = set.needAudio;
                    checkBox3.Checked = set.needText;
                    RenameAndReplace_checkBox.Checked = set.renameAndReplace;
                    AutoStart_checkBox.Checked = set.autostart;
                    comboBox1.SelectedIndex = set.audioLang;
                    comboBox2.SelectedIndex = set.textLang;
                    comboBox1.Enabled = checkBox2.Checked;
                    comboBox2.Enabled = checkBox3.Checked;
                    if (set.autostart)
                        autoStart();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error. Reading settings. Try remove settings file.\r\nErrorMessage: " + ex.Message);
                    Environment.Exit(0);
                }
            }
            else
            {
                try
                {
                    SaveDefaultSettings();
                    Application.Restart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error. Default settings restored. App will restarted. Press OK.");
                }
            }
        }
        
        #endregion

        bool replaceFiles(bool start)
        {
            //start = replace files old
            //finish = replace files new
            to = new List<string>
            {
                richTextBox2.Text + @"\ShooterGame\Content\Paks\" + GetCurrentGameLanguage() + "_Audio-WindowsClient.pak",
                richTextBox2.Text + @"\ShooterGame\Content\Paks\" + GetCurrentGameLanguage() + "_Audio-WindowsClient.sig",
                richTextBox2.Text + @"\ShooterGame\Content\Paks\" + GetCurrentGameLanguage() + "_Text-WindowsClient.pak",
                richTextBox2.Text + @"\ShooterGame\Content\Paks\" + GetCurrentGameLanguage() + "_Text-WindowsClient.sig"
            };
            if (start)
            {
                from = new List<string>
                {
                
                    richTextBox3.Text + @"\" + GetCurrentGameLanguage() + "_Audio-WindowsClient.pak",
                    richTextBox3.Text + @"\" + GetCurrentGameLanguage() + "_Audio-WindowsClient.sig",
                    richTextBox3.Text + @"\" + GetCurrentGameLanguage() + "_Text-WindowsClient.pak",
                    richTextBox3.Text + @"\" + GetCurrentGameLanguage() + "_Text-WindowsClient.sig"
                };
                File.Copy(from[0], to[0], true);
                File.Copy(from[1], to[1], true);
                File.Copy(from[2], to[2], true);
                File.Copy(from[3], to[3], true);
            }
            else
            {
                from = new List<string>
                {
                
                    richTextBox3.Text + @"\" + langCodes[comboBox1.SelectedIndex] + "_Audio-WindowsClient.pak",
                    richTextBox3.Text + @"\" + langCodes[comboBox1.SelectedIndex] + "_Audio-WindowsClient.sig",
                    richTextBox3.Text + @"\" + langCodes[comboBox2.SelectedIndex] + "_Text-WindowsClient.pak",
                    richTextBox3.Text + @"\" + langCodes[comboBox2.SelectedIndex] + "_Text-WindowsClient.sig"
                };
            }


            bool filesExists = false;
            messageError = "Files not Exists:\n";
            foreach (string s in from)
            {
                if (!File.Exists(s))
                {
                    messageError += s + "\n";
                    filesExists = true;
                }
            }
            return filesExists;
        }

        private void autoStart()
        {
            if (!RenameAndReplace_checkBox.Checked && File.Exists(richTextBox1.Text))
                Process.Start(richTextBox1.Text);
            else
            {
                if (md5Files.Count == 0)
                    MessageBox.Show("MD5 File Error. Press 'update or create .md5 File'");
                else
                {
                    if (compareMD5())
                        MessageBox.Show("MD5 Files Changed. Replace it");
                    else
                    {
                        if (replaceFiles(true))
                            MessageBox.Show(messageError);
                        else
                        {
                            if (replaceFiles(false))
                                MessageBox.Show(messageError);
                            else
                            {
                                Process.Start(richTextBox1.Text);
                                timerDelay.Interval = Convert.ToInt32(numericUpDown1.Value) * 1000;
                                timerDelay.Enabled = true;
                            }
                        }
                    }
                }
            }
        }

        #endregion

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = checkBox3.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Instruction inst = new Instruction();
            inst.Show();
        }
    }
}
