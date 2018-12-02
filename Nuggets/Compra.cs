using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuggets
{
    class Compra
    {
        //atributos de clase
        public int compra_id { get; set; }
        public int user_id { get; set; }
        public int repository_id { get; set; }

        public Compra()
        {

        }
        public Compra(int compra_id, int user_id, int repository_id)
        {
            this.compra_id = compra_id;
            this.user_id = user_id;
            this.repository_id = repository_id;
        }
        public Compra(int user_id, int repository_id)
        {
            this.user_id = user_id;
            this.repository_id = repository_id;
        }
    }
}
