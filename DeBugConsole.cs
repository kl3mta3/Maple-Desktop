namespace MapleHome
{
    public partial class DeBugConsole : Form
    {

        internal static bool consoleOpen = false;
        public DeBugConsole()
        {
            InitializeComponent();
        }

        private void rtb_DebugWindow_TextChanged(object sender, EventArgs e)
        {
            rtb_DebugWindow.SelectionStart = rtb_DebugWindow.Text.Length;
            rtb_DebugWindow.ScrollToCaret();
        }



        public void WriteToDebugConsole(string message)
        {
            rtb_DebugWindow.Text = rtb_DebugWindow.Text + Environment.NewLine + message;
        }

        private void btn_DebugWindowClose_Click(object sender, EventArgs e)
        {
            MapleHome.debugConsoleOpen = false;
            MapleHome.debugConsole.Hide();
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            MapleHome.musicForm.toggleDebugConsole();
        }

        private void btn_ClearConsole_Click(object sender, EventArgs e)
        {
            rtb_DebugWindow.Text = "";
        }
    }
}
