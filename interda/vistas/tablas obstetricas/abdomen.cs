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
    public partial class abdomen : Form
    {
        conector conector =new conector();
        public abdomen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            DataTable datos = conector.leer("select * from abdomen");
            abd.DataSource = datos;
            label1.Location = new Point(40, 30);
            abd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            abd.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            abd.ScrollBars = ScrollBars.Both;

            for (int i = 0; i < abd.Columns.Count; i++)
            {
                abd.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            abd.Columns[abd.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            abd.Width = 700;
            abd.Height = 350;
            abd.Location = new Point(50, 60);

        }

        private void abdomen_Load(object sender, EventArgs e)
        {

        }
    }
}
