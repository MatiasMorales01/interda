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
    public partial class conclu : Form
    {
        conector conector=new conector();
        public conclu()
        {
            InitializeComponent();
            label1.Location = new Point(40, 30);
            DataTable datos = conector.leer("select * from conclusion");
            con.DataSource = datos;
            this.Width = 800;
            this.Height = 583;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            con.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            con.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            con.ScrollBars = ScrollBars.Both;

            for (int i = 0; i < con.Columns.Count; i++)
            {
                con.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            con.Columns[con.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            con.Width = 700;
            con.Height = 350;
            con.Location = new Point(50, 60);

        }

        private void conclu_Load(object sender, EventArgs e)
        {

        }
    }
}
