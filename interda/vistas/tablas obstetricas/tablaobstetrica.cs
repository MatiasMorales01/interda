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

        private void MostrarFormulario<T>() where T : Form, new()
        {
            T ventana = new T();
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarFormulario<abdomen>();
        }

        private void cerebelo_Click(object sender, EventArgs e)
        {
            MostrarFormulario<cerebelo>();
        }

        private void cubito_Click(object sender, EventArgs e)
        {
            MostrarFormulario<cubito>();
        }

        private void bbp_Click(object sender, EventArgs e)
        {
            MostrarFormulario<dbp>();
        }

        private void dfo_Click(object sender, EventArgs e)
        {
            MostrarFormulario<dfo>();
        }

        private void femur_Click(object sender, EventArgs e)
        {
            MostrarFormulario<femur>();
        }

        private void humero_Click(object sender, EventArgs e)
        {
            MostrarFormulario<humero>();
        }

        private void lcn_Click(object sender, EventArgs e)
        {
            MostrarFormulario<lcn>();
        }

        private void perone_Click(object sender, EventArgs e)
        {
            MostrarFormulario<perone>();
        }

        private void radio_Click(object sender, EventArgs e)
        {
            MostrarFormulario<radio>();
        }

        private void rnpg_Click(object sender, EventArgs e)
        {
            MostrarFormulario<rnpartosgem>();
        }

        private void rnps_Click(object sender, EventArgs e)
        {
            MostrarFormulario<rnpartsimples>();
        }

        private void tibia_Click(object sender, EventArgs e)
        {
            MostrarFormulario<tibia>();
        }

        private void acm_Click(object sender, EventArgs e)
        {
            MostrarFormulario<acm>();
        }

        private void au_Click(object sender, EventArgs e)
        {
            MostrarFormulario<arteriauternia>();
        }

        private void aum_Click(object sender, EventArgs e)
        {
            MostrarFormulario<arteriumbilical>();
        }

        private void ductus_Click(object sender, EventArgs e)
        {
            MostrarFormulario<ductus>();
        }

        private void psacm_Click(object sender, EventArgs e)
        {
            MostrarFormulario<peaksistolicoacm>();
        }

        private void ad_Click(object sender, EventArgs e)
        {
            MostrarFormulario<aortadescendiente>();
        }
    }

}
