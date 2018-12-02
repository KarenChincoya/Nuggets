using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuggets
{
    public class DAORepository
    {
        public static int create(Repository repo)
        {

            int result = 0;

            MySqlCommand command = new MySqlCommand(string.Format("Insert into repository(creator_id, name, description, picture1, picture2, picture3) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", repo.id_creator, repo.name, repo.description, repo.picture1, repo.picture2, repo.picture3), BDCon.ObtenerConexion());
            result = command.ExecuteNonQuery();

            return result;
        }


        public static Repository read(int id)
        {
            Repository repo = new Repository();
            string query = "select * from repository where repository_id='" + id + "'";

            MySqlCommand command = new MySqlCommand(query, BDCon.ObtenerConexion());
            MySqlDataReader r = command.ExecuteReader();

            while (r.Read())
            {
                repo = new Repository(int.Parse(r["repository_id"].ToString()), int.Parse(r["creator_id"].ToString()), r["name"].ToString(), r["description"].ToString(), r["picture1"].ToString(), r["picture2"].ToString(), r["picture3"].ToString());
            }
            return repo;
        }

        public static int update(Repository repo)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("update repository set name = '{0}', description = '{1}', picture1='{2}', picture2='{3}', picture3='{4}'  where id='{5}'", repo.name, repo.description, repo.picture1, repo.picture2, repo.picture3, repo.id), BDCon.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static int delete(int id)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Delete from repository where repository_id='{0}'", id), BDCon.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static ArrayList readMyCreatedRepos(int user_id)
        {
            ArrayList repos = new ArrayList();

            string query = "select * from repository where creator_id='" + user_id + "'";

            MySqlCommand command = new MySqlCommand(query, BDCon.ObtenerConexion());
            MySqlDataReader r = command.ExecuteReader();

            while (r.Read())
            {
                Repository repo = new Repository(int.Parse(r["repository_id"].ToString()), int.Parse(r["creator_id"].ToString()), r["name"].ToString(), r["description"].ToString(), r["picture1"].ToString(), r["picture2"].ToString(), r["picture3"].ToString());
                repos.Add(repo);
            }
            return repos;
        }

        //Todos
        public static ArrayList readAllRepos()
        {
            ArrayList repos = new ArrayList();

            string query = "select * from repository";

            MySqlCommand command = new MySqlCommand(query, BDCon.ObtenerConexion());
            MySqlDataReader r = command.ExecuteReader();

            while (r.Read())
            {
                Repository repo = new Repository(int.Parse(r["repository_id"].ToString()), int.Parse(r["creator_id"].ToString()), r["name"].ToString(), r["description"].ToString(), r["picture1"].ToString(), r["picture2"].ToString(), r["picture3"].ToString());
                repos.Add(repo);
            }
            return repos;
        }

        public static int getMaxId()
        {
            int result = 0;
            MySqlCommand c = new MySqlCommand(string.Format("select MAX(repository_id) from repository"), BDCon.ObtenerConexion());
            result = int.Parse(c.ExecuteScalar().ToString());

            return result;
        }

        public static int getCountAll()
        {
            int result = 0;
            MySqlCommand c = new MySqlCommand(string.Format("select count(*) from repository"), BDCon.ObtenerConexion());
            result = int.Parse(c.ExecuteScalar().ToString());

            return result;
        }

    }
}
