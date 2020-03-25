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
        int Restante;
        int id_alimento,cantidad,CantidadEntregada,CantidadRestante;
        string item;
        double ValorOficial, ValorOfertado;

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
            
            if (txtPresupuestoTotalOficial.Text == "")
            {
                MessageBox.Show("Rellene el presupuesto, por favor","¡Alto!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
                    MessageBox.Show("Presupuesto General para ALIMENTACIÒN ASIGNADO", "Presupuesto general Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = llenarGv().Tables[0];


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
                txtV_oficial.Enabled = false;
                txtV_ofertado.Enabled = false;
                txtC_entrega.Enabled = false;
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
                    MessageBox.Show("Presupuesto General para ALIMENTACIÒN actualizado.", "Presupuesto general Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtItem.Enabled = true;
                    txtCantidad.Enabled = true;
                    txtV_oficial.Enabled = true;
                    txtV_ofertado.Enabled = true;
                    txtC_entrega.Enabled = true;
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

                RellenarEstadisticas();

                txtItem.Text = "";
                txtCantidad.Text = "0";
                txtV_oficial.Text = "0";
                txtV_ofertado.Text = "0";
                txtC_entrega.Text = "0";
                txtC_restante.Text = "0";
            }
            catch (Exception)
            {

                MessageBox.Show("error al guardar los items");
            }
        }

        private void FrmAlimentacion_Load(object sender, EventArgs e)
        {
            DataSet dataSet;
            string query = "exec listar_pto '"+lblTipoItem.Text+"','"+numero_proceso2+"'";
            bool validadorTotalPresupuesto;

            try
            {
                dataSet = bd.consultar(query);
                txtPresupuestoTotalOficial.Text = dataSet.Tables[0].Rows[0][0].ToString();
                txtPresupuestoTotalOficial.Enabled = true;
                btnAsignar.Text = "Cambiar";
                dataGridView1.DataSource = llenarGv().Tables[0];
                validadorTotalPresupuesto = true;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Item";
                dataGridView1.Columns[2].HeaderText = "Cantidad";
                dataGridView1.Columns[3].HeaderText = "Valor Oficial";
                dataGridView1.Columns[4].HeaderText = "Valor Ofertado";
                dataGridView1.Columns[5].HeaderText = "Valor Total Oficial";
                dataGridView1.Columns[6].HeaderText = "Valor Total Ofertado";
                dataGridView1.Columns[7].HeaderText = "Cantidad Entregada";
                dataGridView1.Columns[8].HeaderText = "Cantidad Restante";
                dataGridView1.Columns[9].HeaderText = "Numero de proceso";

                RellenarEstadisticas();
                
            }
            catch (Exception)
            {
                validadorTotalPresupuesto = false;
            }

            if (validadorTotalPresupuesto == false)
            {
                txtItem.Enabled = false;
                txtCantidad.Enabled = false;
                txtV_oficial.Enabled = false;
                txtV_ofertado.Enabled = false;
                txtC_entrega.Enabled = false;
                txtC_restante.Enabled = false;
                btnGuardar.Enabled = false;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                txtPresupuestoTotalOficial.ReadOnly = true;
            }
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
                id_alimento = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                item = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                cantidad = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                ValorOficial = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                ValorOfertado = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                CantidadEntregada = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
                CantidadRestante = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value);

                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;

            }
            catch (Exception)
            {
                //MessageBox.Show("No hay ninguna fila vàlida seleccionada.", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;
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
                if (txtV_ofertado.TextLength==0)
                {

                }
                else
                {
                    if (Convert.ToInt32(txtV_ofertado.Text) > Convert.ToInt32(txtV_oficial.Text))
                    {
                        MessageBox.Show("El valor Ofertado no puede ser mayor al oficial", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtV_ofertado.Text = "0";
                    }
                }
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            btnAsignar.Enabled = false;
            btnActualizar.Enabled = false;
            DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar este Item?", "Eliminar" + txtItem.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                string query = "exec EliminarAlimento " + id_alimento + ",'" + numero_proceso2 + "'";
                try
                {
                    bd.consultar(query);
                    MessageBox.Show("Item eliminado satisfactoriamente", "¿En hora buena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAsignar.Enabled = true;
                    btnActualizar.Enabled = true;
                    btnActualizar.Enabled = false;
                    btnEliminar.Enabled = false;
                    dataGridView1.DataSource = llenarGv().Tables[0];
                    RellenarEstadisticas();

                }
                catch (Exception)
                {
                    MessageBox.Show("Se ha perdido la conexiòn con el servidor, intentelo de nuevo", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                btnAsignar.Enabled = true;
                btnEliminar.Enabled = false;
            }
            
        }

        private void btnGuardar_MouseDown(object sender, MouseEventArgs e)
        {
            btnGuardar.BackColor = Color.Lime;
        }

        private void btnActualizar_MouseDown(object sender, MouseEventArgs e)
        {
            btnActualizar.BackColor = Color.Lime;
        }

        private void btnEliminar_MouseDown(object sender, MouseEventArgs e)
        {
            btnEliminar.BackColor = Color.Lime;
        }

        private void btnAsignar_MouseDown(object sender, MouseEventArgs e)
        {
            btnAsignar.BackColor = Color.Lime;
        }

        private void txtV_oficial_TextChanged(object sender, EventArgs e)
        {

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

        private void txtPresupuestoTotalOficial_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
            if (id_alimento > 0 && btnActualizar.Text=="Actualizar")
            {
                txtItem.Text = item;
                txtCantidad.Text = cantidad.ToString();
                txtV_oficial.Text = ValorOficial.ToString();
                txtV_ofertado.Text = ValorOfertado.ToString();
                txtC_entrega.Text = CantidadEntregada.ToString();
                txtC_restante.Text = CantidadRestante.ToString();

                btnEliminar.Enabled = false;
                btnGuardar.Enabled = false;
                btnAsignar.Enabled = false;
                btnActualizar.Text = "Confirmar";
                return;
            }

            if(btnActualizar.Text == "Confirmar")
            {
                if (txtItem.Text == "" || txtCantidad.Text == "" || txtV_oficial.Text == "" || txtV_ofertado.Text == "" || txtC_entrega.Text == "")
                {
                    MessageBox.Show("campos sin diligenciar.", "Campos vacìos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Convert.ToInt32(txtCantidad.Text) == 0)
                {
                    MessageBox.Show("La Cantidad debe ser mayor a Cero", "Cantidad Errnea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Convert.ToInt32(txtV_oficial.Text) == 0)
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


                if (Convert.ToInt32(txtC_entrega.Text) + Convert.ToInt32(txtC_restante.Text) != Convert.ToInt32(txtCantidad.Text))
                {
                    MessageBox.Show("La sumatoria de cantidades no coincide, corrijalo por favor.", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string query = "exec ActualizarAlimento " + id_alimento + ",'" + txtItem.Text + "'," +
                    txtCantidad.Text + "," + txtV_oficial.Text + "," + txtV_ofertado.Text + "," + txtC_entrega.Text +
                    "," + txtC_restante.Text + ",'" + numero_proceso2 + "'";

                try
                {
                    bd.consultar(query);
                    MessageBox.Show("Item actualizado correctamente", "¡En hora buena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnActualizar.Enabled = false;
                    btnActualizar.Text = "Actualizar";
                    btnGuardar.Enabled = true;
                    btnAsignar.Enabled = true;
                    txtItem.Text = "";
                    txtCantidad.Text = "0";
                    txtV_oficial.Text = "0";
                    txtV_ofertado.Text = "0";
                    txtC_entrega.Text = "0";
                    txtC_restante.Text = "0";

                    dataGridView1.DataSource = llenarGv().Tables[0];
                    RellenarEstadisticas();
                }
                catch (Exception)
                {

                    MessageBox.Show("Se ha perdido la conexiòn con el servidor, intentelo de nuevo", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        public void RellenarEstadisticas()
        {
            var ds = new DataSet();
            string query = "EXEC SP_RetornarAlimentacion '" + numero_proceso2 + "'";
            ds = bd.consultar(query);

            txtTotalOfertado.Text = "$ "+ds.Tables[0].Rows[0][0].ToString();
            txtPorcentajeEjecutado.Text= ds.Tables[0].Rows[0][1].ToString()+" %";
            txtGanancias.Text= "$ " + ds.Tables[0].Rows[0][2].ToString();
            txtPorcentajeGanancias.Text= ds.Tables[0].Rows[0][3].ToString() + " %";
        }
    }
}
