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

namespace interda.vistas.anatomia_fetal
{
    public partial class extremidades_anatomiaFetal : Form
    {
        conector miConector = new conector();
        public extremidades_anatomiaFetal()
        {
            InitializeComponent();
            DataTable datos = miConector.leer("select * from Formato_extremidades");
            ext.DataSource = datos;
            ext.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ext.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ext.AutoResizeColumns();
            ext.AutoResizeRows();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ext_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
