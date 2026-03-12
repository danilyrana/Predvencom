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
using System.Windows.Forms.DataVisualization.Charting;

namespace Predven
{
    public partial class GRInventario: Form
    {
        Conexion DB_CONN = new Conexion();
        public GRInventario()
        {
            InitializeComponent();
        }
        FrmGraficas Graficas;
        private void button2_Click(object sender, EventArgs e)
        {
            Graficas = new FrmGraficas();
            Graficas.Show();
            this.Hide();

        }
        Principal InicioPrincipal;
        private void button1_Click(object sender, EventArgs e)
        {
            InicioPrincipal = new Principal();
            InicioPrincipal.Show();
            this.Hide();

        }

        private void GRInventario_Load(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("sp_InventarioComparacion", DB_CONN.conPred);
            cm.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            chart1.Series.Clear();

            // Serie Existencia
            chart1.Series.Add("Existencia");
            chart1.Series["Existencia"].ChartType = SeriesChartType.Column;
            chart1.Series["Existencia"].Color = Color.SteelBlue;
            chart1.Series["Existencia"].XValueMember = "NombreProducto";
            chart1.Series["Existencia"].YValueMembers = "Existencia";
            chart1.Series["Existencia"].IsValueShownAsLabel = true;

            // Serie Inventario mínimo
            chart1.Series.Add("InventarioMinimo");
            chart1.Series["InventarioMinimo"].ChartType = SeriesChartType.Column;
            chart1.Series["InventarioMinimo"].Color = Color.OrangeRed;
            chart1.Series["InventarioMinimo"].XValueMember = "NombreProducto";
            chart1.Series["InventarioMinimo"].YValueMembers = "InventarioMinimo";
            chart1.Series["InventarioMinimo"].IsValueShownAsLabel = true;

            chart1.DataSource = dt;
            chart1.DataBind();

            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            chart1.Titles.Clear();
            chart1.Titles.Add("Productos Bajo Inventario Mínimo");

            chart1.Legends[0].Docking = Docking.Top;

        }
    }
}
