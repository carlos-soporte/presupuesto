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
    public partial class FrmModificarProyecto : Form
    {
        public FrmModificarProyecto()
        {
            InitializeComponent();
        }

        private void FrmModificarProyectocs_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAlimentacion_Click(object sender, EventArgs e)
        {
            new FrmAlimentacion().Show();
        }

        private void btnRecursoHumano_Click(object sender, EventArgs e)
        {
            new FrmRecursoHumano().Show();
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            new FrmMateriales().Show();
        }

        private void btnOtros_Click(object sender, EventArgs e)
        {
            new FrmOtros().Show();
        }
    }
}
