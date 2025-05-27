namespace GymYang
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            toolTip1 = new ToolTip(components);
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btCreateAccount = new Button();
            btLogIn = new Button();
            pbFondo = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFondo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1006, 165);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 39F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label1.Location = new Point(206, 12);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(640, 140);
            label1.TabIndex = 1;
            label1.Text = "POWER YOURSELF";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btCreateAccount);
            panel2.Controls.Add(btLogIn);
            panel2.Controls.Add(pbFondo);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 165);
            panel2.Name = "panel2";
            panel2.Size = new Size(1006, 488);
            panel2.TabIndex = 1;
            // 
            // btCreateAccount
            // 
            btCreateAccount.Anchor = AnchorStyles.Top;
            btCreateAccount.BackColor = SystemColors.ActiveCaptionText;
            btCreateAccount.Cursor = Cursors.Hand;
            btCreateAccount.FlatAppearance.BorderSize = 3;
            btCreateAccount.FlatStyle = FlatStyle.Flat;
            btCreateAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btCreateAccount.ForeColor = Color.FromArgb(255, 128, 0);
            btCreateAccount.Location = new Point(335, 159);
            btCreateAccount.Name = "btCreateAccount";
            btCreateAccount.Size = new Size(350, 35);
            btCreateAccount.TabIndex = 1;
            btCreateAccount.Text = "Create Account";
            btCreateAccount.UseVisualStyleBackColor = true;
            btCreateAccount.Click += btCreateAccount_Click;
            // 
            // btLogIn
            // 
            btLogIn.Anchor = AnchorStyles.Top;
            btLogIn.BackColor = SystemColors.ActiveCaptionText;
            btLogIn.Cursor = Cursors.Hand;
            btLogIn.FlatAppearance.BorderSize = 3;
            btLogIn.FlatStyle = FlatStyle.Flat;
            btLogIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogIn.ForeColor = Color.DarkOrange;
            btLogIn.Location = new Point(335, 64);
            btLogIn.Name = "btLogIn";
            btLogIn.Size = new Size(350, 36);
            btLogIn.TabIndex = 1;
            btLogIn.Text = "Log In";
            btLogIn.UseVisualStyleBackColor = true;
            btLogIn.Click += btLogIn_Click;
            // 
            // pbFondo
            // 
            pbFondo.Dock = DockStyle.Fill;
            pbFondo.Image = (Image)resources.GetObject("pbFondo.Image");
            pbFondo.Location = new Point(0, 0);
            pbFondo.Name = "pbFondo";
            pbFondo.Size = new Size(1004, 486);
            pbFondo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFondo.TabIndex = 2;
            pbFondo.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 653);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1024, 700);
            Name = "Home";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GymYang";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbFondo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip1;
        private Panel panel1;
        private Panel panel2;
        private Button btLogIn;
        private Button btCreateAccount;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pbFondo;
        private System.Windows.Forms.Timer timer1;
    }
}
