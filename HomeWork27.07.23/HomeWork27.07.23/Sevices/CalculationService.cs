using HomeWork27._07._23.Sevices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork27._07._23.Sevices
{
    internal class CalculationService : ICalculationService
    {
        public void Calculate(decimal num1, string operations, decimal num2)
        {
            decimal result;
            if(operations=="/" && num2 == 0)
            {
                Console.WriteLine("Can't divide 0");
                return;
            }

            switch (operations)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine(result);
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine(result);
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine(result);
                    break;

                case "/":
                    result = num1 / num2;
                    Console.WriteLine(result);
                    break;
            }
        }
    }
}
