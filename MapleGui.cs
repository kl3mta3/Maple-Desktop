using System.Diagnostics;


namespace MapleHome
{
    public partial class Form1 : Form
    {

        internal bool systemConfigRan = false;


        private bool showingChatForm = false;
        private bool showingMusicForm = false;
        private bool showingLinksForm = false;
        public Form1()
        {
            InitializeComponent();

            ConfigureSystem();


        }
        internal void ConfigureSystem()
        {
            if (systemConfigRan == false)
            {


            }


            systemConfigRan = true;
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

            }

        }



        internal void btn_OpenChatForm_Click(object sender, EventArgs e)
        {

            showingChatForm = !showingChatForm;
            if (showingChatForm)
            {

                MapleHome.aiForm.Show();
            }
            else
            {
                MapleHome.aiForm.Hide();

            }

        }

        public void AiFormClosed()
        {
            showingChatForm = !showingChatForm;
            if (showingChatForm)
            {

                MapleHome.aiForm.Show();
            }
            else
            {
                MapleHome.aiForm.Hide();

            }
        }
        public void MusicFormClosed()
        {
            showingMusicForm = !showingMusicForm;
            if (showingMusicForm)
            {

                MapleHome.musicForm.Show();
            }
            else
            {
                MapleHome.musicForm.Hide();

            }
        }
        public void LinksFormClosed()
        {
            showingLinksForm = !showingLinksForm;
            if (showingLinksForm)
            {

                MapleHome.linksForm.Show();
            }
            else
            {
                MapleHome.linksForm.Hide();

            }
        }


        internal void btn_OpenMusicForm_Click(object sender, EventArgs e)
        {
            showingMusicForm = !showingMusicForm;
            if (showingMusicForm)
            {

                MapleHome.musicForm.Show();
            }
            else
            {
                MapleHome.musicForm.Hide();

            }
        }

        internal void btn_OpenLinksForm_Click(object sender, EventArgs e)
        {

            showingLinksForm = !showingLinksForm;
            if (showingLinksForm)
            {

                MapleHome.linksForm.Show();
            }
            else
            {
                MapleHome.linksForm.Hide();

            }





        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MapleHome.music.DeleteNonSavedFiles();
        }
    }
}



