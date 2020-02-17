using System;
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
    public partial class FrmAdiccionar : Form
    {
        public FrmAdiccionar()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmListarProyectos().Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTiempo.Text = "";
            txtValor.Text = "";
        }
    }
}
