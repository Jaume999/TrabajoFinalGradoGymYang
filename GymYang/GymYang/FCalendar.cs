using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;

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

        private void btnPDF_Click(object sender, EventArgs e)
        {
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Rutina_{usuarioActual}.pdf");
            Document documento = new Document(PageSize.A4, 50, 50, 50, 50);

            try
            {
                PdfWriter.GetInstance(documento, new FileStream(ruta, FileMode.Create));
                documento.Open();

                string rutaLogo = @"C:\Users\jmg18\Desktop\Proyecto_Final_Grado_JaumeMoltoGallego\Imagenes\logo.png";
                if (File.Exists(rutaLogo))
                {
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(rutaLogo);
                    logo.ScaleToFit(100f, 100f);
                    logo.Alignment = Element.ALIGN_CENTER;
                    documento.Add(logo);

                    documento.Add(new Paragraph("\n"));
                }

                //Fuente por defecto
                var fuenteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                var fuenteFecha = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.ORANGE);
                var fuenteTexto = FontFactory.GetFont(FontFactory.HELVETICA, 11);

                //Título general
                Paragraph titulo = new Paragraph($"Rutina de {usuarioActual}\n\n", fuenteTitulo);
                titulo.Alignment = Element.ALIGN_CENTER;
                documento.Add(titulo);

                //Ordenar por fecha
                var entradasOrdenadas = datosDelUsuario
                    .Where(kvp => !string.IsNullOrWhiteSpace(kvp.Value))
                    .OrderBy(kvp => DateTime.TryParse(kvp.Key, out var fecha) ? fecha : DateTime.MinValue);

                foreach (var entrada in entradasOrdenadas)
                {
                    if (!DateTime.TryParse(entrada.Key, out var fecha)) continue;

                    documento.Add(new Paragraph(fecha.ToString("dddd, dd MMMM yyyy"), fuenteFecha));
                    documento.Add(new Paragraph(entrada.Value + "\n", fuenteTexto));
                }

                MessageBox.Show("PDF creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                documento.Close();
            }
        }
    }
}
