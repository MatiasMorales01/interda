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
    public partial class codigoexamen : Form
    {
        conector miConector = new conector();
        public codigoexamen()
        {
            InitializeComponent();
            label1.Location = new Point(40, 30);
            DataTable datos = miConector.leer("select * from codex");
            exam.DataSource = datos;
            exam.Location = new Point(50, 60);
            exam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            exam.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            exam.ScrollBars = ScrollBars.Both;

            for (int i = 0; i < exam.Columns.Count; i++)
            {
                exam.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            exam.Columns[exam.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            exam.Width = 700;
            exam.Height = 350;
        }

        private void codigoexamen_Load(object sender, EventArgs e)
        {

        }
    }
}
