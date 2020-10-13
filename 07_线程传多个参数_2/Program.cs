using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07_线程传多个参数_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello ";
            string str2 = "World";

            Thread thread = new Thread(() => DoWork(str, str2));

            thread.Start();

            Console.ReadKey();
        }

        static void DoWork(string str1, string str2)
        {
            Console.WriteLine(str1 + " " + str2);
        }

    }
}
