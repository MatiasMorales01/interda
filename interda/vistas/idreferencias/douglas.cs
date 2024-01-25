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
    public partial class douglas : Form
    {
        conector conector= new conector();
        public douglas()
        {
            InitializeComponent();
            label1.Location = new Point(40, 30);
            DataTable datos = conector.leer("select * from douglas");
            doug.DataSource = datos;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            doug.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            doug.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            doug.ScrollBars = ScrollBars.Both;

            for (int i = 0; i < doug.Columns.Count; i++)
            {
                doug.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            doug.Columns[doug.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            doug.Width = 700;
            doug.Height = 350;
            doug.Location = new Point(50, 60);
        }

        private void douglas_Load(object sender, EventArgs e)
        {

        }
    }
}
