namespace GymYang
{
    partial class FLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogIn));
            btLogIn = new Button();
            tbPassword = new TextBox();
            lbPassword = new Label();
            tbNombre = new TextBox();
            lbNombre = new Label();
            panelLogIn = new Panel();
            lbLogIn = new Label();
            panelLogIn.SuspendLayout();
            SuspendLayout();
            // 
            // btLogIn
            // 
            btLogIn.BackColor = SystemColors.ActiveCaptionText;
            btLogIn.Cursor = Cursors.Hand;
            btLogIn.FlatAppearance.BorderSize = 3;
            btLogIn.FlatStyle = FlatStyle.Flat;
            btLogIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btLogIn.ForeColor = Color.DarkOrange;
            btLogIn.Location = new Point(99, 331);
            btLogIn.Name = "btLogIn";
            btLogIn.Size = new Size(126, 35);
            btLogIn.TabIndex = 4;
            btLogIn.Text = "Iniciar Sesión";
            btLogIn.UseVisualStyleBackColor = false;
            btLogIn.Click += btLogIn_Click;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.DarkOrange;
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tbPassword.ForeColor = SystemColors.ActiveCaptionText;
            tbPassword.Location = new Point(147, 156);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(125, 20);
            tbPassword.TabIndex = 3;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbPassword.ForeColor = Color.DarkOrange;
            lbPassword.Location = new Point(27, 156);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(88, 20);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Contraseña";
            // 
            // tbNombre
            // 
            tbNombre.BackColor = Color.DarkOrange;
            tbNombre.BorderStyle = BorderStyle.None;
            tbNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tbNombre.ForeColor = SystemColors.ActiveCaptionText;
            tbNombre.Location = new Point(147, 94);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(125, 20);
            tbNombre.TabIndex = 1;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbNombre.ForeColor = Color.DarkOrange;
            lbNombre.Location = new Point(27, 94);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(67, 20);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre";
            // 
            // panelLogIn
            // 
            panelLogIn.Anchor = AnchorStyles.None;
            panelLogIn.BackColor = SystemColors.ActiveCaptionText;
            panelLogIn.Controls.Add(lbLogIn);
            panelLogIn.Controls.Add(lbNombre);
            panelLogIn.Controls.Add(btLogIn);
            panelLogIn.Controls.Add(lbPassword);
            panelLogIn.Controls.Add(tbPassword);
            panelLogIn.Controls.Add(tbNombre);
            panelLogIn.Location = new Point(131, 21);
            panelLogIn.Name = "panelLogIn";
            panelLogIn.Size = new Size(320, 402);
            panelLogIn.TabIndex = 5;
            // 
            // lbLogIn
            // 
            lbLogIn.AutoSize = true;
            lbLogIn.Font = new Font("Segoe UI", 25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lbLogIn.ForeColor = Color.DarkOrange;
            lbLogIn.Location = new Point(16, 9);
            lbLogIn.Name = "lbLogIn";
            lbLogIn.Size = new Size(287, 57);
            lbLogIn.TabIndex = 5;
            lbLogIn.Text = "Iniciar Sesión";
            lbLogIn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(580, 544);
            Controls.Add(panelLogIn);
            DoubleBuffered = true;
            MinimumSize = new Size(598, 591);
            Name = "FLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FLogIn";
            Load += FLogIn_Load;
            panelLogIn.ResumeLayout(false);
            panelLogIn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox tbPassword;
        private Label lbPassword;
        private TextBox tbNombre;
        private Label lbNombre;
        private Button btLogIn;
        private Panel panelLogIn;
        private Label lbLogIn;
    }
}