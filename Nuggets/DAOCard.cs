﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuggets
{
    public class DAOCard
    {
        public static int create(Card c)
        {

            int result = 0;

            MySqlCommand command = new MySqlCommand(string.Format("Insert into card(user_id, number, holdername, securitycode, expirationdate) values('{0}', '{1}', '{2}', '{3}', '{4}')", c.user_id, c.number, c.holdername, c.securityCode, c.expirationDate), BDCon.ObtenerConexion());
            result = command.ExecuteNonQuery();

            return result;
        }
        
        public static Card readCard(int id)
        {
            Card usuario = new Card();
            string query = "select * from card where user_id='" + id + "'";

            MySqlCommand command = new MySqlCommand(query, BDCon.ObtenerConexion());
            MySqlDataReader r = command.ExecuteReader();

            while (r.Read())
            {
                usuario = new Card(int.Parse(r["card_id"].ToString()),int.Parse(r["user_id"].ToString()), r["number"].ToString(), r["holdername"].ToString(), r["securitycode"].ToString(), r["expirationdate"].ToString());
            }
            return usuario;
        }

        public static int updateCard(Card card)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("update card set user_id = '{0}', number = '{1}', holdername='{2}', securitycode='{3}', expirationdate='{4}' where id='{5}'", card.user_id, card.number, card.holdername, card.securityCode, card.expirationDate, card.id), BDCon.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static int delete(int id)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Delete from card where card_id='{0}'", id), BDCon.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
    }
}

