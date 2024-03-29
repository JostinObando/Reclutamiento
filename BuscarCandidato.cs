using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
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
            try
            {
                string nombre = textBox1.Text;
                string apellido = textBox2.Text;
                int idCandidato = int.Parse(textBox3.Text); // Suponiendo que tengas un método para obtener el ID de usuario

                NegocioCandidato negocio = new NegocioCandidato();
                DataTable dataTable = negocio.BuscarCandidato(idCandidato);


                if (dataTable.Rows.Count > 0)
                {
                    dataGridViewCandidatos.DataSource = dataTable; // Cargar el resultado en el DataGridView
                    MessageBox.Show("Usuario validado correctamente.");
                }
                else
                {
                    MessageBox.Show("El usuario no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        // private void btnConsultar_Click(object sender, EventArgs e)
        //{
        //    string nombre = textBox2.Text;
        //    string apellido = textBox1.Text;
        //    int idUsuario = Convert.ToInt32(textBox1.Text); 

        //    NegocioCandidato negocio = new NegocioCandidato();

        //    // Validar usuarios y obtener los resultados
        //  //  List<Candidato> usuariosValidados = negocio.ValidarUsuarios(nombre, apellido, idUsuario);

        //    // Verificar si los campos de nombre, apellido y ID de usuario están llenos
        //    if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido) && !string.IsNullOrEmpty(idUsuario))
        //    {
        //        if (usuariosValidados.Count > 0)
        //        {
        //            // Configurar el DataGridView para mostrar los resultados
        //            dataGridViewCandidatos.DataSource = null; // Limpiar los datos existentes si los hay
        //            dataGridViewCandidatos.DataSource = usuariosValidados;

        //        }
        //        else
        //        {
        //            MessageBox.Show("No se encontraron usuarios con los datos proporcionados.", "Usuarios no encontrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    else
        //    {
        //        // Si falta alguno de los campos, mostrar un mensaje de advertencia
        //        MessageBox.Show("Por favor, complete todos los campos (nombre, apellido y ID de usuario).", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        //    }
    }
}
//}



