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
    public partial class tablaobstetrica : Form
    {
        public tablaobstetrica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abdomen abdomen = new abdomen();    
            abdomen.Show();
        }
    }
}
