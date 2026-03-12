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
    public partial class GRVentasProducto: Form
    {
        Conexion DB_CONN = new Conexion();
        SqlCommand cm;

        public GRVentasProducto()
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void GRVentasProducto_Load(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("sp_Top10ProductosVendidos", DB_CONN.conPred);
            cm.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            chart1.Series.Clear();

            chart1.Series.Add("Productos");
            chart1.Series["Productos"].ChartType = SeriesChartType.Column;

            chart1.Series["Productos"].XValueMember = "NombreProducto";
            chart1.Series["Productos"].YValueMembers = "TotalVendido";

            chart1.DataSource = dt;
            chart1.DataBind();

            // FORMATO DESPUÉS DE CREAR LA SERIE
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            chart1.Series["Productos"].IsValueShownAsLabel = true;
            chart1.Series["Productos"]["PointWidth"] = "0.6";

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
