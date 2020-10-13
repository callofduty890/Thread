using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04_线程的销毁
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("主线程开始,创建并启动线程.");
            Thread t = new Thread(TestMoethod);
            t.Start();//启动线程
            Thread.Sleep(1000);
            Console.Write("主程序试图销毁工作线程.");
            t.Abort();//销毁t
            t.Join();//等待线程被终止
            Console.WriteLine("工作线程终止。主线程终止。");
            Console.ReadKey();
        }
        static void TestMoethod()
        {
            try
            {
                while (true)
                {
                    Console.Write("T");//工作线程
                    Thread.Sleep(100);
                }
            }
            catch (ThreadAbortException abort)
            {
                Console.WriteLine("工作线程被{0}终止。",(string)abort.ExceptionState);
            }
        }

    }
}
