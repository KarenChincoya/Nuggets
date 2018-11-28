using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuggets
{
    public class Repository
    {
        public int id { get; set; }
        public int id_creator { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public String picture1 { get; set; }
        public String picture2 { get; set; }
        public String picture3 { get; set; }

        public Repository()
        {

        }
        public Repository(int id_creator, String name, String description, String picture1, String picture2, String picture3)
        {
            this.id_creator = id_creator;
            this.name = name;
            this.description = description;
            this.picture1 = picture1;
            this.picture2 = picture2;
            this.picture3 = picture3;
        }

        public Repository(int id,  int id_creator, String name, String description, String picture1, String picture2, String picture3)
        {
            this.id = id;
            this.id_creator = id_creator;
            this.name = name;
            this.description = description;
            this.picture1 = picture1;
            this.picture2 = picture2;
            this.picture3 = picture3;
        }
    }

}
