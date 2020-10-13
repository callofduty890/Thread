using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03_线程的中断
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("主线程开始.");
            Thread t = new Thread(DoWork);
            t.Start();//启动线程
            Console.WriteLine("请在100秒之内按任意键中断线程!");
            Console.ReadKey();
            t.Interrupt();//发出中断工作线程的命令
            t.Join();//使用Join方法阻塞当前线程，等待工作线程完成销毁
            Console.WriteLine("主线程结束");
            Console.ReadKey();
        }
        public static void DoWork(object data)
        {
            Console.Write("工作线程开始.");
            try
            {
                Console.Write("工作线程准备休眠100秒...");
                Thread.Sleep(100 * 1000);
            }
            catch (ThreadInterruptedException e)
            {

                Console.WriteLine("睡眠中断");
            }
        }
    }
}
