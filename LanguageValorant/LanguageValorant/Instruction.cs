using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LanguageValorant
{
    public partial class Instruction : Form
    {
        public Instruction()
        {
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
            InitializeComponent();
        }

        string en = @"1. We check the correctness and availability of all folders.
 1.1. 'RiotClientServices.exe' file - RiotGames launcher file.
 1.2. 'VALORANT.exe' folder: - folder with Valorant.exe
 1.3. LangFilesFolder can be created anywhere, this is the folder where voice and text files will be stored.
2. Set language #1 in the game. We update the game client until the Play button appears.
3. Click in the program 'Copy all exist lang-files' (near LangFilesFolder)
4. Set language #2 in the game. We update the game client until the Play button appears.
5. Click in the program 'Copy all exist lang-files' (near LangFilesFolder)
6. Click the 'Create/Update .md5 File' button.
7. Set Delay (time in seconds for which the RiotGames launcher is fully loaded). Default is 10 seconds.
8. Set the checkboxes that you need to replace. ('I need (Audio)' / 'I need (Text)'). [If the checkbox is not checked, these files will not be replaced! If the language in the game is English, and the text is needed in Russian. Check the box for Text
9. Where ticked - select the desired language.
10. Check the box 'Rename and replace files' if you want the program to perform its main function. If removed, the program will simply launch the launcher.
11. Save settings 'Save Settings'
12. Click 'Start Launcher' - we expect the RiotGames launcher to open and close this program. After that, launch Valorant from the launcher.
13. We adjust Delay to your PC power. If it does not work correctly with the standard one (for example, the program may replace files and close before the launcher starts, then the launcher will ask for Update of the game and download the text / audio of the game (UPDATE THE GAME IN ANY EVENT SHOULD BE PERFORMED, AND ONLY AFTER THIS, TRY AGAIN!)
14. If you have configured everything and checked, check the AutoStart checkbox and save the settings.";
        string ru = @"1. Проверяем корректность и наличие всех папок. 
 1.1. 'RiotClientServices.exe' file - файл лаунчера RiotGames.
 1.2. 'VALORANT.exe' folder: - папка с Valorant.exe
 1.3. LangFilesFolder можно создать в любом месте, это папка где будут храниться файлы озвучки и текста.
2. Устанавливаем в игре язык №1. Обновляем клиент игры до появления кнопки Play.
3. Нажимаем в программе 'Copy all exist lang-files' (возле LangFilesFolder)
4. Устанавливаем в игре язык №2. Обновляем клиент игры до появления кнопки Play.
5. Нажимаем в программе 'Copy all exist lang-files' (возле LangFilesFolder)
6. Жмём кнопку 'Create/Update .md5 File'.
7. Устанавливаем Delay (время в секундах, за которое полностью загружается лаунчер RiotGames). По-дефолту 10 секунд.
8. Устанавливаем галочки что Вам нужно заменить. ('I need (Audio)' / 'I need (Text)'). [Если галочка не стоит, эти файлы не будут заменяться! Если в игре стоит язык Английский, а текст нужен на Русском. Ставим галочку на Текст
9. Там где поставили галочки - выбираем нужный язык.
10. Галочку 'Rename and replace files' оставляем, если нужно чтобы программа выполняла свою основную функцию. Если убрать, программа будет просто запускать лаунчер.
11. Сохраняем настройки 'Save Settings'
12. Жмём 'Start Launcher' - ожидаем открытия лаунчера RiotGames и закрытия этой программы. После этого из лаунчера запускаем Valorant.
13. Подгоняем Delay под Ваши мощности ПК. Если со стандартным работает некорректно (может к примеру программа выполнить замену файлов и закрыться раньше чем запуститься лаунчер, тогда лаунчер запросит Update игры и докачает текст/аудио игры (UPDATE ИГРЫ В ЛЮБОМ СЛУЧАЕ ПРИДЁТСЯ ВЫПОЛНИТЬ, И ТОЛЬКО ПОСЛЕ ЭТОГО ПРОБОВАТЬ СНОВА!)
14. Если настроили всё и проверили, ставьте галочку AutoStart и сохраните настройки.";

        private void Instruction_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                richTextBox1.Clear();
                richTextBox1.SelectedText = ru;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                richTextBox1.Clear();
                richTextBox1.SelectedText = en;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
        }
    }
}
