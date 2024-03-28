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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void iniciarProcesoDeSelecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void busToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarCandidato buscarCandidato = new BuscarCandidato();
            buscarCandidato.Show();
        }

        private void agregarCandidatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarUsuarios insertar = new InsertarUsuarios(); 
            insertar.Show();    
        }
    }
}
