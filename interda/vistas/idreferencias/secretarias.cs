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
    public partial class secretarias : Form
    {
        conector conector = new conector();
        public secretarias()
        {
            InitializeComponent();
            DataTable datos = conector.leer("select * from secretarias");
            secre.DataSource = datos;

            secre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            secre.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            secre.AutoResizeColumns();
            secre.AutoResizeRows();
        }

        private void secretarias_Load(object sender, EventArgs e)
        {

        }
    }
}
