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
    public partial class FrmGraficas: Form
    {
        public FrmGraficas()
        {
            InitializeComponent();
        }
        GRVentasProducto VentasProducto;

        private void btnGrVentasProducto_Click(object sender, EventArgs e)
        {
            VentasProducto = new GRVentasProducto();
            VentasProducto.Show();
            this.Hide();

        }
        GRVentasMes VentasMes;
        private void btnGrVentasporMes_Click(object sender, EventArgs e)
        {
            VentasMes = new GRVentasMes();
            VentasMes.Show();
            this.Hide();

        }
        GRInventario Inventario;
        private void btnGrInventario_Click(object sender, EventArgs e)
        {
            Inventario = new GRInventario();
            Inventario.Show();
            this.Hide();

        }
        GRPrediccion Prediccion;
        private void btnGrPrediccion_Click(object sender, EventArgs e)
        {
            Prediccion = new GRPrediccion();
            Prediccion.Show();
            this.Hide();

        }
        Principal InicioPrincipal;
        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            InicioPrincipal = new Principal();
            InicioPrincipal.Show();
            this.Hide();

        }
    }
}
