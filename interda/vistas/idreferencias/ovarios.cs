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
    public partial class ovarios : Form
    {
        conector conector = new conector();
        public ovarios()
        {
            InitializeComponent();
            DataTable datos = conector.leer("select * from ovarios");
            ov.DataSource = datos;

            ov.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ov.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ov.AutoResizeColumns();
            ov.AutoResizeRows();
        }

        private void ovarios_Load(object sender, EventArgs e)
        {

        }
    }
}
