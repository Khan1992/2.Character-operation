using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_获取字符串索引位置
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "We are the world";
            int firstIndex = str.IndexOf("r");
            int secondIndex = str.IndexOf("r", firstIndex + 1);
            int thirdIndex = str.IndexOf("r", secondIndex + 1);
            int size = str.LastIndexOf('e');

            Console.WriteLine("r第一次出现的位置是：" + firstIndex);
            Console.WriteLine("r第二次出现的位置是：" + secondIndex);
            Console.WriteLine("r第三次出现的位置是：" + thirdIndex);
            Console.WriteLine("最后一个'e'出现为位置是：" + size);


            Console.ReadLine();
        }
    }
}
