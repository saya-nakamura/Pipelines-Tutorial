using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICalc calc = new Calc();
            int addAns = calc.Add(Int32.Parse(args[0]), Int32.Parse(args[1]));
            int subAns = calc.Substract(Int32.Parse(args[0]), Int32.Parse(args[1]));
            int multiAns = calc.Multiplication(Int32.Parse(args[0]), Int32.Parse(args[1]));
            int divAns = calc.Division(Int32.Parse(args[0]), Int32.Parse(args[1]));
            Console.WriteLine($"Addition answer:{addAns}");
            Console.WriteLine($"Subtraction answer:{subAns}");
            Console.WriteLine($"Multiplication answer:{multiAns}");
            Console.WriteLine($"Division answer:{divAns}");
            Console.ReadKey();

        }
    }
}
