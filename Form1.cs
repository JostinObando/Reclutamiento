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
            string contrase�a = txtContrasenia.Text;

            // Validar si los campos est�n vac�os
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contrase�a))
            {
                MessageBox.Show("Por favor ingrese su nombre de usuario y contrase�a.");
                return;
            }

            // Validar las credenciales de inicio de sesi�n (aqu� se puede agregar l�gica adicional seg�n sea necesario)
            if (ValidarCredenciales(nombreUsuario, contrase�a))
            {
                // Si las credenciales son v�lidas, mostrar un mensaje de bienvenida y permitir el acceso a la aplicaci�n
                MessageBox.Show("�Bienvenido!");

                Menucs menucs = new Menucs();
                menucs.Show(); 

                // Aqu� puedes abrir la ventana principal de tu aplicaci�n o realizar otras acciones necesarias
            }
            else
            {
                // Si las credenciales no son v�lidas, mostrar un mensaje de error
                MessageBox.Show("Nombre de usuario o contrase�a incorrectos. Por favor, int�ntelo de nuevo.");
            }
        }

        // M�todo para validar las credenciales de inicio de sesi�n (puedes cambiar esta implementaci�n seg�n tus necesidades)
        private bool ValidarCredenciales(string nombreUsuario, string contrase�a)
        {
            // Aqu� puedes agregar la l�gica para validar las credenciales, por ejemplo, consultando una base de datos o utilizando credenciales predefinidas
            // Por ahora, solo se simular� una validaci�n simple
            return nombreUsuario == "Admin" && contrase�a == "Admin";

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