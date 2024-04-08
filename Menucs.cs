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
    public partial class Menucs : Form
    {
        public Menucs()
        {
            InitializeComponent();
        }

        private void busToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarCandidato buscar = new BuscarCandidato();
            buscar.Show();
        }

        private void agregarCandidatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarUsuarios insertar = new InsertarUsuarios();
            insertar.Show();
        }

        private void eliminarCandidatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Elminar elminar = new Elminar();
            elminar.Show();
        }

        private void recomendarCandidatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes(); 
            reportes.Show();    
        }

        private void actualizarCandidatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualizar actualizar = new Actualizar();   
            actualizar.Show();
        }
    }
}
