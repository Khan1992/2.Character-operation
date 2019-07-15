using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_替换字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string strOld = "one world,one dream";          //声明一个字符串变量并初始化
            Console.WriteLine("原始字符串：" + strOld);       //输出原始字符串
            string strNew1 = strOld.Replace(',', '*'); //使用Replace方法将字符串中的“,”替换为“*”
            Console.WriteLine("\n第一种形式的替换：" + strNew1);
            //使用Replace方法将字符串中的“one”替换为“One”
            string strNew2 = strOld.Replace("one", "One");
            Console.WriteLine("\n第二种形式的替换：" + strNew2);
            Console.ReadLine();
        }
    }
}
