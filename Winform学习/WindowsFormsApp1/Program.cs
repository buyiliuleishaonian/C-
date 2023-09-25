using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]//特性，COM的线程模型是单线程模型，如果没有它，无法工作。
        static void Main()
        {
            //Application,是System.Windows.Form.Application的命名空间下的一个静态类
            //提供静态方法和属性来管理应用程序

            //启动应用程序可视样式
            Application.EnableVisualStyles();
            //将某些控件上的CompatibleTextrRenderingDefault设置为false，默认值
            Application.SetCompatibleTextRenderingDefault(false);
            //指定应用程序中的某个窗体
            //启动的窗体可见，并显示出来
            Application.Run(new FrmUserControl());
        }
    }
}
