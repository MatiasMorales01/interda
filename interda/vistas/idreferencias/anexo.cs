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
    public partial class anexo : Form
    {
        conector conector=new conector();
        public anexo()
        {
            InitializeComponent();
            label1.Location = new Point(40, 30);
            DataTable datos = conector.leer("select * from anexos");
            anex.DataSource = datos;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            anex.Location = new Point(50, 60);
            anex.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            anex.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            anex.ScrollBars = ScrollBars.Both;

            for (int i = 0; i < anex.Columns.Count; i++)
            {
                anex.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            anex.Columns[anex.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            anex.Width = 700;
            anex.Height = 350;

        }

        private void anexo_Load(object sender, EventArgs e)
        {

        }
    }
}
