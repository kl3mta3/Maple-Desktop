using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapleHome
{
    public partial class LinksForm : Form
    {
        internal bool systemConfigRan = false;
        public LinksForm()
        {
            InitializeComponent();
            ConfigureSystem();
        }


        internal void ConfigureSystem()
        {
            if (systemConfigRan == false)
            {

                if (Properties.Settings.Default.QuickLink1Name != "Void")
                {
                    txb_QuickLink1Name.Text = Properties.Settings.Default.QuickLink1Name;
                    txb_QuickLink1.Text = Properties.Settings.Default.QuickLink1;
                    btn_QuickLink1.Text = Properties.Settings.Default.QuickLink1Name;

                }
                else
                {
                    txb_QuickLink1Name.Text = "";
                    txb_QuickLink1.Text = "";
                    btn_QuickLink1.Text = "Add Url";

                }
                if (Properties.Settings.Default.QuickLink2Name != "Void")
                {
                    txb_QuickLink2Name.Text = Properties.Settings.Default.QuickLink2Name;
                    txb_QuickLink2.Text = Properties.Settings.Default.QuickLink2;
                    btn_QuickLink2.Text = Properties.Settings.Default.QuickLink2Name;

                }
                else
                {
                    txb_QuickLink2Name.Text = "";
                    txb_QuickLink2.Text = "";
                    btn_QuickLink2.Text = "Add Url";

                }
                if (Properties.Settings.Default.QuickLink3Name != "Void")
                {
                    txb_QuickLink3Name.Text = Properties.Settings.Default.QuickLink3Name;
                    txb_QuickLink3.Text = Properties.Settings.Default.QuickLink3;
                    btn_QuickLink3.Text = Properties.Settings.Default.QuickLink3Name;

                }
                else
                {
                    txb_QuickLink3Name.Text = "";
                    txb_QuickLink3.Text = "";
                    btn_QuickLink3.Text = "Add Url";

                }
                if (Properties.Settings.Default.QuickLink4Name != "Void")
                {
                    txb_QuickLink4Name.Text = Properties.Settings.Default.QuickLink4Name;
                    txb_QuickLink4.Text = Properties.Settings.Default.QuickLink4;
                    btn_QuickLink4.Text = Properties.Settings.Default.QuickLink4Name;

                }
                else
                {
                    txb_QuickLink4Name.Text = "";
                    txb_QuickLink4.Text = "";
                    btn_QuickLink4.Text = "Add Url";

                }
                if (Properties.Settings.Default.QuickLink5Name != "Void")
                {
                    txb_QuickLink5Name.Text = Properties.Settings.Default.QuickLink5Name;
                    txb_QuickLink5.Text = Properties.Settings.Default.QuickLink5;
                    btn_QuickLink5.Text = Properties.Settings.Default.QuickLink5Name;

                }
                else
                {
                    txb_QuickLink5Name.Text = "";
                    txb_QuickLink5.Text = "";
                    btn_QuickLink5.Text = "Add Url";

                }
                if (Properties.Settings.Default.QuickLink4Name != "Void")
                {
                    txb_QuickLink6Name.Text = Properties.Settings.Default.QuickLink6Name;
                    txb_QuickLink6.Text = Properties.Settings.Default.QuickLink6;
                    btn_QuickLink6.Text = Properties.Settings.Default.QuickLink6Name;

                }
                else
                {
                    txb_QuickLink6Name.Text = "";
                    txb_QuickLink6.Text = "";
                    btn_QuickLink6.Text = "Add Url";

                }

                if (Properties.Settings.Default.QuickApp1Name != "")
                {

                    txb_QuickApp1.Text = Properties.Settings.Default.QuickApp1;
                    txb_QuickApp1Name.Text = Properties.Settings.Default.QuickApp1Name;
                    btn_QuickApp1.Text = Properties.Settings.Default.QuickApp1Name;

                }
                else
                {
                    txb_QuickApp1.Text = "";
                    txb_QuickApp1Name.Text = "";
                    btn_QuickApp1.Text = "Add Path..";

                }
                if (Properties.Settings.Default.QuickApp2Name != "")
                {

                    txb_QuickApp2.Text = Properties.Settings.Default.QuickApp2;
                    txb_QuickApp2Name.Text = Properties.Settings.Default.QuickApp2Name;
                    btn_QuickApp2.Text = Properties.Settings.Default.QuickApp2Name;

                }
                else
                {
                    txb_QuickApp2.Text = "";
                    txb_QuickApp2Name.Text = "";
                    btn_QuickApp2.Text = "Add Path..";

                }
                if (Properties.Settings.Default.QuickApp3Name != "")
                {

                    txb_QuickApp3.Text = Properties.Settings.Default.QuickApp3;
                    txb_QuickApp3Name.Text = Properties.Settings.Default.QuickApp3Name;
                    btn_QuickApp3.Text = Properties.Settings.Default.QuickApp3Name;

                }
                else
                {
                    txb_QuickApp3.Text = "";
                    txb_QuickApp3Name.Text = "";
                    btn_QuickApp3.Text = "Add Path..";

                }





                //if (Properties.Settings.Default.OpenAiToken != "Void")
                //{
                //    SetApiSaved();
                //}



                systemConfigRan = true;
            }


        }

        internal void btn_googleLink_Click(object sender, EventArgs e)
        {
            string link = "https://www.Google.com";
            try
            {
                Process proc = new Process();
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.FileName = link;
                proc.Start();

            }
            catch (Exception ex)
            {
                //WriteToMapleConsole(ex.Message);
            }

            //open link in a web brower
            //Process.Start(link);
        }

        internal void btn_GmailLink_Click(object sender, EventArgs e)
        {
            string link = "https://www.Gmail.com";
            try
            {
                Process proc = new Process();
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.FileName = link;
                proc.Start();

            }
            catch (Exception ex)
            {
                // WriteToMapleConsole(ex.Message);
            }
        }

        internal void btn_YoutubeLink_Click(object sender, EventArgs e)
        {
            string link = "https://www.youtube.com";
            try
            {
                Process proc = new Process();
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.FileName = link;
                proc.Start();

            }
            catch (Exception ex)
            {
                //WriteToMapleConsole(ex.Message);
            }


        }

        internal void btn_QuickLink1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.QuickLink1 != "Enter Url...")
            {
                string link = Properties.Settings.Default.QuickLink1;

                try
                {
                    Process proc = new Process();
                    proc.StartInfo.UseShellExecute = true;
                    proc.StartInfo.FileName = link;
                    proc.Start();

                }
                catch (Exception ex)
                {
                    // WriteToMapleConsole(ex.Message);
                }
            }

        }

        internal void btn_QuickLink2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.QuickLink2 != "Enter Url...")
            {
                string link = Properties.Settings.Default.QuickLink2;
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.UseShellExecute = true;
                    proc.StartInfo.FileName = link;
                    proc.Start();

                }
                catch (Exception ex)
                {
                    // WriteToMapleConsole(ex.Message);
                }
            }

        }

        internal void btn_QuickLink3_Click(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.QuickLink3 != "Enter Url...")
            {
                string link = Properties.Settings.Default.QuickLink3;
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.UseShellExecute = true;
                    proc.StartInfo.FileName = link;
                    proc.Start();


                }
                catch (Exception ex)
                {
                    //WriteToMapleConsole(ex.Message);
                }
            }

        }


        //internal void btn_InputEnter_Click(object sender, EventArgs e)
        //{


        //    string question = rtb_MapleInput.Text;


        //    // Helpers helper = new Helpers();
        //    // helper.SendQuestion(question);
        //    WriteToMapleConsole("");
        //    AnswerToMapleConsole($"Me: {question}", Color.PaleTurquoise);

        //    MapleHome.ai.AskQuestion(question);
        //    ClearMapleInput();
        //}

        //internal void ClearMapleInput()
        //{


        //    rtb_MapleInput.Text = "";
        //}



        //internal void AddToMapleConsole(string text)
        //{


        //    rtb_MapleConsole.Text += text;


        //}

        //internal void ClearMapleConsole()
        //{


        //    rtb_MapleConsole.Text = "";


        //}



        public void EnterInput()
        {
            Helpers helper = new Helpers();
            helper.EnterInput();


        }

        public void ExitInput()
        {
            Helpers helper = new Helpers();
            helper.ExitInput();


        }


        private void OpenBrowser(string link)
        {
            bool processStarted = false;

            Process[] processes = Process.GetProcesses();

            foreach (var item in processes)
            {
                if (item.MainWindowTitle.Equals("Google - Google Chrome", StringComparison.OrdinalIgnoreCase))
                {
                    processStarted = true;
                    break;
                }
            }

            if (!processStarted)
            {
                Process p = new Process();
                ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = "chrome.exe";
                p.StartInfo = info;
                info.Arguments = link;
                p.Start();
            }
        }

        //private void btn_ClearMapleConsole_Click(object sender, EventArgs e)
        //{
        //    ClearMapleConsole();
        //}

        private void btn_OpenAiLink_Click(object sender, EventArgs e)
        {

            string link = "https://platform.openai.com/overview";
            try
            {
                Process proc = new Process();
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.FileName = link;
                proc.Start();

            }
            catch (Exception ex)
            {
                //WriteToMapleConsole(ex.Message);
            }


        }

        private void rtb_MapleInput_Leave(object sender, EventArgs e)
        {
            ExitInput();
        }

        private void rtb_MapleInput_Enter(object sender, EventArgs e)
        {

            EnterInput();

        }


        private void txb_QuickLink1_TextChanged(object sender, EventArgs e)
        {

            string link = txb_QuickLink1.Text;
            Properties.Settings.Default.QuickLink1 = link;
            Properties.Settings.Default.Save();



        }

        private void txb_QuickLink2_TextChanged(object sender, EventArgs e)
        {
            string link = txb_QuickLink2.Text;
            Properties.Settings.Default.QuickLink2 = link;
            Properties.Settings.Default.Save();
        }

        private void txb_QuickLink3_TextChanged(object sender, EventArgs e)
        {
            string link = txb_QuickLink3.Text;
            Properties.Settings.Default.QuickLink3 = link;
            Properties.Settings.Default.Save();
        }

        private void txb_QuickLink1_Leave(object sender, EventArgs e)
        {
            txb_QuickLink1.Text = Properties.Settings.Default.QuickLink1;
        }

        private void txb_QuickLink2_Leave(object sender, EventArgs e)
        {

            txb_QuickLink2.Text = Properties.Settings.Default.QuickLink2;
        }

        private void txb_QuickLink3_Leave(object sender, EventArgs e)
        {

            txb_QuickLink3.Text = Properties.Settings.Default.QuickLink3;
        }




        private void txb_QuickLink1Name_TextChanged(object sender, EventArgs e)
        {

            string name = txb_QuickLink1Name.Text;
            Properties.Settings.Default.QuickLink1Name = name;

            Properties.Settings.Default.Save();

        }

        private void txb_QuickLink1Name_Leave(object sender, EventArgs e)
        {
            txb_QuickLink1Name.Text = Properties.Settings.Default.QuickLink1Name;
            btn_QuickLink1.Text = Properties.Settings.Default.QuickLink1Name;
        }

        private void txb_QuickLink2Name_TextChanged(object sender, EventArgs e)
        {
            string name = txb_QuickLink2Name.Text;
            Properties.Settings.Default.QuickLink2Name = name;

            Properties.Settings.Default.Save();
        }

        private void txb_QuickLink2Name_Leave(object sender, EventArgs e)
        {
            txb_QuickLink2Name.Text = Properties.Settings.Default.QuickLink2Name;
            btn_QuickLink2.Text = Properties.Settings.Default.QuickLink2Name;
        }

        private void txb_QuickLink3Name_TextChanged(object sender, EventArgs e)
        {

            string name = txb_QuickLink3Name.Text;
            Properties.Settings.Default.QuickLink3Name = name;
            Properties.Settings.Default.Save();

        }

        private void txb_QuickLink3Name_Leave(object sender, EventArgs e)
        {
            txb_QuickLink3Name.Text = Properties.Settings.Default.QuickLink3Name;
            btn_QuickLink3.Text = Properties.Settings.Default.QuickLink3Name;
        }

        private void lkl_DiscordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string link = "https://discord.gg/PPaRjqnG";
            try
            {
                Process proc = new Process();
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.FileName = link;
                proc.Start();

            }
            catch (Exception ex)
            {
                // WriteToMapleConsole(ex.Message);
            }

        }

        private void txb_QuickLink4Name_TextChanged(object sender, EventArgs e)
        {
            string name = txb_QuickLink4Name.Text;
            Properties.Settings.Default.QuickLink4Name = name;
            Properties.Settings.Default.Save();
        }

        private void txb_QuickLink4Name_Leave(object sender, EventArgs e)
        {
            txb_QuickLink4Name.Text = Properties.Settings.Default.QuickLink4Name;
            btn_QuickLink4.Text = Properties.Settings.Default.QuickLink4Name;
        }

        private void txb_QuickLink5Name_TextChanged(object sender, EventArgs e)
        {
            string name = txb_QuickLink5Name.Text;
            Properties.Settings.Default.QuickLink5Name = name;
            Properties.Settings.Default.Save();
        }

        private void txb_QuickLink5Name_Leave(object sender, EventArgs e)
        {
            txb_QuickLink5Name.Text = Properties.Settings.Default.QuickLink5Name;
            btn_QuickLink5.Text = Properties.Settings.Default.QuickLink5Name;
        }

        private void txb_QuickLink6Name_TextChanged(object sender, EventArgs e)
        {
            string name = txb_QuickLink6Name.Text;
            Properties.Settings.Default.QuickLink6Name = name;
            Properties.Settings.Default.Save();
        }

        private void txb_QuickLink6Name_Leave(object sender, EventArgs e)
        {
            txb_QuickLink6Name.Text = Properties.Settings.Default.QuickLink6Name;
            btn_QuickLink6.Text = Properties.Settings.Default.QuickLink6Name;
        }

        private void txb_QuickLink4_TextChanged(object sender, EventArgs e)
        {
            string link = txb_QuickLink4.Text;
            Properties.Settings.Default.QuickLink4 = link;
            Properties.Settings.Default.Save();
        }

        private void txb_QuickLink4_Leave(object sender, EventArgs e)
        {
            txb_QuickLink4.Text = Properties.Settings.Default.QuickLink4;
        }

        private void txb_QuickLink5_TextChanged(object sender, EventArgs e)
        {
            string link = txb_QuickLink5.Text;
            Properties.Settings.Default.QuickLink5 = link;
            Properties.Settings.Default.Save();
        }

        private void txb_QuickLink5_Leave(object sender, EventArgs e)
        {
            txb_QuickLink5.Text = Properties.Settings.Default.QuickLink5;
        }

        private void txb_QuickLink6_TextChanged(object sender, EventArgs e)
        {
            string link = txb_QuickLink6.Text;
            Properties.Settings.Default.QuickLink6 = link;
            Properties.Settings.Default.Save();
        }

        private void txb_QuickLink6_Leave(object sender, EventArgs e)
        {
            txb_QuickLink6.Text = Properties.Settings.Default.QuickLink6;
        }

        private void btn_QuickLink4_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.QuickLink4 != "Enter Url...")
            {
                string link = Properties.Settings.Default.QuickLink4;
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.UseShellExecute = true;
                    proc.StartInfo.FileName = link;
                    proc.Start();


                }
                catch (Exception ex)
                {
                    //WriteToMapleConsole(ex.Message);
                }
            }
        }

        private void btn_QuickLink5_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.QuickLink5 != "Enter Url...")
            {
                string link = Properties.Settings.Default.QuickLink5;
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.UseShellExecute = true;
                    proc.StartInfo.FileName = link;
                    proc.Start();


                }
                catch (Exception ex)
                {
                    //WriteToMapleConsole(ex.Message);
                }
            }
        }

        private void btn_QuickLink6_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.QuickLink6 != "Enter Url...")
            {
                string link = Properties.Settings.Default.QuickLink6;
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.UseShellExecute = true;
                    proc.StartInfo.FileName = link;
                    proc.Start();


                }
                catch (Exception ex)
                {
                    //WriteToMapleConsole(ex.Message);
                }
            }
        }

        /// Custom Applications
        private void txb_QuickApp1_TextChanged(object sender, EventArgs e)
        {
            string link = txb_QuickApp1.Text;
            Properties.Settings.Default.QuickApp1 = link;
            Properties.Settings.Default.Save();
        }

        private void txb_QuickApp1_Leave(object sender, EventArgs e)
        {
            txb_QuickApp1.Text = Properties.Settings.Default.QuickApp1;

        }

        private void txb_QuickApp2_TextChanged(object sender, EventArgs e)
        {
            string link = txb_QuickApp2.Text;
            Properties.Settings.Default.QuickApp2 = link;
            Properties.Settings.Default.Save();
        }

        private void txb_QuickApp2_Leave(object sender, EventArgs e)
        {
            txb_QuickApp2.Text = Properties.Settings.Default.QuickApp2;

        }

        private void txb_QuickApp3_TextChanged(object sender, EventArgs e)
        {
            string link = txb_QuickApp3.Text;
            Properties.Settings.Default.QuickApp3 = link;
            Properties.Settings.Default.Save();
        }

        private void txb_QuickApp3_Leave(object sender, EventArgs e)
        {
            txb_QuickApp3.Text = Properties.Settings.Default.QuickApp3;

        }



        private void btn_QuickApp1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.QuickApp1 != "Void")
            {
                string link = Properties.Settings.Default.QuickApp1;
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.UseShellExecute = true;
                    proc.StartInfo.FileName = link;
                    proc.Start();


                }
                catch (Exception ex)
                {
                    // WriteToMapleConsole(ex.Message);
                }
            }
        }

        private void btn_QuickApp2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.QuickApp2 != "Void")
            {
                string link = Properties.Settings.Default.QuickApp2;
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.UseShellExecute = true;
                    proc.StartInfo.FileName = link;
                    proc.Start();


                }
                catch (Exception ex)
                {
                    // WriteToMapleConsole(ex.Message);
                }
            }
        }

        private void btn_QuickApp3_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.QuickApp3 != "Void")
            {
                string link = Properties.Settings.Default.QuickApp3;
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.UseShellExecute = true;
                    proc.StartInfo.FileName = link;
                    proc.Start();


                }
                catch (Exception ex)
                {
                    // WriteToMapleConsole(ex.Message);
                }
            }
        }


        private void txb_QuickApp1Name_TextChanged(object sender, EventArgs e)
        {
            string name = txb_QuickApp1Name.Text;
            Properties.Settings.Default.QuickApp1Name = name;
            Properties.Settings.Default.Save();
        }

        private void txb_QuickApp1Name_Leave(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.QuickApp1Name != "")
            {
                txb_QuickApp1Name.Text = Properties.Settings.Default.QuickApp1Name;
                btn_QuickApp1.Text = Properties.Settings.Default.QuickApp1Name;
            }
            else
            {

                txb_QuickApp1Name.Text = "";
                btn_QuickApp1.Text = "Add Path";
            }
        }

        internal void txb_QuickApp2Name_TextChanged(object sender, EventArgs e)
        {
            string name = txb_QuickApp2Name.Text;
            Properties.Settings.Default.QuickApp2Name = name;
            Properties.Settings.Default.Save();
        }

        internal void txb_QuickApp2Name_Leave(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.QuickApp2Name != "")
            {
                txb_QuickApp2Name.Text = Properties.Settings.Default.QuickApp2Name;
                btn_QuickApp2.Text = Properties.Settings.Default.QuickApp2Name;
            }
            else
            {

                txb_QuickApp2Name.Text = "";
                btn_QuickApp2.Text = "Add Path";
            }

        }

        internal void txb_QuickApp3Name_TextChanged(object sender, EventArgs e)
        {
            string name = txb_QuickApp3Name.Text;
            Properties.Settings.Default.QuickApp3Name = name;
            Properties.Settings.Default.Save();
        }

        internal void txb_QuickApp3Name_Leave(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.QuickApp3Name != "")
            {
                txb_QuickApp3Name.Text = Properties.Settings.Default.QuickApp3Name;
                btn_QuickApp3.Text = Properties.Settings.Default.QuickApp3Name;
            }
            else
            {

                txb_QuickApp3Name.Text = "";
                btn_QuickApp3.Text = "Add Path";
            }
        }

        internal void btn_NotePad_Click(object sender, EventArgs e)
        {
            string link = "notepad.exe";
            try
            {
                Process proc = new Process();
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.FileName = link;
                proc.Start();


            }
            catch (Exception ex)
            {
                //WriteToMapleConsole(ex.Message);
            }
        }

        internal void btn_TaskManager_Click(object sender, EventArgs e)
        {
            string link = "Taskmgr.exe";
            try
            {
                Process proc = new Process();
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.FileName = link;
                proc.Start();


            }
            catch (Exception ex)
            {
                //WriteToMapleConsole(ex.Message);
            }
        }

        internal void btn_Calculator_Click(object sender, EventArgs e)
        {
            string link = "Calc.exe";
            try
            {
                Process proc = new Process();
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.FileName = link;
                proc.Start();


            }
            catch (Exception ex)
            {
                // WriteToMapleConsole(ex.Message);
            }
        }

        internal void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OpenAiToken = "a cat";
            string token = Properties.Settings.Default.OpenAiToken;
            //WriteToMapleConsole(token);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void LinksForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MapleHome.form.LinksFormClosed();
        }

        private void LinksForm_FormClosing(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            MapleHome.form.LinksFormClosed();

        }
    }
}
