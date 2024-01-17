﻿using interda.controlador;
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
    public partial class corazon_anatomiaFetal : Form
    {
        conector miConector = new conector();
        public corazon_anatomiaFetal()
        {
            InitializeComponent();
            DataTable datos = miConector.leer("select * from Formato_corazon");
            corazon.DataSource = datos;

            corazon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            corazon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            corazon.AutoResizeColumns();
            corazon.AutoResizeRows();
        }

        private void corazon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
