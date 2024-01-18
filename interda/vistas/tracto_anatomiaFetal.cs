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
    public partial class tracto_anatomiaFetal : Form
    {
        conector miConector = new conector();
        public tracto_anatomiaFetal()
        {
            InitializeComponent();
            DataTable datos = miConector.leer("select * from Formato_tracto_gastrointestinal");
            tracto.DataSource = datos;
            tracto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tracto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tracto.AutoResizeColumns();
            tracto.AutoResizeRows();
        }

        private void tracto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
