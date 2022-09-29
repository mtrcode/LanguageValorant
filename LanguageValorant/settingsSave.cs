using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageValorant
{
    [Serializable]
    public class Settings
    {
        public string RiotClientServices_file { get; set; }
        public string VALORANT_folder { get; set; }
        public string langFilesFolder { get; set; }
        public bool needAudio { get; set; }
        public bool needText { get; set; }
        public bool renameAndReplace { get; set; }
        public bool autostart { get; set; }
        public int audioLang { get; set; }
        public int textLang { get; set; }
        public int delay { get; set; }

        public Settings()
        {
            RiotClientServices_file = @"C:\Program Files\Riot Games\Riot Client\RiotClientServices.exe";
            VALORANT_folder = @"C:\Program Files\Riot Games\VALORANT\live";
            langFilesFolder = @"C:\Program Files\Riot Games\LangFiles";
            delay = 10;
            audioLang = 0;
            textLang = 0;
            needAudio = true;
            needText = false;
            renameAndReplace = true;
            autostart = false;
        }
        public Settings(string RiotClientServicesFile, string VALORANE_Folder, string langFilesFolder1, int Delay, int AudioLang, int TextLang,
            bool NeedAudio, bool NeedText, bool RenameAndReplace, bool AutoStart)
        {
            RiotClientServices_file = RiotClientServicesFile;
            VALORANT_folder = VALORANE_Folder;
            langFilesFolder = langFilesFolder1;
            delay = Delay;
            audioLang = AudioLang;
            textLang = TextLang;
            needAudio = NeedAudio;
            needText = NeedText;
            renameAndReplace = RenameAndReplace;
            autostart = AutoStart;
        }

    }
}
