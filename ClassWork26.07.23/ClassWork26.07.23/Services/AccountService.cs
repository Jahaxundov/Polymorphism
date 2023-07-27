using ClassWork26._07._23.Helpers.ResponseMessages;
using ClassWork26._07._23.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork26._07._23.Services
{
    internal class AccountService : IAccountService
    {
        public bool Login(string username, string password)
        {
            if(username=="x@gmail.com" && password == "x123")
            {
                return true;
            }
            return false;
        }
    }
}
