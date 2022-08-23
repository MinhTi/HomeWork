using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_first_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* vẽ hình trái tim bằng các ký tự 0 , đơn giản chỉ là in dòng chữ ra màn hình */
            Console.Title = "My first project in Csharp";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine("***     0 0 0   0 0 0     ***");
            Console.WriteLine("***   0 0 0 0 0 0 0 0 0   ***");
            Console.WriteLine("*** 0 0 0 0 0 0 0 0 0 0 0 ***");
            Console.WriteLine("*** 0 0 0 0 0 0 0 0 0 0 0 ***");
            Console.WriteLine("***   0 0 0 0 0 0 0 0 0   ***");
            Console.WriteLine("***     0 0 0 0 0 0 0     ***");
            Console.WriteLine("***       0 0 0 0 0       ***");
            Console.WriteLine("***         0 0 0         ***");
            Console.WriteLine("***           0           ***");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
        }

    }
}
