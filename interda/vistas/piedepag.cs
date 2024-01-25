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
    public partial class piedepag : Form
    {
        conector miConector = new conector();
        public piedepag()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            DataTable datos = miConector.leer("select * from `pie de pagina`");
            pie.DataSource = datos;

            pie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            pie.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            pie.AutoResizeColumns();
            pie.AutoResizeRows();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void piedepag_Load(object sender, EventArgs e)
        {

        }
    }
}
