using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Reclutamiento
{
    public partial class BuscarCandidato : Form
    {
        public BuscarCandidato()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nombre = textBox2.Text;
            string apellido = textBox1.Text;
            string idUsuario = textBox3.Text;

            NegocioCandidato negocio = new NegocioCandidato();

           // int validar = negocio.ValidarUsuarios(nombre, apellido, idUsuario);


            // Verificar si los campos de nombre, apellido y ID de usuario están llenos
            if  (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox3.Text))
            {

                UsuariosBuscados usuariosBuscados = new UsuariosBuscados();
                usuariosBuscados.Show();


                // Aquí iría tu lógica para consultar
            }
            else
            {
                // Si falta alguno de los campos, mostrar un mensaje de advertencia
                MessageBox.Show("Por favor, complete todos los campos (nombre, apellido y ID de usuario).", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }


}
