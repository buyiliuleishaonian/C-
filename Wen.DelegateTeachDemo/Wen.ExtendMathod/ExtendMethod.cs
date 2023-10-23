using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wen.ExtendMathod
{
    public static class ExtendMethod
    {
        /// <summary>
        /// 对int类的扩展扩展的类必须是static类型
        /// </summary>
        /// <param name="num1">是当前int变量的值的</param>，当我们需要扩展别人开发的类时，可以将int 换成别人类的名
        /// <param name="num2">这个是参数</param>
        /// <returns></returns>
        public static double Divstion(this int num1,int num2)
        {
            return (num1/num2);
        }
    }
}
