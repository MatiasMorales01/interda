using interda.controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        Dictionary<string, string> institucionImagenes = new Dictionary<string, string>
                {
                    { "Hospital San Pablo de Coquimbo", "hc.png" },
                    { "CLINICA ELQUI", "rse.png" },
                };
        public vistaprincipal()
        {
            InitializeComponent();
            cargarDatoscombobox();

         

            comboBoxdoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxasistente.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxecografo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxpiepag.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxpiepag.SelectedIndexChanged += MostrarDetalleSeleccionado;

            this.FormClosing += vistaprincipal_close;
            
        }
        private void MostrarDetalleSeleccionado(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)sender;

           
            DataRowView selectedRow = (DataRowView)comboBox.SelectedItem;

            StringBuilder detalleStringBuilder = new StringBuilder();
            for (int i = 0; i < selectedRow.Row.ItemArray.Length; i++)
            {
                detalleStringBuilder.AppendLine($"{selectedRow.Row.Table.Columns[i].ColumnName}: {selectedRow.Row[i]}");
            }

           
            textBox1.Text = detalleStringBuilder.ToString();
        }

        private void cargarDatoscombobox()
        {
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

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

            DataTable datos5 = miConector.leer("select * from institucion");
            comboBox1.DataSource = datos5;
            comboBox1.DisplayMember = "Nombre de fantasia";
            comboBox1.ValueMember = "Nombre de fantasia";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;

            if (selectedIndex >= 0)
            {
                DataRowView selectedRow = (DataRowView)comboBox1.SelectedItem;

                if (selectedRow != null)
                {
                    string institucion = selectedRow["Nombre tributario"].ToString();
                    textBox2.Text = institucion;

                    // Verifica si la institución está en el diccionario
                    if (institucionImagenes.ContainsKey(institucion))
                    {
                        string nombreImagen = institucionImagenes[institucion];
                        MostrarImagen(nombreImagen);
                    }

                    string mail1 = selectedRow["Mail 1"].ToString();
                    textBox3.Text = mail1;
                    string mail2 = selectedRow["Mail 2"].ToString();
                    textBox4.Text = mail2;
                    string text_mail = selectedRow["Texto de salida mail"].ToString();
                    textBox5.Text = text_mail;
                }
            }
            else
            {
                LimpiarDatosInstitucion();
            }
        }

        private void LimpiarDatosInstitucion()
        {
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;

            // Puedes agregar más limpieza según sea necesario
        }

        private void MostrarImagen(string nombreImagen)
        {
            string rutaImagen = Path.Combine(@"C:\Users\clinica\source\repos\interda\interda\imagenes", nombreImagen);

            // Verifica si el archivo de imagen existe
            if (File.Exists(rutaImagen))
            {
                pictureBox2.Image = Image.FromFile(rutaImagen);
            }
            else
            {
                // Puedes manejar el caso en el que la imagen no existe
                pictureBox2.Image = null;
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
