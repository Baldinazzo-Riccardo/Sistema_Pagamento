using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemapagamento
{
    abstract class GiveMeMyMoney
    {
        public string ID { get; set; }
        public decimal TotMoney { get; set; } 
        public char TypeOfPayment { get; set; }


        public GiveMeMyMoney(string id, int tot, char typeOfPayment)
        {
            ID = id;
            TotMoney = tot;
            TypeOfPayment = typeOfPayment;
        }

        public bool ThereIsSomethingToPay(decimal money)
        {
            return TotMoney - money >= 0;
        }

        public string Pay(decimal money)
        {
            if (ThereIsSomethingToPay(money))
            {
                TotMoney -= money;
                return this.ToString();
            }
            return "Saldo insufficiente.";
        }

        public override string ToString()
        {
            string str = "";
            str += $"Metodo Di Pagamento s.r.l.\n";
            str += $"Data e orario: {DateTime.Today}. \n";
            str += "------------------------------\n";
            str += $"DISPONIBILITA' DI {TotMoney:C}";
            
            return str;
        }



    }
}
