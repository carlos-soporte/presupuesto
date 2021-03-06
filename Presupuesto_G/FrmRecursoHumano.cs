﻿using System;
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
        string numero_proceso2;
        string nombre_proyecto2;
        int id_recurso;
        string cargo,n_profesional,observacion;
        int v_oficial, v_ofertado, t_meses;
        int a, b;
       
       
        public FrmRecursoHumano(string numero_proceso,string nombre_proyecto)
        {
            InitializeComponent();
            numero_proceso2 = numero_proceso;
            nombre_proyecto2 = nombre_proyecto;
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
                txtObservaciones.Enabled = true;
                btnGuardar.Enabled = true;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;


            if (btnAsignar.Text == "Asignar")
            {
                string query2="EXEC asignar_pto '"+lbRecursoHumano.Text+"',"+txtPtoOficial.Text+",'"+numero_proceso2+"'";
                try
                {
                    bd.consultar(query2);
                    MessageBox.Show("datos guardados correctamente");
                }
                catch (Exception)
                {

                    MessageBox.Show("no hay conexion con elservidor");
                }
                int c = Convert.ToInt32(txtPtoOficial.Text);
                if (c < 1) 
                {

                    MessageBox.Show("el presupuesto oficial no puede ser 0");
                    return;
                }
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
                string query3 = "EXEC modificar_pto '"+lbRecursoHumano.Text+"'," + txtPtoOficial.Text + ",'"+numero_proceso2+"'";
                try
                {
                    bd.consultar(query3);
                    MessageBox.Show("datos actualizados correctamente");
                }
                catch (Exception)
                {

                    MessageBox.Show("no hay conexion con el servidor");
                }
                
                txtPtoOficial.Enabled = false;
                btnAsignar.Text = "Cambiar";
              
                return;
            }
        }
        //metodo para mostrar los datos de recursos humanos
        public DataSet llenarGv()
        {
            DataSet ds;
            string query = "exec listar_recurso '" + numero_proceso2 + "'";
            ds = bd.consultar(query);
            return ds;
        }
        private void FrmRecursoHumano_Load(object sender, EventArgs e)
        {
            DataSet st;
            string query4 = "EXEC listar_pto '" + lbRecursoHumano.Text + "','"+numero_proceso2+"'";
            st = bd.consultar(query4);
            string validacion;
            try
            {
                 validacion = st.Tables[0].Rows[0][0].ToString();
            }
            catch (Exception)
            {

                validacion = "";
            }
            if (validacion == "")
            {
                
                
                //bloquea los datos al iniciar el programa
                txtCargo.Enabled = false;
                txtNombreProfesional.Enabled = false;
                txtTiempoM.Enabled = false;
                txtVofertado.Enabled = false;
                txtVoficial.Enabled = false;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                txtObservaciones.Enabled = false;
                txtTotalP.Enabled = false;
                txt2.Enabled = false;
                txt3.Enabled = false;
                txt4.Enabled = false;

            }
            else
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnAsignar.Text = "Cambiar";
                txtPtoOficial.Enabled = false;
                
                //metodo para mostrar los datos
               

                dataGridView1.DataSource = llenarGv().Tables[0];
                dataGridView1.Columns[1].HeaderText = "Nombre Profesional";
                dataGridView1.Columns[2].HeaderText = "Tiempo en meses";
                dataGridView1.Columns[3].HeaderText = "Valor Oficial";
                dataGridView1.Columns[4].HeaderText = "Valor Ofertado";
                dataGridView1.Columns[5].HeaderText = "Valor Oficial Total";
                dataGridView1.Columns[6].HeaderText = "Valor Ofertado Total";
                dataGridView1.Columns[7].HeaderText = "Descripcion";
                dataGridView1.Columns[8].HeaderText = "ID";
                dataGridView1.Columns[9].HeaderText = "Numero de proceso";
                
                txtPtoOficial.Text= st.Tables[0].Rows[0][0].ToString();
               
            }
           
           
           
           
        }

        //metodo para solo dejar ingresar numeros
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
                return;
            }
            a = Convert.ToInt32(txtVofertado.Text);
            b = Convert.ToInt32(txtVoficial.Text);
            int c = Convert.ToInt32(txtTiempoM.Text);
            if (c == 0)
            {
                MessageBox.Show("el tiempo en  meses no puede ser 0");
                return;
            }
            if (a < 1) 
            {
                MessageBox.Show("el valor ofertado no puede ser 0");
                return;
            }
            if (b < 1)
            {
                MessageBox.Show("el valor oficial no puede ser 0");
                return;
            }
            if (b < a)
            {
                MessageBox.Show("el valor ofertado no puede ser mayor al valor oficial");
                return;

            }

            string query = "exec agregar_recurso '" + txtCargo.Text + "','" + txtNombreProfesional.Text + "'," + txtTiempoM.Text + "," + txtVoficial.Text + "," + txtVofertado.Text + ",'" + txtObservaciones.Text + "','" + numero_proceso2 + "'";
            try
            {
                MessageBox.Show("Datos guardados correctamente");
                txtCargo.Text = "";
                txtNombreProfesional.Text = "";
                txtObservaciones.Text = "";
                txtTiempoM.Text = "";
                txtVofertado.Text = "";
                txtVoficial.Text = "";
                
                bd.consultar(query);
                dataGridView1.DataSource = llenarGv().Tables[0];
            }
            catch (Exception)
            {

                MessageBox.Show("no hay conexion con el servidor");
            } 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string query5;
            if (id_recurso>0 && numero_proceso2!=null)
            {
                DialogResult respuesta = MessageBox.Show("¿seguro que desea eliminar el proyecto?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (respuesta == DialogResult.Yes)
                {
                    query5 = "exec eliminar_recurso " + id_recurso + ",'"+numero_proceso2+"'";
                    try
                    {
                        bd.consultar(query5);
                        MessageBox.Show("datos borrados correctamente");
                        dataGridView1.DataSource = llenarGv().Tables[0];
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("no hay conexion con el servidor");

                    }

                }
                else if (respuesta == DialogResult.No)
                {

                }
                else if (respuesta == DialogResult.Cancel)
                {
                
                
                }
                  

            }
           
           
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmMenu().Show();
        }

        private void btnMenuItems_Click(object sender, EventArgs e)
        {
            this.Hide();

            new FrmModificarItems(numero_proceso2,nombre_proyecto2).Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (id_recurso>0 && numero_proceso2 != null)
            {
                this.Hide();
                new FrmModificarRecursos(cargo, n_profesional, t_meses, v_oficial, v_ofertado, observacion, numero_proceso2, nombre_proyecto2, id_recurso).Show();
               
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
          
                try
                {
                
                    id_recurso = Convert.ToInt32((dataGridView1.Rows[e.RowIndex].Cells[8].Value));
                    cargo = (string)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    n_profesional = (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                    t_meses = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                    v_oficial = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                    v_ofertado = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                    observacion = (string)dataGridView1.Rows[e.RowIndex].Cells[7].Value;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
                catch (Exception)
                {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                }
            
            
        }
    }
}
