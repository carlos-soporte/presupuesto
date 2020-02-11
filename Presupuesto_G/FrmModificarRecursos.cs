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
        string cargo2,n_profesional2,observacion2,numero_proceso2,nombre_proyecto2;
        int t_meses2, v_oficial2, v_ofertado2;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            new FrmRecursoHumano(numero_proceso2,nombre_proyecto2).Show();
        }

        public FrmModificarRecursos(string cargo,string n_profesional,int t_meses,int v_oficial,int v_ofertado,string observacion,string numero_proceso)
        {
            InitializeComponent();
            cargo2 = cargo;
            n_profesional2 = n_profesional;
            t_meses2 = t_meses;
            v_oficial2 = v_oficial;
            v_ofertado2 = v_ofertado;
            numero_proceso2 = numero_proceso;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string query2 = "exec modificar_recurso '" + txtCargo.Text + "','" + txtNProfesional.Text + "'," + txtTmeses.Text + "," + txtVoficial.Text + "," + txtVofertado.Text + ",'" + txtObservaciones.Text + "','" + numero_proceso2 + "'";
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

        private void FrmModificarRecursos_Load(object sender, EventArgs e)
        {

        }
    }
}
