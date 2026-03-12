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
    public partial class GRPrediccion: Form
    {
        Conexion DB_CONN = new Conexion();
        public GRPrediccion()
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

        private void GRPrediccion_Load(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("sp_PrediccionProductos", DB_CONN.conPred);
            cm.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            chart1.Series.Clear();

            // Serie ventas recientes
            chart1.Series.Add("VentasRecientes");
            chart1.Series["VentasRecientes"].ChartType = SeriesChartType.Column;
            chart1.Series["VentasRecientes"].Color = Color.SteelBlue;
            chart1.Series["VentasRecientes"].XValueMember = "NombreProducto";
            chart1.Series["VentasRecientes"].YValueMembers = "VentasRecientes";
            chart1.Series["VentasRecientes"].IsValueShownAsLabel = true;

            // Serie predicción
            chart1.Series.Add("Prediccion");
            chart1.Series["Prediccion"].ChartType = SeriesChartType.Column;
            chart1.Series["Prediccion"].Color = Color.OrangeRed;
            chart1.Series["Prediccion"].XValueMember = "NombreProducto";
            chart1.Series["Prediccion"].YValueMembers = "Prediccion";
            chart1.Series["Prediccion"].IsValueShownAsLabel = true;

            chart1.DataSource = dt;
            chart1.DataBind();

            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            chart1.Titles.Clear();
            chart1.Titles.Add("Predicción de Demanda por Producto");

            chart1.Legends[0].Docking = Docking.Top;

        }
    }
}
