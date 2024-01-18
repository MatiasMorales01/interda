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
    public partial class columna_anatomiaFetal : Form
    {
        conector miConector = new conector();
        public columna_anatomiaFetal()
        {
            InitializeComponent();
            DataTable datos = miConector.leer("select * from Formato_columna_vertebral");
            columna.DataSource = datos;

            columna.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            columna.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            columna.AutoResizeColumns();
            columna.AutoResizeRows();
        }

        private void cerebro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
