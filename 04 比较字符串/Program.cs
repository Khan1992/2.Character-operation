using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_比较字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "nihaoma";
            string str2 = "nihaoma";

            Console.WriteLine(str1 == str2);
            Console.WriteLine(Equals(str1, str2));
            Console.ReadLine();
        }
    }
}
