using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // type name =  value
            int intAge = 25;
            string strFullName = "Nguyen Minh Tien";
            string strEmail = "minhtien291296@gmail.com";

            Console.Title = "My infomation";
            Console.WriteLine("ten cua toi la : " + strFullName);
            Console.WriteLine("tuoi cua toi la : "+ intAge);
            Console.WriteLine("email cua toi la : "+ strEmail);
        }
    }
}
