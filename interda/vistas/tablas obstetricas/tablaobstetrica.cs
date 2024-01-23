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
            abdomen abdomen = new abdomen();
            abdomen.StartPosition = FormStartPosition.Manual;
            abdomen.Location = new Point(720, 205);
            abdomen.Show();
        }

        private void cerebelo_Click(object sender, EventArgs e)
        {
            cerebelo cerebelo = new cerebelo();
            cerebelo.StartPosition = FormStartPosition.Manual;
            cerebelo.Location = new Point(720, 205);
            cerebelo.Show();
        }

        private void cubito_Click(object sender, EventArgs e)
        {
            cubito cubito = new cubito();
            cubito.StartPosition=FormStartPosition.Manual;
            cubito.Location = new Point(720,205);
            cubito.Show();
        }

        private void bbp_Click(object sender, EventArgs e)
        {
            dbp dbp = new dbp();
            dbp.StartPosition = FormStartPosition.Manual;
            dbp.Location = new Point(720, 205);
            dbp.Show();
        }

        private void dfo_Click(object sender, EventArgs e)
        {
            dfo dbp = new dfo();
            dbp.StartPosition = FormStartPosition.Manual;
            dbp.Location = new Point(720, 205);
            dbp.Show();
        }

        private void femur_Click(object sender, EventArgs e)
        {
            femur venetana = new femur();
            venetana.StartPosition = FormStartPosition.Manual;
            venetana.Location = new Point(720, 205);
            venetana.Show();
        }

        private void humero_Click(object sender, EventArgs e)
        {
            humero venetana = new humero();
            venetana.StartPosition = FormStartPosition.Manual;
            venetana.Location = new Point(720, 205);
            venetana.Show();
        }

        private void lcn_Click(object sender, EventArgs e)
        {
            lcn venetana = new lcn();
            venetana.StartPosition = FormStartPosition.Manual;
            venetana.Location = new Point(720, 205);
            venetana.Show();
        }

        private void perone_Click(object sender, EventArgs e)
        {
            perone venetana = new perone();
            venetana.StartPosition = FormStartPosition.Manual;
            venetana.Location = new Point(720, 205);
            venetana.Show();
        }

        private void radio_Click(object sender, EventArgs e)
        {
            radio venetana = new radio();
            venetana.StartPosition = FormStartPosition.Manual;
            venetana.Location = new Point(720, 205);
            venetana.Show();
        }

        private void rnpg_Click(object sender, EventArgs e)
        {
            rnpartosgem venetana = new rnpartosgem();
            venetana.StartPosition = FormStartPosition.Manual;
            venetana.Location = new Point(720, 205);
            venetana.Show();
        }
    }
}
