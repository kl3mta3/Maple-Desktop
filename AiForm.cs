using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MapleHome
{
    public partial class AiForm : Form
    {
        internal bool systemConfigRan = false;
        internal string question = "";
        public AiForm()
        {
            InitializeComponent();
            ConfigureSystem();
        }


        internal void ConfigureSystem()
        {
            if (systemConfigRan == false)
            {

                if (Properties.Settings.Default.OpenAiToken != "Void")
                {
                    SetApiSaved();
                }
                systemConfigRan = true;
            }


        }


        private void rtb_MapleConsole_TextChanged(object sender, EventArgs e)
        {
            rtb_MapleConsole.Select(rtb_MapleConsole.Text.Length, 0);
            rtb_MapleConsole.ScrollToCaret();


        }

        internal void PostQuestionToConsole(string message, Color? c = null)
        {

            System.Windows.Forms.RichTextBox t = rtb_MapleConsole;
            rtb_MapleConsole.Select(rtb_MapleConsole.Text.Length, 0);
            t.AppendText((t.Lines.Count() == 0 ? "" : Environment.NewLine + message));
            t.SelectionColor = c ?? Color.SlateBlue;
            MapleHome.debugConsole.WriteToDebugConsole($"Ai System Question sent to Console: {message}.");
            // rtb_MapleConsole.ScrollToCaret();
        }
        internal void WriteToMapleConsole(string message, Color? c = null)
        {

            if (rtb_MapleConsole.Text.Length >= 1)
            {
                rtb_MapleConsole.Text = rtb_MapleConsole.Text + Environment.NewLine;
            }
            rtb_MapleConsole.AppendText(message);

            MapleHome.debugConsole.WriteToDebugConsole($"Ai System Wrote Message to Console: {message}.");

        }
        internal void AnswerToMapleConsole(string value, Color? c = null)
        {
            System.Windows.Forms.RichTextBox t = rtb_MapleConsole;
            t.SelectionStart = t.TextLength;
            t.SelectionLength = 0;
            t.SelectionColor = c ?? Color.DarkSlateGray;
            t.AppendText((t.Lines.Count() == 0 ? "" : Environment.NewLine + value));
            t.SelectionColor = Color.SlateBlue;
            MapleHome.debugConsole.WriteToDebugConsole($"Ai System Answer sent to Console: {value}.");
            // ScrollTOBottomOfBoX();
        }


        internal void ScrollTOBottomOfBoX()
        {

            rtb_MapleConsole.SelectionStart = rtb_MapleConsole.Text.Length;
            rtb_MapleConsole.ScrollToCaret();


        }




        internal void InsertMapleTag()
        {


            rtb_MapleConsole.Text = rtb_MapleConsole.Text + Environment.NewLine + "Maple:";



        }


        internal void AnswerToMapleConsoleStream(string value, Color? c = null)
        {




            rtb_MapleConsole.AppendText(value);
            //rtb_MapleConsole.Focus();
            // rtb_MapleConsole.ScrollToCaret();
            rtb_MapleConsole.Select(rtb_MapleConsole.Text.Length, 0);
            rtb_MapleConsole.ScrollToCaret();


        }





        internal void btn_InputEnter_Click(object sender, EventArgs e)
        {


            question = rtb_MapleInput.Text;
            rtb_MapleInput.Text = "";




            WriteToMapleConsole(" ");

            // WriteToMapleConsole($"Me: {question}");


            MapleHome.ai.AskQuestion(question);
            // MapleHome.ai.AskGptStream();
            rtb_MapleConsole.Focus();
        }

        internal void ClearMapleInput()
        {


            rtb_MapleInput.Text = "";
        }
        private void btn_ClearMapleConsole_Click(object sender, EventArgs e)
        {
            ClearMapleConsole();
        }

        private void btn_SaveApiKey_Click(object sender, EventArgs e)
        {


            string token = txb_OpenAiApiKey.Text;
            //WriteToMapleConsole(txb_OpenAiApiKey.Text);

            //string[] words = token.Split("-");
            //WriteToMapleConsole(words[0]);
            if (token.StartsWith("sk"))
            {
                if (token.Length > 5)
                {
                    Properties.Settings.Default.OpenAiToken = token;
                    Properties.Settings.Default.Save();
                    //Config.AiConfig.OpenAiApiToken =token;
                    txb_OpenAiApiKey.Text = "";
                    SetApiSaved();
                    WriteToMapleConsole("Token Saved");
                }
                else
                {
                    WriteToMapleConsole("Token too short");

                }
            }
            else
            {

                WriteToMapleConsole("Token must start with sk");
            }

        }


        internal void lkl_SeeApiToken_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            string token = Properties.Settings.Default.OpenAiToken;
            txb_OpenAiApiKey.Text = token;
        }

        internal void lkl_SeeApiToken_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            txb_OpenAiApiKey.Text = "";
        }
        private void rtb_MapleInput_Enter(object sender, EventArgs e)
        {

            EnterInput();

        }
        private void SetApiSaved()
        {

            rbn_ApiSaved1.Checked = true;
        }

        private void rtb_MapleConsole_LinkClicked(object sender, LinkClickedEventArgs e)
        {

            string link = e.LinkText;
            try
            {
                Process proc = new Process();
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.FileName = link;
                proc.Start();


            }
            catch (Exception ex)
            {
                WriteToMapleConsole(ex.Message);
            }
        }
        private void rtb_MapleInput_Leave(object sender, EventArgs e)
        {
            ExitInput();
        }
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
                WriteToMapleConsole(ex.Message);
            }


        }
        internal void AddToMapleConsole(string text)
        {


            rtb_MapleConsole.Text += text;


        }

        internal void ClearMapleConsole()
        {


            rtb_MapleConsole.Text = "";


        }



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

        private void rtb_MapleInput_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                string question = rtb_MapleInput.Text;

                WriteToMapleConsole("");

                //WriteToMapleConsole($"Me: {question}");
                rtb_MapleInput.Text = "";

                MapleHome.ai.AskQuestion(question);
                // rtb_MapleConsole.Focus();

            }

        }

        private void AiForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MapleHome.form.AiFormClosed();
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            MapleHome.form.AiFormClosed();

        }
    }
}
