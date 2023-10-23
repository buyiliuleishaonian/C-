using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wen.TaskLock
{
    public class TestLock
    {
        private int nums = 0;
        //如果进行锁住资源，需要锁住对象，一般可以创建对象

        public void Test()
        {
            lock (this)
            {
                for (int i = 0; i <100; i++)
                {
                    nums++;
                    Console.WriteLine(nums);
                }
            }
        }

        public void TaskLock()
        {
            for (int i = 0; i < 5; i++)
            {
                Task task = Task.Run(() =>
                {
                    Test();
                });
            }
        }
    }
}
