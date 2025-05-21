
namespace GymYang
{
    partial class FCreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCreateUser));
            tbPassword = new TextBox();
            lbPassword = new Label();
            btInsertar = new Button();
            tbApellidos = new TextBox();
            lbApellidos = new Label();
            tbNombre = new TextBox();
            lbNombre = new Label();
            panel1 = new Panel();
            tbPassword2 = new TextBox();
            lbPassword2 = new Label();
            lbCreateUser = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.DarkOrange;
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Cursor = Cursors.IBeam;
            tbPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tbPassword.Location = new Point(147, 217);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(125, 20);
            tbPassword.TabIndex = 6;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbPassword.ForeColor = Color.DarkOrange;
            lbPassword.Location = new Point(27, 220);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(88, 20);
            lbPassword.TabIndex = 5;
            lbPassword.Text = "Contraseña";
            // 
            // btInsertar
            // 
            btInsertar.BackColor = SystemColors.ActiveCaptionText;
            btInsertar.Cursor = Cursors.Hand;
            btInsertar.FlatAppearance.BorderSize = 3;
            btInsertar.FlatStyle = FlatStyle.Flat;
            btInsertar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btInsertar.ForeColor = Color.DarkOrange;
            btInsertar.Location = new Point(110, 332);
            btInsertar.Name = "btInsertar";
            btInsertar.Size = new Size(94, 35);
            btInsertar.TabIndex = 4;
            btInsertar.Text = "Crear";
            btInsertar.UseVisualStyleBackColor = false;
            btInsertar.Click += btInsertar_Click;
            // 
            // tbApellidos
            // 
            tbApellidos.BackColor = Color.DarkOrange;
            tbApellidos.BorderStyle = BorderStyle.None;
            tbApellidos.Cursor = Cursors.IBeam;
            tbApellidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tbApellidos.Location = new Point(147, 155);
            tbApellidos.Name = "tbApellidos";
            tbApellidos.Size = new Size(125, 20);
            tbApellidos.TabIndex = 3;
            tbApellidos.TextChanged += textBox1_TextChanged;
            // 
            // lbApellidos
            // 
            lbApellidos.AutoSize = true;
            lbApellidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbApellidos.ForeColor = Color.DarkOrange;
            lbApellidos.Location = new Point(27, 158);
            lbApellidos.Name = "lbApellidos";
            lbApellidos.Size = new Size(74, 20);
            lbApellidos.TabIndex = 2;
            lbApellidos.Text = "Apellidos";
            // 
            // tbNombre
            // 
            tbNombre.BackColor = Color.DarkOrange;
            tbNombre.BorderStyle = BorderStyle.None;
            tbNombre.Cursor = Cursors.IBeam;
            tbNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(tbPassword2);
            panel1.Controls.Add(lbPassword2);
            panel1.Controls.Add(lbCreateUser);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(lbNombre);
            panel1.Controls.Add(lbPassword);
            panel1.Controls.Add(tbNombre);
            panel1.Controls.Add(btInsertar);
            panel1.Controls.Add(lbApellidos);
            panel1.Controls.Add(tbApellidos);
            panel1.Location = new Point(131, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 402);
            panel1.TabIndex = 1;
            // 
            // tbPassword2
            // 
            tbPassword2.BackColor = Color.DarkOrange;
            tbPassword2.BorderStyle = BorderStyle.None;
            tbPassword2.Cursor = Cursors.IBeam;
            tbPassword2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tbPassword2.Location = new Point(147, 280);
            tbPassword2.Name = "tbPassword2";
            tbPassword2.Size = new Size(125, 20);
            tbPassword2.TabIndex = 9;
            tbPassword2.UseSystemPasswordChar = true;
            // 
            // lbPassword2
            // 
            lbPassword2.AutoSize = true;
            lbPassword2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbPassword2.ForeColor = Color.DarkOrange;
            lbPassword2.Location = new Point(27, 260);
            lbPassword2.Name = "lbPassword2";
            lbPassword2.Size = new Size(88, 40);
            lbPassword2.TabIndex = 8;
            lbPassword2.Text = "Confirmar \r\nContraseña";
            // 
            // lbCreateUser
            // 
            lbCreateUser.AutoSize = true;
            lbCreateUser.Font = new Font("Segoe UI", 25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lbCreateUser.ForeColor = Color.DarkOrange;
            lbCreateUser.Location = new Point(13, 9);
            lbCreateUser.Name = "lbCreateUser";
            lbCreateUser.Size = new Size(297, 57);
            lbCreateUser.TabIndex = 7;
            lbCreateUser.Text = "Crear Usuario";
            lbCreateUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FCreateUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(580, 544);
            Controls.Add(panel1);
            DoubleBuffered = true;
            MinimumSize = new Size(598, 591);
            Name = "FCreateUser";
            Text = "FCreateUser";
            Load += FCreateUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox tbApellidos;
        private Label lbApellidos;
        private TextBox tbNombre;
        private Label lbNombre;
        private Button btInsertar;
        private EventHandler label1_Click;
        private TextBox tbPassword;
        private Label lbPassword;
        private Panel panel1;
        private Label lbCreateUser;
        private Label lbPassword2;
        private TextBox tbPassword2;
    }
}