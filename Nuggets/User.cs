using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuggets
{
    public class User
    {
        public int id { get; set; }
        public String password { get; set; }
        public String name { get; set; }
        public String lastName { get; set; }
        public String fb { get; set; }
        public String email { get; set; }
        public String tel { get; set; }
        public Card card { get; set; }
        public String nickname { get; set; }

        public User(int id, String password, String name, String lastName, String fb, String email, String nickname, String tel, Card card)
        {
            this.id = id;
            this.password = password;
            this.name = name;
            this.lastName = lastName;
            this.fb = fb;
            this.email = email;
            this.tel = tel;
            this.card = card;
        }
        public User(int id, String password, String name, String lastName, String fb, String email, String tel, String nickname)
        {
            this.id = id;
            this.password = password;
            this.name = name;
            this.lastName = lastName;
            this.fb = fb;
            this.email = email;
            this.tel = tel;
        }
        public User(String password, String name, String lastName, String fb, String email, String tel, String nickname)
        {
            this.id = id;
            this.password = password;
            this.name = name;
            this.lastName = lastName;
            this.fb = fb;
            this.email = email;
            this.tel = tel;
        }
        public User()
        {

        }
        public User(String password, String name, String lastName, String fb, String email, String tel, Card card, String nickname)
        {
            this.password = password;
            this.name = name;
            this.lastName = lastName;
            this.fb = fb;
            this.email = email;
            this.tel = tel;
            this.card = card;
        }
    }
}
