using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log
{
    class UserValidator
    {
        public static bool Validate(string login, string password)
        {
            if (login == "admin" && password == "admin")
                return true;

            return false;
        }
    }
}
