﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presupuesto_G
{
    public partial class FrmModificarItems : Form
    {
        public FrmModificarItems()
        {
            InitializeComponent();
        }

        private void FrmModificarProyectocs_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAlimentacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmAlimentacion().Show();
        }

        private void btnRecursoHumano_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmRecursoHumano().Show();
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmMateriales().Show();
        }

        private void btnOtros_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmOtros().Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmMenu().Show();
        }
    }
}
