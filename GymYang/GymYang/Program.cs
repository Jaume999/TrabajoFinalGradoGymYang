namespace GymYang
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new Home());  // Aquí lanzamos el formulario Home que se encarga de gestionar la base de datos
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error404: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
