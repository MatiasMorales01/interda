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
    public partial class humero : Form
    {
        conector conector = new conector();
        public humero()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            Label label1 = new Label();
            label1.Text = "Humero";
            label1.Font  = new Font(label1.Font.FontFamily, 15, label1.Font.Style);
            DataGridView dataGridView1= new DataGridView();
            this.Controls.Add(dataGridView1);
            this.Controls.Add(label1);
            DataTable datos = conector.leer("select * from humero");
            dataGridView1.DataSource = datos;
            label1.Location = new Point(40, 30);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.ScrollBars = ScrollBars.Both;


            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Width = 700;
            dataGridView1.Height = 350;
            dataGridView1.Location = new Point(50, 60);
        }

        private void humero_Load(object sender, EventArgs e)
        {

        }
    }
}
