using ClassWork26._07._23.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork26._07._23.Services
{
    internal class CustomMathService : ICustomMathService
    {
        public int GetNumbersOfSum(int[] nums)
        {
            int sum = 0;
            foreach (var item in nums)
            {
                sum += sum;

            }
            return sum;
        }

        public void Sum(int a,int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);

        }
    }
}
