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
    public partial class anatomia_fetal : Form
    {
        public anatomia_fetal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vistaprincipal atras = new vistaprincipal();
            atras.Show();
            this.Hide();
        }

        private void button_cerebro_Click(object sender, EventArgs e)
        {
            cerebro_anatomiaFetal ventana = new cerebro_anatomiaFetal();
            ventana.Show();
            //this.Hide();
        }

        private void button_cabeza_Click(object sender, EventArgs e)
        {
            cabeza_anatomiaFetal ventana = new cabeza_anatomiaFetal();
            ventana.Show();
            //this.Hide();

        }

        private void button_cara_Click(object sender, EventArgs e)
        {
            cara_anatomiaFetal ventana = new cara_anatomiaFetal();
            ventana.Show();
            //this.Hide();
        }

        private void button_columnaVertebral_Click(object sender, EventArgs e)
        {
            columna_anatomiaFetal ventana = new columna_anatomiaFetal();
            ventana.Show();
            //this.Hide();
        }

        private void button_torax_Click(object sender, EventArgs e)
        {
            torax_anatomiaFetal ventana = new torax_anatomiaFetal();
            ventana.Show();
            //this.Hide();
        }

        private void button_corazon_Click(object sender, EventArgs e)
        {
            corazon_anatomiaFetal ventana = new corazon_anatomiaFetal();
            ventana.Show();
            //this.Hide();
        }

        private void button_Tgastrointestinal_Click(object sender, EventArgs e)
        {
            tracto_anatomiaFetal ventana = new tracto_anatomiaFetal();
            ventana.Show();
            //this.Hide();
        }
    }
}
