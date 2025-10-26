using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemapagamento
{
    class ApplePay : GiveMeMyMoney
    {
        public ApplePay(string id, int tot, char typeOfPayment) : base(id, tot, typeOfPayment)
        {
            ID = id;
            TotMoney = tot;
            TypeOfPayment = typeOfPayment;
        }


        public override string ToString()
        {
            string str = base.ToString() + "";
            return str;
        }
    }
}
