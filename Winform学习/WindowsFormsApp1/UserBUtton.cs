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
    public partial class UserBUtton : UserControl
    {
        public UserBUtton()
        {
            InitializeComponent();
        }
        private string _btnText;
        //添加属性和字段
        public string BtnText
        {
            get { return _btnText; }
            set { _btnText = value;
                this.button1.Text=value;
            }
        }
        private string _labText;
        [Browsable(true)]
        [Category("自定义")]
        [Description("基于label控件的text")]
        public string LabText
        {
            get { return _labText; }
            set { _labText = value;
            this.label1.Text=value;}
        }


        //prop   一次tab可以快速生成一个属性
        public int MyProperty { get; set; }

        //propfull 两次tab可以快速生成一个属性和对应的字段
        private int myVar;

        public int MyVar
        {
            get { return myVar; }
            set { myVar = value; }
        }



        //添加事件，1、需要在类的内部声明事件
        public event Action<object, EventArgs> ShowMsg;

        //2、事件通常在类内部触发，类的外部也可以触发
        //事件通常通过调用委托变量来触发，但只能在包含事件的类内部使用 event 关键字来引发事件。
        private void UserBUtton_Load(object sender, EventArgs e)
        {
            BtnText = "提交";
            LabText="aaaa";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ShowMsg!=null)
            {
                ShowMsg(this, e);
            }
        }
    }
}
