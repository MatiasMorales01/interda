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
    public partial class secretarias : Form
    {
        conector conector = new conector();
        public secretarias()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 583;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            DataTable datos = conector.leer("select * from secretarias");
            secre.DataSource = datos;
            label1.Location = new Point(40, 30);
            secre.Location = new Point(50, 60);
            secre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            secre.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            secre.ScrollBars = ScrollBars.Both;

            for (int i = 0; i < secre.Columns.Count - 1; i++)
            {
                secre.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            // La última columna ocupará todo el espacio disponible
            secre.Columns[secre.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            secre.Width = 700;
            secre.Height = 350;

        }







        private void secretarias_Load(object sender, EventArgs e)
        {

        }
    }
}
