using System;
using System.Windows.Forms;
using AxWMPLib;
using WMPLib;

namespace GymYang
{
    public partial class FVideo : Form
    {
        string videoPath;
        public FVideo(string vPath)
        {
            InitializeComponent();
            videoPath = vPath;
        }

        private void FVideo_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtener la ruta del Escritorio dinámicamente
                //string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // Construir la ruta completa al archivo de video
                //string videoPath = System.IO.Path.Combine(desktopPath, "Proyecto_Final_Grado_JaumeMoltoGallego", "Videos", "dorsales.mp4");

                // Verificar si el archivo existe
                if (System.IO.File.Exists(videoPath))
                {
                    // Asignar la URL del archivo y reproducirlo automáticamente
                    axWindowsMediaPlayer1.URL = videoPath;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                else
                {
                    MessageBox.Show("El archivo de video no se encontró en la ruta especificada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar reproducir el video: " + ex.Message);
            }
        }
    }
}
