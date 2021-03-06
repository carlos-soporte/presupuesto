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
    public partial class FrmListarProyectos : Form
    {
        public string numero_proceso;
        public string descripcion;
        public string nombre_proyecto;
        public int presupuesto_proyecto;
        public FrmListarProyectos()
        {
            InitializeComponent();
        }

        public DataSet llenarGv()
        {
            DataSet ds;
            string query = "exec listar_presupuesto ";
            ds = bd.consultar(query);
            return ds;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(rdbNombreProyecto.Checked==false && rdbNumeroProceso.Checked == false)
            {
                MessageBox.Show("no hay ningun filtro seleccionado,favor seleccionar uno");
            }
            DataSet ds;
            if (string.IsNullOrEmpty(txtFiltrar.Text.Trim()) == false)
            {
                try
                {
                    if (rdbNombreProyecto.Checked == true)
                    {
                        string query = "exec listar_nombre '" + txtFiltrar.Text.Trim() + "'";
                        ds = bd.consultar(query);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else if (rdbNumeroProceso.Checked == true)
                    {
                        string query = "exec listar_proceso  '" + txtFiltrar.Text.Trim() + "'";
                        ds=bd.consultar(query);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("no hay conexion con el servidor");
                }
            }          
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmMenu().Show();
        }

        private void FrmListarProyectos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenarGv().Tables[0];
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenarGv().Tables[0];
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (numero_proceso==null)
            {
                MessageBox.Show("seleccione un proyecto porfavor");
            }
            else
            {
                this.Hide();
                new FrmModificarItems(numero_proceso, nombre_proyecto).Show();               
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string query2;
            if (numero_proceso!=null )
            {
                DialogResult respuesta = MessageBox.Show("¿seguro que desea eliminar el proyecto?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (respuesta == DialogResult.Yes)
                {
                    query2 = "exec eliminar_proyectos  '" + numero_proceso + "'";
                    try
                    {
                       
                        bd.consultar(query2);
                        MessageBox.Show("datos eliminados correctamente ");
                        dataGridView1.DataSource = llenarGv().Tables[0];
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("no hay conexion con elservidor ");
                    }
                    
                }else if (respuesta == DialogResult.No)
                {

                }else if (respuesta == DialogResult.Cancel)
                {

                }
            }
            else
            {
                MessageBox.Show("selecion un proyecto porfavor");
            }
        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                numero_proceso = (string)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                nombre_proyecto = (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                presupuesto_proyecto = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                descripcion = (string)dataGridView1.Rows[e.RowIndex].Cells[3].Value;
            }
            catch (Exception)
            {
                MessageBox.Show("Ningun proyecto seleccionado");        
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (numero_proceso ==null)
            {
                MessageBox.Show("selecion un proyecto porfavor");

            }
            else
            {
                this.Hide();
                new FrmModificarProyecto(numero_proceso, nombre_proyecto, presupuesto_proyecto, descripcion).Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdiccionar_Click(object sender, EventArgs e)
        {
            if (numero_proceso == null)
            {
                MessageBox.Show("selecion un proyecto porfavor");
            }
            else
            {
                this.Hide();
                new FrmAdiccionar().Show();
            }
        }
    }
}
