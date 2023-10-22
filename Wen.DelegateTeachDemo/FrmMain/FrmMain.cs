using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain
{
    //创建委托
    public delegate void Receive(string s);
    public partial class FrmMain : Form
    {
        //声明委托
        public Receive rc { get; set; }
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 发送信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //使用委托
            rc(this.textBox1.Text);
        }

        private string Send()
        {
            return this.textBox1.Text;
        }

        /// <summary>
        /// 创建窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 4; i++)
            {
                FrmChild frm = new FrmChild();
                frm.Show();
                //如果只是等于B窗体中的方法，她只会关联最后一次的方法，必须使用+=
                //这就是在A类中调用B类的方法
                rc+=frm.ReceiveText;//关联委托
            }
        }
    }
}
