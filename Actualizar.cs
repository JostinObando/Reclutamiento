using Datos;
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
    public partial class Actualizar : Form
    {
        public Actualizar()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCandidato = int.Parse(txtID.Text);
                string nombre = textBox1.Text;
                string apellido = textBox2.Text;
                string correoElectronico = textBox3.Text;
                string telefono = textBox4.Text;
                string experienciaLaboral = textBox5.Text;
                string educacion = textBox6.Text;
                string cursosIdiomas = textBox7.Text;


                NegocioCandidato negocio = new NegocioCandidato();
                int resultado = negocio.ActualizarCandidato(idCandidato, nombre, apellido, correoElectronico, telefono, experienciaLaboral, educacion, cursosIdiomas);

                // Manejar el resultado si es necesario
                MessageBox.Show("Candidato actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el candidato: {ex.Message}");
            }



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCandidato = int.Parse(txtID.Text); ;


                NegocioCandidato negocio = new NegocioCandidato();
                DataTable dataTable = negocio.BuscarCandidato(idCandidato);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0]; //
                    // Asignar los valores a las cajas de texto
                    textBox1.Text = row["Nombre"].ToString();
                    textBox2.Text = row["Apellido"].ToString();
                    textBox3.Text = row["CorreoElectronico"].ToString();
                    textBox4.Text = row["Telefono"].ToString();
                    textBox5.Text = row["ExperienciaLaboral"].ToString();
                    textBox6.Text = row["Educacion"].ToString();
                    textBox7.Text = row["CursosIdiomas"].ToString();



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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
