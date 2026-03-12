using System;
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
    public partial class FrmPrediccion: Form
    {
        Conexion conPred = new Conexion();
        Conexion DB_CONN = new Conexion();
        public FrmPrediccion()
        {
            InitializeComponent();
        }

        private void FrmPrediccion_Load(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("sp_PrediccionInventario", DB_CONN.conPred);
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@Busqueda", "");

            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("sp_PrediccionInventario", DB_CONN.conPred);
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@Busqueda", txtBuscar.Text);

            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FrmPrediccion_Load(sender, e);
        }
        Principal Principal;
        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            Principal = new Principal();
            Principal.Show();
            this.Hide();
        }
    }
}
