using NAudio.Gui;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MapleHome
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            img_MapleTitle = new PictureBox();
            label9 = new Label();
            lkl_DiscordLink = new LinkLabel();
            volumeSlider1 = new VolumeSlider();
            comboBoxOutputDriver = new System.Windows.Forms.ComboBox();
            btn_OpenMusicForm = new System.Windows.Forms.Button();
            btn_OpenChatForm = new System.Windows.Forms.Button();
            btn_OpenLinksForm = new System.Windows.Forms.Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)img_MapleTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // img_MapleTitle
            // 
            img_MapleTitle.BackColor = Color.Transparent;
            img_MapleTitle.BackgroundImage = Properties.Resources.Artboard_1_350xp;
            img_MapleTitle.BackgroundImageLayout = ImageLayout.Stretch;
            img_MapleTitle.Location = new Point(95, 11);
            img_MapleTitle.Name = "img_MapleTitle";
            img_MapleTitle.Size = new Size(189, 50);
            img_MapleTitle.TabIndex = 13;
            img_MapleTitle.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(144, 96);
            label9.Name = "label9";
            label9.Size = new Size(147, 20);
            label9.TabIndex = 62;
            label9.Text = "Need Help? Join the ";
            // 
            // lkl_DiscordLink
            // 
            lkl_DiscordLink.AutoSize = true;
            lkl_DiscordLink.BackColor = Color.Transparent;
            lkl_DiscordLink.LinkColor = Color.SteelBlue;
            lkl_DiscordLink.Location = new Point(282, 96);
            lkl_DiscordLink.Name = "lkl_DiscordLink";
            lkl_DiscordLink.Size = new Size(63, 20);
            lkl_DiscordLink.TabIndex = 63;
            lkl_DiscordLink.TabStop = true;
            lkl_DiscordLink.Text = "Discord.";
            lkl_DiscordLink.LinkClicked += lkl_DiscordLink_LinkClicked;
            // 
            // volumeSlider1
            // 
            volumeSlider1.BackColor = Color.Transparent;
            volumeSlider1.BackgroundImageLayout = ImageLayout.Stretch;
            volumeSlider1.Location = new Point(307, 37);
            volumeSlider1.Name = "volumeSlider1";
            volumeSlider1.Size = new Size(96, 16);
            volumeSlider1.TabIndex = 5;
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
            // btn_OpenMusicForm
            // 
            btn_OpenMusicForm.BackColor = Color.Transparent;
            btn_OpenMusicForm.BackgroundImageLayout = ImageLayout.Stretch;
            btn_OpenMusicForm.Cursor = Cursors.IBeam;
            btn_OpenMusicForm.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_OpenMusicForm.FlatAppearance.BorderSize = 0;
            btn_OpenMusicForm.FlatStyle = FlatStyle.Flat;
            btn_OpenMusicForm.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_OpenMusicForm.ForeColor = Color.Black;
            btn_OpenMusicForm.Location = new Point(29, 58);
            btn_OpenMusicForm.Name = "btn_OpenMusicForm";
            btn_OpenMusicForm.Size = new Size(94, 31);
            btn_OpenMusicForm.TabIndex = 115;
            btn_OpenMusicForm.Text = "Music";
            btn_OpenMusicForm.UseVisualStyleBackColor = false;
            btn_OpenMusicForm.Click += btn_OpenMusicForm_Click;
            // 
            // btn_OpenChatForm
            // 
            btn_OpenChatForm.BackColor = Color.Transparent;
            btn_OpenChatForm.BackgroundImageLayout = ImageLayout.Stretch;
            btn_OpenChatForm.Cursor = Cursors.IBeam;
            btn_OpenChatForm.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_OpenChatForm.FlatAppearance.BorderSize = 0;
            btn_OpenChatForm.FlatStyle = FlatStyle.Flat;
            btn_OpenChatForm.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_OpenChatForm.ForeColor = Color.Black;
            btn_OpenChatForm.Location = new Point(140, 58);
            btn_OpenChatForm.Name = "btn_OpenChatForm";
            btn_OpenChatForm.Size = new Size(94, 31);
            btn_OpenChatForm.TabIndex = 116;
            btn_OpenChatForm.Text = "Chat";
            btn_OpenChatForm.UseVisualStyleBackColor = false;
            btn_OpenChatForm.Click += btn_OpenChatForm_Click;
            // 
            // btn_OpenLinksForm
            // 
            btn_OpenLinksForm.BackColor = Color.Transparent;
            btn_OpenLinksForm.BackgroundImageLayout = ImageLayout.Stretch;
            btn_OpenLinksForm.Cursor = Cursors.IBeam;
            btn_OpenLinksForm.FlatAppearance.BorderColor = Color.Black;
            btn_OpenLinksForm.FlatAppearance.BorderSize = 0;
            btn_OpenLinksForm.FlatStyle = FlatStyle.Flat;
            btn_OpenLinksForm.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_OpenLinksForm.ForeColor = Color.Black;
            btn_OpenLinksForm.Location = new Point(255, 58);
            btn_OpenLinksForm.Margin = new Padding(3, 1, 3, 3);
            btn_OpenLinksForm.Name = "btn_OpenLinksForm";
            btn_OpenLinksForm.Size = new Size(94, 30);
            btn_OpenLinksForm.TabIndex = 117;
            btn_OpenLinksForm.Text = "Links";
            btn_OpenLinksForm.UseVisualStyleBackColor = false;
            btn_OpenLinksForm.Click += btn_OpenLinksForm_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(358, 110);
            pictureBox1.TabIndex = 118;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.Main_Window_Border;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(0, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(383, 133);
            pictureBox2.TabIndex = 119;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.Artboard_1_1075;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(382, 133);
            Controls.Add(btn_OpenLinksForm);
            Controls.Add(btn_OpenChatForm);
            Controls.Add(btn_OpenMusicForm);
            Controls.Add(img_MapleTitle);
            Controls.Add(lkl_DiscordLink);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Maple Desktop";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)img_MapleTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        internal PictureBox img_MapleTitle;
        private System.Windows.Forms.TextBox txb_;
        private Label label9;
        private LinkLabel lkl_DiscordLink;
        private RadioButton btn_SaveMusic;
        private VolumeSlider volumeSlider1;
        private System.Windows.Forms.ComboBox comboBoxOutputDriver;
        private VolumeSlider volumeSlider2;
        internal System.Windows.Forms.Button btn_OpenMusicForm;
        internal System.Windows.Forms.Button btn_OpenChatForm;
        internal System.Windows.Forms.Button btn_OpenLinksForm;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}