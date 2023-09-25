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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//初始化窗体组件
        }

        /// <summary>
        /// 绘制窗体前发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //new 控件，初始化控件
            Label lbl1=new Label();
            lbl1.AutoSize= true;//自动显示代销
            lbl1.Location=new Point(60,80);//设置控件的坐标
            lbl1.Name="lbl1";
            lbl1.Size=new Size(100,100);
            lbl1.Text="1234567";
            //添加事件
            lbl1.Click+=Lbl1_Click;
            //将控件添加入窗体
            this.Controls.Add(lbl1);
        }
        /// <summary>
        /// 按下lbl1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lbl1_Click(object sender, EventArgs e)
        {
            //这里的sender就是事件的触发者
            Label lbl2 = (Label)sender;
            MessageBox.Show(lbl2.Text);
        }

        /// <summary>
        /// 得到DateTimePicker的时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.mtxt.TextMaskFormat=MaskFormat.ExcludePromptAndLiterals;
            this.textBox1.Text=this.mtxt.Text;
        }
    }
}
