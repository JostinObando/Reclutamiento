namespace Reclutamiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private enum Roles
        {
            Admin,
            Usuario
        }
        private Roles ValidarCredenciales(string nombreUsuario, string contrase�a)
        {
            if (nombreUsuario == "Admin" && contrase�a == "Admin")
            {
                return Roles.Admin;
            }
            else if (nombreUsuario == "Usuario" && contrase�a == "Admin")
            {
                return Roles.Usuario;
            }
            else
            {
                return Roles.Admin; // Cambia esto a tu l�gica de manejo de credenciales incorrectas
            }
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string contrase�a = txtContrasenia.Text;

            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contrase�a))
            {
                MessageBox.Show("Por favor ingrese su nombre de usuario y contrase�a.");
                return;
            }

            Roles tipoUsuario = ValidarCredenciales(nombreUsuario, contrase�a);

            switch (tipoUsuario)
            {
                case Roles.Admin:
                    MessageBox.Show("�Bienvenido, Administrador!");
                    MenuEmpleador menuEmpleador = new MenuEmpleador();
                    menuEmpleador.Show();
                    break;
                case Roles.Usuario:
                    MessageBox.Show("�Bienvenido, Usuario!");
                    Menucs menucs = new Menucs();
                    menucs.Show();
                    break;
                default:
                    MessageBox.Show("Nombre de usuario o contrase�a incorrectos. Por favor, int�ntelo de nuevo.");
                    break;
            }
        }

        // M�todo para validar las credenciales de inicio de sesi�n (puedes cambiar esta implementaci�n seg�n tus necesidades)
       

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContrasenia.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}