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

namespace interda.vistas
{
    public partial class binforme : Form
    {
        private conector conector = new conector();
        

        public binforme()
        {
            InitializeComponent();
            DataTable datos = conector.leer("select Fecha, CI, Nombres, Apellidos,`Tipo de exámen`,FUR,Ecografista,Correlativo from buscador limit 15");
            tablabuscador.DataSource = datos;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            tablabuscador.CellDoubleClick += tablabuscador_CellDoubleClick;
            tablabuscador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tablabuscador.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tablabuscador.AutoResizeColumns();
            tablabuscador.AutoResizeRows();
        }
        private void tablabuscador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;

                DataGridViewRow filaSeleccionada = tablabuscador.Rows[rowIndex];

                // Obtiene los valores de nombre y apellido de la fila seleccionada
                string nombre = filaSeleccionada.Cells["Nombres"].Value.ToString();
                string apellido = filaSeleccionada.Cells["Apellidos"].Value.ToString();

                // Muestra un mensaje con el nombre y apellido
                pb ventana = new pb();
                ventana.Show();

                // Puedes usar el índice (rowIndex) como desees
                MessageBox.Show($"Has seleccionado:\nNombre: {nombre}\nApellido: {apellido}\nÍndice: {rowIndex}", "Información");
            }
        }

        private void pruebas_Load(object sender, EventArgs e)
        {

        }

        private void buscarci_Click(object sender, EventArgs e)
        {
            string textoci = textBoxci.Text;

            // Verificar si el campo de búsqueda está vacío o nulo
            string consultaSQL = string.IsNullOrEmpty(textoci)
                ? "select Fecha, CI, Nombres, Apellidos, `Tipo de exámen`, FUR, Ecografista, Correlativo from buscador limit 15"
                : "select Fecha, CI, Nombres, Apellidos, `Tipo de exámen`, FUR, Ecografista, Correlativo from buscador where CI='" + textoci + "'";

            DataTable datos = conector.leer(consultaSQL);
            tablabuscador.DataSource = datos;

            tablabuscador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tablabuscador.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tablabuscador.AutoResizeColumns();
            tablabuscador.AutoResizeRows();
        }

        private void buscarapellidos_Click(object sender, EventArgs e)
        {
            string textoap = textBoxapellidos.Text;
            DataTable datos = conector.leer("SELECT Fecha, CI, Nombres, Apellidos, `Tipo de exámen`, FUR, Ecografista, Correlativo FROM buscador WHERE Apellidos LIKE '%" + textoap + "%'");
            tablabuscador.DataSource = datos;

            tablabuscador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tablabuscador.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tablabuscador.AutoResizeColumns();
            tablabuscador.AutoResizeRows();
        }

        private void textBoxci_TextChanged(object sender, EventArgs e)
        {

        }

        private void tablabuscador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
