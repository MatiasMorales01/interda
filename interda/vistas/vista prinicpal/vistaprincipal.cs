using interda.controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace interda.vistas
{
    public partial class vistaprincipal : Form
    {
        conector miConector = new conector();
        public vistaprincipal()
        {
            InitializeComponent();
            cargarDatoscombobox();
            comboBoxdoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxasistente.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxecografo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxpiepag.DropDownStyle = ComboBoxStyle.DropDownList;
            this.FormClosing += vistaprincipal_close;
        }

        private void cargarDatoscombobox()
        {
            DataTable datos = miConector.leer("select * from ecografista");
            comboBoxdoctor.DataSource = datos;
            comboBoxdoctor.DisplayMember = "ecografista";
            comboBoxdoctor.ValueMember = "ecografista";
            DataTable datos2 = miConector.leer("select * from secretarias");
            comboBoxasistente.DataSource = datos2;
            comboBoxasistente.DisplayMember = "Detalle secretaria";
            comboBoxasistente.ValueMember = "Detalle secretaria";
            DataTable datos3 = miConector.leer("select * from ecógrafo");
            comboBoxecografo.DataSource = datos3;
            comboBoxecografo.DisplayMember = "ecógrafo";
            comboBoxecografo.ValueMember = "ecógrafo";
            DataTable datos4 = miConector.leer("select * from `pie de pagina`");
            comboBoxpiepag.DataSource = datos4;
            comboBoxpiepag.DisplayMember = "pie de pagina";
            comboBoxpiepag.ValueMember = "pie de pagina";
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
            ventana.StartPosition = FormStartPosition.CenterScreen;
            ventana.Show();
            //this.Hide();
        }

        private void btnidreferencias_Click(object sender, EventArgs e)
        {
            idreferencias idreferencias = new idreferencias();
            idreferencias.StartPosition = FormStartPosition.Manual;
            idreferencias.Location = new Point(120, 170);
            //idreferencias.StartPosition = FormStartPosition.CenterScreen;
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
            anatomia_Fetal ventana = new anatomia_Fetal();
            ventana.Show();
           // this.Hide();

        }

        private void btntablaobstetrica_Click(object sender, EventArgs e)
        {
            tablaobstetrica tablaobstetrica = new tablaobstetrica();
            tablaobstetrica.StartPosition = FormStartPosition.Manual;
            tablaobstetrica.Location = new Point(120, 170);
            tablaobstetrica.Show();
        }

        private void btnpiedepagina_Click(object sender, EventArgs e)
        {
            piedepag piedepag = new piedepag();
            piedepag.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                MessageBox.Show("Usted ha sido Hackeado por cocodrilo :(");
            }
            
        }

        private void btnconclusionanatomia_Click(object sender, EventArgs e)
        {
            conclusion_anatomia conclusionA = new conclusion_anatomia();
            conclusionA.Show();
        }

        private void btnbuscarinf_Click(object sender, EventArgs e)
        {
            binforme buscarinf = new binforme();
            buscarinf.Show();
        }

        private void btnplanillautero_Click(object sender, EventArgs e)
        {
            plantilla_uteros plantilla_utero = new plantilla_uteros();
            plantilla_utero.Show();
        }

        private void btninstitucionencabezado_Click(object sender, EventArgs e)
        {
            institucion institucion = new institucion();
            institucion.Show();
        }
    }
}
