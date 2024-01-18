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

        private void button6_Click(object sender, EventArgs e)
        {
            codigoexamen codigoexamen = new codigoexamen(); 
            codigoexamen.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            valor valor = new valor();
            valor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ecografo ecografo = new ecografo();
            ecografo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tratante tratante = new tratante();
            tratante.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            isapre isapre = new isapre();
            isapre.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            anexo anexo = new anexo();
            anexo.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            douglas douglas = new douglas();
            douglas.Show();
        }
    }
}
