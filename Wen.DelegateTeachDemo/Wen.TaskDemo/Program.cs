using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wen.TaskDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Test1();
            //Test2();
            Test3();
            Console.ReadKey();
        }
        //创建Task对象，然后调用Start方法启动线程
        static void Test1()
        {
            Task task = new Task(() =>
            {
                //在这个地方编写具体执行任务
                Console.WriteLine("new一个新的Task，对应的子线程ID="+Thread.CurrentThread.ManagedThreadId);
            });
            task.Start();
        }

        //启动Task的静态方法Run直接启动线程
        static void Test2()
        {
            Task task = Task.Run(() => {
                Console.WriteLine("new一个新的Task，对应的子线程ID="+Thread.CurrentThread.ManagedThreadId);
            });
        }

        //使用Factory.StartNew启动
        static void Test3()
        {
            Task task = Task.Factory.StartNew(() => {
                Console.WriteLine("new一个新的Task，对应的子线程ID="+Thread.CurrentThread.ManagedThreadId);
            });
        }
    }
}


