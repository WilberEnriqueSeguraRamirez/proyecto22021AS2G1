﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmMantenimientoConsultaGeneralUsuarios : Form
    {
        public frmMantenimientoConsultaGeneralUsuarios()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            dvgConsulta.DataSource = tabla;

        }
    }
}