using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_获取指定位置的字符
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "努力工作是人生最好的投资";
            char chr = str[5];
            Console.WriteLine("字符串中索引位置5的字符是：" + chr);
            Console.ReadLine();
        }
    }
}
