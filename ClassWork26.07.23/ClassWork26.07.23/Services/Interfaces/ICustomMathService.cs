using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork26._07._23.Services.Interfaces
{
    internal interface ICustomMathService
    {
        void Sum(int a,int b);
        int GetNumbersOfSum(int[] nums);
    }
}
