//using interda.vistas.idreferencias;
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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Width = 800;
            this.Height = 583;
        }

        private void idreferencias_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ecografistas ecografistas = new ecografistas();
            ecografistas.StartPosition = FormStartPosition.Manual;
            ecografistas.Location = new Point(720, 205);

            ecografistas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mhz mhz = new mhz();
            mhz.StartPosition = FormStartPosition.Manual;
            mhz.Location = new Point(720, 205);
            mhz.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            codigoexamen codigoexamen = new codigoexamen();
            codigoexamen.StartPosition = FormStartPosition.Manual;
            codigoexamen.Location = new Point(720, 205);
            codigoexamen.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            valor valor = new valor();
            valor.StartPosition = FormStartPosition.Manual;
            valor.Location = new Point(720, 205);
            valor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ecografo ecografo = new ecografo();
            ecografo.StartPosition = FormStartPosition.Manual;
            ecografo.Location = new Point(720, 205);
            ecografo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tratante tratante = new tratante();
            tratante.StartPosition = FormStartPosition.Manual;
            tratante.Location = new Point(720, 205);
            tratante.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            isapre isapre = new isapre();
            isapre.StartPosition = FormStartPosition.Manual;
            isapre.Location = new Point(720, 205);
            isapre.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            anexo anexo = new anexo();
            anexo.StartPosition = FormStartPosition.Manual;
            anexo.Location = new Point(720, 205);
            anexo.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            douglas douglas = new douglas();
            douglas.StartPosition = FormStartPosition.Manual;
            douglas.Location = new Point(720, 205);
            douglas.Show();
        }

        private void boton_conclusion_Click(object sender, EventArgs e)
        {
            conclu conclu = new conclu();
            conclu.StartPosition = FormStartPosition.Manual;
            conclu.Location = new Point(720, 205);
            conclu.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            endometrio endometrio = new endometrio();
            endometrio.StartPosition = FormStartPosition.Manual;
            endometrio.Location = new Point(720, 205);
            endometrio.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ovarios ovarios = new ovarios();
            ovarios.StartPosition = FormStartPosition.Manual;
            ovarios.Location = new Point(720, 205);
            ovarios.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            utero utero = new utero();
            utero.StartPosition = FormStartPosition.Manual;
            utero.Location = new Point(720, 205);
            utero.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            vejiga vejiga = new vejiga();
            vejiga.StartPosition = FormStartPosition.Manual;
            vejiga.Location = new Point(720, 205);
            vejiga.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            secretarias secretarias = new secretarias();
            secretarias.StartPosition = FormStartPosition.Manual;
            secretarias.Location = new Point(720, 205);
            secretarias.Show();
        }
    }
}
