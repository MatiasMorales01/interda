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
    public partial class douglas : Form
    {
        conector conector= new conector();
        public douglas()
        {
            InitializeComponent();
            DataTable datos = conector.leer("select * from douglas");
            doug.DataSource = datos;

            doug.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            doug.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            doug.AutoResizeColumns();
            doug.AutoResizeRows();
        }

        private void douglas_Load(object sender, EventArgs e)
        {

        }
    }
}
