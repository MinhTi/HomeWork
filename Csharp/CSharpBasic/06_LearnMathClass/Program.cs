using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_LearnMathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //su dung lop tinh toan so hoc : Math
            //tim max
            int max = Math.Max(10, 11);
            Console.WriteLine($"max cua {10} va {11} la : {max}");

            //tim min
            int min = Math.Min(10, 11);
            Console.WriteLine($" min cua {10} va {11} la : {min}");

            //tim tri tuyet doi
            int intAbs = Math.Abs(-1996);
            Console.WriteLine($" gia tri tuyet doi cua {-1996} la : {intAbs}");

            //tim can bac 2
            double canb2 = Math.Sqrt(121);
            Console.WriteLine($" can bang 2 cua {121} la : {canb2}");
        }
    }
}
