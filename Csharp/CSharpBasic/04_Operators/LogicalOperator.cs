using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Operators
{
    internal class LogicalOperator
    {
        static void Main()
        {
            // set 2 so a b bat ky
            int a = 100; int b = 120;
            bool c = (a % 2 == 0) & (b % 2 == 0);

            //in ra man hinh ket qua cua c
            Console.WriteLine(c);
        }
    }
}
