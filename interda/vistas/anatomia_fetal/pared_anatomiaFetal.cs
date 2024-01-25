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
    public partial class pared_anatomiaFetal : Form
    {
        conector miConector = new conector();
        public pared_anatomiaFetal()
        {
            InitializeComponent();
            DataTable datos = miConector.leer("select * from Formato_pared_abdominal");
            pared.DataSource = datos;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            pared.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            pared.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            pared.AutoResizeColumns();
            pared.AutoResizeRows();
        }

        private void pared_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pared_anatomiaFetal_Load(object sender, EventArgs e)
        {

        }
    }
}
