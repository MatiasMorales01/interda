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
    public partial class mhz : Form
    {
        conector miConector = new conector();
        public mhz()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            DataTable datos = miConector.leer("Select * from mhz");
            mh.DataSource = datos;
            label1.Location = new Point(40, 30);
            mh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            mh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            mh.ScrollBars = ScrollBars.Both;

            for (int i = 0; i < mh.Columns.Count; i++)
            {
                mh.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

   
            mh.Columns[mh.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            mh.Width = 700;
            mh.Height = 350;
            mh.Location = new Point(50, 60);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void mhz_Load(object sender, EventArgs e)
        {

        }
    }
}
