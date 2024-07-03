using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Input;


namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //CheckForConfig();
        } //Initialize UI

        //Create system files. In this case, just the config

        readonly String AppConfigPath = @"QuickRefConfig.txt";

        double timeLeft; //actual value used for timer per tick
        int minutes; //value derived from timeLeft to calculate string for gui 
        int seconds; //value derived from timeLeft to calculate string for gui 
        bool TimerActive = false; //just an easier way to check the .active parameter. i can probably do away with this.
        int timeInterval; //interval for drawings set with the settime method
        bool BetweenIntervals; // just to tell other methods if the its break time. might not need this?
        int TimeLeftBetweenIntervals; //actual timer value when counting
        bool FirstStart = true; // used to determine whether the button should say "start" or "pause"
        readonly int betweenIntervalsTime = 2; //amount of time in seconds that the user gets a break between images

        //#### Directory variables bullshit from here on out ####

        //string directory;
        bool IsDirectorySet = false; //force user to select directory before selecting an image

        public FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
        // Object instantiation to select directly
 
        readonly Random rand = new Random(); // used when selecting random image from array
        string[] jpgfiles;
        string[] pngfiles;

        readonly List<String> NudeFileList = new System.Collections.Generic.List<string>();
        readonly List<String> ClothedFileList = new System.Collections.Generic.List<string>();
        readonly List<String> PortraitFileList = new System.Collections.Generic.List<string>();

        List<String> CurrentFileList = new System.Collections.Generic.List<string>();
        
        string NudeDirectory;
        string ClothedDirectory;
        string PortraitDirectory;

        //saving data
        //readonly TextWriter DirectoryWrite = new StreamWriter("Config.txt");
        //TextReader DirectoryRead = new StreamReader("Config.txt");

        public bool CheckForConfig(ref string userDirectory, string directoryLabel)
        {
            //Find exe location and where to store config file
            string workingPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string configFilePath = workingPath + "\\" + AppConfigPath;
            //FileStream fWrite = new FileStream(configFilePath, FileMode.Create, FileAccess.ReadWrite, FileShare.None, 8, FileOptions.None);

            if (File.Exists(configFilePath))
            {
                string searchFor = "=";
                using (StreamReader sr = new StreamReader(configFilePath))
                {
                    string[] linesInFile = File.ReadAllLines(configFilePath);
                    foreach (string sourceLine in linesInFile)
                    {
                        if (sourceLine.Contains(searchFor) && sourceLine.StartsWith(directoryLabel))
                        {
                            string foundDirectory = sourceLine.Substring(sourceLine.IndexOf(searchFor) + searchFor.Length);
                            if (foundDirectory.Trim() != "")
                            {
                                userDirectory = foundDirectory.Trim();
                                return true; //only returns true if the directory is set successfully
                            }
                        } 
                    }
                    return false; //visual studio threw an error without this. i think it's 
                    // trying to cover for when there are NO lines in the file
                    //actually i didnt need an else statement too. if the line is never found, it will leave the foreach loop
                    //And will return false
                }

            }
            else //if the file doesn't exist, then it's empty
            {
                return false;
            }
        }
        //#### Methods for handling timers and image changes####
        public bool StillCounting()
        {

            //changes timer label based on how much time is left
            if (timeLeft < 5)
            {
                DrawTimer.BackColor = Color.Red;
            }
            else if (timeLeft < 10)
            {
                DrawTimer.BackColor = Color.Yellow;
            }
            else if (timeLeft < (timeInterval / 2))
            {
                DrawTimer.BackColor = Color.Yellow;
            }

            //checks if there's still time left
            if (timeLeft < 1)
                return false;
            else
                return true;

        }
        public bool StillTimeBetweenIntervals()
        {
            //checks if there's still time left
            if (TimeLeftBetweenIntervals < 1)
                return false;
            else
                return true;
        }
        public void SetTime(int duration)
        {
            // To not require a "stop" button, changing the time will reset everything.
            Timer1.Stop();
            TimerActive = false;
            StartButton.Text = "Start";
            BetweenIntervals = false;
            //Then do the usual setup
            timeLeft = duration;
            timeInterval = duration;
            UpdateTimer();
            FirstStart = true;
            StartButton.Enabled = true;
        }
        public void StartTimer()
        {
            if (CurrentFileList.Count > 0)
            {
                PictureBox1.Load(CurrentFileList[rand.Next(CurrentFileList.Count)]);
                DrawTimer.BackColor = Color.LightGray;
                SetTime(timeInterval);
                TimerActive = true;
                BetweenIntervals = false;
                Timer1.Start();
                if (!BetweenIntervals) StartButton.Text = "Pause";
            }
            else
            {
                MessageBox.Show("Directory not set :(");
            }

        }

        public void PauseResume()
        {
            if (!TimerActive)
            {
                if (FirstStart)
                {
                    if (IsDirectorySet && CurrentFileList.Count > 0)
                    {
                        StartTimer();
                        FirstStart = false;
                        StartButton.Text = "Pause";
                        AllButtonsOnOff(false);
                    }
                    else
                        MessageBox.Show("Please set your directory first.");

                }
                else
                {
                    Timer1.Start();
                    UpdateTimer();
                    TimerActive = true;
                    if (!BetweenIntervals) StartButton.Text = "Pause";
                }
                
            }
            else
            {
                Timer1.Stop();
                TimerActive = false;
                if (!BetweenIntervals) StartButton.Text = "Resume";
            }
        }
        public void UpdateTimer()
        {
                minutes = (int) (timeLeft / 60);
                seconds = (int) (timeLeft % 60);

            DrawTimer.Text = minutes.ToString("00") + ":" + seconds.ToString("00");
        }
        public void NextImage()
        {
                TimeLeftBetweenIntervals = betweenIntervalsTime;
                StartButton.Enabled = false;
                PictureBox1.Image = null;
                Timer1.Stop();
                DrawTimer.Text = "00:00";
                BufferTimer.Start();
                BetweenIntervals = true;
        }

        private void AllButtonsOnOff(bool onOff)
        {
            if (onOff == false)
            {
                timer30s.Enabled = false;
                timer60s.Enabled = false;
                timer2m.Enabled = false;
                timer5m.Enabled = false;
                timer10m.Enabled = false;
                customTime.Enabled = false;
                NudePanel.Enabled = false;
                ClothedPanel.Enabled = false;
                PortraitPanel.Enabled = false;
                StopButton.Visible = true;
            }
            else
            {
                timer30s.Enabled = true;
                timer60s.Enabled = true;
                timer2m.Enabled = true;
                timer5m.Enabled = true;
                timer10m.Enabled = true;
                customTime.Enabled = true;
                NudePanel.Enabled = true;
                ClothedPanel.Enabled = true;
                PortraitPanel.Enabled = true;
                StopButton.Visible = false;
            }
        }
        private void StopTimer()
        {
            SetTime(timeInterval);
            BufferTimer.Stop();
            DrawTimer.BackColor = Color.LightGray;
            AllButtonsOnOff(true);
            StopButton.Visible = false;
            PictureBox1.Image = null;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            PauseResume();
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            StopTimer();
        }
        private void Timer30s_Click(object sender, EventArgs e)
        {
            SetTime(30);
        }

        private void Timer60s_Click(object sender, EventArgs e)
        {
            SetTime(60);
        }

        private void Timer2m_Click(object sender, EventArgs e)
        {
            SetTime(120);
        }
        private void Timer5m_Click(object sender, EventArgs e)
        {
            SetTime(300);
        }

        private void Timer10m_Click(object sender, EventArgs e)
        {
            SetTime(600);
        }

        //#### Methods for directory assignment ####

