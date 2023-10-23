using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wen.TaskCrossVisit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 解决子线程跨线程改变主线程控件属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            Task task = new Task(() =>
            {
                this.label1.Text="来自Task的任务信息，跟着常老师学了很多c#高级编程知识";
            });
            //这个方法就是用来解决跨线程访问
            task.Start(TaskScheduler.FromCurrentSynchronizationContext());
        }

        /// <summary>
        /// 模拟耗时任务,耗时任务，就是在线程中，需要经过很多代码之后，才可以显示结果
        /// 但是在没有显示结果之前，是无法进行其他操作的
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Time_Click(object sender, EventArgs e)
        {
            Task task = new Task(() => 
            {
                Thread.Sleep(5000);
                this.label1.Text="来自Task的任务信息，跟着常老师学了很多c#高级编程知识";
            });
            task.Start(TaskScheduler.FromCurrentSynchronizationContext());
        }

        /// <summary>
        /// 解决耗时任务，就是在线程中，执行耗时的代码，之后，直接显示出来，同时这段时间还可以执行别的代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            //通常要用Run方法，要不然无法启动线程
            Task task = Task.Run(() => 
            {
                Thread.Sleep(5000);
            });
            task.ContinueWith((t) => 
            {
                this.label1.Text="来自Task的任务信息，跟着常老师学了很多c#高级编程知识";
            },TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
