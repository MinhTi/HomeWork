using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Operators
{
    internal class AsignOperator
    {
        static void Main()
        {
            // += -= *= %= /=
            int a = 120;
            int b = 10;

            a += b;
            Console.WriteLine("a = " + a);
            a -= b;
            Console.WriteLine("a = " + a);
            a *= b;
            Console.WriteLine("a = " + a);
            a = a % (100 * b);
            Console.WriteLine("a = " + a);
            a /= b;
            Console.WriteLine("a = " + a);
        }
    }
}
