using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_去除空白内容
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "            abc      ";
            string shortStr = str.Trim();
            Console.WriteLine("str的原值是: [" + str + "]");
            Console.WriteLine("去掉首位空白的值:[" + shortStr + "]");

            Console.ReadLine();
        }
    }
}
