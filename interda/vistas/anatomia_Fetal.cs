using interda.vistas.anatomia_fetal;
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
    public partial class anatomia_Fetal : Form
    {
        public anatomia_Fetal()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 583;
            string rutaImagen = "C:\\Users\\clinica\\source\\repos\\interda\\interda\\imagenes\\fondo.png";
            this.BackgroundImage = Image.FromFile(rutaImagen);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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

        private void button_riñones_Click(object sender, EventArgs e)
        {
            rinones_anatomiaFetal ventana = new rinones_anatomiaFetal();
            ventana.Show();
            //this.Hide();
        }

        private void button_paredAbdominal_Click(object sender, EventArgs e)
        {
            pared_anatomiaFetal ventana = new pared_anatomiaFetal();
            ventana.Show();
            //this.Hide();
        }

        private void button_vejigaFetal_Click(object sender, EventArgs e)
        {
            vejiga_anatomiaFetal ventana = new vejiga_anatomiaFetal();
            ventana.Show();
            //this.Hide();
        }

        private void button_cordonUmbilical_Click(object sender, EventArgs e)
        {
            cordon_anatomiaFetal ventana = new cordon_anatomiaFetal();
            ventana.Show();
            //this.Hide();
        }

        private void button_extremidades_Click(object sender, EventArgs e)
        {
            extremidades_anatomiaFetal ventana = new extremidades_anatomiaFetal();
            ventana.Show();
            //this.Hide();
        }

        private void anatomia_Fetal_Load(object sender, EventArgs e)
        {

        }
    }
}
