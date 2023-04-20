namespace MapleHome
{
    partial class musicForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musicForm));
            btn_StopAll = new Button();
            btn_PlayingLast = new Button();
            Volume = new Label();
            volumeSlider3 = new TrackBar();
            lbl_PlayingStatus = new Label();
            btn_Ping = new Button();
            ckb_SaveVideo = new CheckBox();
            rbn_PlayAudio = new RadioButton();
            lbl_ProgressBarTrackLength = new Label();
            label16 = new Label();
            btn_Stop = new Button();
            btn_Skip = new Button();
            btn_Resume = new Button();
            btn_Pause = new Button();
            lbl_CurrentTrackPosition = new Label();
            tbr_TrackProgressBar = new TrackBar();
            ckb_SaveMusic = new CheckBox();
            linkLabel1 = new LinkLabel();
            lbl_PlayingLink = new LinkLabel();
            label21 = new Label();
            btn_Playlist = new Button();
            label13 = new Label();
            lbl_PlayingArtist = new Label();
            lbl_PlayingName = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            txb_SongInput = new TextBox();
            btn_Play = new Button();
            panel1 = new Panel();
            MusicBgPanel = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            comboBoxOutputDriver = new ComboBox();
            bindingSource1 = new BindingSource(components);
            btn_MusicDebugConsoleToggle = new Button();
            lbl_PlayTrackPlaylistID = new Label();
            lbl_PlayListTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)volumeSlider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbr_TrackProgressBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MusicBgPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btn_StopAll
            // 
            btn_StopAll.BackColor = Color.Black;
            btn_StopAll.Cursor = Cursors.IBeam;
            btn_StopAll.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_StopAll.FlatStyle = FlatStyle.Flat;
            btn_StopAll.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btn_StopAll.ForeColor = Color.WhiteSmoke;
            btn_StopAll.Location = new Point(328, 321);
            btn_StopAll.Name = "btn_StopAll";
            btn_StopAll.Size = new Size(59, 25);
            btn_StopAll.TabIndex = 126;
            btn_StopAll.Text = "Stop all";
            btn_StopAll.UseVisualStyleBackColor = false;
            // 
            // btn_PlayingLast
            // 
            btn_PlayingLast.BackColor = Color.Black;
            btn_PlayingLast.BackgroundImageLayout = ImageLayout.Stretch;
            btn_PlayingLast.Cursor = Cursors.IBeam;
            btn_PlayingLast.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_PlayingLast.FlatStyle = FlatStyle.Flat;
            btn_PlayingLast.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btn_PlayingLast.ForeColor = Color.WhiteSmoke;
            btn_PlayingLast.Location = new Point(160, 321);
            btn_PlayingLast.Name = "btn_PlayingLast";
            btn_PlayingLast.Size = new Size(49, 25);
            btn_PlayingLast.TabIndex = 145;
            btn_PlayingLast.Text = "Prev";
            btn_PlayingLast.UseVisualStyleBackColor = false;
            btn_PlayingLast.Click += btn_PlayingLast_Click;
            // 
            // Volume
            // 
            Volume.AutoSize = true;
            Volume.BackColor = Color.SteelBlue;
            Volume.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            Volume.Location = new Point(299, 374);
            Volume.Name = "Volume";
            Volume.Size = new Size(49, 15);
            Volume.TabIndex = 132;
            Volume.Text = "Volume";
            // 
            // volumeSlider3
            // 
            volumeSlider3.BackColor = Color.SteelBlue;
            volumeSlider3.LargeChange = 10;
            volumeSlider3.Location = new Point(258, 352);
            volumeSlider3.Maximum = 100;
            volumeSlider3.Name = "volumeSlider3";
            volumeSlider3.RightToLeft = RightToLeft.No;
            volumeSlider3.Size = new Size(130, 56);
            volumeSlider3.TabIndex = 144;
            volumeSlider3.TickStyle = TickStyle.None;
            volumeSlider3.Value = 100;
            volumeSlider3.Scroll += OnVolumeSliderChanged;
            // 
            // lbl_PlayingStatus
            // 
            lbl_PlayingStatus.AutoSize = true;
            lbl_PlayingStatus.BackColor = Color.SteelBlue;
            lbl_PlayingStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_PlayingStatus.Location = new Point(122, 121);
            lbl_PlayingStatus.Name = "lbl_PlayingStatus";
            lbl_PlayingStatus.Size = new Size(0, 28);
            lbl_PlayingStatus.TabIndex = 143;
            // 
            // btn_Ping
            // 
            btn_Ping.BackColor = Color.Black;
            btn_Ping.FlatAppearance.BorderSize = 0;
            btn_Ping.FlatStyle = FlatStyle.Flat;
            btn_Ping.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Ping.ForeColor = Color.Transparent;
            btn_Ping.Location = new Point(20, 418);
            btn_Ping.Name = "btn_Ping";
            btn_Ping.Size = new Size(49, 20);
            btn_Ping.TabIndex = 142;
            btn_Ping.Text = "Ping Api";
            btn_Ping.UseVisualStyleBackColor = false;
            btn_Ping.Click += btn_PingYouTube_Click;
            // 
            // ckb_SaveVideo
            // 
            ckb_SaveVideo.AutoSize = true;
            ckb_SaveVideo.BackColor = Color.Transparent;
            ckb_SaveVideo.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            ckb_SaveVideo.Location = new Point(284, 88);
            ckb_SaveVideo.Name = "ckb_SaveVideo";
            ckb_SaveVideo.Size = new Size(91, 19);
            ckb_SaveVideo.TabIndex = 141;
            ckb_SaveVideo.Text = "Save Video";
            ckb_SaveVideo.UseVisualStyleBackColor = false;
            ckb_SaveVideo.CheckedChanged += ckb_SaveVideo_CheckedChanged;
            // 
            // rbn_PlayAudio
            // 
            rbn_PlayAudio.AutoSize = true;
            rbn_PlayAudio.BackColor = Color.Transparent;
            rbn_PlayAudio.Checked = true;
            rbn_PlayAudio.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            rbn_PlayAudio.Location = new Point(315, 20);
            rbn_PlayAudio.Name = "rbn_PlayAudio";
            rbn_PlayAudio.Size = new Size(70, 23);
            rbn_PlayAudio.TabIndex = 140;
            rbn_PlayAudio.TabStop = true;
            rbn_PlayAudio.Text = "Audio";
            rbn_PlayAudio.UseVisualStyleBackColor = false;
            rbn_PlayAudio.Visible = false;
            rbn_PlayAudio.CheckedChanged += rbn_PlayAudio_CheckedChanged;
            // 
            // lbl_ProgressBarTrackLength
            // 
            lbl_ProgressBarTrackLength.AutoSize = true;
            lbl_ProgressBarTrackLength.BackColor = Color.SteelBlue;
            lbl_ProgressBarTrackLength.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ProgressBarTrackLength.Location = new Point(343, 295);
            lbl_ProgressBarTrackLength.Name = "lbl_ProgressBarTrackLength";
            lbl_ProgressBarTrackLength.Size = new Size(31, 15);
            lbl_ProgressBarTrackLength.TabIndex = 136;
            lbl_ProgressBarTrackLength.Text = "0:00";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.SteelBlue;
            label16.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(28, 295);
            label16.Name = "label16";
            label16.Size = new Size(31, 15);
            label16.TabIndex = 135;
            label16.Text = "0:00";
            // 
            // btn_Stop
            // 
            btn_Stop.BackColor = Color.Black;
            btn_Stop.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Stop.Cursor = Cursors.IBeam;
            btn_Stop.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_Stop.FlatStyle = FlatStyle.Flat;
            btn_Stop.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Stop.ForeColor = Color.WhiteSmoke;
            btn_Stop.Location = new Point(279, 321);
            btn_Stop.Name = "btn_Stop";
            btn_Stop.Size = new Size(49, 25);
            btn_Stop.TabIndex = 124;
            btn_Stop.Text = "Stop";
            btn_Stop.UseVisualStyleBackColor = false;
            btn_Stop.Click += OnButtonStopClick;
            // 
            // btn_Skip
            // 
            btn_Skip.BackColor = Color.Black;
            btn_Skip.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Skip.Cursor = Cursors.IBeam;
            btn_Skip.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_Skip.FlatStyle = FlatStyle.Flat;
            btn_Skip.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Skip.ForeColor = Color.WhiteSmoke;
            btn_Skip.Location = new Point(211, 321);
            btn_Skip.Name = "btn_Skip";
            btn_Skip.Size = new Size(49, 25);
            btn_Skip.TabIndex = 123;
            btn_Skip.Text = "Skip";
            btn_Skip.UseVisualStyleBackColor = false;
            btn_Skip.Click += btn_Skip_Click;
            // 
            // btn_Resume
            // 
            btn_Resume.BackColor = Color.Black;
            btn_Resume.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Resume.Cursor = Cursors.IBeam;
            btn_Resume.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_Resume.FlatStyle = FlatStyle.Flat;
            btn_Resume.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Resume.ForeColor = Color.WhiteSmoke;
            btn_Resume.Location = new Point(79, 321);
            btn_Resume.Name = "btn_Resume";
            btn_Resume.Size = new Size(59, 25);
            btn_Resume.TabIndex = 122;
            btn_Resume.Text = "Resume";
            btn_Resume.UseVisualStyleBackColor = false;
            btn_Resume.Click += OnButtonResumeClick;
            // 
            // btn_Pause
            // 
            btn_Pause.BackColor = Color.Black;
            btn_Pause.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Pause.Cursor = Cursors.IBeam;
            btn_Pause.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_Pause.FlatStyle = FlatStyle.Flat;
            btn_Pause.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Pause.ForeColor = Color.WhiteSmoke;
            btn_Pause.Location = new Point(28, 321);
            btn_Pause.Name = "btn_Pause";
            btn_Pause.Size = new Size(49, 25);
            btn_Pause.TabIndex = 121;
            btn_Pause.Text = "Pause";
            btn_Pause.UseVisualStyleBackColor = false;
            btn_Pause.Click += OnButtonPauseClick;
            // 
            // lbl_CurrentTrackPosition
            // 
            lbl_CurrentTrackPosition.AutoSize = true;
            lbl_CurrentTrackPosition.BackColor = Color.SteelBlue;
            lbl_CurrentTrackPosition.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_CurrentTrackPosition.Location = new Point(169, 295);
            lbl_CurrentTrackPosition.Name = "lbl_CurrentTrackPosition";
            lbl_CurrentTrackPosition.Size = new Size(60, 15);
            lbl_CurrentTrackPosition.TabIndex = 137;
            lbl_CurrentTrackPosition.Text = "0:00/0:00";
            // 
            // tbr_TrackProgressBar
            // 
            tbr_TrackProgressBar.BackColor = Color.SteelBlue;
            tbr_TrackProgressBar.Location = new Point(21, 270);
            tbr_TrackProgressBar.Maximum = 100;
            tbr_TrackProgressBar.Name = "tbr_TrackProgressBar";
            tbr_TrackProgressBar.RightToLeft = RightToLeft.No;
            tbr_TrackProgressBar.Size = new Size(360, 56);
            tbr_TrackProgressBar.TabIndex = 133;
            tbr_TrackProgressBar.TickFrequency = 10;
            tbr_TrackProgressBar.TickStyle = TickStyle.None;
            tbr_TrackProgressBar.MouseDown += tbr_TrackProgressBar_MouseDown;
            tbr_TrackProgressBar.MouseUp += tbr_TrackProgressBar_MouseUp;
            // 
            // ckb_SaveMusic
            // 
            ckb_SaveMusic.AutoSize = true;
            ckb_SaveMusic.BackColor = Color.Transparent;
            ckb_SaveMusic.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            ckb_SaveMusic.Location = new Point(188, 88);
            ckb_SaveMusic.Name = "ckb_SaveMusic";
            ckb_SaveMusic.Size = new Size(91, 19);
            ckb_SaveMusic.TabIndex = 134;
            ckb_SaveMusic.Text = "Save Music";
            ckb_SaveMusic.UseVisualStyleBackColor = false;
            ckb_SaveMusic.CheckedChanged += ckb_SaveMusic_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.SteelBlue;
            linkLabel1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(188, 393);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(170, 19);
            linkLabel1.TabIndex = 138;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "\\AppData\\Roaming\\Maple";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // lbl_PlayingLink
            // 
            lbl_PlayingLink.AutoSize = true;
            lbl_PlayingLink.BackColor = Color.SteelBlue;
            lbl_PlayingLink.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_PlayingLink.LinkColor = Color.Black;
            lbl_PlayingLink.Location = new Point(92, 232);
            lbl_PlayingLink.MaximumSize = new Size(260, 0);
            lbl_PlayingLink.Name = "lbl_PlayingLink";
            lbl_PlayingLink.Size = new Size(12, 15);
            lbl_PlayingLink.TabIndex = 130;
            lbl_PlayingLink.TabStop = true;
            lbl_PlayingLink.Text = "-";
            lbl_PlayingLink.Click += lbl_PlayingLink_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.SteelBlue;
            label21.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(64, 394);
            label21.Name = "label21";
            label21.Size = new Size(118, 19);
            label21.TabIndex = 129;
            label21.Text = "Files are saved to ";
            // 
            // btn_Playlist
            // 
            btn_Playlist.BackColor = Color.Black;
            btn_Playlist.Cursor = Cursors.IBeam;
            btn_Playlist.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_Playlist.FlatStyle = FlatStyle.Flat;
            btn_Playlist.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Playlist.ForeColor = Color.WhiteSmoke;
            btn_Playlist.Location = new Point(28, 364);
            btn_Playlist.Name = "btn_Playlist";
            btn_Playlist.Size = new Size(60, 25);
            btn_Playlist.TabIndex = 127;
            btn_Playlist.Text = "Playlist";
            btn_Playlist.UseVisualStyleBackColor = false;
            btn_Playlist.Click += btn_Playlist_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(135, 14);
            label13.Name = "label13";
            label13.Size = new Size(133, 28);
            label13.TabIndex = 125;
            label13.Text = "Maple Music";
            // 
            // lbl_PlayingArtist
            // 
            lbl_PlayingArtist.AutoSize = true;
            lbl_PlayingArtist.BackColor = Color.SteelBlue;
            lbl_PlayingArtist.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_PlayingArtist.Location = new Point(90, 189);
            lbl_PlayingArtist.MaximumSize = new Size(240, 0);
            lbl_PlayingArtist.Name = "lbl_PlayingArtist";
            lbl_PlayingArtist.Size = new Size(15, 19);
            lbl_PlayingArtist.TabIndex = 120;
            lbl_PlayingArtist.Text = "-";
            // 
            // lbl_PlayingName
            // 
            lbl_PlayingName.AutoSize = true;
            lbl_PlayingName.BackColor = Color.SteelBlue;
            lbl_PlayingName.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_PlayingName.Location = new Point(90, 150);
            lbl_PlayingName.MaximumSize = new Size(240, 0);
            lbl_PlayingName.Name = "lbl_PlayingName";
            lbl_PlayingName.Size = new Size(15, 19);
            lbl_PlayingName.TabIndex = 119;
            lbl_PlayingName.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SteelBlue;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(41, 229);
            label6.Name = "label6";
            label6.Size = new Size(50, 23);
            label6.TabIndex = 118;
            label6.Text = "Link:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SteelBlue;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(31, 189);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 117;
            label4.Text = "Artist:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SteelBlue;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 150);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 116;
            label3.Text = "Name:";
            // 
            // txb_SongInput
            // 
            txb_SongInput.BackColor = Color.LightGray;
            txb_SongInput.Location = new Point(16, 49);
            txb_SongInput.Name = "txb_SongInput";
            txb_SongInput.PlaceholderText = "Enter Song Title Here";
            txb_SongInput.Size = new Size(378, 27);
            txb_SongInput.TabIndex = 115;
            txb_SongInput.KeyPress += txb_SongInput_KeyPress;
            // 
            // btn_Play
            // 
            btn_Play.BackColor = Color.Black;
            btn_Play.Cursor = Cursors.IBeam;
            btn_Play.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_Play.FlatStyle = FlatStyle.Flat;
            btn_Play.ForeColor = Color.WhiteSmoke;
            btn_Play.Location = new Point(16, 82);
            btn_Play.Name = "btn_Play";
            btn_Play.Size = new Size(94, 29);
            btn_Play.TabIndex = 114;
            btn_Play.Text = "Play";
            btn_Play.UseVisualStyleBackColor = false;
            btn_Play.Click += btn_Play_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(12, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 323);
            panel1.TabIndex = 131;
            // 
            // MusicBgPanel
            // 
            MusicBgPanel.BackColor = Color.Transparent;
            MusicBgPanel.BackgroundImage = Properties.Resources.Music_Bg_Panel;
            MusicBgPanel.BackgroundImageLayout = ImageLayout.Stretch;
            MusicBgPanel.Location = new Point(4, 6);
            MusicBgPanel.Name = "MusicBgPanel";
            MusicBgPanel.Size = new Size(402, 445);
            MusicBgPanel.TabIndex = 128;
            MusicBgPanel.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += OnTimerTick;
            // 
            // comboBoxOutputDriver
            // 
            comboBoxOutputDriver.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOutputDriver.FormattingEnabled = true;
            comboBoxOutputDriver.Location = new Point(128, 80);
            comboBoxOutputDriver.Name = "comboBoxOutputDriver";
            comboBoxOutputDriver.Size = new Size(227, 28);
            comboBoxOutputDriver.TabIndex = 3;
            // 
            // btn_MusicDebugConsoleToggle
            // 
            btn_MusicDebugConsoleToggle.BackColor = Color.Black;
            btn_MusicDebugConsoleToggle.Cursor = Cursors.IBeam;
            btn_MusicDebugConsoleToggle.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_MusicDebugConsoleToggle.FlatStyle = FlatStyle.Flat;
            btn_MusicDebugConsoleToggle.Font = new Font("Segoe UI", 4F, FontStyle.Regular, GraphicsUnit.Point);
            btn_MusicDebugConsoleToggle.ForeColor = Color.WhiteSmoke;
            btn_MusicDebugConsoleToggle.ImageAlign = ContentAlignment.TopCenter;
            btn_MusicDebugConsoleToggle.Location = new Point(353, 418);
            btn_MusicDebugConsoleToggle.Name = "btn_MusicDebugConsoleToggle";
            btn_MusicDebugConsoleToggle.Size = new Size(37, 20);
            btn_MusicDebugConsoleToggle.TabIndex = 147;
            btn_MusicDebugConsoleToggle.Text = "Debug";
            btn_MusicDebugConsoleToggle.TextAlign = ContentAlignment.TopCenter;
            btn_MusicDebugConsoleToggle.UseVisualStyleBackColor = false;
            btn_MusicDebugConsoleToggle.Click += btn_MusicDebugConsoleToggle_Click;
            // 
            // lbl_PlayTrackPlaylistID
            // 
            lbl_PlayTrackPlaylistID.AutoSize = true;
            lbl_PlayTrackPlaylistID.BackColor = Color.SteelBlue;
            lbl_PlayTrackPlaylistID.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_PlayTrackPlaylistID.Location = new Point(159, 367);
            lbl_PlayTrackPlaylistID.MaximumSize = new Size(240, 0);
            lbl_PlayTrackPlaylistID.Name = "lbl_PlayTrackPlaylistID";
            lbl_PlayTrackPlaylistID.Size = new Size(15, 19);
            lbl_PlayTrackPlaylistID.TabIndex = 149;
            lbl_PlayTrackPlaylistID.Text = "-";
            // 
            // lbl_PlayListTitle
            // 
            lbl_PlayListTitle.AutoSize = true;
            lbl_PlayListTitle.BackColor = Color.SteelBlue;
            lbl_PlayListTitle.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_PlayListTitle.Location = new Point(98, 369);
            lbl_PlayListTitle.Name = "lbl_PlayListTitle";
            lbl_PlayListTitle.Size = new Size(62, 15);
            lbl_PlayListTitle.TabIndex = 148;
            lbl_PlayListTitle.Text = "Playing # :";
            // 
            // musicForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.Artboard_1_1075;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(410, 460);
            Controls.Add(linkLabel1);
            Controls.Add(btn_Ping);
            Controls.Add(lbl_PlayTrackPlaylistID);
            Controls.Add(label21);
            Controls.Add(lbl_PlayListTitle);
            Controls.Add(btn_MusicDebugConsoleToggle);
            Controls.Add(lbl_CurrentTrackPosition);
            Controls.Add(btn_Playlist);
            Controls.Add(btn_StopAll);
            Controls.Add(Volume);
            Controls.Add(btn_PlayingLast);
            Controls.Add(volumeSlider3);
            Controls.Add(lbl_PlayingStatus);
            Controls.Add(ckb_SaveVideo);
            Controls.Add(rbn_PlayAudio);
            Controls.Add(lbl_ProgressBarTrackLength);
            Controls.Add(label16);
            Controls.Add(btn_Stop);
            Controls.Add(btn_Skip);
            Controls.Add(btn_Resume);
            Controls.Add(btn_Pause);
            Controls.Add(tbr_TrackProgressBar);
            Controls.Add(ckb_SaveMusic);
            Controls.Add(lbl_PlayingLink);
            Controls.Add(label13);
            Controls.Add(lbl_PlayingArtist);
            Controls.Add(lbl_PlayingName);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txb_SongInput);
            Controls.Add(btn_Play);
            Controls.Add(panel1);
            Controls.Add(MusicBgPanel);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "musicForm";
            Text = "Maple Music";
            Load += musicForm_Load;
            ((System.ComponentModel.ISupportInitialize)volumeSlider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbr_TrackProgressBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)MusicBgPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Button btn_StopAll;
        internal Button btn_PlayingLast;
        private Label Volume;
        private TrackBar volumeSlider3;
        private Label lbl_PlayingStatus;
        private Button btn_Ping;
        private CheckBox ckb_SaveVideo;
        private RadioButton rbn_PlayAudio;
        private Label lbl_ProgressBarTrackLength;
        private Label label16;
        internal Button btn_Stop;
        internal Button btn_Skip;
        internal Button btn_Resume;
        internal Button btn_Pause;
        private Label lbl_CurrentTrackPosition;
        private TrackBar tbr_TrackProgressBar;
        private CheckBox ckb_SaveMusic;
        private LinkLabel linkLabel1;
        private LinkLabel lbl_PlayingLink;
        private Label label21;
        internal Button btn_Playlist;
        private Label label13;
        internal Label lbl_PlayingArtist;
        internal Label lbl_PlayingName;
        private Label label6;
        private Label label4;
        private Label label3;
        internal TextBox txb_SongInput;
        internal Button btn_Play;
        private Panel panel1;
        private PictureBox MusicBgPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBoxOutputDriver;
        private BindingSource bindingSource1;
        internal Button btn_MusicDebugConsoleToggle;
        internal Label lbl_PlayTrackPlaylistID;
        private Label lbl_PlayListTitle;
    }
}