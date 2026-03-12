using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Predven
{
   
    class Conexion
    {
        public SqlConnection conPred;

    public Conexion()
        {
            try
            {
                conPred = new SqlConnection(ConfigurationManager.ConnectionStrings
                    ["Predven.Properties.Settings.ConexionBD"].ConnectionString);
                conPred.Open();
            }
           catch(Exception ex)
            {
                MessageBox.Show("No se pudo conectar a la base de datos" + ex.ToString());
            }
        }
     
    }

}
