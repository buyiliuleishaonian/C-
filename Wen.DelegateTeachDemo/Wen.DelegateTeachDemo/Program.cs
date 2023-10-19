using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//泛型，委托，事件，多线程
//委托：方法，将方法当作参数
//类A（a） ——>类B（b,c）（正常情况下当A类中调用了B类，是无法在b类中创建A类的对象）
//问题：c是无法直接访问A类中的a方法，使用委托可以完成这个任务
//委托：是不是对a这个方法的访问起到“桥梁作用”
//委托：就是将方法，当作参数来使用
//委托：五步法

//1、声明委托，必须定义在类的外面，命名空间下;就是声明方法的原型

//2、根据委托写出对应的方法

//3、创建委托变量

//4、关联委托方法（给委托赋值），多路委托（多播委托），按我关联的顺序运行，可以通过=，+=，-=分别是关联，关联，删除关联

//5、使用委托变量

namespace Wen.DelegateTeachDemo
{
    public delegate void Mydelegate();

    internal class Program
    {
        static void Main(string[] args)
        {
            Mydelegate my = null;
            my=Mystuday1;
            my+=Mystuday2;
            my+=Mystuday3;

            Console.ReadKey(true);
        }

        static void Mystuday1()
        {
            Console.WriteLine("输出1");
        }
        static void Mystuday2()
        {
            Console.WriteLine("输出2");
        }
        static void Mystuday3()
        {
            Console.WriteLine("输出3");
        }


    }
}
