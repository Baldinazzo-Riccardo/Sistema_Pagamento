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

        private bool ThereIsSomethingToPay(decimal money)
        {
            return TotMoney - money >= 0;
        }

        public void Pay(decimal money)
        {
            if (ThereIsSomethingToPay(money))
            {
                TotMoney -= money;
            }
        }

        //P paypal C cripto B carta A applepay
        public string GetInfo()
        {
            string info = "";
            info += $"Metodo Di Pagamento s.r.l.\n";
            info += $"Data e orario: {DateTime.Today}. \n";
            info += "---------INFORMAZIONI---------";
            info += "\n";
            info += "Metodo di pagamento: ";

            switch (TypeOfPayment)
            {
                case 'P':
                    info += "Paypal";
                    break;
                case 'C':
                    info += "Criptovaluta";
                    break;
                case 'B':
                    info += "Carta di Credito";
                    break;
                case 'A':
                    info += "Apple Pay";
                    break;
            }
            info += $"\n{ID} - Disponibilita' di {TotMoney:C}";
            return info;
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
