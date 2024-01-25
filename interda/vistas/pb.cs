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
    public partial class pb : Form
    {
        public pb(string nombre, string apellido)
        {

            
            InitializeComponent();
            label1.Text = nombre;
            label2.Text = apellido;
        }

        private void pb_Load(object sender, EventArgs e)
        {

        }
    }
}
