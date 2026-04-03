using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;

namespace Predven
{
    public partial class FrmReporte: Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        internal CrystalDecisions.CrystalReports.Engine.ReportDocument ReporteExporta;


        private void FrmReporte_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = ReporteExporta; 
        }
    }
}
