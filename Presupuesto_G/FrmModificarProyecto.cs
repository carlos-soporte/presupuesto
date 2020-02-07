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
    public partial class FrmModificarProyecto : Form
    {
        public string numero_proceso2;
        public string nombre_proyecto2;
        public int presupuesto_proyecto2;
        string descripcion2;
        public FrmModificarProyecto(string numero_proceso,string nombre_proyecto,int presupuesto_proyecto,string descripcion)
        {
            numero_proceso2 = numero_proceso;
            nombre_proyecto2 = nombre_proyecto;
            presupuesto_proyecto2 = presupuesto_proyecto;
            descripcion2 = descripcion;
            InitializeComponent();
        }

        

        private void txtPresupuestoProyecto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreProyecto.Text == "" || txtDescripcion.Text==""||txtPresupuestoProyecto.Text=="")
            {
                MessageBox.Show("campos vacios favor llenarlos todos para continuar");
                return;
            }

            try
            {
                string query = "exec modificar_proyectos '" + numero_proceso2 + "','" + txtNombreProyecto.Text.Trim() + "'," + txtPresupuestoProyecto.Text.Trim() + ",'" + txtDescripcion.Text.Trim() + "'";
                bd.consultar(query);
                MessageBox.Show("datos actualizados  correctamente");
                this.Hide();
                new FrmListarProyectos().Show();
                
            }
            catch (Exception)
            {

                MessageBox.Show("no hay conexion con el servidor");
            }
           
        }

        private void FrmModificarProyecto_Load(object sender, EventArgs e)
        {
            txtNombreProyecto.Text = nombre_proyecto2;
            txtPresupuestoProyecto.Text =presupuesto_proyecto2.ToString();
            txtDescripcion.Text = descripcion2;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
            txtPresupuestoProyecto.Text = "";
            txtNombreProyecto.Text = "";
        }
    }
}
