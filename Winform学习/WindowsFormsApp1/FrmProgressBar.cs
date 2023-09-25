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
    public partial class FrmProgressBar : Form
    {
        public FrmProgressBar()
        {
            InitializeComponent();
            this.progressBar1.Maximum = 100;
            this.progressBar1.Minimum=0;
            this.progressBar1.Value=0;
            this.progressBar1.Enabled = false;//不使用
            this.progressBar1.Style=ProgressBarStyle.Continuous;
            this.progressBar1.Step=5;

            this.timer1.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (this.txtBarMax.Text.Trim().Length!=0)
            {
                this.progressBar1.Maximum=Convert.ToInt32( this.txtBarMax.Text);
            }
            this.timer1.Enabled= true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.progressBar1.Value<this.progressBar1.Maximum)
            {
                this.progressBar1.Increment(this.progressBar1.Step);
                this.lblNum.Text=this.progressBar1.Value.ToString();
            }
            else
            {
                this.timer1.Enabled=false;
                 MessageBox.Show("加载已完成");
                return;
            }
        }
        /// <summary>
        /// 暂停事件事件的响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled=false;
        }
        
        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled=true;
        }
    }
}
