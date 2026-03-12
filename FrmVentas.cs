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
    public partial class FrmVentas: Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        Conexion conPred = new Conexion();
        SqlCommand sc = new SqlCommand();
        Principal Inicio;
        FrmCobrar Cobrar;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void txtCódigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                string codigo = txtCódigo.Text.Trim();

                if (codigo != "")
                {
                    BuscarYAgregarProducto(codigo);
                }

                txtCódigo.Clear();
                txtCódigo.Focus();
            }

        }

        private void BuscarYAgregarProducto(string codigo)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.ConexionBD))
                {
                    con.Open();

                    string sql = @"
                    SELECT 
                        P.CódigoBarras,
                        P.NombreProducto,
                        P.PrecioVenta,
                        P.Existencia,
                        C.NombreCategoria
                    FROM Productos P
                    INNER JOIN Categorias C ON P.CategoriaID = C.CategoriaID
                    WHERE P.CódigoBarras = @código";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@código", codigo);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                string cod = dr["CódigoBarras"].ToString();
                                string nombre = dr["NombreProducto"].ToString();
                                decimal precio = Convert.ToDecimal(dr["PrecioVenta"]);
                                int existencia = Convert.ToInt32(dr["Existencia"]);
                                string categoria = dr["NombreCategoria"].ToString();

                                txtNombre.Text = nombre;
                                txtPrecio.Text = precio.ToString("N2");
                                txtUnidades.Text = existencia.ToString();
                                txtCategoria.Text = categoria;

                                AgregarProductoAlGrid(cod, nombre, precio, existencia);
                            }
                            else
                            {
                                MessageBox.Show("Producto no encontrado.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar producto: " + ex.Message);
            }
        }

        private void AgregarProductoAlGrid(string cod, string nombre, decimal precio, int existencia)
        {
            bool encontrado = false;

            foreach (DataGridViewRow fila in dgvVenta.Rows)
            {
                if (fila.Cells["Código"].Value != null &&
                    fila.Cells["Código"].Value.ToString() == cod)
                {
                    int cantidadActual = Convert.ToInt32(fila.Cells["Cantidad"].Value);

                    if (cantidadActual + 1 > existencia)
                    {
                        MessageBox.Show("No hay suficiente stock.");
                        return;
                    }

                    cantidadActual++;
                    fila.Cells["Cantidad"].Value = cantidadActual;
                    fila.Cells["Importe"].Value = (precio * cantidadActual).ToString("N2");

                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                if (existencia <= 0)
                {
                    MessageBox.Show("Producto sin stock.");
                    return;
                }

                dgvVenta.Rows.Add(cod, nombre, precio.ToString("N2"), 1, precio.ToString("N2"));
            }

            CalcularTotal();
        }

        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow fila in dgvVenta.Rows)
            {
                if (fila.Cells["Importe"].Value != null)
                {
                    total += Convert.ToDecimal(fila.Cells["Importe"].Value);
                }
            }

            lblTotal.Text = total.ToString("N2");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {

            dgvVenta.Columns.Clear();

            dgvVenta.Columns.Add("Código", "Código");
            dgvVenta.Columns.Add("Nombre", "Nombre");
            dgvVenta.Columns.Add("Precio", "Precio");
            dgvVenta.Columns.Add("Cantidad", "Cantidad");
            dgvVenta.Columns.Add("Importe", "Importe");

            txtCódigo.Focus();
            lblTotal.Text = "0.00";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {

            if (dgvVenta.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la venta.");
                return;
            }

            decimal total = Convert.ToDecimal(lblTotal.Text);

            FrmCobrar cobrar = new FrmCobrar(total);
            cobrar.ShowDialog();

            if (cobrar.VentaConfirmada)
            {
                MessageBox.Show("Venta cobrada correctamente.");

                dgvVenta.Rows.Clear();
                txtCódigo.Clear();
                txtNombre.Clear();
                txtPrecio.Clear();
                txtUnidades.Clear();
                txtCategoria.Clear();
                lblTotal.Text = "0.00";
                txtCódigo.Focus();
            }
        }

        private void buscarCliente(Exception ex)
        {
            if (this.txtCódigo.Text == "")
            {
                MessageBox.Show("Por favor llena los campos faltantes: Código de Barras");
            }
            else
            {
                try
                {
                    sc = new SqlCommand("SELECT NombreProducto, PrecioCosto, Existencia, Categoria " +
                        "FROM Productos WHERE CódigoBarras ='" + this.txtCódigo.Text + "'",conPred.conPred);
                    sc.CommandType = CommandType.Text;
                    SqlDataReader dr = sc.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        this.txtNombre.Text = dr["NombreProducto"].ToString();  
                        this.txtPrecio.Text = dr["PrecioCosto"].ToString(); 
                        this.txtUnidades.Text = dr["Existencia"].ToString();  
                        this.txtCategoria.Text = dr["Categoria"].ToString();  
                        dr.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el producto con el código de barras proporcionado.");
                    }
                }
                catch 
                {
                    MessageBox.Show("Error al buscar el cliente: " + ex.Message);
                }
            }
        }
    }
}

    
