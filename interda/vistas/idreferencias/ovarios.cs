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
    public partial class ovarios : Form
    {
        conector conector = new conector();
        public ovarios()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 583;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            DataTable datos = conector.leer("select * from ovarios");
            ov.DataSource = datos;
            label1.Location = new Point(40, 30);
            ov.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            ov.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            ov.ScrollBars = ScrollBars.Both;

            for (int i = 0; i < ov.Columns.Count; i++)
            {
                ov.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

    
            ov.Columns[ov.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            ov.Width = 700;
            ov.Height = 350;
            ov.Location = new Point(50, 60);

        }

        private void ovarios_Load(object sender, EventArgs e)
        {

        }
    }
}
