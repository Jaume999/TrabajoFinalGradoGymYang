namespace GymYang
{
    partial class FProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FProfile));
            panel1 = new Panel();
            btModificar = new Button();
            cbPassword = new CheckBox();
            btEliminarCuenta = new Button();
            lbCreateUser = new Label();
            tbPassword = new TextBox();
            lbNombre = new Label();
            lbPassword = new Label();
            tbNombre = new TextBox();
            btAtras = new Button();
            lbApellidos = new Label();
            tbApellidos = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(btModificar);
            panel1.Controls.Add(cbPassword);
            panel1.Controls.Add(btEliminarCuenta);
            panel1.Controls.Add(lbCreateUser);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(lbNombre);
            panel1.Controls.Add(lbPassword);
            panel1.Controls.Add(tbNombre);
            panel1.Controls.Add(btAtras);
            panel1.Controls.Add(lbApellidos);
            panel1.Controls.Add(tbApellidos);
            panel1.Location = new Point(131, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 402);
            panel1.TabIndex = 2;
            // 
            // btModificar
            // 
            btModificar.Cursor = Cursors.Hand;
            btModificar.FlatAppearance.BorderSize = 3;
            btModificar.FlatStyle = FlatStyle.Flat;
            btModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btModificar.ForeColor = Color.DarkOrange;
            btModificar.Location = new Point(111, 277);
            btModificar.Name = "btModificar";
            btModificar.Size = new Size(94, 35);
            btModificar.TabIndex = 10;
            btModificar.Text = "Modificar";
            btModificar.UseVisualStyleBackColor = true;
            btModificar.Click += btModificar_Click;
            // 
            // cbPassword
            // 
            cbPassword.AutoSize = true;
            cbPassword.BackColor = SystemColors.ActiveCaptionText;
            cbPassword.CheckAlign = ContentAlignment.MiddleCenter;
            cbPassword.Cursor = Cursors.Hand;
            cbPassword.Location = new Point(289, 220);
            cbPassword.Name = "cbPassword";
            cbPassword.Size = new Size(18, 17);
            cbPassword.TabIndex = 9;
            cbPassword.UseVisualStyleBackColor = false;
            cbPassword.CheckedChanged += cbPassword_CheckedChanged;
            // 
            // btEliminarCuenta
            // 
            btEliminarCuenta.BackColor = SystemColors.ActiveCaptionText;
            btEliminarCuenta.Cursor = Cursors.Hand;
            btEliminarCuenta.FlatAppearance.BorderSize = 3;
            btEliminarCuenta.FlatStyle = FlatStyle.Flat;
            btEliminarCuenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btEliminarCuenta.ForeColor = Color.DarkOrange;
            btEliminarCuenta.Location = new Point(149, 332);
            btEliminarCuenta.Name = "btEliminarCuenta";
            btEliminarCuenta.Size = new Size(139, 35);
            btEliminarCuenta.TabIndex = 8;
            btEliminarCuenta.Text = "Eliminar Cuenta";
            btEliminarCuenta.UseVisualStyleBackColor = false;
            btEliminarCuenta.Click += btEliminarCuenta_Click;
            // 
            // lbCreateUser
            // 
            lbCreateUser.AutoSize = true;
            lbCreateUser.Font = new Font("Segoe UI", 25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lbCreateUser.ForeColor = Color.DarkOrange;
            lbCreateUser.Location = new Point(65, 9);
            lbCreateUser.Name = "lbCreateUser";
            lbCreateUser.Size = new Size(194, 57);
            lbCreateUser.TabIndex = 7;
            lbCreateUser.Text = "Mi Perfil";
            lbCreateUser.TextAlign = ContentAlignment.MiddleCenter;
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
            // btAtras
            // 
            btAtras.BackColor = SystemColors.ActiveCaptionText;
            btAtras.Cursor = Cursors.Hand;
            btAtras.FlatAppearance.BorderSize = 3;
            btAtras.FlatStyle = FlatStyle.Flat;
            btAtras.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btAtras.ForeColor = Color.DarkOrange;
            btAtras.Location = new Point(27, 332);
            btAtras.Name = "btAtras";
            btAtras.Size = new Size(94, 35);
            btAtras.TabIndex = 4;
            btAtras.Text = "Atrás";
            btAtras.UseVisualStyleBackColor = false;
            btAtras.Click += btAtras_Click;
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
            // 
            // FProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(580, 544);
            Controls.Add(panel1);
            DoubleBuffered = true;
            MinimumSize = new Size(598, 591);
            Name = "FProfile";
            Text = "FProfile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbCreateUser;
        private TextBox tbPassword;
        private Label lbNombre;
        private Label lbPassword;
        private TextBox tbNombre;
        private Button btAtras;
        private Label lbApellidos;
        private TextBox tbApellidos;
        private Button btEliminarCuenta;
        private CheckBox cbPassword;
        private Button btModificar;
    }
}