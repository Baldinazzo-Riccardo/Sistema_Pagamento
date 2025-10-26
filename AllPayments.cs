using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemapagamento
{
    internal class AllPayments
    {
        int totalPayments { get; set; } = 0;
        int totalAccess { get; set; } = 0;
        int totalDisconnections { get; set; } = 0;
        decimal TotMoneyReceived { get; set; } = 0;

        public void GetPayments()
        {
            totalPayments++;
        }
        public void GetAccess()
        {
            totalAccess++;
        }
        public void GetDisconnect()
        {
            totalDisconnections++;
        }

        public void AddMoney(decimal money)
        {
            TotMoneyReceived += money;
        }
    }
}
