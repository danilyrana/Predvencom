using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predven
{
    public partial class FrmAyuda: Form
    {
        public FrmAyuda()
        {
            InitializeComponent();
        }

        private void btnSoporte_Click(object sender, EventArgs e)
        {
            string correo = "soporte_predven@gmail.com";
            string asunto = "Soporte Sistema Predven";
            string mensaje = "Hola, necesito ayuda con el sistema.";

            string url = $"https://mail.google.com/mail/?view=cm&to={correo}&su={asunto}&body={mensaje}";

            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });

        }
        Principal Principal;
        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            Principal = new Principal();
            Principal.Show();
            this.Hide();
        }
    }
}
