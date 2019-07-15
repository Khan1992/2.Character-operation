using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_格式化字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            // 输出金额
            Console.WriteLine(string.Format("1251+3950的结果是（以货币形式显示）：{0:C}", 1251 + 3950));
            // 输出科学计数法
            Console.WriteLine(string.Format("120000.1用科学计数法表示：{0:E}", 120000.1));
            // 输出以分隔符显示的数字
            Console.WriteLine(string.Format("12800以分隔符数字显示的结果是：{0:N0}", 12800));
            // 输出小数点后两位
            Console.WriteLine(string.Format("π取两位小数点：{0:F2}", Math.PI));
            // 输出16进制
            Console.WriteLine(string.Format("33的16进制结果是：{0:X4}", 33));
            // 输出百分号数字
            Console.WriteLine(string.Format("天才是由 {0:P0} 的灵感，加上 {1:P0} 的汗水 。", 0.01, 0.99));
            Console.ReadLine();
        }
    }
}
