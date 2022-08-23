using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StringClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringClass
            string str= "Hello World";
            Console.WriteLine(str);
            Console.WriteLine(str.Length);
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            string str1 = "   Hell World   ";
            Console.WriteLine(str1.Trim());  // loai bo space truoc va sau chuoi
            Console.WriteLine(str1.Contains("o")); // tra ve true hoac false
        }
    }
}
