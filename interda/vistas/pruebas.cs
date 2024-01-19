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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace interda.vistas
{
    public partial class pruebas : Form
    {
        private conector conector = new conector();
        

        public pruebas()
        {
            InitializeComponent();
            DataTable datos = conector.leer("select Fecha, CI, Nombres, Apellidos,`Tipo de exámen`,FUR,Ecografista,Correlativo from buscador");
            tablabuscador.DataSource = datos;

            tablabuscador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tablabuscador.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tablabuscador.AutoResizeColumns();
            tablabuscador.AutoResizeRows();
        }
    

        private void pruebas_Load(object sender, EventArgs e)
        {

        }

        private void buscarci_Click(object sender, EventArgs e)
        {
            string textoci= textBoxci.Text;
            DataTable datos = conector.leer("select Fecha, CI, Nombres, Apellidos,`Tipo de exámen`,FUR,Ecografista,Correlativo from buscador where CI='"+textoci+"'");
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
    }
}