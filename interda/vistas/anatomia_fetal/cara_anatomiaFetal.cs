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
    public partial class cara_anatomiaFetal : Form
    {
        conector miConector = new conector();
        public cara_anatomiaFetal()
        {
            InitializeComponent();
            DataTable datos = miConector.leer("select * from `Formato cara`");
            cara.DataSource = datos;

            cara.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            cara.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cara.AutoResizeColumns();
            cara.AutoResizeRows();
        }

        private void cara_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
