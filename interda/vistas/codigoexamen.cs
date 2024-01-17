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
          
            DataTable datos = miConector.leer("select * from codex");
            exam.DataSource = datos;

            exam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            exam.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            exam.AutoResizeColumns();
            exam.AutoResizeRows();
        }

        private void codigoexamen_Load(object sender, EventArgs e)
        {

        }
    }
}
