using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork26._07._23
{
    internal class Person : IPerson
    {
        public string Name { get ; set ; }

        public void GetName()
        {
            Console.WriteLine("Fidan");
        }
    }
}
