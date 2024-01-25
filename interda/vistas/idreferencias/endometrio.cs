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
    public partial class endometrio : Form
    {
        conector conector= new conector();
        public endometrio()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 583;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            DataTable datos = conector.leer("select * from endometriotipo");
            endo.DataSource = datos;
            label1.Location = new Point(40, 30);
            endo.Location = new Point(50, 60);

            endo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None; 
            endo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; 
            endo.ScrollBars = ScrollBars.Both; 
            if (endo.Columns.Count > 0)
            {
                endo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            endo.Width = 700;
            endo.Height = 350;
        }

        private void endometrio_Load(object sender, EventArgs e)
        {
            
        }
    }
}
