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

namespace interda.vistas
{
    public partial class plantilla_uteros : Form
    {
        conector conector = new conector();
        public plantilla_uteros()
        {
            InitializeComponent();
            cargarDatos();
        }
        private void cargarDatos()
        {
            DataTable datos = conector.leer("select * from plantilla_utero");
            comboBox_nombre.DataSource = datos;
            comboBox_nombre.DisplayMember = "Nombre";
            comboBox_nombre.ValueMember = "Nombre";
            comboBox_nombre.SelectedIndex = -1;
        }

        private void comboBox_nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_nombre.Text = comboBox_nombre.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_plantilla_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
