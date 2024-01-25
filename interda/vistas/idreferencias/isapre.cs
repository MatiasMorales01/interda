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
    public partial class isapre : Form
    {
        conector conector=new conector();
        public isapre()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            DataTable datos = conector.leer("select * from isapre");
            isa.DataSource = datos;
            label1.Location = new Point(40, 30);
            isa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            isa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            isa.ScrollBars = ScrollBars.Both;

            for (int i = 0; i < isa.Columns.Count; i++)
            {
                isa.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            isa.Columns[isa.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            isa.Width = 700;
            isa.Height = 350;
            isa.Location = new Point(50, 60);

        }

        private void isapre_Load(object sender, EventArgs e)
        {

        }
    }
}
