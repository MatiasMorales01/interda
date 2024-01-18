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
    public partial class cordon_anatomiaFetal : Form
    {
        conector miConector = new conector();
        public cordon_anatomiaFetal()
        {
            InitializeComponent();
        }

        private void cordon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
