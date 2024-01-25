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
    public partial class informeobstetrico : Form
    {
        public informeobstetrico()
        {
            InitializeComponent();
        }
        private void MostrarFormulario<T>() where T : Form, new()
        {
            T ventana = new T();
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();
        }

        private void btnconcldiaginfobst_Click(object sender, EventArgs e)
        {
            MostrarFormulario<conclusionobstetrica>();
        }

        private void btnliquamniotico_Click(object sender, EventArgs e)
        {
            MostrarFormulario<liquidoamniotico>();
        }

        private void btnplacenta_Click(object sender, EventArgs e)
        {
            MostrarFormulario<placenta>();
        }

        private void btnpresentacion_Click(object sender, EventArgs e)
        {
            MostrarFormulario<presentacion>();
        }
    }
}
