﻿using System;
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
    public partial class anatomia_fetal : Form
    {
        public anatomia_fetal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vistaprincipal atras = new vistaprincipal();
            atras.Show();
            this.Hide();
        }

        private void button_cerebro_Click(object sender, EventArgs e)
        {
            cerebro_anatomiaFetal ventana = new cerebro_anatomiaFetal();
            ventana.Show();
            //this.Hide();
        }
    }
}
