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
    public partial class utero : Form
    {
        conector conector = new conector();
        public utero()
        {
            InitializeComponent();
            DataTable datos = conector.leer("select * from utero");
           ut.DataSource = datos;

            ut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ut.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ut.AutoResizeColumns();
            ut.AutoResizeRows();
        }

        private void utero_Load(object sender, EventArgs e)
        {

        }
    }
}
