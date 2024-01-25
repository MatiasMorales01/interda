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
    public partial class vejiga : Form
    {
        conector conector= new conector();
        public vejiga()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 583;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            DataTable datos = conector.leer("select * from vejiga");
            vejig.DataSource = datos;
            label1.Location = new Point(40, 30);
            vejig.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            vejig.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            vejig.ScrollBars = ScrollBars.Both;

            for (int i = 0; i < vejig.Columns.Count; i++)
            {
                vejig.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

           
            vejig.Columns[vejig.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            vejig.Width = 700;
            vejig.Height = 350;
            vejig.Location = new Point(50, 60);

        }

        private void vejiga_Load(object sender, EventArgs e)
        {

        }
    }
}
