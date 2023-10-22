using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLambda
{
    public delegate int Add(int a,int b);
    public class DelegatLambdaTest
    {

       
        public void Test(int t1,int t2)
        {
            //创建委托，关联方法
             Add a1 = AddInt;

            //使用匿名委托
            Add a2 = delegate (int a, int b) { return t1+t2; };

            //使用Lambda表达式,=>表示goes to
            Add a3 = (int a, int b) => { return a+b; };

            //当匿名的方法只有一句代码需要执行时
            Add a4=(int a, int b) =>  a+b;

            //当不想写参数的数据类型时,当然这里输入的数据，必须是创建委托时参数的类型一致
            Add a5 = (a, b) => { return a+b; };

        }
        public int AddInt(int t1, int t2)
        {

            return t1+t2;
        }
    }

}
