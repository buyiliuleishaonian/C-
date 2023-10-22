using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wen.EventDemo
{
    public  delegate void ReceiveData(string s);
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 发送信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       

        //把子窗体对象放在容器中
        List<Form> listForm=new List<Form>();   


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
                //在事件中只能+=/-=得到方法
                //这就是在A类中调用B类的方法
                frm.EventReceive+=ReceiveMsg;//关联事件
                listForm.Add(frm);
            }
        }


        public void ReceiveMsg(string s)
        {
            this.textBox1.Text+=s+"\r\n";
        }


        /// <summary>
        /// 也是将数据通信的事件，在窗体 委托事件中删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            //事件无法通过得到null来清空，只能通过-=移除
            foreach (FrmChild frm in listForm)
            {
                frm.EventReceive-=ReceiveMsg;
            }
        }
    }
}
