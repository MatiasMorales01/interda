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
    public partial class cerebro_anatomiaFetal : Form
    {
        conector miConector = new conector();
        public cerebro_anatomiaFetal()
        {
            InitializeComponent();
            DataTable datos = miConector.leer("select * from `Formato cerebro`");
            cerebro.DataSource = datos;

            cerebro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            cerebro.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cerebro.AutoResizeColumns();
            cerebro.AutoResizeRows();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void cerebro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void cerebro_anatomiaFetal_Load(object sender, EventArgs e)
        {

        }
    }
}
