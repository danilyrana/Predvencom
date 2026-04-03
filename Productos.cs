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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        Conexion conPred = new Conexion();
        SqlCommand cm = new SqlCommand();
        Principal Inicio;

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void CargarProductos()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlCommand cmd = new SqlCommand("BuscarProductos", conPred.conPred))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CódigoBarras", DBNull.Value);
                    cmd.Parameters.AddWithValue("@NombreProducto", DBNull.Value);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }
        private void btnCancelarP_Click(object sender, EventArgs e)
        {

            txtNombreP.Enabled = true;
            txtCódigoP.Enabled = true;
            btnAgregarP.Enabled = true;
            btnEditarP.Enabled = false;

            txtCódigoP.Text = string.Empty;
            txtNombreP.Text = string.Empty;
            txtCategoriaP.Text = string.Empty;
            txtPrecioCP.Text = string.Empty;
            txtPrecioMP.Text = string.Empty;
            txtInvMaxP.Text = string.Empty;
            txtUnidadesP.Text = string.Empty;
            txtPrecioVP.Text = string.Empty;
            txtInvMinP.Text = string.Empty;
            txtDiscontinuoP.Text = string.Empty;

            CargarProductos();
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtCódigoP.Text == "" && this.txtNombreP.Text == "")
            {
                MessageBox.Show("Por favor llena al menos un campo: Código o Nombre del Producto.");
                return;
            }

            DataTable dt = new DataTable();

            try
            {
                using (SqlCommand cmd = new SqlCommand("BuscarProductos", conPred.conPred))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (string.IsNullOrWhiteSpace(txtCódigoP.Text))
                        cmd.Parameters.AddWithValue("@CódigoBarras", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@CódigoBarras", txtCódigoP.Text.Trim());

                    if (string.IsNullOrWhiteSpace(txtNombreP.Text))
                        cmd.Parameters.AddWithValue("@NombreProducto", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@NombreProducto", txtNombreP.Text.Trim());

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;

                    txtCódigoP.Text = dt.Rows[0]["CódigoBarras"].ToString();
                    txtNombreP.Text = dt.Rows[0]["NombreProducto"].ToString();
                    txtCategoriaP.Text = dt.Rows[0]["NombreCategoria"].ToString();
                    txtUnidadesP.Text = dt.Rows[0]["Existencia"].ToString();
                    txtPrecioCP.Text = dt.Rows[0]["PrecioCosto"].ToString();
                    txtPrecioVP.Text = dt.Rows[0]["PrecioVenta"].ToString();
                    txtPrecioMP.Text = dt.Rows[0]["PrecioMayoreo"].ToString();
                    txtInvMinP.Text = dt.Rows[0]["InventarioMinimo"].ToString();
                    txtInvMaxP.Text = dt.Rows[0]["InventarioMaximo"].ToString();
                    txtDiscontinuoP.Text = dt.Rows[0]["Discontinuo"].ToString();

                    txtCódigoP.Enabled = false;
                    btnAgregarP.Enabled = false;
                    btnEditarP.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se encontraron productos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        public DataTable GetData(string procedureName)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand(procedureName, conPred.conPred))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos: " + ex.Message);
            }
            return dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.DataSource = GetData("BuscarProductos");
        }

        private void btnMenuP_Click(object sender, EventArgs e)
        {
            Inicio = new Principal();
            Inicio.Show();
            this.Hide();
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            if (txtCódigoP.Text == "" || txtNombreP.Text == "" || txtCategoriaP.Text == "")
            {
                MessageBox.Show("Por favor llena los campos faltantes: Código del Producto, Nombre del Producto, Categoría");
                return;
            }

            try
            {
                string st = @"
                INSERT INTO Productos
                (CódigoBarras, NombreProducto, CategoriaID, PrecioCosto, PrecioVenta, PrecioMayoreo, Existencia, InventarioMinimo, InventarioMaximo, Discontinuo)
                VALUES
                (@CódigoBarras, @NombreProducto, 
                (SELECT CategoriaID FROM Categorias WHERE NombreCategoria = @NombreCategoria),
                @PrecioCosto, @PrecioVenta, @PrecioMayoreo, @Existencia, @InventarioMinimo, @InventarioMaximo, @Discontinuo)";

                using (SqlCommand cmd = new SqlCommand(st, conPred.conPred))
                {
                    cmd.Parameters.AddWithValue("@CódigoBarras", txtCódigoP.Text.Trim());
                    cmd.Parameters.AddWithValue("@NombreProducto", txtNombreP.Text.Trim());
                    cmd.Parameters.AddWithValue("@NombreCategoria", txtCategoriaP.Text.Trim());
                    cmd.Parameters.AddWithValue("@PrecioCosto", Convert.ToDecimal(txtPrecioCP.Text));
                    cmd.Parameters.AddWithValue("@PrecioVenta", Convert.ToDecimal(txtPrecioVP.Text));
                    cmd.Parameters.AddWithValue("@PrecioMayoreo", Convert.ToDecimal(txtPrecioMP.Text));
                    cmd.Parameters.AddWithValue("@Existencia", Convert.ToInt32(txtUnidadesP.Text));
                    cmd.Parameters.AddWithValue("@InventarioMinimo", Convert.ToInt32(txtInvMinP.Text));
                    cmd.Parameters.AddWithValue("@InventarioMaximo", Convert.ToInt32(txtInvMaxP.Text));
                    cmd.Parameters.AddWithValue("@Discontinuo", txtDiscontinuoP.Text.Trim());

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Producto agregado correctamente.");
                btnCancelarP.PerformClick();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de formato en los datos: " + ex.Message);
            }
        }

   
        private void btnEditarP_Click(object sender, EventArgs e)
        {

            if (txtCódigoP.Text == "" || txtNombreP.Text == "" || txtCategoriaP.Text == "")
            {
                MessageBox.Show("Por favor llena los campos faltantes: Código del Producto, Nombre del Producto, Categoría");
                return;
            }

            try
            {
                string st = @"
                UPDATE Productos
                SET
                    NombreProducto = @NombreProducto,
                    CategoriaID = (SELECT CategoriaID FROM Categorias WHERE NombreCategoria = @NombreCategoria),
                    PrecioCosto = @PrecioCosto,
                    PrecioVenta = @PrecioVenta,
                    PrecioMayoreo = @PrecioMayoreo,
                    Existencia = @Existencia,
                    InventarioMinimo = @InventarioMinimo,
                    InventarioMaximo = @InventarioMaximo,
                    Discontinuo = @Discontinuo
                WHERE CódigoBarras = @CódigoBarras";

                using (SqlCommand cmd = new SqlCommand(st, conPred.conPred))
                {
                    cmd.Parameters.AddWithValue("@CódigoBarras", txtCódigoP.Text.Trim());
                    cmd.Parameters.AddWithValue("@NombreProducto", txtNombreP.Text.Trim());
                    cmd.Parameters.AddWithValue("@NombreCategoria", txtCategoriaP.Text.Trim());
                    cmd.Parameters.AddWithValue("@PrecioCosto", Convert.ToDecimal(txtPrecioCP.Text));
                    cmd.Parameters.AddWithValue("@PrecioVenta", Convert.ToDecimal(txtPrecioVP.Text));
                    cmd.Parameters.AddWithValue("@PrecioMayoreo", Convert.ToDecimal(txtPrecioMP.Text));
                    cmd.Parameters.AddWithValue("@Existencia", Convert.ToInt32(txtUnidadesP.Text));
                    cmd.Parameters.AddWithValue("@InventarioMinimo", Convert.ToInt32(txtInvMinP.Text));
                    cmd.Parameters.AddWithValue("@InventarioMaximo", Convert.ToInt32(txtInvMaxP.Text));
                    cmd.Parameters.AddWithValue("@Discontinuo", txtDiscontinuoP.Text.Trim());

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Producto actualizado correctamente.");
                btnCancelarP.PerformClick();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de formato en los datos: " + ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Productos_Load(object sender, EventArgs e)
        {
            CargarProductos();
            btnEditarP.Enabled = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                txtCódigoP.Text = fila.Cells["CódigoBarras"].Value.ToString();
                txtNombreP.Text = fila.Cells["NombreProducto"].Value.ToString();
                txtCategoriaP.Text = fila.Cells["NombreCategoria"].Value.ToString();
                txtUnidadesP.Text = fila.Cells["Existencia"].Value.ToString();
                txtPrecioCP.Text = fila.Cells["PrecioCosto"].Value.ToString();
                txtPrecioVP.Text = fila.Cells["PrecioVenta"].Value.ToString();
                txtPrecioMP.Text = fila.Cells["PrecioMayoreo"].Value.ToString();
                txtInvMinP.Text = fila.Cells["InventarioMinimo"].Value.ToString();
                txtInvMaxP.Text = fila.Cells["InventarioMaximo"].Value.ToString();
                txtDiscontinuoP.Text = fila.Cells["Discontinuo"].Value.ToString();

                txtCódigoP.Enabled = false;
                btnAgregarP.Enabled = false;
                btnEditarP.Enabled = true;
            }
        }

        private void txtPrecioCP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}