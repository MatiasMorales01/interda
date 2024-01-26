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

        /*private void button1_Click(object sender, EventArgs e)
        {
            vistaprincipal atras = new vistaprincipal();
            atras.Show();
            this.Hide();
        }*/

        private void MostrarFormulario<T>() where T : Form, new()
        {
            T ventana = new T();
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();
        }

        private void button_cerebro_Click(object sender, EventArgs e)
        {
            MostrarFormulario<cerebro_anatomiaFetal>();
        }

        private void button_cabeza_Click(object sender, EventArgs e)
        {
            MostrarFormulario<cabeza_anatomiaFetal>();
     

        }

        private void button_cara_Click(object sender, EventArgs e)
        {
            MostrarFormulario<cara_anatomiaFetal>();
        }

        private void button_columnaVertebral_Click(object sender, EventArgs e)
        {
            MostrarFormulario<columna_anatomiaFetal>();
        }

        private void button_torax_Click(object sender, EventArgs e)
        {
            MostrarFormulario<torax_anatomiaFetal>();
        }

        private void button_corazon_Click(object sender, EventArgs e)
        {
            MostrarFormulario<corazon_anatomiaFetal>();
        }

        private void button_Tgastrointestinal_Click(object sender, EventArgs e)
        {
            MostrarFormulario<tracto_anatomiaFetal>();
        }

        private void button_riñones_Click(object sender, EventArgs e)
        {
            MostrarFormulario<rinones_anatomiaFetal>();
        }

        private void button_paredAbdominal_Click(object sender, EventArgs e)
        {
            MostrarFormulario<pared_anatomiaFetal>();
        }

        private void button_vejigaFetal_Click(object sender, EventArgs e)
        {
            MostrarFormulario<vejiga_anatomiaFetal>();
        }

        private void button_cordonUmbilical_Click(object sender, EventArgs e)
        {
            MostrarFormulario<cordon_anatomiaFetal>();
        }

        private void button_extremidades_Click(object sender, EventArgs e)
        {
            MostrarFormulario<extremidades_anatomiaFetal>();
        }

        private void anatomia_Fetal_Load(object sender, EventArgs e)
        {

        }
    }
}
