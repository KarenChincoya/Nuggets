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

            MySqlCommand command = new MySqlCommand(string.Format("Insert into user(password, name, lastname, fb, email, tel, nickname) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", u.password, u.name, u.lastName, u.fb, u.email, u.tel, u.nickname), BDCon.ObtenerConexion());
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

            MySqlCommand comando = new MySqlCommand(string.Format("update user set password = '{0}', name = '{1}', lastname='{2}', fb='{3}', email='{4}', tel='{5}'  where user_id='{6}'", user.password, user.name, user.lastName, user.fb, user.email, user.tel, user.id), BDCon.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static int updatWithoutPassword(User user)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("update users set name = '{0}', lastname='{1}', fb='{2}', email='{3}', tel='{4}'  where id='{5}'", user.name, user.lastName, user.fb, user.email, user.tel, user.id), BDCon.ObtenerConexion());
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

        public static int getLastId()
        {
            int result = 0;
            MySqlCommand c = new MySqlCommand(string.Format("select MAX(user_id) from user"), BDCon.ObtenerConexion());
            result = int.Parse(c.ExecuteScalar().ToString());
            
            return result;
        }

        public static string getPwd(int id)
        {
            string result = "";
            MySqlCommand command = new MySqlCommand(string.Format("select password from user where user_id='{0}'", id), BDCon.ObtenerConexion());
            MySqlDataReader r = command.ExecuteReader();

            while (r.Read())
            {
                result = r["password"].ToString();
            }

            return result;
        }

        public static bool getPermisoVista(int user_id, int repository_id)
        {
            MySqlCommand c = new MySqlCommand(string.Format("select count(*) from (select * from repository where creator_id = '"+user_id+"' and repository_id = '"+repository_id+"') as num"), BDCon.ObtenerConexion());
            int count1 = int.Parse(c.ExecuteScalar().ToString());

            MySqlCommand c2 = new MySqlCommand(string.Format("select  count(*) from (SELECT * FROM compras where user_id = '"+user_id+"' and repository_id = '"+repository_id+"') as num"), BDCon.ObtenerConexion());
            int count2 = int.Parse(c2.ExecuteScalar().ToString());

            if(count1!=0 || count2 != 0) {
                return true;
            }

            return false;
        }
    }
}

