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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtContraseña.Text = "";
            txtUsuario.Text = "";
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text.Trim()=="" || txtContraseña.Text.Trim() == "")
            {
                MessageBox.Show("faltan datos por ingresar");
                return;
            }
            try
            {
                string query= "exec validar_usuario '"+txtUsuario.Text.Trim()+"','"+txtContraseña.Text.Trim()+"'";
                DataSet ds = bd.consultar(query);
                string usuario = ds.Tables[0].Rows[0][0].ToString().Trim();
                string contraseña = ds.Tables[0].Rows[0][1].ToString().Trim();
                if (txtUsuario.Text.Trim() == usuario && txtContraseña.Text.Trim() == contraseña)
                {
                    MessageBox.Show("datos ingresados correctamente");
                    this.Hide();
                    new FrmMenu().Show();
                }
                else
                {
                    MessageBox.Show("usuario y/o contraseña erròneos,vuelva a intentarlo");
                    txtContraseña.Text = "";
                    txtUsuario.Text = "";
                    return;
                }
                }
            catch (Exception)
            {
                MessageBox.Show("error al conectarce con el servidor");
            }
            
                    
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
