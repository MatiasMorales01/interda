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
    public partial class utero : Form
    {
        conector conector = new conector();
        public utero()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            DataTable datos = conector.leer("select * from utero");
            ut.DataSource = datos;
            label1.Location = new Point(40, 30);
            ut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            ut.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            ut.ScrollBars = ScrollBars.Both;

            for (int i = 0; i < ut.Columns.Count; i++)
            {
                ut.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

          
            ut.Columns[ut.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            ut.Width = 700;
            ut.Height = 350;
            ut.Location = new Point(50, 60);

        }

        private void utero_Load(object sender, EventArgs e)
        {

        }
    }
}
