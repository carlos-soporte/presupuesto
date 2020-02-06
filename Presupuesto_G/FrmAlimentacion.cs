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
            string query = " exec agregar_alimento '" + txtItem.Text + "'," + txtCantidad.Text + ",'" + txtV_oficial.Text + "'," +
                           txtV_ofertado.Text + "','" + txtC_entrega.Text + "','" + txtC_restante.Text + "','" + numero_proceso2 + "'";

            try
            {
                bd.consultar(query);
                MessageBox.Show("items guardados con exito");
                dataGridView1.DataSource = llenarGv();
            }
            catch (Exception)
            {

                MessageBox.Show("error al guardar los items");
            }
        }
    }
}
