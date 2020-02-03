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
    public partial class FrmListarProyectos : Form
    {
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
    }
}
