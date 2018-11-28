using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuggets
{
    public class Card
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public String number { get; set; }
        public String holdername { get; set; }
        public String securityCode { get; set; }
        public string expirationDate { get; set; }
        public Card()
        {

        }
        public Card(String number, String holdername, String securityCode, String expirationDate)
        {
            this.number = number;
            this.holdername = holdername;
            this.securityCode = securityCode;
        }
        public Card(int user_id, String number, String holdername, String securityCode, String expirationDate)
        {
            this.user_id = user_id;
            this.number = number;
            this.holdername = holdername;
            this.securityCode = securityCode;
        }
        public Card(int id, int user_id, String number, String holdername, String securityCode, String expirationDate)
        {
            this.id = id;
            this.user_id = user_id;
            this.number = number;
            this.holdername = holdername;
            this.securityCode = securityCode;
        }
    }
}
