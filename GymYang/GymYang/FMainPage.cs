using System;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using AxWMPLib;
using WMPLib;

namespace GymYang
{
    public partial class FMainPage : Form
    {
        private Form formularioActivo = null;
        private string usuarioNombre;
        private Usuario usuario;
        public string vPath;

        public FMainPage(Usuario u)
        {
            InitializeComponent();
            usuario = u;
            usuarioNombre = usuario.Nombre;
        }

        private void abrirFormulario(Form hijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = hijo;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            hijo.FormBorderStyle = FormBorderStyle.None;
            panelMainL.Dock = DockStyle.Fill;
            panelMainL.Controls.Add(hijo);
            panelMainL.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
        }

        private void showSubMenu(Panel subMenu)
        {
            subMenu.Visible = !subMenu.Visible;
        }

        private void btEspalda_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubSub1);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubSub2);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubSub3);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubSub4);
        }
        private void button17_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubSub5);
        }
        private void btReservar_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubSub6);
        }

        // Botones Espalda
        private void btDorsales_Click(object sender, EventArgs e)
        {
            //Porque tengo la carpeta del proyecto en el Escritorio si lo tuviera en otro sitio seria cambiar el .Desktop
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            vPath = System.IO.Path.Combine(desktopPath, "Proyecto_Final_Grado_JaumeMoltoGallego", "Videos", "dorsales.mp4");
            abrirFormulario(new FVideo(vPath));
        }
        private void btnExtensionLumbar_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            vPath = System.IO.Path.Combine(desktopPath, "Proyecto_Final_Grado_JaumeMoltoGallego", "Videos", "extensionLumbar.mp4");
            abrirFormulario(new FVideo(vPath));
        }
        private void btnJalonPecho_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            vPath = System.IO.Path.Combine(desktopPath, "Proyecto_Final_Grado_JaumeMoltoGallego", "Videos", "jalonPecho.mp4");
            abrirFormulario(new FVideo(vPath));
        }

        // Botones Pecho
        private void btPressPechoInclinado_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            vPath = System.IO.Path.Combine(desktopPath, "Proyecto_Final_Grado_JaumeMoltoGallego", "Videos", "pressPechoInclinado.mp4");
            abrirFormulario(new FVideo(vPath));
        }

        private void btPressPecho_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            vPath = System.IO.Path.Combine(desktopPath, "Proyecto_Final_Grado_JaumeMoltoGallego", "Videos", "pressPechoConvergente.mp4");
            abrirFormulario(new FVideo(vPath));
        }

        private void btAperturaPectoral_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            vPath = System.IO.Path.Combine(desktopPath, "Proyecto_Final_Grado_JaumeMoltoGallego", "Videos", "aperturaPectoral.mp4");
            abrirFormulario(new FVideo(vPath));
        }

        // Botones Abdomen
        private void btnAbdomenTotal_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            vPath = System.IO.Path.Combine(desktopPath, "Proyecto_Final_Grado_JaumeMoltoGallego", "Videos", "abdominalTotal.mp4");
            abrirFormulario(new FVideo(vPath));
        }

        private void btnCruchAbdominal_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            vPath = System.IO.Path.Combine(desktopPath, "Proyecto_Final_Grado_JaumeMoltoGallego", "Videos", "crunchAbdominal.mp4");
            abrirFormulario(new FVideo(vPath));
        }

        private void btnCrunchBancoDeclinado_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            vPath = System.IO.Path.Combine(desktopPath, "Proyecto_Final_Grado_JaumeMoltoGallego", "Videos", "crunchBancoDeclinado.mp4");
            abrirFormulario(new FVideo(vPath));
        }

        // Botones Piernas
        private void btnPrensaPiernas_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            vPath = System.IO.Path.Combine(desktopPath, "Proyecto_Final_Grado_JaumeMoltoGallego", "Videos", "prensaPiernas.mp4");
            abrirFormulario(new FVideo(vPath));
        }

        private void btnFlexionPiernaSentado_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            vPath = System.IO.Path.Combine(desktopPath, "Proyecto_Final_Grado_JaumeMoltoGallego", "Videos", "flexionPiernaSentado.mp4");
            abrirFormulario(new FVideo(vPath));
        }

        private void btnAductor_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            vPath = System.IO.Path.Combine(desktopPath, "Proyecto_Final_Grado_JaumeMoltoGallego", "Videos", "aductor.mp4");
            abrirFormulario(new FVideo(vPath));
        }

        // Botones Brazos
        private void btnPressTricepsSentado_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            vPath = System.IO.Path.Combine(desktopPath, "Proyecto_Final_Grado_JaumeMoltoGallego", "Videos", "pressTricepsSentado.mp4");
            abrirFormulario(new FVideo(vPath));
        }

        private void btnCurlBiceps_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            vPath = System.IO.Path.Combine(desktopPath, "Proyecto_Final_Grado_JaumeMoltoGallego", "Videos", "curlBiceps.mp4");
            abrirFormulario(new FVideo(vPath));
        }

        private void btnPressHombrosConvergente_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            vPath = System.IO.Path.Combine(desktopPath, "Proyecto_Final_Grado_JaumeMoltoGallego", "Videos", "pressHombrosConvergente.mp4");
            abrirFormulario(new FVideo(vPath));
        }

        // Botones Funciones
        private void pbProfile_Click(object sender, EventArgs e)
        {
            FProfile fProfile = new FProfile(this, usuario);
            fProfile.Show();
            this.Hide();
        }

        private void btCalendar_Click(object sender, EventArgs e)
        {
            // Ahora usamos directamente el nombre del usuario logueado
            abrirFormulario(new FCalendar(usuarioNombre));
        }

        private void btnReservarYoga_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FReservarClase(usuarioNombre));
        }

        private void btnReservarZumba_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FReservarClaseZumba(usuarioNombre));
        }

        
    }
}
