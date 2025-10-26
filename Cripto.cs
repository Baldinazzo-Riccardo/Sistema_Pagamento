using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemapagamento
{
    class Cripto : GiveMeMyMoney
    {
        //P paypal C cripto B carta A applepay

        decimal valueInMoney = 1.3m;

        public Cripto(string id, int tot, char typeOfPayment) : base(id, tot, typeOfPayment)
        {
            ID = id;
            TotMoney = tot * valueInMoney;
            TypeOfPayment = typeOfPayment;
        }

        
        public override string ToString()
        {
            string str = base.ToString() + "";
            return str;
        }
 
    }
}
