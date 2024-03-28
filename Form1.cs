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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados por el usuario en los campos de texto
            string nombreUsuario = txtUsuario.Text;
            string contraseña = txtContrasenia.Text;

            // Validar si los campos están vacíos
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor ingrese su nombre de usuario y contraseña.");
                return;
            }

            // Validar las credenciales de inicio de sesión (aquí se puede agregar lógica adicional según sea necesario)
            if (ValidarCredenciales(nombreUsuario, contraseña))
            {
                // Si las credenciales son válidas, mostrar un mensaje de bienvenida y permitir el acceso a la aplicación
                MessageBox.Show("¡Bienvenido!");

                Menucs menucs = new Menucs();
                menucs.Show(); 

                // Aquí puedes abrir la ventana principal de tu aplicación o realizar otras acciones necesarias
            }
            else
            {
                // Si las credenciales no son válidas, mostrar un mensaje de error
                MessageBox.Show("Nombre de usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.");
            }
        }

        // Método para validar las credenciales de inicio de sesión (puedes cambiar esta implementación según tus necesidades)
        private bool ValidarCredenciales(string nombreUsuario, string contraseña)
        {
            // Aquí puedes agregar la lógica para validar las credenciales, por ejemplo, consultando una base de datos o utilizando credenciales predefinidas
            // Por ahora, solo se simulará una validación simple
            return nombreUsuario == "Admin" && contraseña == "Admin";

        }

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