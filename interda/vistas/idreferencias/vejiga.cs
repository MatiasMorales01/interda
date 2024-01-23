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
    public partial class vejiga : Form
    {
        conector conector= new conector();
        public vejiga()
        {
            InitializeComponent();
            DataTable datos = conector.leer("select * from vejiga");
            vejig.DataSource = datos;

            vejig.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            vejig.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            vejig.AutoResizeColumns();
            vejig.AutoResizeRows();
        }

        private void vejiga_Load(object sender, EventArgs e)
        {

        }
    }
}
