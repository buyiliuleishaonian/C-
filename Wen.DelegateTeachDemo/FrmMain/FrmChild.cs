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
    public partial class FrmChild : Form
    {
        public Receive rce { get; set; }
        public FrmChild()
        {
            
            InitializeComponent();
        }

        //根据委托创建方法
        public void ReceiveText(string s)
        {
            this.textBox1.Text+=s+"\r\n";
        }

    }
}
