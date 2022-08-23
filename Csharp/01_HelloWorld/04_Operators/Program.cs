using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* cac phep toan  + - * / % ++ */
            int a, b;
            int sum;
            string strMsg1;

            /* thuc hanh cac phep toan */
            a = 100;
            b = 200;
            sum = a + b;

            // 3 cach viet vao nhap 1 so :
            // cach 1
            Console.WriteLine("cach 1 : Tong " + a +" + " + b+ " = " +sum);

            //cach 2
            Console.WriteLine("cach2 : Tong {0} + {1} = {2}",a,b,sum);

            //cach3 
            Console.WriteLine($"cach 3 : tong {a} + {b} = {sum}");
        }
    }
}
