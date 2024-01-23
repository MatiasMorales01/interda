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
    public partial class ecografo : Form
        
    {
        conector miConector = new conector();
        public ecografo()
        {
            InitializeComponent();
            label1.Location = new Point(40, 30);
            DataTable datos = miConector.leer("select * from ecografo");
            eco.DataSource = datos;

            eco.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            eco.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            eco.ScrollBars = ScrollBars.Both;

            for (int i = 0; i < eco.Columns.Count; i++)
            {
                eco.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            eco.Columns[eco.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            eco.Width = 700;
            eco.Height = 350;
            eco.Location = new Point(50, 60);

        }

        private void ecografo_Load(object sender, EventArgs e)
        {

        }
    }
}
