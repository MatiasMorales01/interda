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

        private void button1_Click(object sender, EventArgs e)
        {
            abdomen ventana = new abdomen();
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();
        }

        private void cerebelo_Click(object sender, EventArgs e)
        {
            cerebelo ventana = new cerebelo();
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();
        }

        private void cubito_Click(object sender, EventArgs e)
        {
            cubito ventana = new cubito();
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();
        }

        private void bbp_Click(object sender, EventArgs e)
        {
            dbp ventana = new dbp();
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();
        }

        private void dfo_Click(object sender, EventArgs e)
        {
            dfo ventana = new dfo();
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();
        }
            private void femur_Click(object sender, EventArgs e)
        {
            femur ventana = new femur();
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();
        }

        private void humero_Click(object sender, EventArgs e)
        {
            humero ventana = new humero();
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();
        }

        private void lcn_Click(object sender, EventArgs e)
        {
            lcn ventana = new lcn();
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();
        }

        private void perone_Click(object sender, EventArgs e)
        {
            perone ventana = new perone();
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();
        }

        private void radio_Click(object sender, EventArgs e)
        {
            radio ventana = new radio();
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();
        }

        private void rnpg_Click(object sender, EventArgs e)
        {
            rnpartosgem ventana = new rnpartosgem();
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();
        }

        private void rnps_Click(object sender, EventArgs e)
        {
            rnpartsimples ventana = new rnpartsimples();
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();
        }

        private void tibia_Click(object sender, EventArgs e)
        {
            tibia ventana = new tibia();
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();
        }

        private void acm_Click(object sender, EventArgs e)
        {
            acm ventana = new acm();
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();

        }

        private void au_Click(object sender, EventArgs e)
        {
            arteriauternia ventana = new arteriauternia();
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();
        }

        private void aum_Click(object sender, EventArgs e)
        {
            arteriumbilical ventana = new arteriumbilical();
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();
        }

        private void ductus_Click(object sender, EventArgs e)
        {
            ductus ventana = new ductus();
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();
        }

        private void psacm_Click(object sender, EventArgs e)
        {
            peaksistolicoacm ventana = new peaksistolicoacm();
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();
        }

        private void ad_Click(object sender, EventArgs e)
        {
            aortadescendiente ventana = new aortadescendiente();
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(720, 205);
            ventana.Show();
        }
    }
}
