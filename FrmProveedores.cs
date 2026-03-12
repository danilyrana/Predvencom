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
    public partial class FrmProveedores: Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        Conexion conPred = new Conexion();
        SqlCommand cm = new SqlCommand();
        Principal Inicio;

        DataTable dt;

        public DataTable GetData(string consulta)
        {
            cm = new SqlCommand(consulta, conPred.conPred);
            SqlDataAdapter adp = new SqlDataAdapter(cm);
            dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            this.dataGridViewProveedores.DataSource = GetData(" EXEC sp_BuscarProveedor");

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewProveedores.Rows.Count > 0)
            {
                this.txtIDProveedor.Text = this.dataGridViewProveedores.SelectedRows[0].Cells[0].Value.ToString();
                this.txtNombreProveedor.Text = this.dataGridViewProveedores.SelectedRows[0].Cells[1].Value.ToString();
                this.txtNombreContactoPrv.Text = this.dataGridViewProveedores.SelectedRows[0].Cells[2].Value.ToString();
                this.txtNumeroContactoPrv.Text = this.dataGridViewProveedores.SelectedRows[0].Cells[3].Value.ToString();
                this.txtCorreoPrv.Text = this.dataGridViewProveedores.SelectedRows[0].Cells[4].Value.ToString();
                this.txtDireccionPrv.Text = this.dataGridViewProveedores.SelectedRows[0].Cells[5].Value.ToString();

                this.txtIDProveedor.Enabled = false;
                this.btnAgregar.Enabled = false;
                this.btnEditar.Enabled = true;

                }
            }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.txtIDProveedor.Text == "" || this.txtNombreProveedor.Text == "")
            {
                MessageBox.Show("Por favor llena los campos faltantes: ID Proveedor, Nombre ");
            }
            else
            {
                string[] partes = txtNombreContactoPrv.Text.Split(' ');

                string nombre = partes.Length > 0 ? partes[0] : "";
                string apellidoP = partes.Length > 1 ? partes[1] : "";
                string apellidoM = partes.Length > 2 ? partes[2] : "";
                try
                {
                    String st = "UPDATE Proveedores SET " +
                   "NombreProveedor='" + txtNombreProveedor.Text + "', " +
                   "NombreContacto='" + nombre + "', " +
                   "ApellidoPaterno='" + apellidoP + "', " +
                   "ApellidoMaterno='" + apellidoM + "', " +
                   "Telefono1='" + txtNumeroContactoPrv.Text + "', " +
                   "Correo='" + txtCorreoPrv.Text + "' " +
                   "WHERE ProveedorID=" + txtIDProveedor.Text;

                    cm = new SqlCommand(st, conPred.conPred);
                    cm.CommandType = CommandType.Text;
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Proveedor actualizado correctamente.");

                    this.btnCancelar.PerformClick();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ha ocurrido un error " + ex.Message);
                }
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtIDProveedor.Text == "" & this.txtNombreProveedor.Text == "")
            {
                MessageBox.Show("Por favor llena los campos faltantes: Id Proveedor, Nombre");
            }
            else
            {
                try
                {
                    cm = new SqlCommand("sp_BuscarProveedor", conPred.conPred);
                    cm.CommandType = CommandType.StoredProcedure;

                    SqlParameter paramID = new SqlParameter("@IDProveedor", SqlDbType.Int);

                    if (string.IsNullOrEmpty(txtIDProveedor.Text))
                        paramID.Value = DBNull.Value;
                    else
                        paramID.Value = Convert.ToInt32(txtIDProveedor.Text);

                    cm.Parameters.Add(paramID);

                    SqlParameter paramNombre = new SqlParameter("@Nombre", SqlDbType.NVarChar, 100);

                    if (string.IsNullOrEmpty(txtNombreProveedor.Text))
                        paramNombre.Value = DBNull.Value;
                    else
                        paramNombre.Value = txtNombreProveedor.Text;

                    cm.Parameters.Add(paramNombre);

                    SqlDataReader dr = cm.ExecuteReader();

                    if (dr.Read())
                    {
                        txtIDProveedor.Text = dr["IDProveedor"].ToString();
                        txtNombreProveedor.Text = dr["Nombre"].ToString();
                        txtNombreContactoPrv.Text = dr["NombreContacto"].ToString();
                        txtNumeroContactoPrv.Text = dr["NumeroContacto"].ToString();
                        txtCorreoPrv.Text = dr["Correo1"].ToString();
                        txtDireccionPrv.Text = dr["Direccion"].ToString();

                        txtIDProveedor.Enabled = false;
                        txtNombreProveedor.Enabled = false;
                        btnAgregar.Enabled = false;
                        btnEditar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Proveedor no existe.");
                        txtIDProveedor.Enabled = true;
                        btnAgregar.Enabled = true;
                        btnEditar.Enabled = false;
                    }

                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                }
            
                }
            }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            Inicio = new Principal();
            Inicio.Show();
            this.Hide();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtIDProveedor.Enabled = true;
            this.txtNombreProveedor.Enabled = true;
            this.btnAgregar.Enabled = true;
            this.btnEditar.Enabled = false;
            this.txtIDProveedor.Text = string.Empty;
            this.txtNombreProveedor.Text = string.Empty;
            this.txtNombreContactoPrv.Text = string.Empty;
            this.txtNumeroContactoPrv.Text = string.Empty;
            this.txtCorreoPrv.Text = string.Empty;
            this.txtDireccionPrv.Text = string.Empty;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreProveedor.Text == "")
            {
                MessageBox.Show("Falta el nombre del proveedor");
                return;
            }

            string[] partes = txtNombreContactoPrv.Text.Split(' ');

            string nombre = partes.Length > 0 ? partes[0] : "";
            string apellidoP = partes.Length > 1 ? partes[1] : "";
            string apellidoM = partes.Length > 2 ? partes[2] : "";

            try
            {
                string st = "INSERT INTO Proveedores " +
                            "(NombreProveedor, NombreContacto, ApellidoPaterno, ApellidoMaterno, Teléfono1, Correo1) " +
                            "VALUES ('" + txtNombreProveedor.Text + "', '" +
                                         nombre + "', '" +
                                         apellidoP + "', '" +
                                         apellidoM + "', '" +
                                         txtNumeroContactoPrv.Text + "', '" +
                                         txtCorreoPrv.Text + "')";

                cm = new SqlCommand(st, conPred.conPred);
                cm.ExecuteNonQuery();

                MessageBox.Show("Proveedor agregado correctamente.");
                btnCancelar.PerformClick();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
