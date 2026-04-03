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
    public partial class Principal: Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        FrmVentas Ventas;
        Productos Productos;
        FrmProveedores Proveedores;
        FrmReporte Reportes;
        public string usuario;

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas = new FrmVentas();
            Ventas.Show();
            this.Hide();

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {

            Productos = new Productos();
            Productos.Show();
            this.Hide();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedores = new FrmProveedores();
            Proveedores.Show();
            this.Hide();

        }
        FrmGraficas Graficas;
        private void btnGraficas_Click(object sender, EventArgs e)
        {
            Graficas = new FrmGraficas();
           Graficas.Show();
            this.Hide();

        }
        FrmPrediccion Prediccion;
        private void btnPrediccion_Click(object sender, EventArgs e)
        {
            Prediccion = new FrmPrediccion();
            Prediccion.Show();
            this.Hide();
        }
        FrmAyuda Ayuda;
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Ayuda = new FrmAyuda();
            Ayuda.Show();
            this.Hide();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes = new FrmReporte();
            Reportes.Show();
            this.Hide();    

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            panelMenu.Left = (this.ClientSize.Width - panelMenu.Width) / 2;
            panelMenu.Top = (this.ClientSize.Height - panelMenu.Height) / 2;

   
            btnVentas.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnProveedores.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnGraficas.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnReportes.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnPrediccion.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnAyuda.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;

            lblBienvenida.Text = $"Bienvenido 👋 {usuario}";

            btnVentas.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnProveedores.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnGraficas.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnReportes.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnPrediccion.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnAyuda.FlatAppearance.MouseOverBackColor = Color.Gray;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            panelMenu.Left = (this.ClientSize.Width - panelMenu.Width) / 2;
            panelMenu.Top = (this.ClientSize.Height - panelMenu.Height) / 2;
        }
    }
}
