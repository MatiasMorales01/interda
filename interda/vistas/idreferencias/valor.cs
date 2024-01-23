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
    public partial class valor : Form
    {
        conector miConector=new conector();
        public valor()
        {
            InitializeComponent();

            DataTable datos = miConector.leer("select * from valormonetario");
            val.DataSource = datos;
            label1.Location = new Point(40, 30);
            val.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            val.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            val.ScrollBars = ScrollBars.Both;

            for (int i = 0; i < val.Columns.Count; i++)
            {
                val.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

           
            val.Columns[val.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            val.Width = 700;
            val.Height = 350;
            val.Location = new Point(50, 60);

        }

        private void valor_Load(object sender, EventArgs e)
        {

        }
    }
}
