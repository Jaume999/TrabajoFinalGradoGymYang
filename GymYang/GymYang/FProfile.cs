using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Data.SqlClient;
using Npgsql;

namespace GymYang
{
    public partial class FProfile : Form
    {
        private FMainPage previousForm;
        public Usuario usuario;
        public FProfile(FMainPage f, Usuario u)
        {
            InitializeComponent();
            previousForm = f;
            usuario = u;

            //Necesario pq en el .Designer.cs no se ha creado automáticamente, lo creamos a mano
            this.Load += new System.EventHandler(this.FProfile_Load);
        }

        private void FProfile_Load(object sender, EventArgs e)
        {
            //MessageBox.Show($"Nombre: {usuario.Nombre}, Apellidos: {usuario.Apellidos}, Password: {usuario.Password}");

            tbNombre.Text = usuario.Nombre;
            tbApellidos.Text = usuario.Apellidos;
            tbPassword.Text = usuario.Password;
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void btEliminarCuenta_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
            "¿Estás seguro de que quieres eliminar tu cuenta?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                using (NpgsqlConnection conexionBD = Conexion.GetConnection())
                {
                    if (conexionBD == null)
                    {
                        MessageBox.Show("No se pudo establecer la conexión con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string sql = "DELETE FROM public.usuarios WHERE nombre = @nombre AND password = @password";

                    try
                    {
                        using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexionBD))
                        {
                            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                            comando.Parameters.AddWithValue("@password", usuario.Password);

                            int filasAfectadas = comando.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                Home homeForm = new Home();
                                homeForm.Show();

                                this.Close();
                                previousForm.Close();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el usuario en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la cuenta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassword.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }

        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            string nuevoNombre = tbNombre.Text.Trim();
            string nuevosApellidos = tbApellidos.Text.Trim();
            string nuevaPassword = tbPassword.Text.Trim();

            // Comprobar si hay cambios
            if (nuevoNombre == usuario.Nombre &&
                nuevosApellidos == usuario.Apellidos &&
                nuevaPassword == usuario.Password)
            {
                MessageBox.Show("No se detectaron cambios en los datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (NpgsqlConnection conexionBD = Conexion.GetConnection())
            {
                if (conexionBD == null)
                {
                    MessageBox.Show("No se pudo conectar a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sql = "UPDATE public.usuarios SET nombre = @nuevoNombre, apellidos = @nuevosApellidos, password = @nuevaPassword WHERE nombre = @nombreActual AND password = @passwordActual";

                try
                {
                    using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@nuevoNombre", nuevoNombre);
                        comando.Parameters.AddWithValue("@nuevosApellidos", nuevosApellidos);
                        comando.Parameters.AddWithValue("@nuevaPassword", nuevaPassword);
                        comando.Parameters.AddWithValue("@nombreActual", usuario.Nombre);
                        comando.Parameters.AddWithValue("@passwordActual", usuario.Password);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Datos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Actualizar los datos en el objeto local
                            usuario.Nombre = nuevoNombre;
                            usuario.Apellidos = nuevosApellidos;
                            usuario.Password = nuevaPassword;
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron coincidencias para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            homeForm.Show();

            this.Close();
            previousForm.Close();
        }
    }
}
