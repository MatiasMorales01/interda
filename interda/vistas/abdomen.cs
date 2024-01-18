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
    public partial class abdomen : Form
    {
        conector conector =new conector();
        public abdomen()
        {
            InitializeComponent();
            DataTable datos = conector.leer("select * from abdomen");
            abd.DataSource = datos;

            abd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            abd.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            abd.AutoResizeColumns();
            abd.AutoResizeRows();
        }

        private void abdomen_Load(object sender, EventArgs e)
        {

        }
    }
}
