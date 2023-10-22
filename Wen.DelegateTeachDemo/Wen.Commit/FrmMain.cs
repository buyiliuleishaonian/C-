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
   
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btn_Commit_Click(object sender, EventArgs e)
        {
            FrmSalve slave=new  FrmSalve(Show1,Show2);
            slave.Show();
        }

        //2、编写具体方法
        private string Show1()
        {
            return  this.textBox1.Text;
        }

        private void Show2(string s)
        {
            this.textBox1.Text =s;
        }
    }
}
