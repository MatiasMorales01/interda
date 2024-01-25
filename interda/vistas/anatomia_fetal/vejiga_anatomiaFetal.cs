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
    public partial class vejiga_anatomiaFetal : Form
    {
        conector miConector = new conector();
        public vejiga_anatomiaFetal()
        {
            InitializeComponent();
            DataTable datos = miConector.leer("select * from Formato_vejiga_fetal");
            vejiga.DataSource = datos;
            this.Width = 800;
            this.Height = 583;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            vejiga.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            vejiga.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            vejiga.AutoResizeColumns();
            vejiga.AutoResizeRows();
        }

        private void vejiga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vejiga_anatomiaFetal_Load(object sender, EventArgs e)
        {

        }
    }
}