#pragma warning disable IDE0060 // Remove unused parameter
        private void AskUserToSetDirectory(List<String> fileList,ref string userDirectory, string directoryLabel)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            //string directory;
            // this is a hacky method i got from an answer here: https://stackoverflow.com/questions/11624298/how-do-i-use-openfiledialog-to-select-a-folder
            var dlg = new FolderPicker();
            string[] userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\'); //get username to insert into directory as it will not take wildcards
            dlg.InputPath = @"c:\users\" + userName[1] + @"\Documents";
            if (dlg.ShowDialog(IntPtr.Zero) == true)
            {
                userDirectory = dlg.ResultPath;
                WriteDirectory(ref userDirectory, directoryLabel, AppConfigPath);
                //userDirectory = directory;
                IsDirectorySet = true;
                //DirectoryWrite.WriteLine(directory);

                jpgfiles = Directory.GetFiles(userDirectory, "*.jpg");
                pngfiles = Directory.GetFiles(userDirectory, "*.png");
                //files = Directory.GetFiles(directory, "*.webp");
                //files = Directory.GetFiles(directory, "*.bmp");


                foreach (string a in jpgfiles)
                {
                    fileList.Add(a);
                }
                foreach (string a in pngfiles)
                {
                    fileList.Add(a);
                }
                
            }
        }
        private void ChangeFileList(List<String> fileList, ref string userDirectory, bool overwriteCurrent, string directoryName)
        {

/*            void buildFileList()
                {

                }*/
            if (fileList.Count > 0)
            {
                CurrentFileList = fileList;
            }
            else if (userDirectory != null)
            {
                Console.WriteLine("found directory! it is:" + "|" + userDirectory + "|");
                IsDirectorySet = true;

                jpgfiles = Directory.GetFiles(userDirectory, "*.jpg");
                pngfiles = Directory.GetFiles(userDirectory, "*.png");

                foreach (string a in jpgfiles)
                {
                    fileList.Add(a);
                }
                foreach (string a in pngfiles)
                {
                    fileList.Add(a);
                }
                if (overwriteCurrent) CurrentFileList.Clear();
                CurrentFileList.AddRange(fileList);
            }
            else if (CheckForConfig(ref userDirectory, directoryName))
            {
                Console.WriteLine("found directory! it is:" + "|"+userDirectory+"|");
                IsDirectorySet= true;

                jpgfiles = Directory.GetFiles(userDirectory, "*.jpg");
                pngfiles = Directory.GetFiles(userDirectory, "*.png");

                foreach (string a in jpgfiles)
                {
                    fileList.Add(a);
                }
                foreach (string a in pngfiles)
                {
                    fileList.Add(a);
                }
                if (overwriteCurrent) CurrentFileList.Clear();
                CurrentFileList.AddRange(fileList);
            }
            else
            {
                AskUserToSetDirectory(fileList, ref userDirectory, directoryName);
            }           
        }


        private void SetDirectoryButton_Click(object sender, EventArgs e) //deprecated
        {
            AskUserToSetDirectory(NudeFileList, ref NudeDirectory,"NudeDirectory");
            CurrentFileList.AddRange(NudeFileList);

        }

        private void CheckIfSpecificDirectorySet(ref System.Windows.Forms.Button buttonName, bool uncheckOthers)
        {
            if (IsDirectorySet == true && CurrentFileList.Count > 0)
            {
               if (uncheckOthers == true)
                {
                    NudeDirectoryButton.Font = new Font(NudeDirectoryButton.Font, FontStyle.Regular);
                    ClothedDirectoryButton.Font = new Font(NudeDirectoryButton.Font, FontStyle.Regular);
                    PortraitDirectoryButton.Font = new Font(NudeDirectoryButton.Font, FontStyle.Regular);
                }
                buttonName.Font = new Font(buttonName.Font, FontStyle.Bold);

                
            
            }
            else
            {
                buttonName.Font = new Font(buttonName.Font, FontStyle.Regular);
            }

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (!BetweenIntervals)
            {
                if (StillCounting())
                {
                    timeLeft--;
                    UpdateTimer();
                }
                else
                {
                    NextImage();

                }
            }
        }

        private void BufferTimer_Tick(object sender, EventArgs e)
        {
            if (BetweenIntervals)
            {
                if (StillTimeBetweenIntervals())
                {
                    TimeLeftBetweenIntervals--;
                }
                else
                {
                    StartTimer();
                }
            }
        }

        private void CustomTime_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the test control.
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            if (customTime != null)
            {
                int lengthOfAnswer = textBox.Text.ToString().Length;
                customTime.Select(0, lengthOfAnswer);
            }
        }


        private void CustomTimePressKey(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex("[0-9sm\b]");
            var regexCombo = new Regex("[sm]");


            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '\r') //Press ENTER event
            {
                //int to combine later after processing of string
                int totalSeconds = 0;
                int totalMinutes = 0;
                int newCustomTime;//= 0; //the compiler said i dont need to assign this!

                //if there are no Ms or Ss
                if (!regexCombo.IsMatch(customTime.Text))
                {
                    int.TryParse(customTime.Text, out int convertedTime); //compiler told me that this variable declaration can be inlined! neat!
                    SetTime(convertedTime);
                }
                else if (customTime.Text != null) //if the values contain more than just numbers, figure out the minutes and seconds
                {

                    string workingString = null;
                    //go through each character, concatenating them together until finding a m or s 
                    for (int i = 0; i < customTime.Text.Length; i++)
                    {
                        if (customTime.Text[i].ToString() == "s")
                        {
                            int.TryParse(workingString, out seconds);
                            workingString = null;
                            totalSeconds = seconds;
                        }
                        else if (customTime.Text[i].ToString() == "m")
                        {
                            int.TryParse(workingString, out minutes);
                            workingString = null;
                            totalMinutes = minutes;
                        }
                        else
                        {
                            workingString += customTime.Text[i].ToString();
                        }
                    }
                    newCustomTime = totalSeconds + (totalMinutes * 60);
                    SetTime(newCustomTime);
                }
            }
            else
            {
                e.Handled = true;
            }

        }

        private void CustomTime_TextChanged(object sender, EventArgs e)
        {


        }

        private void ControlBackspace(object sender, KeyEventArgs e)
        {   // if the user presses ctrl + backspace, delete the whole field
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            if ((Control.ModifierKeys == Keys.Control) & (e.KeyCode == Keys.Back))
            {
                textBox.Text = "";
            }
        }

        private void WriteDirectory(ref string directoryName,string directoryLabel, string configPath)
        {
            //Find exe location and where to store config file
            string workingPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string configFilePath = workingPath + "\\" + configPath;

            //create list that will contain all directories
            List<string> directoryCollection = new List<string>();


                string fullNudeDirectory = "NudeDirectory = " + NudeDirectory;
                directoryCollection.Add(fullNudeDirectory);

                string fullClothedDirectory = "ClothedDirectory = " + ClothedDirectory;
                directoryCollection.Add(fullClothedDirectory);

                string fullPortraitDirectory = "PortraitDirectory = " + PortraitDirectory;
                directoryCollection.Add(fullPortraitDirectory);
            
            void buildConfig()
            {
                using (StreamWriter sw = new StreamWriter(configFilePath, false))
                {
                    foreach (string directory in directoryCollection)
                    {
                        sw.WriteLine(directory);
                        Console.WriteLine("Wrote new line to config");
                    }
                }
            }

            //Console.WriteLine("Existing config file is in" + configFilePath);
            if (!File.Exists(configFilePath))
            {
                using (FileStream fs = File.Create(configFilePath));
                //File.Create(configFilePath);
                Console.WriteLine("Created new config");
                buildConfig();
            }
            else
            {
                File.Delete(configFilePath);
                using (FileStream fs = File.Create(configFilePath));
                buildConfig();

            }

            //read the file
            //string[] linesInFile = File.ReadAllLines(configFilePath);
            //string searchFor = "="; // How we will find parameters

            //Console.WriteLine(linesInFile.Length);



            //Console.WriteLine(NudeDirectory);
            //Console.WriteLine("count in collection is "+directoryCollection.Count);
            /*  using (StreamWriter sw = new StreamWriter(configFilePath, false))
              {
                  foreach (string directory in directoryCollection)
                  {
                      sw.WriteLine(directory);
                      Console.WriteLine("Wrote new line to config");
                  }
              }*/

            /*            if (linesInFile.Length == 0)
                        {
                            using (StreamWriter sw = new StreamWriter(configFilePath, true))
                            {
                                sw.WriteLine(newDirectory);
                                Console.WriteLine("File empty, wrote new line to config");
                            }
                        }
                        else
                        {
                            int count = 0;
                            foreach (string line in linesInFile)
                            {
                                count++;
                                if (line.Contains(searchFor) && line.StartsWith(directoryLabel))
                                {
                                    line.Replace(line, newDirectory);
                                    Console.WriteLine("Updated line in config");
                                }
                                else
                                    using (StreamWriter sw = new StreamWriter(configFilePath, true))
                                    {
                                        sw.WriteLine(newDirectory);
                                        Console.WriteLine("Wrote new line to config");
                                    }
                            }
                        } 
            */


            /*  using (StreamWriter sw = new StreamWriter("C:\\Users\\Josh\\Desktop\\test.txt"))
              {

              }*/
        }
        private void TestButton_Click(object sender, EventArgs e)
        {
            /* string[] parameters = File.ReadAllLines("C:\\Users\\Josh\\Desktop\\test.txt");
             foreach (string line in parameters)
             {
                 if (line.Contains("NudeDirectory"))
                 {
                     PullDirectory(ref NudeDirectory, line);
                     IsDirectorySet = true;
                 }
                 else if (line.Contains("ClothedDirectory"))
                 {
                     PullDirectory(ref ClothedDirectory, line);
                     IsDirectorySet = true;
                 }
                 else if (line.Contains("PortraitDirectory"))
                 {
                     PullDirectory(ref PortraitDirectory, line);
                     IsDirectorySet = true;
                 }
             }*/
            string workingPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            Console.WriteLine(workingPath);

        }

        private void UncheckAll()
        {
            NudeCheckbox.Checked = false;
            ClothedCheckbox.Checked = false;
            PortraitCheckbox.Checked = false;
        }
        private void NudeDirectoryButton_Click(object sender, EventArgs e) //CHOOSE directory
        {
            ChangeFileList(NudeFileList, ref NudeDirectory, true, "NudeDirectory");
            CheckIfSpecificDirectorySet(ref NudeDirectoryButton, true);
            UncheckAll();
        }

        private void SetNudeDirectoryButton_Click(object sender, EventArgs e) //FIND directory
        {
            AskUserToSetDirectory(NudeFileList,ref NudeDirectory,"NudeDirectory");
            CurrentFileList.Clear();
            CurrentFileList.AddRange(NudeFileList);
            CheckIfSpecificDirectorySet(ref NudeDirectoryButton, true);
            NudeCheckbox.Checked = false;
        }

        private void ClothedDirectoryButton_Click(object sender, EventArgs e)//CHOOSE directory
        {
            ChangeFileList(ClothedFileList, ref ClothedDirectory, true, "ClothedDirectory");
            CheckIfSpecificDirectorySet(ref ClothedDirectoryButton, true);
            UncheckAll();
        }

        private void SetClothedDirectoryButton_Click(object sender, EventArgs e) //FIND directory
        {
            AskUserToSetDirectory(ClothedFileList, ref ClothedDirectory, "ClothedDirectory");
            CurrentFileList.Clear();
            CurrentFileList.AddRange(ClothedFileList);
            CheckIfSpecificDirectorySet(ref ClothedDirectoryButton, true);
            ClothedCheckbox.Checked = false;
        }

        private void PortraitDirectoryButton_Click(object sender, EventArgs e)//CHOOSE directory
        {
            ChangeFileList(PortraitFileList, ref PortraitDirectory, true,"PortraitDirectory");
            CheckIfSpecificDirectorySet(ref PortraitDirectoryButton, true);
            UncheckAll();
        }

        private void SetPortraitDirectoryButton_Click(object sender, EventArgs e) //FIND directory
        {
            AskUserToSetDirectory(PortraitFileList, ref PortraitDirectory, "PortraitDirectory");
            CurrentFileList.Clear();
            CurrentFileList.AddRange(PortraitFileList);
            CheckIfSpecificDirectorySet(ref PortraitDirectoryButton, true);
            PortraitCheckbox.Checked = false;
        }


        // ##### This checkbox code is an absolute mess. Try not to worry about it... #####
        private void NudeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (NudeCheckbox.Checked == true)
            {

                ChangeFileList(NudeFileList, ref NudeDirectory, true, "NudeDirectory");
                CheckIfSpecificDirectorySet(ref NudeDirectoryButton, false);

                if (ClothedCheckbox.Checked == true) //if clothed is checked, then we also add those to the pool
                {
                    if (ClothedDirectory != "")
                    {
                        CurrentFileList.AddRange(ClothedFileList);
                    }
                    else MessageBox.Show("Clothed directory not set.");
                }

                if (PortraitCheckbox.Checked == true) // same for portait, add them with the rest
                {
                    if (PortraitDirectory != "")
                    {
                        CurrentFileList.AddRange(PortraitFileList);
                    }
                    else MessageBox.Show("Portrait directory not set.");
                }

            }
            else
            {
                CurrentFileList.Clear();
                CheckIfSpecificDirectorySet(ref NudeDirectoryButton, false);
                if (ClothedCheckbox.Checked == true) //if clothed is checked, then we also add those to the pool
                {
                    if (ClothedDirectory != "")
                    {
                        CurrentFileList.AddRange(ClothedFileList);
                    }
                    else MessageBox.Show("Clothed directory not set.");
                }

                if (PortraitCheckbox.Checked == true) // same for portait, add them with the rest
                {
                    if (PortraitDirectory != "")
                    {
                        CurrentFileList.AddRange(PortraitFileList);
                    }
                    else MessageBox.Show("Portrait directory not set.");
                }
            }
        }

        private void ClothedCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ClothedCheckbox.Checked == true)
            {

                ChangeFileList(ClothedFileList, ref ClothedDirectory, true,"ClothedDirectory");
                CheckIfSpecificDirectorySet(ref ClothedDirectoryButton, false);

                if (NudeCheckbox.Checked == true) //if Nude is checked, then we also add those to the pool
                {
                    if (NudeDirectory != "")
                    {
                        CurrentFileList.AddRange(NudeFileList);
                    }
                    else MessageBox.Show("Nude directory not set.");
                }

                if (PortraitCheckbox.Checked == true) // same for portait, add them with the rest
                {
                    if (PortraitDirectory != "")
                    {
                        CurrentFileList.AddRange(PortraitFileList);
                    }
                    else MessageBox.Show("Portrait directory not set.");
                }

            }
            else
            {
                CurrentFileList.Clear();
                CheckIfSpecificDirectorySet(ref ClothedDirectoryButton, false);
                if (NudeCheckbox.Checked == true) //if Nude is checked, then we also add those to the pool
                {
                    if (NudeDirectory != "")
                    {
                        CurrentFileList.AddRange(NudeFileList);
                    }
                    else MessageBox.Show("Nude directory not set.");
                }

                if (PortraitCheckbox.Checked == true) // same for portait, add them with the rest
                {
                    if (PortraitDirectory != "")
                    {
                        CurrentFileList.AddRange(PortraitFileList);
                    }
                    else MessageBox.Show("Portrait directory not set.");
                }
            }
        }

        private void PortraitCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (PortraitCheckbox.Checked == true)
            {

                ChangeFileList(PortraitFileList, ref PortraitDirectory, true,"PortraitDirectory");
                CheckIfSpecificDirectorySet(ref PortraitDirectoryButton, false);

                if (ClothedCheckbox.Checked == true) //if clothed is checked, then we also add those to the pool
                {
                    if (ClothedDirectory != "")
                    {
                        CurrentFileList.AddRange(ClothedFileList);
                    }
                    else MessageBox.Show("Clothed directory not set.");
                }

                if (NudeCheckbox.Checked == true) // same for portait, add them with the rest
                {
                    if (NudeDirectory != "")
                    {
                        CurrentFileList.AddRange(NudeFileList);
                    }
                    else MessageBox.Show("Nude directory not set.");
                }

            }
            else
            {
                CurrentFileList.Clear();
                CheckIfSpecificDirectorySet(ref PortraitDirectoryButton, false);
                if (NudeCheckbox.Checked == true) //if Nude is checked, then we also add those to the pool
                {
                    if (NudeDirectory != "")
                    {
                        CurrentFileList.AddRange(NudeFileList);
                    }
                    else MessageBox.Show("Nude directory not set.");
                }

                if (ClothedCheckbox.Checked == true) // same for portait, add them with the rest
                {
                    if (ClothedDirectory != "")
                    {
                        CurrentFileList.AddRange(ClothedFileList);
                    }
                    else MessageBox.Show("Clothed directory not set.");
                }
            }
        }

        private void StepTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
