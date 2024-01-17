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
    public partial class cabeza_anatomiaFetal : Form
    {
        conector miConector = new conector();
        public cabeza_anatomiaFetal()
        {
            InitializeComponent();
            DataTable datos = miConector.leer("select * from `Formato cabeza`");
            cabeza.DataSource = datos;

            cabeza.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            cabeza.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cabeza.AutoResizeColumns();
            cabeza.AutoResizeRows();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cerebro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
