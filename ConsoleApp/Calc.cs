using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Calc : ICalc
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Substract(int x, int y)
        {
            return x - y;
        }

        public int Multiplication(int x, int y)
        {
            return x * y;
        }

        public int Division(int x, int y)
        {
            return x / y;
        }
    }
}
