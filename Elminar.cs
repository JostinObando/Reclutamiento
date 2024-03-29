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
    public partial class Elminar : Form
    {
        public Elminar()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idCandidato;
            NegocioCandidato negocioCandidato = new NegocioCandidato();

            if (int.TryParse(textBox3.Text, out idCandidato))
            {
                try
                {
                    NegocioCandidato negocio = new NegocioCandidato();
                    negocio.BorrarCandidato(idCandidato);

                    MessageBox.Show("Candidato eliminado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar candidato: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de candidato válido");
            }



        }
    }
}
