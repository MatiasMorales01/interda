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
    public partial class pruebas : Form
    {
        private conector Conector = new conector(); 
        private TableLayoutPanel tableLayoutPanel1;
        public pruebas()
        {
            InitializeComponent();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.Dock = DockStyle.Fill;
            this.Controls.Add(tableLayoutPanel1);
            DataTable dataTable = Conector.leer("SELECT uwu FROM pruebas");

            foreach (DataRow row in dataTable.Rows)
            {
                string dato = row["uwu"].ToString();
                AgregarTextBox(dato);
            }

        }
        private void AgregarTextBox(string texto)
        {
            TextBox textBox = new TextBox();
            textBox.Text = texto;
            tableLayoutPanel1.Controls.Add(textBox);
        }

        private void pruebas_Load(object sender, EventArgs e)
        {

        }
    }
}
