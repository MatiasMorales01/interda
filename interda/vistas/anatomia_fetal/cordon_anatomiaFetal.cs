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
    public partial class cordon_anatomiaFetal : Form
    {
        conector miConector = new conector();
        public cordon_anatomiaFetal()
        {
            InitializeComponent();
            DataTable datos = miConector.leer("select * from Formato_cordon_umbilical");
            cordon.DataSource = datos;
            this.Width = 800;
            this.Height = 583;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            cordon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            cordon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cordon.AutoResizeColumns();
            cordon.AutoResizeRows();
        }

        private void cordon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cordon_anatomiaFetal_Load(object sender, EventArgs e)
        {

        }
    }
}
