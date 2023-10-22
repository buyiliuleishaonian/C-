using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wen.Commit
{
    //1、声明委托
    public delegate string ShowText();

    public delegate void Test(string s);
    public partial class FrmSalve : Form
    {
        public FrmSalve(ShowText text,Test text1)
        {
            //4、关联委托
            ShowText showText = text;
            InitializeComponent();
            //5、调用委托
            //这是在B类中调用A类的方法
            this.textBox1.Text=showText().ToString();
            text2=text1;
        }

        //3、创建委托变量
        public ShowText Test1 { get; set; }//尽量创建委托属性，符合编码规范
         
        ShowText showText = null;

        Test text2 = null;

        private void button1_Click(object sender, EventArgs e)
        {
            text2(this.textBox1.Text);
        }
    }
}
