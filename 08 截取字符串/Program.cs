using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_截取字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string strFile = "Program.cs";
            Console.WriteLine("文件完整名称：" + strFile);
            string strFileName = strFile.Substring(0, strFile.IndexOf('.'));
            string strExtension = strFile.Substring(strFile.IndexOf('.'));

            Console.WriteLine("文件名：" + strFileName);
            Console.WriteLine("扩展名" + strExtension);
            Console.ReadLine();
        }
    }
}
