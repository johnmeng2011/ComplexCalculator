using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var x = new ComplexNumber(3, 2);
            var y = new ComplexNumber(-1,5);

            var calculator  = new ComplexCalculator();

            var z = calculator.Add(x, y);
            Console.WriteLine("x+y="+ z.ToString());
            z = calculator.Subtract(x, y);
            Console.WriteLine("x-y=" + z.ToString());

            z = calculator.Multiply(x, y);
            Console.WriteLine("x*y=" + z.ToString());

            z = calculator.Divide(x, y);
            Console.WriteLine("x/y=" + z.ToString());

            Console.ReadKey();

        }
    }
}
