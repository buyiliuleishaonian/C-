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

namespace Wen.TaskAdanceDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //取消任务信号源
        private CancellationTokenSource cts=new CancellationTokenSource();

        /// <summary>
        /// 启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TaskStart_Click(object sender, EventArgs e)
        {
            //如果任务取消之后，还想在运行,就重新new一个取消对象源好了
            if (cts.IsCancellationRequested)
            {
                cts=new CancellationTokenSource();
            }
            Task task = new Task(() => {
                int nums = 0;
                while (!cts.IsCancellationRequested)
                {
                    nums++;
                    Thread.Sleep(1000);
                    Console.WriteLine(nums);
                }
            },cts.Token);
            task.Start();   
        }

        /// <summary>
        /// 停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TaskStop_Click(object sender, EventArgs e)
        {
            cts.Cancel();//取消之后，无法再启动
        }

        /// <summary>
        /// 暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TaskReSet_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 继续
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TaskContinue_Click(object sender, EventArgs e)
        {

        }
    }
}
