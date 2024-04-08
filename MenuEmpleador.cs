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
    public partial class MenuEmpleador : Form
    {
        public MenuEmpleador()
        {
            InitializeComponent();
        }

        private void buscarUsuairoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarCandidato buscarCandidato = new BuscarCandidato();
            buscarCandidato.Show();

        }

        private void hacerReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.Show();
        }

        private void actualizarInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualizar actualizacion = new Actualizar();
            actualizacion.Show();
        }

        private void borrarInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Elminar elminar = new Elminar();    
            elminar.Show();
        }
    }
}
