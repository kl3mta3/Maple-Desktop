using System.Diagnostics;
//using static System.Net.Mime.MediaTypeNames;
using NAudio.Wave;
using static MapleHome.MusicSystem;

namespace MapleHome
{
    public partial class musicForm : Form
    {
        internal bool systemConfigRan = false;
        public bool saveMusic = false;
        public musicForm()
        {
            InitializeComponent();
            PopulateOutputDriverCombo();
        }

        private void musicForm_Load(object sender, EventArgs e)
        {

        }
        internal void btn_Play_Click(object sender, EventArgs e)
        {
            if (txb_SongInput.Text != null)
            {
                string searchrequest = txb_SongInput.Text;

                // WriteToMapleConsole($" starting search with query {searchrequest}");

                MapleHome.music.HandleRequest(searchrequest, sender, e);
                txb_SongInput.Text = "";
            }
        }

        private void rbn_PlayAudio_CheckedChanged(object sender, EventArgs e)
        {

            if (rbn_PlayAudio.Checked)
            {
                MapleHome.playAudio = true;
                MapleHome.playVideo = false;
                //WriteToMapleConsole("Playing Audio Files");
            }
            else

            {
                MapleHome.playAudio = false;
                MapleHome.playVideo = true;
                //WriteToMapleConsole("Playing Video Files");
            }
        }

