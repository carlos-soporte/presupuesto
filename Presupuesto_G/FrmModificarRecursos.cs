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
    public partial class FrmModificarRecursos : Form
    {

        string nombre_proyecto2,numero_proceso2;
        int id_recurso2;
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            new FrmRecursoHumano(numero_proceso2,nombre_proyecto2).Show();
        }

        public FrmModificarRecursos(string cargo,string n_profesional,int t_meses,int v_oficial,int v_ofertado,string observacion,string numero_proceso,string nombre_proyecto,int id_recurso)
        {
            InitializeComponent();
            txtCargo.Text = cargo;
            txtNProfesional.Text = n_profesional;
            txtTmeses.Text = t_meses.ToString();
            txtVoficial.Text = v_oficial.ToString();
            txtVofertado.Text = v_ofertado.ToString();
            txtObservaciones.Text=observacion;
            nombre_proyecto2 = nombre_proyecto;
            numero_proceso2 = numero_proceso;
            id_recurso2 = id_recurso;
           
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(txtVoficial.Text);
            b = Convert.ToInt32(txtVofertado.Text);
            if (a < b) 
            {
                MessageBox.Show("el valor oficial no puede ser menor al valor ofertado");
                return;
            }

            string query2 = "exec modificar_recurso '" + txtCargo.Text + "','" + txtNProfesional.Text + "'," + txtTmeses.Text + "," + txtVoficial.Text + "," + txtVofertado.Text + ",'" + txtObservaciones.Text + "','" + numero_proceso2 + "',"+id_recurso2;
            try
            {
                bd.consultar(query2);
                MessageBox.Show("datos actualizados correctamente");
                this.Hide();
                new FrmRecursoHumano(numero_proceso2,nombre_proyecto2).Show();
            }
            catch (Exception)
            {

                MessageBox.Show("no hay conexion con el servidor");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCargo.Text = "";
            txtNProfesional.Text = "";
            txtTmeses.Text = "";
            txtVoficial.Text = "";
            txtVofertado.Text = "";
            txtObservaciones.Text = "";
        }

        private void FrmModificarRecursos_Load(object sender, EventArgs e)
        {

        }
    }
}
