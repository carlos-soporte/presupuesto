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
        string numero_proceso2;
        string nombre_proyecto2;
        int id_recurso;
        string cargo,n_profesional,observacion;
        int v_oficial, v_ofertado, t_meses;

       
       
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
        //metodo para mostrar los datos de recursos humanos
        public DataSet llenarGv()
        {
            DataSet ds;
            string query="exec listar_recurso '"+numero_proceso2+"'";
            ds = bd.consultar(query);
            return ds;

        }

        private void FrmRecursoHumano_Load(object sender, EventArgs e)
        {
            //metodo para mostrar los datos
            dataGridView1.DataSource = llenarGv().Tables[0];
            //bloquea los datos al iniciar el programa
            txtCargo.Enabled = false;
            txtNombreProfesional.Enabled = false;
            txtTiempoM.Enabled = false;
            txtVofertado.Enabled = false;
            txtVoficial.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            txt1.Enabled = false;
            txt2.Enabled = false;
            txt3.Enabled = false;
            txt4.Enabled = false;
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

            if (numero_proceso2 == null)
            {
                MessageBox.Show("seleccione un item porfavor");
            }
            else
            {
                this.Hide();
                new FrmModificarRecursos(cargo,n_profesional,t_meses,v_oficial,v_ofertado,observacion,numero_proceso2,nombre_proyecto2,id_recurso).Show();

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_recurso = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                cargo=(string)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                n_profesional = (string)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
                t_meses = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                v_oficial = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                v_ofertado= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                observacion=(string)dataGridView1.Rows[e.RowIndex].Cells[6].Value;
            }
            catch (Exception)
            {

                MessageBox.Show("no hay items seleccionados");
            }
        }
    }
}
