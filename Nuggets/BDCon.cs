using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Nuggets
{
    public class BDCon
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=nuggets; Userid=root; password='';");
            conectar.Open();
            return conectar;
        }
    }
}
