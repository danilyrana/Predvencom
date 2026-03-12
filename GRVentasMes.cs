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
    public partial class GRVentasMes: Form
    {
        Conexion DB_CONN = new Conexion();

        public GRVentasMes()
        {
            InitializeComponent();
        }

        private void GRVentasMes_Load(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("sp_VentasPorMes", DB_CONN.conPred);
            cm.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            chart1.Series.Clear();

            chart1.Series.Add("Ventas");
            chart1.Series["Ventas"].ChartType = SeriesChartType.Line;
            chart1.Series["Ventas"].BorderWidth = 3;
            chart1.Series["Ventas"].Color = Color.DarkGreen;

            chart1.Series["Ventas"].XValueMember = "Mes";
            chart1.Series["Ventas"].YValueMembers = "TotalVentas";

            chart1.Series["Ventas"].IsValueShownAsLabel = true;

            chart1.DataSource = dt;
            chart1.DataBind();

            chart1.ChartAreas[0].AxisX.Interval = 1;

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            chart1.Titles.Clear();
            chart1.Titles.Add("Ventas por Mes (Año Actual)");

            chart1.Legends[0].Docking = Docking.Top;

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
    }
}
