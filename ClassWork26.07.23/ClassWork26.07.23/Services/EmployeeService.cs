using ClassWork26._07._23.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork26._07._23.Services
{
    internal class EmployeeService : IEmployeeService
    {
        

        public void Search(string searchText)
        {
            string[] employyes = { "Fidan", "Sheref", "Cahangir" };
            foreach (var item in employyes)
            {
                if (item.Contains(searchText))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
