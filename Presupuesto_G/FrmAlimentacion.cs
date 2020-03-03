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
        int Restante;

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
            if(txtItem.Text=="" || txtCantidad.Text=="" || txtV_oficial.Text=="" || txtV_ofertado.Text=="" || txtC_entrega.Text == "")
            {
                MessageBox.Show("campos sin diligenciar.", "Campos vacìos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Convert.ToInt32(txtCantidad.Text) == 0)
            {
                MessageBox.Show("La Cantidad debe ser mayor a Cero", "Cantidad Errnea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Convert.ToInt32(txtV_oficial.Text)==0)
            {
                MessageBox.Show("El valor oficial debe ser mayor a Cero", "Valor Oficial Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Convert.ToInt32(txtV_ofertado.Text) == 0)
            {
                MessageBox.Show("El valor Ofertado debe ser mayor a Cero", "Valor Ofertado Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Convert.ToInt32(txtC_entrega.Text) > Convert.ToInt32(txtCantidad.Text))
            {
                MessageBox.Show("La Cantidad Entregada no puede ser mayor a la Cantidad Total.", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if(Convert.ToInt32(txtC_entrega.Text)+Convert.ToInt32(txtC_restante.Text)!= Convert.ToInt32(txtCantidad.Text))
            {
                MessageBox.Show("La sumatoria de cantidades no coincide, corrijalo por favor.", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
            txtCantidad.Text = "0";
            txtC_entrega.Text = "0";
            txtV_ofertado.Text = "0";
            txtV_oficial.Text = "0";
            if (txtCantidad.TextLength == 0 || txtCantidad.Text=="0")
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
            if (txtCantidad.TextLength==0 && txtCantidad.Text=="")
            {
                txtC_entrega.Enabled = false;
                txtC_entrega.Text = "0";
                txtC_restante.Text = "0";
                
            }
            else
            {
                txtC_entrega.Enabled = true;

                
                
            }

            
        }

        private void txtC_entrega_TextChanged(object sender, EventArgs e)
        {
            

            if (txtCantidad.Text == "")
            {

            }
            else
            {

                if (txtC_entrega.TextLength == 0)
                {

                }
                else
                {
                    if (Convert.ToInt32(txtC_entrega.Text) > Convert.ToInt32(txtCantidad.Text))
                    {
                        MessageBox.Show("Ha excedido la cantidad", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtC_entrega.Text = "0";
                        txtC_restante.Text = "0";
                    }

                    Restante = Convert.ToInt32(txtCantidad.Text) - Convert.ToInt32(txtC_entrega.Text);
                    txtC_restante.Text = Restante.ToString();

                }
            }
            
        }

        private void txtV_ofertado_TextChanged(object sender, EventArgs e)
        {
            if (txtV_oficial.Text=="")
            {

            }
            else
            {
                if (Convert.ToInt32(txtV_ofertado.Text) > Convert.ToInt32(txtPtoOficial.Text))
                {
                    MessageBox.Show("Ha excedido el Valor Oficial de este Item", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtV_ofertado.Text = "0";

                }
            }
            
        }
    }
}
