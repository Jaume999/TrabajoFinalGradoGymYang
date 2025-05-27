using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace GymYang
{
    public partial class FReservarClase : Form
    {
        private Dictionary<string, Dictionary<int, string>> reservasPorFecha;
        private List<Button> botonesPlaza;
        private string usuarioActual;
        private const string ArchivoReservas = "reservas_global.json";

        public FReservarClase(string usuario)
        {
            InitializeComponent();

            usuarioActual = usuario;
            reservasPorFecha = new Dictionary<string, Dictionary<int, string>>();
            botonesPlaza = new List<Button>();

            this.Load += FReservarClase_Load;
            this.Resize += FReservarClase_Resize;
            monthCalendar.DateChanged += MonthCalendar_DateChanged;

            InicializarBotones();
            CargarReservas();
        }

        private void InicializarBotones()
        {
            for (int i = 1; i <= 16; i++)
            {
                Button btn = this.Controls.Find("btnPlaza" + i, true)[0] as Button;
                btn.Tag = i;
                btn.BackColor = Color.SandyBrown;
                btn.Click += BotonPlaza_Click;
                botonesPlaza.Add(btn);
            }
        }

        private void FReservarClase_Load(object sender, EventArgs e)
        {
            CenterCalendar();
            PosicionarBotones();
            ActualizarBotones();
        }

        private void FReservarClase_Resize(object sender, EventArgs e)
        {
            CenterCalendar();
            PosicionarBotones();
        }

        private void CenterCalendar()
        {
            monthCalendar.Left = (ClientSize.Width - monthCalendar.Width) / 2;
            monthCalendar.Top = (ClientSize.Height - monthCalendar.Height) / 2;
        }

        private void PosicionarBotones()
        {
            int espacio = 10;
            int tamaño = 40;

            int stepX = (monthCalendar.Width - tamaño * 4) / 3;
            int stepY = (monthCalendar.Height - tamaño * 4) / 3;

            int left = monthCalendar.Left;
            int top = monthCalendar.Top;
            int right = monthCalendar.Right;
            int bottom = monthCalendar.Bottom;

            for (int i = 0; i < 4; i++)
                botonesPlaza[i].Location = new Point(left + i * (tamaño + stepX), top - tamaño - espacio);

            for (int i = 4; i < 8; i++)
                botonesPlaza[i].Location = new Point(left + (i - 4) * (tamaño + stepX), bottom + espacio);

            for (int i = 8; i < 12; i++)
                botonesPlaza[i].Location = new Point(left - tamaño - espacio, top + (i - 8) * (tamaño + stepY));

            for (int i = 12; i < 16; i++)
                botonesPlaza[i].Location = new Point(right + espacio, top + (i - 12) * (tamaño + stepY));

            foreach (var btn in botonesPlaza)
                btn.Size = new Size(tamaño, tamaño);
        }

        private void BotonPlaza_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int plazaId = (int)btn.Tag;
            string fechaKey = monthCalendar.SelectionStart.Date.ToString("yyyy-MM-dd");

            if (!reservasPorFecha.ContainsKey(fechaKey))
                reservasPorFecha[fechaKey] = new Dictionary<int, string>();

            if (reservasPorFecha[fechaKey].ContainsKey(plazaId))
            {
                if (reservasPorFecha[fechaKey][plazaId] == usuarioActual)
                {
                    //Solo puedes liberar tu propia plaza
                    reservasPorFecha[fechaKey].Remove(plazaId);
                    btn.BackColor = Color.SandyBrown;
                    btn.Text = plazaId.ToString();
                }
                else
                {
                    MessageBox.Show($"Plaza reservada por otro usuario: {reservasPorFecha[fechaKey][plazaId]}",
                                    "No puedes liberar esta plaza", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                //Reservar plaza
                reservasPorFecha[fechaKey][plazaId] = usuarioActual;
                btn.BackColor = Color.Black;
                btn.Text = usuarioActual.Substring(0, 1).ToUpper();
            }

            GuardarReservas();
        }

        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            ActualizarBotones();
        }

        private void ActualizarBotones()
        {
            string fechaKey = monthCalendar.SelectionStart.Date.ToString("yyyy-MM-dd");

            var reservasHoy = reservasPorFecha.ContainsKey(fechaKey)
                ? reservasPorFecha[fechaKey]
                : new Dictionary<int, string>();

            foreach (var btn in botonesPlaza)
            {
                int id = (int)btn.Tag;
                if (reservasHoy.ContainsKey(id))
                {
                    string quien = reservasHoy[id];
                    btn.BackColor = quien == usuarioActual ? Color.Black : Color.Gray;
                    btn.Text = quien.Substring(0, 1).ToUpper();
                    btn.Enabled = quien == usuarioActual;  //Solo habilitado si es tu reserva
                }
                else
                {
                    btn.BackColor = Color.SandyBrown;
                    btn.Text = id.ToString();
                    btn.Enabled = true;  //Botón libre y habilitado
                }
            }
        }

        private void CargarReservas()
        {
            try
            {
                if (File.Exists(ArchivoReservas))
                {
                    string json = File.ReadAllText(ArchivoReservas);
                    reservasPorFecha = JsonSerializer.Deserialize<Dictionary<string, Dictionary<int, string>>>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema al cargar las reservas. Se reiniciarán.\n\n" + ex.Message,
                                "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                File.Delete(ArchivoReservas);
                reservasPorFecha = new Dictionary<string, Dictionary<int, string>>();
            }
        }

        private void GuardarReservas()
        {
            string json = JsonSerializer.Serialize(reservasPorFecha, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ArchivoReservas, json);
        }
    }
}
