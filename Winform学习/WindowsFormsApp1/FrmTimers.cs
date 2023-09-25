using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmTimers : Form
    {
        private delegate void dt();

        private System.Threading.Timer timer3;
        public FrmTimers()
        {
            InitializeComponent();
            this.textBox1.Text=DateTime.Now.ToShortDateString();
        }
        int nums = 0;
        private void FrmTimers_Load(object sender, EventArgs e)
        {
            //创建控件对象
            System.Timers.Timer timer = new System.Timers.Timer();
            //timer.AutoReset = false;//只执行一次，就会停止触发对应的Elapsed事件
            //设定控件属性
            timer.Interval = 1000;
            //添加事件
            timer.Elapsed+=Timer_Elapsed;
            //执行控件，这个控件不需要添加到容器中去
            timer.Start();

           timer3=new System.Threading.Timer(new System.Threading.TimerCallback(objDelegate => { nums+=2;
               Action<int> ac = ShowThreadTime;
               this.Invoke(ac,nums);
           }),null,1000,1000); 
        }

        private void ShowThreadTime(int num)
        {
            this.label3.Text=num.ToString();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Action action = UpTextBox2;//Winform中自带的
            this.Invoke(action);
        }

        public void UpTextBox2()
        {
            this.textBox2.Text=DateTime.Now.ToLongDateString();
        }
    }
}
