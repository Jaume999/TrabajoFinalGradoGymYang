using System;
using System.Windows.Forms;
using Npgsql;

namespace GymYang
{
    public partial class FCreateUser : Form
    {
        public FCreateUser()
        {
            InitializeComponent();
        }

        private void FCreateUser_Load(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text) ||
                string.IsNullOrWhiteSpace(tbApellidos.Text) ||
                string.IsNullOrWhiteSpace(tbPassword.Text) ||
                string.IsNullOrWhiteSpace(tbPassword2.Text))
            {
                MessageBox.Show("Es necesario rellenar todos los campos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!tbPassword.Text.Equals(tbPassword2.Text))
            {
                MessageBox.Show("No has puesto la misma contraseña...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombreCliente = tbNombre.Text.Trim();
            string apellidosCliente = tbApellidos.Text.Trim();
            string passwordCliente = tbPassword.Text.Trim();

            using (NpgsqlConnection conexionBD = Conexion.GetConnection())
            {
                if (conexionBD == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // OPCIONAL: Verifica si el nombre ya existe
                string checkSql = "SELECT COUNT(*) FROM public.usuarios WHERE nombre = @nombre";
                using (NpgsqlCommand checkCmd = new NpgsqlCommand(checkSql, conexionBD))
                {
                    checkCmd.Parameters.AddWithValue("@nombre", nombreCliente);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Ya existe un usuario con ese nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string sql = "INSERT INTO public.usuarios(nombre, apellidos, password) VALUES(@nombre, @apellidos, @password)";
                try
                {
                    using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombreCliente);
                        comando.Parameters.AddWithValue("@apellidos", apellidosCliente);
                        comando.Parameters.AddWithValue("@password", passwordCliente);
                        comando.ExecuteNonQuery();
                    }

                    // Crear objeto Usuario
                    Usuario usuario = new Usuario()
                    {
                        Nombre = nombreCliente,
                        Apellidos = apellidosCliente,
                        Password = passwordCliente
                    };

                    MessageBox.Show("Registro guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mostrar siguiente formulario
                    FMainPage fMainPage = new FMainPage(usuario);
                    fMainPage.Show();
                    this.Hide();
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al guardar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
