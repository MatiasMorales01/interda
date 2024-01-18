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
    public partial class tratante : Form
    {
        conector miConector = new conector();
        public tratante()
        {
            InitializeComponent();
            DataTable datos = miConector.leer("select * from tratante");
            tra.DataSource = datos;

            tra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tra.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tra.AutoResizeColumns();
            tra.AutoResizeRows();
        }

        private void tra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
