using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predven
{
    public partial class FrmCobrar : Form
    {

        private decimal totalVenta = 0;
        private string metodoPago = "";

        public bool VentaConfirmada { get; private set; } = false;
        public decimal MontoRecibido { get; private set; } = 0;
        public decimal Propina { get; private set; } = 0;
        public decimal Cambio { get; private set; } = 0;
        public FrmCobrar(decimal total)
        {
            InitializeComponent();
            totalVenta = total;
        }

        FrmVentas Ventas = new FrmVentas(); 

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void FrmCobrar_Load(object sender, EventArgs e)
        {
            lblTotalVenta.Text = totalVenta.ToString("N2");

            pnlEfectivo.Visible = false;
            pnlTarjeta.Visible = false;
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            metodoPago = "EFECTIVO";
            pnlEfectivo.Visible = true;
            pnlTarjeta.Visible = false;
        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            metodoPago = "TARJETA";
            pnlEfectivo.Visible = false;
            pnlTarjeta.Visible = true;

        }

        private void txtRecibido_TextChanged(object sender, EventArgs e)
        {
            CalcularCambio();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CalcularCambio();
        }


        private void CalcularCambio()
        {
            decimal recibido = 0;
            decimal propina = 0;

            decimal.TryParse(txtRecibido.Text, out recibido);
            decimal.TryParse(txtPropina.Text, out propina);

            decimal totalConPropina = totalVenta + propina;
            decimal cambio = recibido - totalConPropina;

            lblCambio.Text = cambio.ToString("N2");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (metodoPago == "")
            {
                MessageBox.Show("Selecciona un método de pago.");
                return;
            }

            if (metodoPago == "EFECTIVO")
            {
                decimal recibido = 0;
                decimal propina = 0;

                if (!decimal.TryParse(txtRecibido.Text, out recibido))
                {
                    MessageBox.Show("Ingresa una cantidad válida en efectivo.");
                    return;
                }

                decimal.TryParse(txtPropina.Text, out propina);

                decimal totalConPropina = totalVenta + propina;

                if (recibido < totalConPropina)
                {
                    MessageBox.Show("El efectivo recibido no alcanza para cubrir el total.");
                    return;
                }

                MontoRecibido = recibido;
                Propina = propina;
                Cambio = recibido - totalConPropina;
            }

            if (metodoPago == "TARJETA")
            {
                if (txtReferenciaTarjeta.Text.Trim() == "")
                {
                    MessageBox.Show("Ingresa la referencia de la tarjeta.");
                    return;
                }
            }

            VentaConfirmada = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            VentaConfirmada = false;
            this.Close();
        }

        private void txtReferenciaTarjeta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Ventas.Show();
            this.Hide();
        }
    }
}


    
    