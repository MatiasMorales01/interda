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
            DataTable datos = conector.leer("select * from anexos");
            anex.DataSource = datos;

            anex.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            anex.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            anex.AutoResizeColumns();
            anex.AutoResizeRows();
        }

        private void anexo_Load(object sender, EventArgs e)
        {

        }
    }
}
