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
        private Roles ValidarCredenciales(string nombreUsuario, string contraseña)
        {
            if (nombreUsuario == "Admin" && contraseña == "Admin")
            {
                return Roles.Admin;
            }
            else if (nombreUsuario == "Usuario" && contraseña == "Admin")
            {
                return Roles.Usuario;
            }
            else
            {
                return Roles.Admin; // Cambia esto a tu lógica de manejo de credenciales incorrectas
            }
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string contraseña = txtContrasenia.Text;

            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor ingrese su nombre de usuario y contraseña.");
                return;
            }

            Roles tipoUsuario = ValidarCredenciales(nombreUsuario, contraseña);

            switch (tipoUsuario)
            {
                case Roles.Admin:
                    MessageBox.Show("¡Bienvenido, Administrador!");
                    MenuEmpleador menuEmpleador = new MenuEmpleador();
                    menuEmpleador.Show();
                    break;
                case Roles.Usuario:
                    MessageBox.Show("¡Bienvenido, Usuario!");
                    Menucs menucs = new Menucs();
                    menucs.Show();
                    break;
                default:
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.");
                    break;
            }
        }

        // Método para validar las credenciales de inicio de sesión (puedes cambiar esta implementación según tus necesidades)
       

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