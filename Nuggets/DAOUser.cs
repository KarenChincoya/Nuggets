using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections;

namespace Nuggets
{
    public class DAOUser
    {
        public static int create(User u)
        {

            int result = 0;

            MySqlCommand command = new MySqlCommand(string.Format("Insert into user(password, name, lastname, fb, email, tel) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", u.password, u.name, u.lastName, u.fb, u.email, u.tel), BDCon.ObtenerConexion());
            result = command.ExecuteNonQuery();

            return result;
        }

        public static ArrayList readUsers()
        {
            ArrayList listaUsuarios = new ArrayList();

            string query = "select * user";

            MySqlCommand command = new MySqlCommand(query, BDCon.ObtenerConexion());
            MySqlDataReader r = command.ExecuteReader();

            while (r.Read())
            {
                User usuario = new User(int.Parse(r["user_id"].ToString()), r["password"].ToString(), r["name"].ToString(), r["lastname"].ToString(), r["fb"].ToString(), r["email"].ToString(), r["tel"].ToString(), r["nickname"].ToString());
                listaUsuarios.Add(usuario);
            }
            return listaUsuarios;
        }

        public static User readUser(int id)
        {
            User usuario = new User();
            string query = "select * from user where user_id='" + id + "'";

            MySqlCommand command = new MySqlCommand(query, BDCon.ObtenerConexion());
            MySqlDataReader r = command.ExecuteReader();

            while (r.Read())
            {
                usuario = new User(int.Parse(r["user_id"].ToString()), r["password"].ToString(), r["name"].ToString(), r["lastname"].ToString(), r["fb"].ToString(), r["email"].ToString(), r["tel"].ToString(), r["nickname"].ToString());
            }
            return usuario;
        }

        public static int updateUser(User user)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("update users set password = '{0}', name = '{1}', lastname='{2}', fb='{3}', email='{4}', tel='{5}'  where id='{6}'", user.password, user.name, user.lastName, user.fb, user.email, user.tel, user.id), BDCon.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static int delete(int id)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Delete from user where user_id='{0}'", id), BDCon.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public int getLastId()
        {
            int result = 0;
            
            return result;
        }
    }
}

