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
using System.Windows.Forms.VisualStyles;

namespace interda.vistas
{
    public partial class nuevo_informe : Form
    {
        conector conector= new conector();
        public nuevo_informe()
        {
            InitializeComponent();
            this.FormClosing += nuevo_informe_close;
            comboBox2_procedencia.DropDownStyle= ComboBoxStyle.DropDownList;
            comboBox1_ecografista.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1_ecografo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1_codigo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3_prevision.DropDownStyle = ComboBoxStyle.DropDownList;
            cargarDatoscombobox();
        }
        private void cargarDatoscombobox()
        {
            DataTable datos = conector.leer("select * from tratante");
            comboBox2_procedencia.DataSource = datos;
            comboBox2_procedencia.DisplayMember = "Tratante";
            comboBox2_procedencia.ValueMember = "Tratante";

            DataTable datos2 = conector.leer("select * from ecografista");
            comboBox1_ecografista.DataSource = datos2;
            comboBox1_ecografista.DisplayMember = "Ecografista";
            comboBox1_ecografista.ValueMember = "Ecografista";

            DataTable datos3 = conector.leer("select * from ecografo");
            comboBox1_ecografo.DataSource = datos3;
            comboBox1_ecografo.DisplayMember = "Ecógrafo";
            comboBox1_ecografo.ValueMember = "Ecógrafo";


            DataTable datos4 = conector.leer("SELECT CONCAT(`Código del examen`, ' | ', detalle) AS codigoexamen FROM codex");
            comboBox1_codigo.DataSource = datos4;
            comboBox1_codigo.DisplayMember = "codigoexamen";
            comboBox1_codigo.ValueMember = "codigoexamen";

            DataTable datos5 = conector.leer("select * from isapre");
            comboBox3_prevision.DataSource = datos5;
            comboBox3_prevision.DisplayMember = "Isapre";
            comboBox3_prevision.ValueMember = "Isapre";


        }


        private void nuevo_informe_close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vistaprincipal atras = new vistaprincipal();
            atras.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void nuevo_informe_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
