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
            string rutaImagen = "C:\\Users\\clinica\\source\\repos\\interda\\interda\\imagenes\\fondo.png";
            this.BackgroundImage = Image.FromFile(rutaImagen);
            this.Width = 800;
            this.Height = 583;
        }

        private void idreferencias_Load(object sender, EventArgs e)
        {

        }

        private void MostrarFormulario<T>() where T : Form, new()
        {
            T ventana = new T();
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarFormulario<ecografistas>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarFormulario<mhz>();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MostrarFormulario<codigoexamen>();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MostrarFormulario<valor>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarFormulario<ecografo>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarFormulario<tratante>();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MostrarFormulario<isapre>();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MostrarFormulario<anexo>();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MostrarFormulario<douglas>();
        }

        private void boton_conclusion_Click(object sender, EventArgs e)
        {
            MostrarFormulario<conclu>();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MostrarFormulario<endometrio>();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MostrarFormulario<ovarios>();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MostrarFormulario<utero>();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MostrarFormulario<vejiga>();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MostrarFormulario<secretarias>();
        }
    }
}
