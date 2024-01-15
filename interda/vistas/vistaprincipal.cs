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
            // Cierra la aplicación cuando se cierra cualquier formulario
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
    }
}
