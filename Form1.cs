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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //btnAceptar
        private void button1_Click(object sender, EventArgs e)
        {
            if( this.txtUsuario.Text == "" || this.txtContraseña.Text == "")
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
    }
}
