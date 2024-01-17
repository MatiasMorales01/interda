using interda.controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interda.vistas
{
    public partial class torax_anatomiaFetal : Form
    {
        conector miConector = new conector();
        public torax_anatomiaFetal()
        {
            InitializeComponent();
            DataTable datos = miConector.leer("select * from Formato_columna_vertebral");
            torax.DataSource = datos;

            torax.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            torax.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            torax.AutoResizeColumns();
            torax.AutoResizeRows();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void columna_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
