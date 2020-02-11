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
    public partial class FrmModificarItems : Form
    {
        string numero_proceso2;
        string nombre_proyecto2;
        public FrmModificarItems(string numero_proceso,string nombre_proyecto)
        {
            numero_proceso2 = numero_proceso;
            nombre_proyecto2 = nombre_proyecto;
            InitializeComponent();
        }

        private void FrmModificarProyectocs_Load(object sender, EventArgs e)
        {
            lbProyecto.Text = nombre_proyecto2;
        }

        private void btnAlimentacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmAlimentacion(numero_proceso2).Show();
        }

        private void btnRecursoHumano_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmRecursoHumano(numero_proceso2,nombre_proyecto2).Show();
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

        private void label10_Click(object sender, EventArgs e)
        {
            
        }
    }
}
