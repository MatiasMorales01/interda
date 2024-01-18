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
    public partial class rinones_anatomiaFetal : Form
    {
        conector miConector = new conector();
        public rinones_anatomiaFetal()
        {
            InitializeComponent();
            DataTable datos = miConector.leer("select * from Formato_rinones");
            rinones.DataSource = datos;
            rinones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            rinones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            rinones.AutoResizeColumns();
            rinones.AutoResizeRows();
        }

        private void rinones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
