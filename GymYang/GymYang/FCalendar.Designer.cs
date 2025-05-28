namespace GymYang
{
    partial class FCalendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCalendar));
            monthCalendar = new MonthCalendar();
            tbCalendar = new TextBox();
            btnGuardar = new Button();
            panel1 = new Panel();
            btnPDF = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // monthCalendar
            // 
            monthCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            monthCalendar.BackColor = SystemColors.Highlight;
            monthCalendar.FirstDayOfWeek = Day.Monday;
            monthCalendar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            monthCalendar.ForeColor = Color.DarkOrange;
            monthCalendar.Location = new Point(149, 127);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 0;
            monthCalendar.TitleBackColor = Color.DarkOrange;
            monthCalendar.TrailingForeColor = Color.DarkOrange;
            monthCalendar.DateChanged += monthCalendar_DateChanged_1;
            // 
            // tbCalendar
            // 
            tbCalendar.BackColor = Color.Black;
            tbCalendar.BorderStyle = BorderStyle.None;
            tbCalendar.Dock = DockStyle.Fill;
            tbCalendar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCalendar.ForeColor = Color.DarkOrange;
            tbCalendar.Location = new Point(0, 0);
            tbCalendar.Multiline = true;
            tbCalendar.Name = "tbCalendar";
            tbCalendar.Size = new Size(501, 60);
            tbCalendar.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaptionText;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 3;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.DarkOrange;
            btnGuardar.Location = new Point(149, 83);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(220, 32);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tbCalendar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(501, 60);
            panel1.TabIndex = 3;
            // 
            // btnPDF
            // 
            btnPDF.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPDF.BackColor = SystemColors.ActiveCaptionText;
            btnPDF.Cursor = Cursors.Hand;
            btnPDF.FlatAppearance.BorderSize = 3;
            btnPDF.FlatStyle = FlatStyle.Flat;
            btnPDF.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPDF.ForeColor = Color.DarkOrange;
            btnPDF.Location = new Point(149, 380);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(220, 32);
            btnPDF.TabIndex = 4;
            btnPDF.Text = "Crear PDF";
            btnPDF.UseVisualStyleBackColor = false;
            btnPDF.Click += btnPDF_Click;
            // 
            // FCalendar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(501, 459);
            Controls.Add(btnPDF);
            Controls.Add(panel1);
            Controls.Add(btnGuardar);
            Controls.Add(monthCalendar);
            DoubleBuffered = true;
            Name = "FCalendar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FCalendar";
            FormClosing += FCalendar_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar monthCalendar;
        private TextBox tbCalendar;
        private Button btnGuardar;
        private Panel panel1;
        private Button btnPDF;
    }
}