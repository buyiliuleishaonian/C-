using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Wen.ThreadDemo
{
    internal class Program
    {
        //主线程
        static void Main(string[] args)
        {
            Console.WriteLine("这是主线程任务1");
            Thread thread1 = new Thread(Test1);
            thread1.IsBackground=true;
            thread1.Start();

            Thread thread2=new Thread(Test2);
            thread2.IsBackground=true;
            thread2.Start();

            Console.WriteLine("主线程任务2");
            Console.WriteLine("主线程任务3");

            Console.ReadKey(true);
        }

        static void Test1()
        {
            Thread.Sleep(2000);
            Console.WriteLine("这是子线程任务1");
        }

        static void Test2()
        {
            Thread.Sleep(3000);
            Console.WriteLine("这是子线程任务2");
        }
    }
}
