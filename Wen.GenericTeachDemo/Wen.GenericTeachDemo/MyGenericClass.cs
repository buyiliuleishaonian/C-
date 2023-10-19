using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wen.GenericTeachDemo
{
    public class MyGenericClass
    {
        //泛型是可以加约束的
        //如果需要实现加减乘除，需要写很多的方法重载，针对不同的数据类型

        //对此我们采用泛型方法
        public T Add<T, T1, T2>(T1 num1,T2 num2) where T:struct ,T1,T2//约束返回值类型是，值类型（结构类型），T1,T2同样的约束为结构类型
        {
            // return num1+num2; 是错误的，当返回类型和参数类型不一样，无法转变
            //需要通过Dynamic类型
            dynamic a = num1;//将在运行a时，解析a
            dynamic b = num2;
            return a+b;
        }

        public T Add<T,T1>(T1  num)
            { dynamic a = num;
            return a;
        }
    }

    public class Generic<T>
    {
        List<T> alist=new List<T>();
        
        //索引器
        //public T this[int index]{getlset}索引器的本质

        /// <summary>
        /// 这个类自己的索引器
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[ int index]
        {
            get { return alist[index]; }
            set { alist[index]=value; }
        }

        public List<T> list 
        {
            get { return alist; }
        }
        


        public int Length
        {
            get { return alist.Count; }
        }

        public void Add(T num1)
        {
            alist.Add(num1);
        }

        public void AddRange(T[] nums)
        { 
            alist.AddRange(nums);
        }
    }
}
