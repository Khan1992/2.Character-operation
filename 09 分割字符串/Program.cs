using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_分割字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "编程学习不再难，让编程创造财富不再难，让编程改变工作和人生不再难";
            char[] separator = { '，' };
            string[] splitString = str.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < splitString.Length; i++)
            {
                Console.WriteLine(splitString[i]);
            }

            Console.ReadLine();
        }
    }
}
