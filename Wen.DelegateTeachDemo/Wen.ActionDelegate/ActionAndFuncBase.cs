using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wen.ActionDelegate
{
    public class ActionAndFuncBase
    {
        /// <summary>
        /// 系统自带的无参数的泛型委托
        /// </summary>
        public void Test1()
        {
            //这里的Action<>,在里面有几个数据类型，就表示此委托有对应的数据类型参数
            Action<int> act1 = delegate (int a) { Console.WriteLine($"{a}"); };
            Action<string, string> act2 = (a, b) => { Console.WriteLine($"你好我是{a}，你好我是{b}"); };
            Action act3 = () => { Console.WriteLine("你好"); };
        }

        /// <summary>
        /// 系统有参数泛型委托
        /// </summary>
        public void Test2()
        {
            //表示不需要参数的委托
            Func<int> func1 = () => { return 10; };

            //这里int表示一个参数，最后一个数据类型表示为需要返回的参数类型
            Func<int,double> func2=(a)=>{ return a+10.1; };

            Func<int, int, double> func4 = (a, b) => { return a+b; };
        }
    }
}
