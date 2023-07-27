using ClassWork26._07._23.Helpers.ResponseMessages;
using ClassWork26._07._23.Services;
using ClassWork26._07._23.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork26._07._23.Controllers
{
    internal class AccountController
    {
        private readonly IAccountService _accountService;

        public AccountController()
        {
            _accountService = new AccountService();
        }
        public void Login()
        {
            Console.WriteLine("Add email");
           Email: string email = Console.ReadLine();

            Console.WriteLine("Add password");
            string password = Console.ReadLine();

            bool isLogin = _accountService.Login(email,password);

            if (isLogin)
            {
                Console.WriteLine(AccountMessage.LoginSucces);
                Console.WriteLine("Welcome"+email);
            }
            else
            {
                Console.WriteLine(AccountMessage.LoginFailed);
                goto Email;
            }
           
        }
    }
}
