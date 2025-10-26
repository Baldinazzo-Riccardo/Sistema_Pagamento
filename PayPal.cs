using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemapagamento
{
    class PayPal : GiveMeMyMoney, IProtected
    {
        //P paypal C cripto B carta A applepay

        public string Email { get; set; }
        public string Password { get; set; }
        public bool isAuthenticated { get; set; }


        public PayPal(string id, int tot, char typeOfPayment, string email, string password) : base(id, tot, typeOfPayment)
        {
            ID = id;
            TotMoney = tot;
            TypeOfPayment = typeOfPayment;
            Email = email;
            Password = password;
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
            if (isAuthenticated)
            {
                return true;
            }
            return false;
        } 
    }
}
