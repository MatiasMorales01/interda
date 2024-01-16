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
    public partial class ecografistas : Form
    {
        conector miConector = new conector();
        public ecografistas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable datos = miConector.leer("Select * from ecografista");
            eco.DataSource = datos;

            eco.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            eco.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            eco.AutoResizeColumns();
            eco.AutoResizeRows();
        }

        private void eco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
