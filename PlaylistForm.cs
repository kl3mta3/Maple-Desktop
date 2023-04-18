namespace MapleHome
{
    public partial class PlaylistForm : Form
    {
        public PlaylistForm()
        {
            InitializeComponent();
        }

        private void btn_ClearPlaylist_Click(object sender, EventArgs e)
        {
            ClearPlaylistConsole();
            MapleHome.music.ClearAudioPlaylist();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            MapleHome.musicForm.togglePLaylistConsole();
        }

        public void WriteToPlaylistConsole(string message)
        {


            rtb_PlaylistConsole.Text = rtb_PlaylistConsole.Text + Environment.NewLine + message;


        }
        public void ClearPlaylistConsole()
        {

            rtb_PlaylistConsole.Text = "";


        }

        private void lbl_Playlist_Click(object sender, EventArgs e)
        {

        }
    }
}