        private void txb_SongInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txb_SongInput.Text != null)
                {
                    string searchrequest = txb_SongInput.Text;



                    MapleHome.music.PlaySearchRequest(searchrequest, sender, e);

                    txb_SongInput.Text = "";
                }

            }
        }

        internal IWavePlayer CreateWavePlayer()
        {
            switch (comboBoxOutputDriver.SelectedIndex)
            {
                case 2:
                    return new WaveOutEvent();
                case 1:
                    return new WaveOut(WaveCallbackInfo.FunctionCallback());
                default:
                    return new WaveOut();
            }
        }


        internal void WriteToMapleConsole(string message)
        {
            //rtb_DebugMusic.Text = message + Environment.NewLine + rtb_DebugMusic.Text;


            MapleHome.debugConsole.WriteToDebugConsole(message);


        }

        internal void SetPlayStatus(string message)
        {
            lbl_PlayingStatus.Text = message;
        }
        internal void ClearSongInfoDisplay()
        {

            lbl_PlayingName.Text = "";


            lbl_PlayingArtist.Text = "";

            lbl_PlayingLink.Text = "";

            lbl_PlayingStatus.Text = "";
            lbl_PlayTrackPlaylistID.Text = "";

        }

        public void SetProgressBarCurrentTrackLength(string _length)
        {
            if (_length != "0:00")
            {
                lbl_ProgressBarTrackLength.Text = _length;
            }
            else
            {
                lbl_ProgressBarTrackLength.Text = "0:00";

            }

        }

        public void SetProgressBarCurrentProgress(string _progress)
        {
            if (_progress != "0:00")
            {

                lbl_CurrentTrackPosition.Text = _progress;
            }
            else
            {

                lbl_CurrentTrackPosition.Text = "0:00/0:00";
            }
        }



        public void DisplayCurrentSongInfo(string _title, string _artist, string _url, string _id)
        {
            lbl_PlayingName.Text = _title;

            lbl_PlayingArtist.Text = _artist;

            lbl_PlayingLink.Text = _url;
            lbl_PlayTrackPlaylistID.Text = _id;
        }
        internal void SetProgressBarCurrentValue(int _value)
        {
            if (_value <= tbr_TrackProgressBar.Maximum)
            {
                float roundedValue = MathF.Round(_value);
                // WriteToMapleConsole("TrackProgressBar.Value" + roundedValue.ToString());
                tbr_TrackProgressBar.Value = (int)roundedValue;
            }


        }
        internal void SetProgressBarMaxValue(int _value)
        {
            // WriteToMapleConsole("TrackProgressBar.Maximum" + _value.ToString());
            tbr_TrackProgressBar.Maximum = _value;

        }


        internal void BeginPlayback(string filename)
        {


            WriteToMapleConsole($"Audio BeginPlayback Triggered at {filename}");

            MapleHome.wavePlayer = null;
            SetPlayStatus("-Now Playing-");
            Debug.Assert(MapleHome.wavePlayer == null);
            MapleHome.wavePlayer = CreateWavePlayer();
            WriteToMapleConsole("Wave Player Created");
            try
            {
                MapleHome.audioFile = new AudioFileReader(filename);
                WriteToMapleConsole("File Read");

            }
            catch
            {
                WriteToMapleConsole("Error Finding File Redownloading");
                Song song = MapleHome.music.SongFromUrl(MapleHome.music.currentTrack.url);
                MapleHome.audioFile = new AudioFileReader(song.path);
                WriteToMapleConsole("File Read");

            }
            WriteToMapleConsole($"Audio file  {MapleHome.audioFile.FileName}");
            SetProgressBarMaxValue((int)MapleHome.audioFile.TotalTime.TotalSeconds);
            WriteToMapleConsole($"Audio file Length  {MapleHome.audioFile.Length}");
            WriteToMapleConsole($"Audio file Length as int {(int)MapleHome.audioFile.Length}");
            WriteToMapleConsole($"Audio file TotalTime {MapleHome.audioFile.TotalTime}");
            WriteToMapleConsole($"Audio file TotalSeconds {MapleHome.audioFile.TotalTime.TotalSeconds}");
            WriteToMapleConsole($"Audio file TotalSeconds as int {(int)MapleHome.audioFile.TotalTime.TotalSeconds}");

            MapleHome.audioFile.Volume = (float)volumeSlider3.Value / 100;



            SetProgressBarCurrentValue((int)MapleHome.audioFile.CurrentTime.TotalSeconds);
            WriteToMapleConsole("SetProgressBarCurrentValue TO " + MapleHome.audioFile.CurrentTime.TotalSeconds.ToString());
            WriteToMapleConsole("SetProgressBarMaxValue TO " + MapleHome.audioFile.TotalTime.TotalSeconds.ToString());
            MapleHome.wavePlayer.Init(MapleHome.audioFile);

            WriteToMapleConsole($"Volume lvl {MapleHome.audioFile.Volume}");
            MapleHome.wavePlayer.PlaybackStopped += OnPlaybackStopped;
            MapleHome.music.playingTrack = true;
            lbl_ProgressBarTrackLength.Text = FormatTimeSpan(MapleHome.audioFile.TotalTime);
            WriteToMapleConsole("Starting Play");
            SetPlayStatus("Now Playing:");


            MapleHome.wavePlayer.Play();
            WriteToMapleConsole("Audio Playback Started");
            EnableButtons(true);
            timer1.Enabled = true; // timer for updating current time label

            WriteToMapleConsole("Tick Timer on");
        }

        private static string FormatTimeSpan(TimeSpan ts)
        {
            return string.Format("{0:D2}:{1:D2}", (int)ts.TotalMinutes, ts.Seconds);
        }

        void OnTimerTick(object sender, EventArgs e)
        {

            string total = FormatTimeSpan(MapleHome.audioFile.TotalTime);
            string current = FormatTimeSpan(MapleHome.audioFile.CurrentTime);
            string combined = $"{current}/{total}";

            //WriteToMapleConsole($"{test}");
            MapleHome.music.currentTrackCurrentTime = (int)MapleHome.audioFile.CurrentTime.TotalSeconds;


            SetProgressBarCurrentProgress(combined);
            if (!MapleHome.music.userpressedSeek && MapleHome.music.playingTrack)
            {

                if (MapleHome.audioFile != null)
                {
                    try
                    {

                        SetProgressBarCurrentValue((int)MapleHome.audioFile.CurrentTime.TotalSeconds);
                        MapleHome.music.progressBarCurrentTime = tbr_TrackProgressBar.Value;


                    }
                    catch (Exception ex)
                    {

                        MapleHome.debugConsole.WriteToDebugConsole($"Error updating Progressbar value  Reason:{ex}");

                    }


                }


            }

        }

        void PlaybackPanel_Disposed(object sender, EventArgs e)
        {
            CleanUp();
        }

        private void PopulateOutputDriverCombo()
        {
            comboBoxOutputDriver.Items.Add("WaveOut Window Callbacks");
            comboBoxOutputDriver.Items.Add("WaveOut Function Callbacks");
            comboBoxOutputDriver.Items.Add("WaveOut Event Callbacks");
            comboBoxOutputDriver.SelectedIndex = 0;
        }

        private void StopAll()
        {

            if (MapleHome.music.playingTrack)
            {
                MapleHome.music.userPressedStop = true;
                MapleHome.wavePlayer.Stop();
                MapleHome.music.ClearAudioPlaylist();
            }

        }
        internal void BeginVideoPlayback(string filePath)
        {

            //WriteToMapleConsole("Video Begin Playback Triggered");
            //WriteToMapleConsole($" file path {filePath}");
            //MapleHome.videoPlayer.videoPath = filePath;
            //MapleHome.videoPlayer.playVideo = true;
            //MapleHome.videoPlayer.Show();
            //MapleHome.videoPlayer.PlayVideo();
            //WriteToMapleConsole("Video Playback Started");

        }

        private void EnableButtons(bool playing)
        {
            //btn_Play.Enabled = !playing;
            //btn_Stop.Enabled = playing;
            //btn_Resume.Enabled = playing;
        }



        void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {

            Debug.Assert(!InvokeRequired, "PlaybackStopped on wrong thread");
            //Helpers helper = new Helpers();
            WriteToMapleConsole("Tick Timer stopped");
            MapleHome.music.trackPaused = false;

            WriteToMapleConsole("Playback Stopped");
            MapleHome.music.playingTrack = false;
            //helper.DisplayCurrentSongInfo("-", "-", "-", "-");
            timer1.Enabled = false;
            if (!MapleHome.music.userPressedStop)
            {

                ClearSongInfoDisplay();
                SetPlayStatus("");
            }
            else
            {

                SetPlayStatus("-Stopped-");
            }

            CleanUp();
            EnableButtons(false);
            lbl_CurrentTrackPosition.Text = "00:00";
            //if (!MapleHome.music.currentTrack.keepFile)
            //{
            //    try
            //    {

            //        File.Delete(MapleHome.music.currentTrack.path);
            //    }
            //    catch (Exception ex)
            //    {

            //        WriteToMapleConsole("File Delete Failed " + ex.Message);
            //    }


            //}
            MapleHome.music.currentTrack = null;
            MapleHome.music.userPressedStop = false;




            if (MapleHome.music.playlistCount > 1 && !MapleHome.music.userPressedStop && !MapleHome.music.userPressedLast)
            {
                MapleHome.debugConsole.WriteToDebugConsole($"Next Track Triggered After Stop");
                MapleHome.music.PlayNextTrack(sender, e);


                MapleHome.music.userPressedLast = false;
                MapleHome.music.userPressedNext = false;
                return;
            }
            if (MapleHome.music.userPressedLast)
            {

                MapleHome.debugConsole.WriteToDebugConsole($"Last Track Triggered ");
                MapleHome.music.PlayLastTrack(sender, e);


                MapleHome.music.userPressedLast = false;
                MapleHome.music.userPressedNext = false;
                return;
            }
            if (MapleHome.music.userPressedLast)
            {

                MapleHome.debugConsole.WriteToDebugConsole($"Last Track Triggered ");
                MapleHome.music.PlayNextTrack(sender, e);

                MapleHome.music.userPressedLast = false;
                MapleHome.music.userPressedNext = false;
                return;
            }
            MapleHome.debugConsole.WriteToDebugConsole($"Reached last of OnStop ");
            MapleHome.music.userPressedLast = false;
            MapleHome.music.userPressedNext = false;
            //MapleHome.music.userPressedStop = false;
            //MapleHome.music.userpressedSeek = false;
        }

        private void CleanUp()
        {
            if (MapleHome.audioFile != null)
            {
                MapleHome.audioFile.Dispose();
                MapleHome.audioFile = null;
            }
            if (MapleHome.wavePlayer != null)
            {
                MapleHome.wavePlayer.Dispose();
                MapleHome.wavePlayer = null;
            }
        }


        private void ckb_SaveMusic_CheckedChanged(object sender, EventArgs e)
        {

            if (!ckb_SaveMusic.Checked)
            {
                MapleHome.saveMusic = false;
                MapleHome.debugConsole.WriteToDebugConsole("Saving Music Disabled");
            }
            else
            {
                MapleHome.saveMusic = true;
                MapleHome.debugConsole.WriteToDebugConsole("Saving Music Enabled");
            }
        }

        private void ckb_SaveVideo_CheckedChanged(object sender, EventArgs e)
        {

            if (!ckb_SaveVideo.Checked)
            {
                MapleHome.saveVideo = false;
                //WriteToMapleConsole("Saving Video Disabled");
            }
            else
            {
                MapleHome.saveVideo = true;
                //WriteToMapleConsole("Saving Video Enabled");
            }
        }


        private void tbr_TrackProgressBar_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            try
            {
                MapleHome.music.progressBarCurrentTime = tbr_TrackProgressBar.Value;
                MapleHome.music.userpressedSeek = false;
                MapleHome.audioFile.CurrentTime = TimeSpan.FromSeconds(MapleHome.music.progressBarCurrentTime);

            }
            catch (Exception ex)
            {
                MapleHome.debugConsole.WriteToDebugConsole(ex.Message);
            }



        }

        private void tbr_TrackProgressBar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {


            try
            {
                MapleHome.music.userpressedSeek = true;
            }
            catch (Exception ex)
            {
                MapleHome.debugConsole.WriteToDebugConsole(ex.Message);
            }
        }
        private void StopPlayer()
        {

            if (MapleHome.music.playlistCount >= MapleHome.music.currentTrackPlaylistId)
            {
                if (MapleHome.music.playingTrack)
                { //pause 
                  //switch to next track.
                    MapleHome.music.userPressedStop = true;
                    MapleHome.music.trackPaused = true;
                    SetPlayStatus("-Stopped-");
                    timer1.Enabled = false;
                    MapleHome.wavePlayer.Pause();

                }

            }
            else if (MapleHome.music.playlistCount <= MapleHome.music.currentTrackPlaylistId)
            {
                if (MapleHome.music.playingTrack)
                {
                    MapleHome.music.userPressedStop = true;
                    MapleHome.wavePlayer.Stop();

                    MapleHome.music.ClearAudioPlaylist();
                }

            }


        }

        private void PausePlayer()
        {

            if (!MapleHome.music.trackPaused && MapleHome.music.playingTrack)
            {

                MapleHome.music.trackPaused = true;

                //lbl_PlayingStatus.Text = "-Paused-";
                SetPlayStatus("-Paused-");
                MapleHome.wavePlayer.Pause();


            }

        }

        private void OnButtonStopClick(object sender, EventArgs e)
        {

            StopPlayer();

        }


        private void OnButtonResumeClick(object sender, EventArgs e)
        {
            if (MapleHome.music.trackPaused && MapleHome.music.playingTrack)
            {

                MapleHome.music.trackPaused = false;
                MapleHome.music.userPressedStop = false;

                //lbl_PlayingStatus.Text = "-Paused-";
                SetPlayStatus("-Now Playing-");
                MapleHome.wavePlayer.Play();
                timer1.Enabled = true;

            }
            else if (MapleHome.music.trackPaused && MapleHome.music.userPressedStop)
            {
                MapleHome.music.userPressedStop = false;
                MapleHome.music.trackPaused = false;
                MapleHome.music.PlayNextTrack(sender, e);

            }

        }



        private void OnButtonPauseClick(object sender, EventArgs e)
        {
            PausePlayer();
        }
        private void OnVolumeSliderChanged(object sender, EventArgs e)
        {
            if (MapleHome.music.playingTrack)
            {
                MapleHome.audioFile.Volume = (float)volumeSlider3.Value / 100;
            }
            //helpers.WriteToMapleConsole($"Volume Changed to {MapleHome.audioFile.Volume}");
        }

        private void btn_Playlist_Click(object sender, EventArgs e)
        {
            togglePLaylistConsole();

        }

        private void btn_PlayingLast_Click(object sender, EventArgs e)
        {



            try
            {

                MapleHome.music.userPressedLast = true;
                MapleHome.wavePlayer.Stop();
                //WriteToMapleConsole("Skip Audio Pressed");
                //MapleHome.music.PlayLastTrack(sender, e);
            }
            catch (Exception ex)
            {

                MapleHome.debugConsole.WriteToDebugConsole(ex.Message);
            }



        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            try
            {
                MapleHome.wavePlayer.Stop();
                MapleHome.music.userPressedNext = true;
                //WriteToMapleConsole("Skip Audio Pressed");
                //MapleHome.music.PlayNextTrack(sender, e);

            }
            catch (Exception ex)
            {
                MapleHome.debugConsole.WriteToDebugConsole(ex.Message);



            }
        }

        private void btn_PingYouTube_Click(object sender, EventArgs e)
        {

            MapleHome.music.PingYouTube();
        }


        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string link = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Maple";

            try
            {

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    UseShellExecute = true,
                    Arguments = link,
                    FileName = "explorer.exe"

                };

                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                //WriteToMapleConsole(ex.Message);
            }
        }




        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            object sender = new object();
            e.Cancel = true;
            PausePlayer();

            MapleHome.form.MusicFormClosed();

        }



        internal void btn_MusicDebugConsoleToggle_Click(object sender, EventArgs e)
        {
            toggleDebugConsole();
        }



        public void toggleDebugConsole()
        {
            MapleHome.debugConsoleOpen = !MapleHome.debugConsoleOpen;
            if (MapleHome.debugConsoleOpen)
            {
                MapleHome.debugConsole.Show();

            }
            else
            {
                MapleHome.debugConsole.Hide();

            }

        }

        public void togglePLaylistConsole()
        {
            MapleHome.playlistConsoleOpen = !MapleHome.playlistConsoleOpen;
            if (MapleHome.playlistConsoleOpen)
            {
                MapleHome.playlistConsole.Show();
                MapleHome.playlistConsole.ClearPlaylistConsole();
                MapleHome.music.DisplayAudioPlaylist();
            }
            else
            {
                MapleHome.playlistConsole.Hide();

            }

        }

        private void lbl_PlayingLink_Click(object sender, EventArgs e)
        {
            string link = MapleHome.music.currentTrack.url;
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
    }
}

















