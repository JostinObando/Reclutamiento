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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int idCandidato = int.Parse(txTid.Text); // Suponiendo que tengas un método para obtener el ID de usuario

                NegocioCandidato negocio = new NegocioCandidato();
                DataTable dataTable = negocio.GenerarReporteCandidatos(nombre, apellido, idCandidato);


                if (dataTable.Rows.Count > 0)
                {
                    dataGridViewReportes.DataSource = dataTable; // Cargar el resultado en el DataGridView
                                                                 // Crear un archivo de texto para escribir la información
                    string rutaArchivo = @"D:\IncioSeccion\Reclutamiento\reporte_candidatos.txt";
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\IncioSeccion\Reclutamiento\reporte_candidatos.txt"))
                    {
                        // Escribir los encabezados de las columnas
                        for (int i = 0; i < dataTable.Columns.Count; i++)
                        {
                            file.Write(dataTable.Columns[i].ColumnName + "\t");
                        }
                        file.WriteLine();

                        // Escribir cada fila de datos en el archivo
                        foreach (DataRow row in dataTable.Rows)
                        {
                            for (int i = 0; i < dataTable.Columns.Count; i++)
                            {
                                file.Write(row[i].ToString() + "\t");
                            }
                            file.WriteLine();
                            MessageBox.Show("Se ha creado el archivo  @\"D:\\IncioSeccion\\Reclutamiento\\reporte_candidatos.txt\" 'reporte_candidatos.txt' correctamente.");
                        }
                    }




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
    }
}
