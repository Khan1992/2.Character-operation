using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_输出不同格式的日期
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime strDate = DateTime.Now;//获取当前日期时间
            // 输出短日期格式
            Console.WriteLine(string.Format("当前日期的短日期格式表示：{0:d}", strDate));
            // 输出长日期格式
            Console.WriteLine(string.Format("当前日期的长日期格式表示：{0:D}", strDate));
            Console.WriteLine();//换行
            // 输出完整日期/时间格式（短时间）
            Console.WriteLine(string.Format("当前日期时间的完整日期/时间格式（短时间）表示：{0:f}", strDate));
            // 输出完整日期/时间格式（长时间）
            Console.WriteLine(string.Format("当前日期时间的完整日期/时间格式（长时间）表示：{0:F}", strDate));
            Console.WriteLine();//换行
            // 输出常规日期/时间格式（短时间）
            Console.WriteLine(string.Format("当前日期时间的常规日期/时间格式（短时间）表示：{0:g}", strDate));
            // 输出常规日期/时间格式（长时间）
            Console.WriteLine(string.Format("当前日期时间的常规日期/时间格式（长时间）表示：{0:G}", strDate));
            Console.WriteLine();//换行
            // 输出时间格式
            Console.WriteLine(string.Format("当前时间的短时间格式表示：{0:t}", strDate));
            // 输出长时间格式
            Console.WriteLine(string.Format("当前时间的长时间格式表示：{0:T}", strDate));
            Console.WriteLine();//换行
            // 输出月/日格式
            Console.WriteLine(string.Format("当前日期的月/日格式表示：{0:M}", strDate));
            // 输出年/月格式
            Console.WriteLine(string.Format("当前日期的年/月格式表示：{0:Y}", strDate));
            Console.ReadLine();
        }
    }
}
