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
    public partial class FrmAlimentacion : Form
    {
        string numero_proceso2;
        int id_alimento;
        int cantidad;
        int CantidadRestante;
        int CantidadEntregada;

        public FrmAlimentacion(string numero_proceso)
        {
            numero_proceso2 = numero_proceso;
            InitializeComponent();
        }

        public DataSet llenarGv()
        {
            DataSet ds;
            string query = "exec listar_alimentos '"+numero_proceso2+"'";
            ds = bd.consultar(query);
            ds.Tables[0].Rows.Count.ToString();
            
            return ds;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (txtPtoOficial.Text == "")
            {
                MessageBox.Show("favor llenar los campos");
                return;
            }

            if (btnAsignar.Text == "Asignar")
            {
                btnAsignar.Text = "Cambiar";
                txtPtoOficial.Enabled = false;
                return;
            }

            if (btnAsignar.Text == "Cambiar")
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //if(txtItem.Text=="" )
            string query = " exec agregar_alimento '" + txtItem.Text + "'," + txtCantidad.Text + "," + txtV_oficial.Text + "," +
                           txtV_ofertado.Text + "," + txtC_entrega.Text + "," + txtC_restante.Text + ",'" + numero_proceso2 + "'";
            
            try
            {
                bd.consultar(query);
                MessageBox.Show("items guardados con exito");
                dataGridView1.DataSource = llenarGv().Tables[0];
            }
            catch (Exception)
            {

                MessageBox.Show("error al guardar los items");
            }
        }

        private void FrmAlimentacion_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenarGv().Tables[0];
            txtC_restante.Text = "0";
            if (txtCantidad.TextLength == 0)
            {
                txtC_entrega.Enabled = false;
                txtC_restante.Enabled = false;
            }
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            new FrmModificarItems(numero_proceso2,"").Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmListarProyectos().Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                id_alimento = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            }
            catch (Exception)
            {

            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtV_oficial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtV_ofertado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtC_entrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtC_restante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.TextLength==0)
            {
                txtC_entrega.Enabled = false;
            }
            else
            {
                txtC_entrega.Enabled = true;
                
            }
        }

        private void txtC_entrega_TextChanged(object sender, EventArgs e)
        {
            
            if (txtC_entrega.TextLength == 0)
            {
                
            }
            else
            {

                //cantidad = Convert.ToInt32(txtC_entrega.Text);
                //CantidadEntregada = Convert.ToInt32(txtC_restante.Text);
                if (Convert.ToInt32(txtC_entrega.Text) > Convert.ToInt32(txtCantidad.Text))
                {
                    MessageBox.Show("Ha excedido la cantidad", MessageBoxIcon.Information.ToString());
                }
            }
        }
    }
}
