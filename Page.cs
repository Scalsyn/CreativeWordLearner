using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreativeWordLearner
{
    public partial class Page : Form
    {
        #region GLOBALS
        public Random rd = new Random();
        User User = new User();
        public bool isStarted, isCreating, isAsked;
        public short NewPoints;
        public byte Question_Lang, Check_Lang = 1, HelpCounter, QuestionCounter, GoodAnswers;
        public List<string> AllUsers = new List<string>();
        public List<string> AllWords = new List<string>();
        public List<string> RoundWords = new List<string>(10);
        public string[] Line;
        StringBuilder AskedWords = new StringBuilder();
        #endregion

        #region INIT
        public Page()
        {
            InitializeComponent();
        }
        #endregion

        #region EVENTS
        private void Page_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToString("yyyy. MM. dd.");
            if (!File.Exists("words.txt"))
            {
                MessageBox.Show("An important file (words.txt) is missing!", "Missing File", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Environment.Exit(0);
            }
            if (!File.Exists("users.txt"))
            {
                using FileStream fs = File.Create("users.txt");
                using var sr = new StreamWriter(fs);
            }
            else
            {
                using StreamReader sr = new StreamReader("users.txt");
                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    AllUsers.Add(s);
                    box_User.Items.Add(s.Split(';')[0]);
                }
            }
            using (StreamReader sr = new StreamReader("words.txt"))
            {
                while (!sr.EndOfStream)
                    AllWords.Add(sr.ReadLine());
            }
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            //update clock
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void StartButton_Clicked(object sender, EventArgs e)
        {
            //if not started -> start -> change interface
            if (!isStarted)
            {
                GoodAnswers = 0;
                QuestionCounter = 0;
                NewPoints = 0;
                isStarted = true;
                btn_help.Enabled = true;
                answer.Enabled = true;
                btn_start.Text = "Check";
                lbl_Help.Text = "";
                lbl_language.Visible = false;
                btn_switch.Visible = false;
                PickNewWords();
            }
            //if round end is rached -> show result -> give points -> stop asking
            if (QuestionCounter == 10)
            {
                GivePoints();
                SetNewRound();
                Save();
                return;
            }
            //if no word is asked -> find 10 new random AllWords (depending on current level) -> start the round
            if (!isAsked)
            {
                Line = RoundWords[QuestionCounter].Split(';');

                //show word
                question.Text = Line[Question_Lang];
                AskedWords.Append($"{Line[Check_Lang]}  ");
                isAsked = true;
            }
            //user enters a solution -> check it -> then continue with the next
            else
            {
                string answerTrimmed = answer.Text.Trim();
                //if trimmed word is empty -> do nothing
                if (answerTrimmed.Length == 0) return;
                isAsked = false;
                bool isCorrect = false;
                QuestionCounter++;
                //check hungarian word
                if (Question_Lang == 1)
                {
                    if (answerTrimmed == Line[0])
                        isCorrect = true;
                }
                //check english word
                else
                {
                    for (int i = 1; i < Line.Length; i++)
                        if (answerTrimmed == Line[i])
                            isCorrect = true;
                }
                //if user found out the word:
                if (isCorrect == true)
                {
                    btn_start.Visible = false;
                    btn_delete.Enabled = false;
                    answer.BackColor = Color.LightGreen;
                    GoodAnswers++;
                    //count points
                    if (Line[Question_Lang].Length > 5) NewPoints += 5;
                    else NewPoints += 4;
                    //wait 1 sec -> set interfaces -> get next word
                    answer.Select(0, 0);
                    System.Threading.Thread.Sleep(1000);
                    btn_start.Visible = true;
                    btn_delete.Enabled = true;
                    answer.BackColor = Color.White;
                    answer.Text = "";
                    lbl_Help.Text = "";
                    HelpCounter = 0;
                    lbl_AskedWords.Text = AskedWords.ToString();
                    StartButton_Clicked(sender, e);
                }
                //if user did not find out the word:
                else
                {
                    answer.Text = Line[Check_Lang];
                    answer.Select(0, 0);
                    //wait 1 sec -> set interfaces -> get next word
                    answer.BackColor = Color.IndianRed;
                    btn_delete.Enabled = false;
                    btn_start.Visible = false;
                    System.Threading.Thread.Sleep(1200);
                    btn_start.Visible = true;
                    btn_delete.Enabled = true;
                    answer.BackColor = Color.White;
                    answer.Text = "";
                    lbl_Help.Text = "";
                    HelpCounter = 0;
                    lbl_AskedWords.Text = AskedWords.ToString();
                    StartButton_Clicked(sender, e);
                }
            }
        }

        private void NewProfileButton_Clicked(object sender, EventArgs e)
        {
            //CREATING NEW PROFILE:
            //if not in creating phase -> set phase on -> give the interface visible
            if (!isCreating)
            {
                isCreating = true;
                txt_User.Visible = true;
                btn_User.Text = "Add";
                return;
            }
            txt_User.Text = txt_User.Text.Trim();
            //if the trimmed string is empty or contains (;) char -> exit
            if (txt_User.Text.Length == 0 || txt_User.Text.Contains(";"))
            {
                txt_User.BackColor = Color.IndianRed;
                return;
            }
            //if the name is already in the list -> exit
            for (int i = 0; i < AllUsers.Count; i++)
            {
                if (txt_User.Text == AllUsers[i].Split(';')[0])
                {
                    txt_User.BackColor = Color.IndianRed;
                    return;
                }
            }
            //seems everything was ok -> put new user in the list -> hide interface -> save
            AllUsers.Add($"{txt_User.Text};1;0;0;0");
            box_User.Items.Add(txt_User.Text);
            btn_User.Visible = false;
            txt_User.Visible = false;
            box_User.Visible = false;
            lblSelectTxt.Visible = false;
            btn_start.Enabled = true;
            btn_delete.Visible = true;
            SetUser();
            Save();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            //WHEN HELP BUTTON IS PRESSED
            //if all help used -> exit
            if (HelpCounter == 3) return;
            //use StringBuilder to assembly help AllWords
            StringBuilder sb = new StringBuilder();
            //first help
            if (HelpCounter == 0)
            {
                HelpCounter++;
                NewPoints -= 1;
                for (int i = 0; i < Line[Check_Lang].Length; i++)
                {
                    if (Line[Check_Lang][i] != ' ')
                        sb.Append("*");
                    else
                        sb.Append(" ");
                }
                //show help
                lbl_Help.Text = sb.ToString();
                return;
            }
            //second help (only useable with longer AllWords)
            if (HelpCounter == 1 && Line[Check_Lang].Length > 2)
            {
                HelpCounter++;
                NewPoints -= 1;
                for (int i = 0; i < Line[Check_Lang].Length; i++)
                {
                    //show the first and the last char
                    if (i == 0 || i == Line[Check_Lang].Length - 1)
                    {
                        sb.Append(Line[Check_Lang][i]);
                        continue;
                    }
                    if (Line[Check_Lang][i] != ' ')
                        sb.Append("*");
                    else
                        sb.Append(" ");
                }
                //show help
                lbl_Help.Text = sb.ToString();
                return;
            }
            //third help (only useable with longer AllWords)
            if (HelpCounter == 2 && Line[Check_Lang].Length > 5)
            {
                HelpCounter++;
                NewPoints -= 2;
                for (int i = 0; i < Line[Check_Lang].Length; i++)
                {
                    //show the first and the last char
                    if (i == 0 || i == Line[Check_Lang].Length - 1)
                    {
                        sb.Append(Line[Check_Lang][i]);
                        continue;
                    }
                    if (Line[Check_Lang][i] != ' ')
                    {
                        //+help: 50% on each char to show
                        if (rd.Next(2) == 1)
                            sb.Append(Line[Check_Lang][i]);
                        else
                            sb.Append("*");
                    }
                    else
                        sb.Append(" ");
                }
                //show help
                lbl_Help.Text = sb.ToString();
            }
        }

        private void Page_Closing(object sender, FormClosingEventArgs e)
        {
            //call Save method before exit
            Save();
        }

        private void LanguageButton_Clicked(object sender, EventArgs e)
        {
            //change the Question_Lang
            if (Question_Lang == 0)
            {
                Question_Lang = 1;
                Check_Lang = 0;
                btn_switch.Text = "Hungarian";
                return;
            }
            Question_Lang = 0;
            Check_Lang = 1;
            btn_switch.Text = "English";
        }

        private void UserSelectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //user selected from the box (dropdown) menu
            btn_start.Enabled = true;
            btn_User.Visible = false;
            box_User.Visible = false;
            txt_User.Visible = false;
            lblSelectTxt.Visible = false;
            btn_delete.Visible = true;
            SetUser();
        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Are you sure you want to delete this profile?", "Delete Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlgResult == DialogResult.Yes)
            {
                answer.Text = "";
                lbl_AskedWords.Text = "";
                answer.Enabled = false;
                lbl_Help.Text = "";
                question.Text = "";
                btn_start.Text = "Start";
                btn_start.Enabled = false;
                btn_switch.Visible = true;
                btn_switch.Text = "English";
                btn_help.Enabled = false;
                bar_userProgress.Value = 0;
                bar_userProgress.Visible = false;
                lbl_userLevel.Text = "";
                lbl_userName.Text = "";
                btn_delete.Visible = false;
                lblSelectTxt.Visible = true;
                box_User.Visible = true;
                btn_User.Visible = true;
                btn_User.Text = "New";
                isStarted = false;
                isAsked = false;
                HelpCounter = 0;
                QuestionCounter = 0;
                GoodAnswers = 0;
                RoundWords.Clear();
                AskedWords.Clear();
                Question_Lang = 0;
                Check_Lang = 1;
                box_User.Text = "";
                int w = 0;
                for (int i = 0; i < AllUsers.Count; i++)
                {
                    if (AllUsers[i].Split(';')[0] == User.name)
                        w = i;
                }
                AllUsers.RemoveAt(w);
                box_User.Items.Clear();
                foreach (var v in AllUsers)
                    box_User.Items.Add(v.Split(';')[0]);
                Save();
            }
        }

        #endregion

        #region METHODS
        public void PickNewWords()
        {
            RoundWords.Clear();
            int min = 0, max = AllWords.Count;
            switch (User.level)
            {
                case 1: { max /= 10; break; } //10%
                case 2: { max = (max / 10) * 2; break; } //20%
                case 3: { max = (max / 10) * 3; break; } //30%
                case 4: { max = (max / 10) * 4; break; } //40%
                case 5: { max = (max / 10) * 5; break; } //50%
                case 6: { min = max / 10; max = (max / 10) * 6; break; } //10% - 60%
                case 7: { min = (max / 10) * 2; max = (max / 10) * 7; break; } //20% - 70%
                case 8: { min = (max / 10) * 3; max = (max / 10) * 8; break; } //30% - 80%
                case 9: { min = (max / 10) * 4; max = (max / 10) * 9; break; } //40% - 90%
                case 10: { min = (max / 10) * 5; break; } //50% - 100%
            }
            RoundWords.Add(AllWords[rd.Next(min, max)]);
            while (RoundWords.Count < 10)
            {
                bool isIn = false;
                string s = AllWords[rd.Next(min, max)];
                for (int i = 0; i < RoundWords.Count; i++)
                {
                    if (RoundWords[i].Split(';')[0] == s.Split(';')[0])
                        isIn = true;
                }
                if (!isIn)
                    RoundWords.Add(s);
            }

        }

        public void GivePoints()
        {
            //if user is not on max level -> give points
            if (User.level < 10)
            {
                User.points += NewPoints;
                //if points reach or exceed current level maximum -> do level up
                if (bar_userProgress.Maximum <= User.points)
                {
                    User.level++;
                    User.points = 0;
                    bar_userProgress.Value = 0;
                    lbl_userLevel.Text = $"Level: {User.level}";
                    bar_userProgress.Maximum = SetProgressMax();
                    MessageBox.Show($"You have reached level {User.level}!", "Congratulation!");
                }
                else
                {
                    bar_userProgress.Value = User.points;
                }
            }
        }

        public void Save()
        {
            //if user is not selected -> exit
            if (User == null) return;
            //save user's progress
            using (StreamWriter sw = new StreamWriter("users.txt"))
            {
                for (int i = 0; i < AllUsers.Count; i++)
                {
                    if (AllUsers[i].Split(';')[0] == User.name)
                        sw.WriteLine($"{User.name};{User.level};{User.points};{User.sumOfResults};{User.playedRounds}");
                    else
                        sw.WriteLine(AllUsers[i]);
                }
                sw.Close();
            }
        }

        public int SetProgressMax()
        {
            switch (User.level)
            {
                case 1: return 100;
                case 2: return 120;
                case 3: return 150;
                case 4: return 190;
                case 5: return 240;
                case 6: return 300;
                case 7: return 370;
                case 8: return 450;
                case 9: return 540;
                case 10: return 100;
                default: return 100;
            }
        }

        public void SetNewRound()
        {
            AskedWords.Clear();
            isStarted = false;
            btn_help.Enabled = false;
            answer.Enabled = false;
            User.playedRounds++;
            User.sumOfResults += GoodAnswers * 10;
            answer.Text = "";
            lbl_AskedWords.Text = "";
            question.Text = "The Round is over!";
            if (GoodAnswers == 0) lbl_Help.Text = $"Your current result: {GoodAnswers}%\nYour average result: {User.Get_AverageResult}%";
            else lbl_Help.Text = $"Your current result: {GoodAnswers}0%\nYour average result: {User.Get_AverageResult}%";
            btn_start.Text = "Start Again";
            lbl_language.Visible = true;
            btn_switch.Visible = true;
        }

        public void SetUser()
        {
            //check if user made a new profile or selected an existing one
            string selectedName;
            if (isCreating) selectedName = txt_User.Text;
            else selectedName = box_User.Text;
            isCreating = false;
            //look for the selected user's data from AllUsers list
            for (int i = 0; i < AllUsers.Count; i++)
            {
                if (AllUsers[i].Split(';')[0] == selectedName)
                {
                    string[] s = AllUsers[i].Split(';');
                    User.name = s[0];
                    User.level = byte.Parse(s[1]);
                    User.points = short.Parse(s[2]);
                    User.sumOfResults = int.Parse(s[3]);
                    User.playedRounds = short.Parse(s[4]);
                    break;
                }
            }
            //set the user's interface on the bottom-left
            lbl_userName.Text = User.name;
            lbl_userLevel.Text = $"Level: {User.level}";
            bar_userProgress.Visible = true;
            btn_switch.Enabled = true;
            txt_User.Text = "";
            //set progress bar maximum
            bar_userProgress.Maximum = SetProgressMax();
            //set progress bar current
            if (User.level == 10)
                bar_userProgress.Value = 100;
            else
                bar_userProgress.Value = User.points;
        }
        #endregion
    }
}