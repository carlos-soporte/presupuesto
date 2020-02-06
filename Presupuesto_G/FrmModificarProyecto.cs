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
        string numero_proceso2;
        string nombre_proyecto2;
        int presupuesto_proyecto2;
        string descripcion2;
        public FrmModificarProyecto(string numero_proceso,string nombre_proyecto,int presupuesto_proyecto,string descripcion)
        {
            InitializeComponent();
        }

        

        private void txtPresupuestoProyecto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
