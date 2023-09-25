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
    public partial class FrmToolControl : Form
    {
        public FrmToolControl()
        {
            InitializeComponent();
        }

        private void FrmToolControl_Load(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(1);//指定选项卡，选择哪一项
            string s = this.tabControl1.SelectedTab.Text;//获取选择的选项卡的text和name；
            this.tabControl1.SelectedIndex = 1;//指定索引激活选定选项卡
        }

        /// <summary>
        /// 当选项卡的索引发生改变时触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strIndex = this.tabControl1.SelectedTab.Text.ToString();
            switch (strIndex)
            {
                case "文本":
                    this.textBox1.Text=strIndex;
                break;
                case "文件":
                    this.textBox2.Text=strIndex;
                    break;
            }
        }
    }
}
