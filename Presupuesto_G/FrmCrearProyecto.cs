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
    public partial class FrmCrearProyecto : Form
    {
        public FrmCrearProyecto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreProyecto.Text.Trim() == "" )
            {
                MessageBox.Show("Faltan campos por llenar");
                return;
            }
            else if(txtPresupuestoProyecto.Text.Trim() == "")
            {
                MessageBox.Show("Faltan campos por llenar");
                return;
            }else if(txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Faltan campos por llenar");
                return;
            }else if(txtNumeroProceso.Text.Trim() == "")
            {
                MessageBox.Show("Faltan campos por llenar");
                return;
            }

            try
            {
                string query = "exec crear_proyecto '" + txtNumeroProceso.Text.Trim() + "','" + txtNombreProyecto.Text.Trim() + "'," + txtPresupuestoProyecto.Text.Trim() + ",'" + txtDescripcion.Text.Trim() + "'";
                bd.consultar(query);
                MessageBox.Show("proyecto creado correctamente");
               
            }
            catch (Exception)
            {
                MessageBox.Show("no hay conexion con el servidor");
                
               
            }

            this.Hide();
            new FrmModificarProyecto().Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmMenu().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
            txtNombreProyecto.Text = "";
            txtNumeroProceso.Text = "";
            txtPresupuestoProyecto.Text = "";
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
    }
}
