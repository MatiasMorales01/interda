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
    public partial class valor : Form
    {
        conector miConector=new conector();
        public valor()
        {
            InitializeComponent();

            DataTable datos = miConector.leer("select * from valormonetario");
            val.DataSource = datos;

            val.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            val.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            val.AutoResizeColumns();
            val.AutoResizeRows();
        }

        private void valor_Load(object sender, EventArgs e)
        {

        }
    }
}
