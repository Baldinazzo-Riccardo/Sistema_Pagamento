using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemapagamento
{
    internal interface IProtected
    {
        string Email { get; set; }
        string Password { get; set; }
        bool isAuthenticated { get; set; }


        void Access(string email, string passw);

        void Exit();

        bool IsLoggedIn();
    }
}
