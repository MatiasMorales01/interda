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
    public partial class piedepag : Form
    {
        conector miConector = new conector();
        public piedepag()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable datos = miConector.leer("select * from `pie de pagina`");
            pie.DataSource = datos;
        }
    }
}
