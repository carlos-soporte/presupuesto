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
        string numero_proceso3;
        public FrmRecursoHumano(string numero_proceso2)
        {
            InitializeComponent();
            numero_proceso3 = numero_proceso2;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (txtPtoOficial.Text == "")
            {
                MessageBox.Show("favor llenar los campos");
                return;
            }

           
                txtCargo.Enabled = true;
                txtNombreProfesional.Enabled = true;
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

        public DataSet llenarGv()
        {
            DataSet ds;
            string query="exec listar_recurso '"+txtCargo.Text.Trim()+"','"+txtNombreProfesional.Text+"',"+txtTiempoM.Text+","+txtVoficial.Text+","+txtVofertado.Text+",'"+txtObservaciones.Text+"','"+numero_proceso3+"'";
            ds = bd.consultar(query);
            return ds;

        }

        private void FrmRecursoHumano_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenarGv().Tables[0];
            
            txtCargo.Enabled = false;
            txtNombreProfesional.Enabled = false;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCargo.Text == "" || txtNombreProfesional.Text == "" || txtPtoOficial.Text == "" || txtVofertado.Text == "" || txtTiempoM.Text == "" || txtVoficial.Text == ""|| txtObservaciones.Text=="")
            {
                MessageBox.Show("campos vacios,favor ingresarlos");
            }


        }
    }
}
