using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10_13_多线程
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("主线:开始...");
            Thread.Sleep(100);
            Console.WriteLine("主线程:结束!");
            Console.ReadKey();
        }
    }
}
