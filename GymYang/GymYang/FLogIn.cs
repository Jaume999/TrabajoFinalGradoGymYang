using System;
using System.Windows.Forms;
using Npgsql;

namespace GymYang
{
    public partial class FLogIn : Form
    {
        public FLogIn()
        {
            InitializeComponent();
        }

        private void FLogIn_Load(object sender, EventArgs e)
        {
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Es necesario rellenar todos los campos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombreCliente = tbNombre.Text.Trim();
            string passwordCliente = tbPassword.Text.Trim();

            using (NpgsqlConnection conexionBD = Conexion.GetConnection())
            {
                if (conexionBD == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sql = "SELECT nombre, apellidos, password FROM public.usuarios WHERE nombre = @nombre AND password = @password";

                try
                {
                    using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombreCliente);
                        comando.Parameters.AddWithValue("@password", passwordCliente);

                        using (NpgsqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Usuario usuario = new Usuario()
                                {
                                    Nombre = reader.GetString(0),
                                    Apellidos = reader.GetString(1),
                                    Password = reader.GetString(2)
                                };

                                MessageBox.Show("Ingreso exitoso \n\nBienvenido " + usuario.Nombre, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                FMainPage fMain = new FMainPage(usuario); // Pasa el objeto usuario
                                fMain.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Nombre o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
