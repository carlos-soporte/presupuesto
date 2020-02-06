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
    public partial class FrmRecursoHumano : Form
    {
        public FrmRecursoHumano()
        {
            InitializeComponent();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (txtPtoOficial.Text == "")
            {
                MessageBox.Show("favor llenar los campos");
                return;
            }

           
                txtCargo.Enabled = true;
                txtNombre.Enabled = true;
                txtTiempoM.Enabled = true;
                txtVofertado.Enabled = true;
                txtVoficial.Enabled = true;
                btnGuardar.Enabled = true;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            if (btnAsignar.Text == "Asignar")
            {
                btnAsignar.Text = "Cambiar";
                txtPtoOficial.Enabled = false;
                return;
            }

            if (btnAsignar.Text == "Cambiar" )
            {
                btnAsignar.Text = "Guardar";
                txtPtoOficial.Enabled = true;
                return;
            }
                
            if (btnAsignar.Text == "Guardar")
            {
                    txtPtoOficial.Enabled = false;
                    btnAsignar.Text = "Cambiar";
                txtPtoOficial.Text = txtPtoOficial.Text;
                return;
            }


           
            
            
        }

        private void FrmRecursoHumano_Load(object sender, EventArgs e)
        {
            txtCargo.Enabled = false;
            txtNombre.Enabled = false;
            txtTiempoM.Enabled = false;
            txtVofertado.Enabled = false;
            txtVoficial.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void txtPtoOficial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            
        }
    }
}
