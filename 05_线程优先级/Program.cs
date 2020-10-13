using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05_线程优先级
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread tlowest = new Thread(DoWork1);//创建线程对象实例
            Thread tHighest = new Thread(DoWork2);//创建线程对象实例

            //设置线程优先级
            tlowest.Priority = ThreadPriority.Lowest;
            tHighest.Priority = ThreadPriority.Highest;

            //启动线程
            tlowest.Start("Lowest");
            tHighest.Start("Highest");

            Console.WriteLine("请耐性等待5秒.....");

            Thread.Sleep(5000);//等待五秒进行累加，用来判断优先级

            //终止线程
            tlowest.Abort();
            tHighest.Abort();

            Console.ReadKey();

        }
        public static void DoWork1(object data)
        {
            long count1 = 0;
            try
            {
                while(true){ count1++; }//死循环累加
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("{0} , count1={1}", data, count1);
            }
        }
        public static void DoWork2(object data)
        {
            long count2 = 0;
            try
            {
                while (true) { count2++; }//死循环累加
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("{0} , count1={1}", data, count2);
            }
        }
    }
}
