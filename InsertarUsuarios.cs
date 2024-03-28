using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reclutamiento
{
    public partial class InsertarUsuarios : Form
    {
        public InsertarUsuarios()
        {
            InitializeComponent();
        }

        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textBox1.Text;
                string apellido = textBox2.Text;
                string correoElectronico = textBox3.Text;
                string telefono = textBox4.Text;
                string experienciaLaboral = textBox5.Text;
                string educacion = textBox6.Text;
                string cursosIdiomas = textBox7.Text;

                NegocioCandidato negocio = new NegocioCandidato();

                int nehocios = negocio.InsertarCandidatos(nombre, apellido, correoElectronico, telefono, experienciaLaboral, educacion, cursosIdiomas);

                if (nehocios > 0)
                {

                    MessageBox.Show("Candidato creado exitosamente.");
                }
                else
                {
                    //Si el ingreso de la informacion falla, muestra un mensaje de error
                    MessageBox.Show("Error al crear el usuario");
                }
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir
                MessageBox.Show($"Error: {ex.Message}");
            }


}
    }
}
