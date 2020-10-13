using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


//通过对象完成线程传参
namespace _06_线程传多个参数
{

    public class ThreadTest
    {
        private string str1;
        private string str2;

        public string Str1 { get => str1; set => str1 = value; }
        public string Str2 { get => str2; set => str2 = value; }

        public ThreadTest(string a,string b)
        {
            this.Str1 = a;
            this.Str2 = b;
        }

        public void ThreadProc()
        {
            Console.WriteLine(Str1 + Str2);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //通过对象完成传参
            ThreadTest tt = new ThreadTest("Hello ", "World");

            Thread thread = new Thread(tt.ThreadProc);

            thread.Start();//启动线程
        }
    }
}
