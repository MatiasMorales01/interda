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
    public partial class tratante : Form
    {
        conector miConector = new conector();
        public tratante()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 583;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            DataTable datos = miConector.leer("select * from tratante");
            tra.DataSource = datos;
            label1.Location = new Point(40, 30);
            tra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            tra.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            tra.ScrollBars = ScrollBars.Both;

            for (int i = 0; i < tra.Columns.Count; i++)
            {
                tra.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            tra.Columns[tra.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            tra.Width = 700;
            tra.Height = 350;
            tra.Location = new Point(50, 60);

        }

        private void tra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tratante_Load(object sender, EventArgs e)
        {

        }
    }
}
