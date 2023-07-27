using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork26._07._23
{
    internal class Bird : Animal
    {
        public int Age { get; set; }
        public Bird()
        {
            Console.WriteLine("hello bird");
        }
        public override void Eating()
        {
            Console.WriteLine("bird eating");
        }


    }
}
