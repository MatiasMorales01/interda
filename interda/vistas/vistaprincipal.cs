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
    public partial class vistaprincipal : Form
    {
        public vistaprincipal()
        {
            InitializeComponent();
            this.FormClosing += vistaprincipal_close;
        }

        private void vistaprincipal_close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void vistaprincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnnuevoinf_Click(object sender, EventArgs e)
        {
            nuevo_informe ventana = new nuevo_informe();
            ventana.Show();
            this.Hide();
        }

        private void btnidreferencias_Click(object sender, EventArgs e)
        {
            idreferencias idreferencias = new idreferencias(); 
            idreferencias.Show();
           // this.Hide();
        }

        private void btninfobstetrico_Click(object sender, EventArgs e)
        {
            informeobstetrico informeobstetrico = new informeobstetrico();
            informeobstetrico.Show();

        }

        private void btnanatomiafetal_Click(object sender, EventArgs e)
        {
            anatomia_fetal ventana = new anatomia_fetal();
            ventana.Show();
            this.Hide();

        }

        private void btntablaobstetrica_Click(object sender, EventArgs e)
        {
            tablaobstetrica tablaobstetrica = new tablaobstetrica();
            tablaobstetrica.Show();
        }
    }
}
