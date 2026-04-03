using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predven
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Conexion conPred = new Conexion();
        SqlCommand sc = new SqlCommand();
        Principal Inicio;


        private void Login_Load(object sender, EventArgs e)
        {
            panelLogin.Left = (this.ClientSize.Width - panelLogin.Width) / 2;
            panelLogin.Top = (this.ClientSize.Height - panelLogin.Height) / 2;

            txtUsuario.Text = "Ingrese su usuario";
            txtUsuario.ForeColor = Color.Gray;

            txtContraseña.UseSystemPasswordChar = false;
            txtContraseña.Text = "Ingrese su contraseña";
            txtContraseña.ForeColor = Color.Gray;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //btnAceptar
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;

            if ( this.txtUsuario.Text == "" || this.txtContraseña.Text == "")
            {
                MessageBox.Show("Por favor llena los campos faltantes");
            }
            else
            {
                try
                {
                    sc = new SqlCommand("SELECT Login, Password FROM Usuarios WHERE Login ='" 
                        + txtUsuario.Text + "'AND Password= '" + txtContraseña.Text + "'", conPred.conPred);
                    sc.CommandType = CommandType.Text;
                    SqlDataReader dr = sc.ExecuteReader();
                    if (dr.Read())
                    {
                        Inicio = new Principal();
                        Inicio.usuario = txtUsuario.Text;
                        Inicio.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Datos incorrectos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error" + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Resize(object sender, EventArgs e)
        {
            panelLogin.Left = (this.ClientSize.Width - panelLogin.Width) / 2;
            panelLogin.Top = (this.ClientSize.Height - panelLogin.Height) / 2;
        
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text != "Ingrese su contraseña")
            {
                txtContraseña.UseSystemPasswordChar = !chkMostrar.Checked;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ingrese su usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ingrese su usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Ingrese su contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.UseSystemPasswordChar = false;
                txtContraseña.Text = "Ingrese su contraseña";
                txtContraseña.ForeColor = Color.Gray;
            }
        }
    }
}
