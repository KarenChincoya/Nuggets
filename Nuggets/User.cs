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
        public string password { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string fb { get; set; }
        public string email { get; set; }
        public string tel { get; set; }
        public Card card { get; set; }
        public string nickname { get; set; }

        public User(int id, string password, string name, string lastName, string fb, string email, string nickname, string tel, Card card)
        {
            this.id = id;
            this.password = password;
            this.name = name;
            this.lastName = lastName;
            this.fb = fb;
            this.email = email;
            this.tel = tel;
            this.card = card;
            this.nickname = nickname;
        }
        public User(int id, string password, string name, string lastName, string fb, string email, string tel, string nickname)
        {
            this.id = id;
            this.password = password;
            this.name = name;
            this.lastName = lastName;
            this.fb = fb;
            this.email = email;
            this.tel = tel;
            this.nickname = nickname;
        }
        public User(string password, string name, string lastName, string fb, string email, string tel, string nickname)
        {
            this.id = id;
            this.password = password;
            this.name = name;
            this.lastName = lastName;
            this.fb = fb;
            this.email = email;
            this.tel = tel;
            this.nickname = nickname;
        }
        public User()
        {

        }
        public User(string password, string name, string lastName, string fb, string email, string tel, Card card, string nickname)
        {
            this.password = password;
            this.name = name;
            this.lastName = lastName;
            this.fb = fb;
            this.email = email;
            this.tel = tel;
            this.card = card;
            this.nickname = nickname;
        }
    }
}
