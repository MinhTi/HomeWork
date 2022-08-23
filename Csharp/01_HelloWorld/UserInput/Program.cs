using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {// full name, age, avg mark
            Console.WriteLine("Ho va ten: ");
            string fullName = Console.ReadLine();

            Console.WriteLine("Tuoi: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            int age = System.Int32.Parse(Console.ReadLine());

            Console.WriteLine("Diem TB: ");
            //float avgMark = Convert.ToSingle(Console.ReadLine());
            float avgMark = System.Single.Parse(Console.ReadLine());

            Console.WriteLine("======================================");
            Console.WriteLine("======================================");
            Console.WriteLine("======================================");
            Console.WriteLine();
            Console.WriteLine("Hello, My full name is " + fullName);
            Console.WriteLine("I'm " + age);
            Console.WriteLine("My avg mark is " + avgMark);
        }
    }
}
