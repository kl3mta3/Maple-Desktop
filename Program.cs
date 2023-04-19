using System.IO;
using MapleHome.Resources.AppData.Config;
using NAudio.Wave;
using YoutubeExplode;
//using System.Reflection.Emit;

namespace MapleHome
{
    internal static class MapleHome
    {
        public static Config config { get; internal set; }
        internal static string openAiToken = Properties.Settings.Default.OpenAiToken;
        internal static string youtubeApiKey = Properties.Settings.Default.YoutubeApiKey;
       
        internal static bool inInput = false;
        internal static bool saveMusic = false;
        internal static bool saveVideo = false;
        internal static bool playAudio = true;
        internal static bool playVideo = false;
        internal static bool debugConsoleOpen = false;
        internal static bool playlistConsoleOpen = false;
        internal static string systemPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        internal static MusicSystem music = new MusicSystem();
        internal static AiSystem ai = new AiSystem();
        internal static string musicSavePath = Path.Combine(systemPath, @"Maple\Saved Music");
        internal static string videoSavePath = Path.Combine(systemPath, @"Maple\Saved Videos");
        internal static IWavePlayer wavePlayer;
        internal static WaveOutEvent outputDevice;
        internal static AudioFileReader audioFile;
        internal static VideoPlayer videoPlayer = new VideoPlayer();
        internal static YoutubeClient youtube = new YoutubeClient();

        internal static Form1 form = new Form1();
        internal static AiForm aiForm = new AiForm();
        internal static musicForm musicForm = new musicForm();
        internal static LinksForm linksForm = new LinksForm();
        internal static DeBugConsole debugConsole = new DeBugConsole();
        internal static PlaylistForm playlistConsole = new PlaylistForm();

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            //if (!Directory.Exists(musicSavePath))
            //{
            //    Directory.CreateDirectory(musicSavePath);

            //}
            //if (!Directory.Exists(videoSavePath))
            //{
            //    Directory.CreateDirectory(videoSavePath);

            //}
 
           
            System.Windows.Forms.Application.Run(new Form1());
        }


    }


    class Helpers
    {
        public void WriteToMapleConsole(string value)
        {
            

           // RichTextBox? t = System.Windows.Forms.Application.OpenForms["Form1"].Controls["rtb_MapleConsole"] as RichTextBox;
           // t.Text = t.Text + "\n" + value;

           
            // RichTextBox? r = System.Windows.Forms.Application.OpenForms["AiForm"].Controls["rtb_MapleConsole1"] as RichTextBox;
            //r.Text = r.Text + "\n" + value;




        }

        public void AnswerToMapleConsole(string value, Color? c = null)
        {
            //RichTextBox? t = System.Windows.Forms.Application.OpenForms["Form1"].Controls["rtb_MapleConsole"] as RichTextBox;
            //t.SelectionStart = t.TextLength;
            //t.SelectionLength = 0;
            //t.SelectionColor = c ?? Color.DarkSlateGray;
            //t.AppendText((t.Lines.Count() == 0 ? "" : value));
            //t.SelectionColor = Color.SlateBlue;


        }




        public async void SendQuestion(string value)
        {

            
           MapleHome.ai.AskQuestion(value);
        }

        public void SetOpenAIApiKey(string value)
        {

            MapleHome.openAiToken = value;



        }
        public void EnterInput()
        {

            //MapleHome.inInput = true;
            //WriteToMapleConsole("System: InInput= true");

        }

        public void ExitInput()
        {


            //MapleHome.inInput = false;
            // WriteToMapleConsole("System: InInput= false");
        }
        public void DisplayCurrentSongInfo(string _title, string _artist, string _url)
        {
            //Label? title = System.Windows.Forms.Application.OpenForms["Form1"].Controls["lbl_PlayingName"] as Label;
            //title.Text = _title;

            //Label? artist = System.Windows.Forms.Application.OpenForms["Form1"].Controls["lbl_PlayingArtist"] as Label;
            //artist.Text = _artist;


            //LinkLabel? url = System.Windows.Forms.Application.OpenForms["Form1"].Controls["lbl_PlayingLink"] as LinkLabel;
            //url.Text = _url;

        }



        public void SetPlayStatus(string _status)
        {

            //Label status = System.Windows.Forms.Application.OpenForms["Form1"].Controls["lbl_PlayingStatus"] as Label;
            //status.Text = _status;





        }

        public void ClearSongInfoDisplay()
        {
            //Label title = System.Windows.Forms.Application.OpenForms["Form1"].Controls["lbl_PlayingName"] as Label;
            //title.Text = "-";

            //Label artist = System.Windows.Forms.Application.OpenForms["Form1"].Controls["lbl_PlayingArtist"] as Label;
            //artist.Text = "-";


            //LinkLabel url = System.Windows.Forms.Application.OpenForms["Form1"].Controls["lbl_PlayingLink"] as LinkLabel;
            //url.Text = "-";

        }


        public void SetProgressBarCurrentTrackLength(string _length)
        {
            //if (_length != "0:00")
            //{
            //    Label? length = System.Windows.Forms.Application.OpenForms["Form1"].Controls["lbl_ProgressBarTrackLength"] as Label;
            //    length.Text = _length;
            //}
            //else
            //{
            //    Label? length = System.Windows.Forms.Application.OpenForms["Form1"].Controls["lbl_ProgressBarTrackLength"] as Label;
            //    length.Text = "0:00";

            //}

        }



        public void SetProgressBarCurrentProgress(string _progress)
        {
            //if (_progress != "0:00")
            //{
            //    Label? progress = System.Windows.Forms.Application.OpenForms["Form1"].Controls["lbl_CurrentTrackPosition"] as Label;
            //    progress.Text = _progress;
            //}
            //else
            //{
            //    Label? progress = System.Windows.Forms.Application.OpenForms["Form1"].Controls["lbl_CurrentTrackPosition"] as Label;
            //    progress.Text = "0:00/0:00";
            //}
        }


        public void SetProgressBarMaxValue(int _value)
        {
        //    System.Windows.Forms.TrackBar? progress = System.Windows.Forms.Application.OpenForms["Form1"].Controls["tbr_TrackProgressBar"] as System.Windows.Forms.TrackBar;
        //    progress.Maximum = _value;

        //    WriteToMapleConsole("Progress mave value set to "+_value.ToString());
        }
        public void SetProgressBarCurrentValue(int _value)
        {
            //float roundedValue = MathF.Round(_value);
            //WriteToMapleConsole(roundedValue.ToString());
            //System.Windows.Forms.TrackBar? progress = System.Windows.Forms.Application.OpenForms["Form1"].Controls["tbr_TrackProgressBar"] as System.Windows.Forms.TrackBar;
            //progress.Value = (int)roundedValue;
        }
    }
}

