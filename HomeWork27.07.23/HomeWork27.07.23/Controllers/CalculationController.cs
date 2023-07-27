using HomeWork27._07._23.Sevices;
using HomeWork27._07._23.Sevices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork27._07._23.Controllers
{
    internal class CalculationController
    {
        private readonly ICalculationService _calculationService;

        public CalculationController()
        {
            _calculationService = new CalculationService();
        }

        public void Calculate()
        {
            Console.WriteLine("Add number");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Add operation");
            string operation = Console.ReadLine();

            Console.WriteLine("Add number");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());

            _calculationService.Calculate(num1, operation, num2);
        }
    }
}
