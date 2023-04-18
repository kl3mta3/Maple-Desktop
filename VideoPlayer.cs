using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace MapleHome
{
    public partial class VideoPlayer : Form
    {
        public string videoPath { get; set; }
        public bool playVideo { get; set; }
        internal MusicSystem music = MapleHome.music;
        public VideoPlayer()
        {
            InitializeComponent();
        }

        private void VideoPlayer_Load(object sender, EventArgs e)
        {
            if (playVideo)
            {
                PlayVideo();
            }
            //PlayVideo();
        }


        private void VideoPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            var player = new MediaPlayer();
            player.Close();
        }

        internal void PlayVideo()
        {
            /// use this to play video once its more understood
            /// for now , just play a video from a url
            //var player = new MediaPlayer();
            //player.Open(new Uri(videoPath));
            //player.Play();

            ///end
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            music.DisplayVideoPlaylist();
        }
    }
}
