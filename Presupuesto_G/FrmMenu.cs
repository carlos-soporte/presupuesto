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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnCrearProyecto_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmCrearProyecto().Show();
        }

        private void btnListarProyectos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmListarProyectocs().Show();
        }
    }
}
