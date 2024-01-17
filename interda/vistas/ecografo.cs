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
    public partial class ecografo : Form
        
    {
        conector miConector = new conector();
        public ecografo()
        {
            InitializeComponent();
            DataTable datos = miConector.leer("select * from ecografo");
            eco.DataSource = datos;

            eco.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            eco.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            eco.AutoResizeColumns();
           eco.AutoResizeRows();
        }

        private void ecografo_Load(object sender, EventArgs e)
        {

        }
    }
}
