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

            var serie = chart1.Series.Add("Ventas");
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            serie.Color = System.Drawing.Color.SteelBlue;
            serie.IsValueShownAsLabel = true;

            chart1.DataSource = dt;
            serie.XValueMember = "Mes";
            serie.YValueMembers = "TotalVentas";

            chart1.DataBind();


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
