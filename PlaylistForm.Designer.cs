namespace MapleHome
{
    partial class PlaylistForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistForm));
            pictureBox1 = new PictureBox();
            rtb_PlaylistConsole = new RichTextBox();
            btn_ClearPlaylist = new Button();
            lbl_Playlist = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Music_Bg_Panel;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(6, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(530, 330);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // rtb_PlaylistConsole
            // 
            rtb_PlaylistConsole.BackColor = SystemColors.InactiveCaptionText;
            rtb_PlaylistConsole.Font = new Font("Gill Sans Ultra Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            rtb_PlaylistConsole.ForeColor = SystemColors.ScrollBar;
            rtb_PlaylistConsole.Location = new Point(16, 12);
            rtb_PlaylistConsole.Name = "rtb_PlaylistConsole";
            rtb_PlaylistConsole.Size = new Size(513, 311);
            rtb_PlaylistConsole.TabIndex = 1;
            rtb_PlaylistConsole.Text = "";
            // 
            // btn_ClearPlaylist
            // 
            btn_ClearPlaylist.BackColor = Color.Black;
            btn_ClearPlaylist.Cursor = Cursors.IBeam;
            btn_ClearPlaylist.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_ClearPlaylist.FlatStyle = FlatStyle.Flat;
            btn_ClearPlaylist.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ClearPlaylist.ForeColor = Color.WhiteSmoke;
            btn_ClearPlaylist.Location = new Point(6, 344);
            btn_ClearPlaylist.Name = "btn_ClearPlaylist";
            btn_ClearPlaylist.Size = new Size(81, 24);
            btn_ClearPlaylist.TabIndex = 114;
            btn_ClearPlaylist.Text = "Clear Playlist";
            btn_ClearPlaylist.UseVisualStyleBackColor = false;
            btn_ClearPlaylist.Click += btn_ClearPlaylist_Click;
            // 
            // lbl_Playlist
            // 
            lbl_Playlist.AutoSize = true;
            lbl_Playlist.BackColor = Color.Black;
            lbl_Playlist.Font = new Font("Gill Sans Ultra Bold", 7.8F, FontStyle.Underline, GraphicsUnit.Point);
            lbl_Playlist.ForeColor = Color.WhiteSmoke;
            lbl_Playlist.Location = new Point(96, 16);
            lbl_Playlist.Name = "lbl_Playlist";
            lbl_Playlist.Size = new Size(44, 19);
            lbl_Playlist.TabIndex = 0;
            lbl_Playlist.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Gill Sans Ultra Bold", 7.8F, FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(18, 19);
            label1.TabIndex = 115;
            label1.Text = "#";
            // 
            // PlaylistForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.Artboard_1_1075;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(541, 380);
            Controls.Add(label1);
            Controls.Add(lbl_Playlist);
            Controls.Add(btn_ClearPlaylist);
            Controls.Add(rtb_PlaylistConsole);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PlaylistForm";
            Text = "Music Playlist";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private RichTextBox rtb_PlaylistConsole;
        internal Button btn_ClearPlaylist;
        private Label lbl_Playlist;
        private Label label1;
    }
}