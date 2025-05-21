using Microsoft.VisualBasic.ApplicationServices;

namespace GymYang
{
    public partial class Home : Form
    {
        FCreateUser FCreateUser = new FCreateUser();
        FLogIn FLogIn = new FLogIn();

        Image[] imagenes;
        int indiceActual = 0;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            imagenes = new Image[]
            {
                Image.FromFile(@"C:\Users\jmg18\Desktop\Proyecto_Final_Grado_JaumeMoltoGallego\Imagenes\fitness3.jpg"),
                Image.FromFile(@"C:\Users\jmg18\Desktop\Proyecto_Final_Grado_JaumeMoltoGallego\Imagenes\logo.png"),
                Image.FromFile(@"C:\Users\jmg18\Desktop\Proyecto_Final_Grado_JaumeMoltoGallego\Imagenes\fitness.png"),
                Image.FromFile(@"C:\Users\jmg18\Desktop\Proyecto_Final_Grado_JaumeMoltoGallego\Imagenes\fitness2.png")
            };
            pbFondo.Image = imagenes[indiceActual];
        }

        private void btCreateAccount_Click(object sender, EventArgs e)
        {
            FCreateUser.Show();  //Abre el segundo formulario
            this.Hide();
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            FLogIn.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            indiceActual = (indiceActual + 1) % imagenes.Length;
            pbFondo.Image = imagenes[indiceActual];
        }
    }
}
