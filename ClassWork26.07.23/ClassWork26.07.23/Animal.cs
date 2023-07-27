using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork26._07._23
{
    internal  class Animal
    {
        private readonly string Adress;
        public string Phone { get; set; } = "numbers";
        public string Name { get; set; }

        
        public virtual void Eating()
        {
            Console.WriteLine("animal eating");
        }
    }
}
