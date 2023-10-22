using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLambda
{
    public delegate T1 MyGenericDelegateLambda<T1>(T1 T1,T1 T2);
    public delegate T2 MyGenericDelegateLambda1<T1, T2>(T1 T, T2 t2);//返回值需要和参数类型中至少有一个相同
    /// <summary>
    /// 自定义泛型委托结合匿名委托和Lambda
    /// </summary>
   public class GenericDelegateLambda
    {
        public int Add(int a,int b)
        {
            return a+b;
        }
        public double Add1(double d1,double d2)
        {
            return d1+d2;
        }

        public void Test()
        {
            //普通泛型委托关联方法
            MyGenericDelegateLambda<int> mydelegate1 = Add;
            MyGenericDelegateLambda<double> mydelegate2 = Add1;

            //泛型委托匿名方法
            MyGenericDelegateLambda<int>  mydelegate3=delegate(int a,int b){ return a+b; };
            MyGenericDelegateLambda<double> mydelegate4 = delegate (double a, double b) { return a+b; };

            //用Lambda表达式
            MyGenericDelegateLambda<int> mydelegate5 = (int a, int b) => {return a + b; };
            MyGenericDelegateLambda<double> mydelegate6 = (a, b) => a+b;
        }

    }
}
