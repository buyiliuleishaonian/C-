using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wen.GenericTeachDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyGenericClass  genericClass = new MyGenericClass();
            double result1= genericClass.Add<int, int, int>(100,100);
            double result2= genericClass.Add<double, double, double>(100.0,122.0) ;

            Console.WriteLine(result1);
            Console.WriteLine(result2);

           Generic<string>  gr=new Generic<string>();
            gr.Add("ss");
            gr.Add("s");
            Console.ReadKey(true);
        }
    }
}
