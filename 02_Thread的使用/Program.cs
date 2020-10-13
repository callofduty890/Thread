using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_Thread的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main线程开始");
            Thread t = new Thread(DoWork);//创建线程对象实例
            t.Start();//启动线程
            for (int i = 0; i < 10; i++)
            {
                Console.Write("M");
                Thread.Sleep(500);
            }
            Console.Write("  Main线程结束.");Console.ReadKey();
        }
        public static void DoWork()
        {
            Console.Write("工作线程开始");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("w");
                Thread.Sleep(500);
            }
            Console.Write("  工作线程结束.");
        }
    }
}
