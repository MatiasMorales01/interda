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
            DataTable datos = conector.leer("select * from isapre");
            isa.DataSource = datos;

            isa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            isa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            isa.AutoResizeColumns();
            isa.AutoResizeRows();
        }

        private void isapre_Load(object sender, EventArgs e)
        {

        }
    }
}
