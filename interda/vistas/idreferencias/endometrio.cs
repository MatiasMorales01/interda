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
    public partial class endometrio : Form
    {
        conector conector= new conector();
        public endometrio()
        {
            InitializeComponent();
        }

        private void endometrio_Load(object sender, EventArgs e)
        {
            DataTable datos = conector.leer("select * from endometriotipo");
            endo.DataSource = datos;

            endo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            endo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            endo.AutoResizeColumns();
            endo.AutoResizeRows();
        }
    }
}
