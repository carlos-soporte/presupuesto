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
    public partial class FrmOtros : Form
    {

        string numero_proceso2;

        public FrmOtros(string numero_proceso)
        {
            numero_proceso2 = numero_proceso;
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmListarProyectos().Show();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            new FrmModificarItems(numero_proceso2, "").Show();
            this.Hide();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (txtPresupuestoTotalOficial.Text == "")
            {
                MessageBox.Show("Rellene el presupuesto para Otros Items, por favor", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Convert.ToInt32(txtPresupuestoTotalOficial.Text) <= 0)
            {
                MessageBox.Show("Este campo no pueder ser menor o igual a cero, por favor cambie el dato", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (btnAsignar.Text == "Asignar")
            {

                string query = "exec asignar_pto '" + lblTipoItem.Text + "'," + txtPresupuestoTotalOficial.Text + ",'" + numero_proceso2 + "'";

                try
                {
                    bd.consultar(query);
                    txtPresupuestoTotalOficial.ReadOnly = true;
                    btnAsignar.Text = "Cambiar";
                    MessageBox.Show("Presupuesto General para OTROS ITEMS asignado", "Presupuesto Otros Items Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //dataGridView1.DataSource = llenarGv().Tables[0];


                }
                catch (Exception)
                {
                    MessageBox.Show("Se ha perdido la conexiòn con el servidor, intentelo de nuevo", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;

            }

            if (btnAsignar.Text == "Cambiar")
            {

                btnAsignar.Text = "Guardar";
                txtPresupuestoTotalOficial.ReadOnly = false;
                txtItem.Enabled = false;
                txtCantidad.Enabled = false;
                btnGuardar.Enabled = false;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
                return;

            }

            if (btnAsignar.Text == "Guardar")
            {
                string query = "exec modificar_pto '" + lblTipoItem.Text + "'," + txtPresupuestoTotalOficial.Text + ",'" + numero_proceso2 + "'";
                try
                {
                    bd.consultar(query);
                    txtPresupuestoTotalOficial.ReadOnly = true;
                    btnAsignar.Text = "Cambiar";
                    MessageBox.Show("Presupuesto para OTROS ITEMS actualizado.", "Presupuesto para OTROS ITEMS Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtItem.Enabled = true;
                    txtCantidad.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnActualizar.Enabled = true;
                    btnEliminar.Enabled = true;

                }
                catch (Exception)
                {

                    MessageBox.Show("Se ha perdido la conexiòn con el servidor, intentelo de nuevo", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return;

            }
        }

        private void txtPresupuestoTotalOficial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void FrmOtros_Load(object sender, EventArgs e)
        {
            DataSet dataSet;
            string query = "exec listar_pto '" + lblTipoItem.Text + "','" + numero_proceso2 + "'";
            bool validadorTotalPresupuesto;

            try
            {
                dataSet = bd.consultar(query);
                txtPresupuestoTotalOficial.Text = dataSet.Tables[0].Rows[0][0].ToString();
                txtPresupuestoTotalOficial.Enabled = true;
                btnAsignar.Text = "Cambiar";
                //dataGridView1.DataSource = llenarGv().Tables[0];
                validadorTotalPresupuesto = true;
                //dataGridView1.Columns[0].HeaderText = "ID";
                //dataGridView1.Columns[1].HeaderText = "Item";
                //dataGridView1.Columns[2].HeaderText = "Cantidad";
                //dataGridView1.Columns[3].HeaderText = "Valor Oficial";
            }
            catch (Exception)
            {
                validadorTotalPresupuesto = false;
            }

            if (validadorTotalPresupuesto == false)
            {
                txtItem.Enabled = false;
                txtCantidad.Enabled = false;
                btnGuardar.Enabled = false;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                txtPresupuestoTotalOficial.ReadOnly = true;
            }
        }
    }
}
