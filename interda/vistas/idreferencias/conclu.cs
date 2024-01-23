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
    public partial class conclu : Form
    {
        conector conector=new conector();
        public conclu()
        {
            InitializeComponent();
            DataTable datos = conector.leer("select * from conclusion");
            con.DataSource = datos;

            con.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            con.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            con.AutoResizeColumns();
            con.AutoResizeRows();
        }

        private void conclu_Load(object sender, EventArgs e)
        {

        }
    }
}
