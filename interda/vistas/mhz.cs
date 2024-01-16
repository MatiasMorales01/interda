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
    public partial class mhz : Form
    {
        conector miConector = new conector();
        public mhz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable datos = miConector.leer("Select * from mhz");
            mh.DataSource = datos;

            mh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            mh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            mh.AutoResizeColumns();
            mh.AutoResizeRows();
        }
    }
}
