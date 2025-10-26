using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemapagamento
{
    class Card : GiveMeMyMoney, IProtected
    {
        //P paypal C cripto B carta A applepay

        public string Email { get; set; }
        public string Password { get; set; }
        public bool isAuthenticated { get; set; }
        public DateTime Date { get; set; }


        public Card(string id, int tot, char typeOfPayment, string email, string password, DateTime date) : base(id, tot, typeOfPayment)
        {
            ID = id;
            TotMoney = tot;
            TypeOfPayment = typeOfPayment;
            Email = email;
            Password = password;
            Date = date;
        }


        public override string ToString()
        {
            string str = base.ToString() + "";
            return str;
        }

        void IProtected.Access(string email, string passw)
        {
            if (email == Email && passw == Password)
            {
                isAuthenticated = true;
            }
        }

        void IProtected.Exit()
        {
            if (isAuthenticated)
            {
                isAuthenticated = false;
            }
        }

        bool IProtected.IsLoggedIn()
        {
            if (isAuthenticated && Date > DateTime.Today)
            {
                return true;
            }
            return false;
        }

        
    }
}
