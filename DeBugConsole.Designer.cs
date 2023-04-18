namespace MapleHome
{
    partial class DeBugConsole
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
            pictureBox1 = new PictureBox();
            rtb_DebugWindow = new RichTextBox();
            btn_ClearConsole = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Music_Bg_Panel;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(9, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(464, 268);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // rtb_DebugWindow
            // 
            rtb_DebugWindow.BackColor = SystemColors.InfoText;
            rtb_DebugWindow.ForeColor = Color.WhiteSmoke;
            rtb_DebugWindow.HideSelection = false;
            rtb_DebugWindow.Location = new Point(15, 12);
            rtb_DebugWindow.Name = "rtb_DebugWindow";
            rtb_DebugWindow.ReadOnly = true;
            rtb_DebugWindow.Size = new Size(451, 256);
            rtb_DebugWindow.TabIndex = 1;
            rtb_DebugWindow.Text = "";
            rtb_DebugWindow.TextChanged += rtb_DebugWindow_TextChanged;
            // 
            // btn_ClearConsole
            // 
            btn_ClearConsole.BackColor = Color.Black;
            btn_ClearConsole.Cursor = Cursors.IBeam;
            btn_ClearConsole.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_ClearConsole.FlatStyle = FlatStyle.Flat;
            btn_ClearConsole.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ClearConsole.ForeColor = Color.WhiteSmoke;
            btn_ClearConsole.Location = new Point(392, 285);
            btn_ClearConsole.Name = "btn_ClearConsole";
            btn_ClearConsole.Size = new Size(81, 24);
            btn_ClearConsole.TabIndex = 115;
            btn_ClearConsole.Text = "Clear Console";
            btn_ClearConsole.UseVisualStyleBackColor = false;
            btn_ClearConsole.Click += btn_ClearConsole_Click;
            // 
            // DeBugConsole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Artboard_1_1075;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(485, 321);
            Controls.Add(btn_ClearConsole);
            Controls.Add(rtb_DebugWindow);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeBugConsole";
            Text = "DeBugConsole";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private RichTextBox rtb_DebugWindow;
        internal Button btn_ClearConsole;
    }
}