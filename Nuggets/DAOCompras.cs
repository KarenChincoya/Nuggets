using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuggets
{
    class DAOCompras
    {
        //Data Access Object del objeto compra
        public static int create(Compra c)
        {
            int result = 0;

            MySqlCommand command = new MySqlCommand(string.Format("Insert into compras(user_id, repository_id) values('{0}', '{1}')", c.user_id, c.repository_id), BDCon.ObtenerConexion());
            result = command.ExecuteNonQuery();

            return result;
        }

        public static ArrayList readMyPurchases(int user_id)
        {
            ArrayList compras = new ArrayList();

            string query = "select * from compras where user_id='" + user_id + "'";

            MySqlCommand command = new MySqlCommand(query, BDCon.ObtenerConexion());
            MySqlDataReader r = command.ExecuteReader();

            while (r.Read())
            {
                Compra compra = new Compra(int.Parse(r["compra_id"].ToString()), int.Parse(r["user_id"].ToString()), int.Parse(r["repository_id"].ToString()));
                compras.Add(compra);
            }
            return compras;
        }
        
    }
}
