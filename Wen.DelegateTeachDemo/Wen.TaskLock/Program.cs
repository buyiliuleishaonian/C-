using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Wen.TaskLock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestLock test = new TestLock();
            test.TaskLock();


            Console.ReadKey(true);
        }
    }
}
