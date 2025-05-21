using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace GymYang
{
    public partial class FCalendar : Form
    {
        //Diccionario para almacenar información por fecha
        private Dictionary<string, string> datosDelUsuario;
        private string usuarioActual;

        //Cada uno tendrá su propio archivo JSON
        private string ArchivoDatos => $"datos_{usuarioActual}.json";

        public FCalendar(string usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            datosDelUsuario = new Dictionary<string, string>();
            CargarInformacion();

            //Cambiar colores del MonthCalendar
            monthCalendar.BackColor = Color.WhiteSmoke;
            monthCalendar.ForeColor = Color.DarkSlateGray;
            monthCalendar.TitleBackColor = Color.MediumSlateBlue;
            monthCalendar.TitleForeColor = Color.DarkOrange;
            monthCalendar.TrailingForeColor = Color.LightGray;

            //Configurar el TextBox para permitir desplazamiento vertical
            tbCalendar.Multiline = true;
            tbCalendar.ScrollBars = ScrollBars.Vertical;
        }

        private void CargarInformacion()
        {
            try
            {
                if (File.Exists(ArchivoDatos))
                {
                    string json = File.ReadAllText(ArchivoDatos);
                    datosDelUsuario = JsonSerializer.Deserialize<Dictionary<string, string>>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema al cargar los datos. Se reiniciarán.\n\n" + ex.Message,
                                "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                File.Delete(ArchivoDatos);
                datosDelUsuario = new Dictionary<string, string>();
            }
        }

        private void GuardarInformacion()
        {
            DateTime fechaSeleccionada = monthCalendar.SelectionStart;
            string fechaKey = fechaSeleccionada.ToString("o"); //formato ISO 8601
            string informacion = tbCalendar.Text;

            datosDelUsuario[fechaKey] = informacion;

            string json = JsonSerializer.Serialize(datosDelUsuario, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ArchivoDatos, json);
        }

        private void monthCalendar_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            DateTime fechaSeleccionada = monthCalendar.SelectionStart;
            string info = string.Empty;

            var entrada = datosDelUsuario.FirstOrDefault(kvp => DateTime.TryParse(kvp.Key, out var dt) && dt.Date == fechaSeleccionada.Date);

            info = entrada.Value ?? string.Empty;
            tbCalendar.Text = info;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarInformacion();
            MessageBox.Show("Información guardada correctamente.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FCalendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardarInformacion();
        }
    }
}
