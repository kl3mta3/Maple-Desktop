namespace MapleHome
{
    partial class AiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AiForm));
            lkl_SeeApiToken = new LinkLabel();
            label15 = new Label();
            label7 = new Label();
            btn_SaveApiKey = new Button();
            btn_ClearMapleConsole = new Button();
            btn_OpenAiLink = new Button();
            label19 = new Label();
            rtb_MapleInput = new RichTextBox();
            label18 = new Label();
            txb_OpenAiApiKey = new TextBox();
            btn_InputEnter = new Button();
            label20 = new Label();
            rbn_ApiSaved1 = new CheckBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            rtb_MapleConsole = new RichTextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lkl_SeeApiToken
            // 
            lkl_SeeApiToken.AutoSize = true;
            lkl_SeeApiToken.BackColor = Color.Transparent;
            lkl_SeeApiToken.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            lkl_SeeApiToken.LinkColor = Color.Black;
            lkl_SeeApiToken.Location = new Point(326, 552);
            lkl_SeeApiToken.Name = "lkl_SeeApiToken";
            lkl_SeeApiToken.Size = new Size(154, 15);
            lkl_SeeApiToken.TabIndex = 119;
            lkl_SeeApiToken.TabStop = true;
            lkl_SeeApiToken.Text = "(Click to See Saved Token)";
            lkl_SeeApiToken.TextAlign = ContentAlignment.MiddleCenter;
            lkl_SeeApiToken.MouseDown += lkl_SeeApiToken_MouseDown;
            lkl_SeeApiToken.MouseUp += lkl_SeeApiToken_MouseUp;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(88, 553);
            label15.Name = "label15";
            label15.Size = new Size(183, 15);
            label15.TabIndex = 117;
            label15.Text = "(An OpenAi Api Token is Needed)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(486, 585);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 116;
            label7.Text = "Saved";
            // 
            // btn_SaveApiKey
            // 
            btn_SaveApiKey.BackColor = Color.Black;
            btn_SaveApiKey.Cursor = Cursors.IBeam;
            btn_SaveApiKey.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_SaveApiKey.FlatStyle = FlatStyle.Flat;
            btn_SaveApiKey.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SaveApiKey.ForeColor = Color.WhiteSmoke;
            btn_SaveApiKey.Location = new Point(437, 572);
            btn_SaveApiKey.Name = "btn_SaveApiKey";
            btn_SaveApiKey.Size = new Size(43, 22);
            btn_SaveApiKey.TabIndex = 115;
            btn_SaveApiKey.Text = "Save";
            btn_SaveApiKey.UseVisualStyleBackColor = false;
            btn_SaveApiKey.Click += btn_SaveApiKey_Click;
            // 
            // btn_ClearMapleConsole
            // 
            btn_ClearMapleConsole.BackColor = Color.Black;
            btn_ClearMapleConsole.Cursor = Cursors.IBeam;
            btn_ClearMapleConsole.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_ClearMapleConsole.FlatStyle = FlatStyle.Flat;
            btn_ClearMapleConsole.ForeColor = Color.WhiteSmoke;
            btn_ClearMapleConsole.Location = new Point(580, 405);
            btn_ClearMapleConsole.Name = "btn_ClearMapleConsole";
            btn_ClearMapleConsole.Size = new Size(81, 29);
            btn_ClearMapleConsole.TabIndex = 114;
            btn_ClearMapleConsole.Text = "Clear";
            btn_ClearMapleConsole.UseVisualStyleBackColor = false;
            btn_ClearMapleConsole.Click += btn_ClearMapleConsole_Click;
            // 
            // btn_OpenAiLink
            // 
            btn_OpenAiLink.BackColor = Color.Black;
            btn_OpenAiLink.Cursor = Cursors.IBeam;
            btn_OpenAiLink.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_OpenAiLink.FlatStyle = FlatStyle.Flat;
            btn_OpenAiLink.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            btn_OpenAiLink.ForeColor = Color.WhiteSmoke;
            btn_OpenAiLink.Location = new Point(534, 572);
            btn_OpenAiLink.Name = "btn_OpenAiLink";
            btn_OpenAiLink.Size = new Size(81, 24);
            btn_OpenAiLink.TabIndex = 113;
            btn_OpenAiLink.Text = "OpenAi.com";
            btn_OpenAiLink.UseVisualStyleBackColor = false;
            btn_OpenAiLink.Click += btn_OpenAiLink_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(26, 425);
            label19.Name = "label19";
            label19.Size = new Size(47, 20);
            label19.TabIndex = 112;
            label19.Text = "Input";
            // 
            // rtb_MapleInput
            // 
            rtb_MapleInput.AcceptsTab = true;
            rtb_MapleInput.BackColor = Color.LightGray;
            rtb_MapleInput.Location = new Point(26, 448);
            rtb_MapleInput.Name = "rtb_MapleInput";
            rtb_MapleInput.Size = new Size(540, 101);
            rtb_MapleInput.TabIndex = 111;
            rtb_MapleInput.Text = "";
            rtb_MapleInput.Enter += rtb_MapleInput_Enter;
            rtb_MapleInput.KeyPress += rtb_MapleInput_KeyPress;
            rtb_MapleInput.Leave += rtb_MapleInput_Leave;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(24, 17);
            label18.Name = "label18";
            label18.Size = new Size(120, 28);
            label18.TabIndex = 110;
            label18.Text = "Maple Chat";
            // 
            // txb_OpenAiApiKey
            // 
            txb_OpenAiApiKey.BackColor = Color.LightGray;
            txb_OpenAiApiKey.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            txb_OpenAiApiKey.Location = new Point(59, 571);
            txb_OpenAiApiKey.Name = "txb_OpenAiApiKey";
            txb_OpenAiApiKey.PlaceholderText = "OpenAi API Token";
            txb_OpenAiApiKey.Size = new Size(372, 25);
            txb_OpenAiApiKey.TabIndex = 108;
            // 
            // btn_InputEnter
            // 
            btn_InputEnter.BackColor = Color.Black;
            btn_InputEnter.Cursor = Cursors.IBeam;
            btn_InputEnter.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_InputEnter.FlatStyle = FlatStyle.Flat;
            btn_InputEnter.ForeColor = Color.WhiteSmoke;
            btn_InputEnter.Location = new Point(580, 478);
            btn_InputEnter.Name = "btn_InputEnter";
            btn_InputEnter.Size = new Size(81, 47);
            btn_InputEnter.TabIndex = 107;
            btn_InputEnter.Text = "Enter";
            btn_InputEnter.UseVisualStyleBackColor = false;
            btn_InputEnter.Click += btn_InputEnter_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(417, 602);
            label20.Name = "label20";
            label20.Size = new Size(244, 19);
            label20.TabIndex = 118;
            label20.Text = "Don't have a token? Visit OpenAi.com.";
            // 
            // rbn_ApiSaved1
            // 
            rbn_ApiSaved1.AutoSize = true;
            rbn_ApiSaved1.BackColor = Color.Transparent;
            rbn_ApiSaved1.Location = new Point(497, 566);
            rbn_ApiSaved1.Name = "rbn_ApiSaved1";
            rbn_ApiSaved1.Size = new Size(18, 17);
            rbn_ApiSaved1.TabIndex = 120;
            rbn_ApiSaved1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Music_Bg_Panel;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(7, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(678, 617);
            pictureBox1.TabIndex = 121;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(172, 427);
            label1.Name = "label1";
            label1.Size = new Size(298, 19);
            label1.TabIndex = 122;
            label1.Text = "Note: Long Answers might take a moment. ";
            // 
            // rtb_MapleConsole
            // 
            rtb_MapleConsole.BackColor = SystemColors.InactiveCaptionText;
            rtb_MapleConsole.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rtb_MapleConsole.ForeColor = Color.WhiteSmoke;
            rtb_MapleConsole.Location = new Point(24, 48);
            rtb_MapleConsole.Name = "rtb_MapleConsole";
            rtb_MapleConsole.ReadOnly = true;
            rtb_MapleConsole.Size = new Size(637, 360);
            rtb_MapleConsole.TabIndex = 123;
            rtb_MapleConsole.Text = "";
            rtb_MapleConsole.LinkClicked += rtb_MapleConsole_LinkClicked;
            rtb_MapleConsole.TextChanged += rtb_MapleConsole_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(111, 602);
            label2.Name = "label2";
            label2.Size = new Size(289, 19);
            label2.TabIndex = 124;
            label2.Text = "Client Restart Needed after adding a new key!";
            // 
            // AiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Artboard_1_1075;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(697, 641);
            Controls.Add(label2);
            Controls.Add(rtb_MapleConsole);
            Controls.Add(label1);
            Controls.Add(lkl_SeeApiToken);
            Controls.Add(label15);
            Controls.Add(label7);
            Controls.Add(btn_SaveApiKey);
            Controls.Add(btn_ClearMapleConsole);
            Controls.Add(btn_OpenAiLink);
            Controls.Add(label19);
            Controls.Add(rtb_MapleInput);
            Controls.Add(label18);
            Controls.Add(txb_OpenAiApiKey);
            Controls.Add(btn_InputEnter);
            Controls.Add(label20);
            Controls.Add(rbn_ApiSaved1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AiForm";
            Text = "Maple Chat";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lkl_SeeApiToken;
        private Label label15;
        private Label label7;
        internal Button btn_SaveApiKey;
        internal Button btn_ClearMapleConsole;
        internal Button btn_OpenAiLink;
        private Label label19;
        internal RichTextBox rtb_MapleInput;
        private Label label18;
        internal TextBox txb_OpenAiApiKey;
        internal Button btn_InputEnter;
        private Label label20;
        private CheckBox rbn_ApiSaved1;
        private PictureBox pictureBox1;
        private Label label1;
        private RichTextBox rtb_MapleConsole;
        private Label label2;
    }
}