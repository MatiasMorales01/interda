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
    public partial class idreferencias : Form
    {
        public idreferencias()
        {
            InitializeComponent();
        }

        private void idreferencias_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ecografistas ecografistas = new ecografistas(); 
            ecografistas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mhz mhz = new mhz();    
            mhz.Show();
        }
    }
}
