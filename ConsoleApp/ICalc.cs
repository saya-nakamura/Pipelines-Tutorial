using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public interface ICalc
    {
        int Add(int x, int y);
        int Substract(int x, int y);
        int Multiplication(int x, int y);
        int Division(int x, int y);
    }
}
