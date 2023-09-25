using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.MenuStrip;

namespace WindowsFormsApp1
{
    public partial class FrmMenustrip : Form
    {
        public FrmMenustrip()
        {
            InitializeComponent();            
        }

        /// <summary>
        /// 退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseForm_Click(object sender, EventArgs e)
        {
            //DialogResult dl=MessageBox.Show("退出窗体","提示信息",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            //if (dl==DialogResult.OK)
            //{
            //    Application.Exit(); 
            //}
            this.Close(); 
        }

        /// <summary>
        /// 创建学生窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateStudentForm_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length!=0)//判断Mdi容器是否已经存在子窗体
            {
                foreach (Form item in this.MdiChildren)//循环遍历窗体中的控件，是否含有窗体控件，就将其删除
                {
                    item.Close();
                    FrmStudent frm = new FrmStudent();
                    frm.MdiParent= this;
                    frm.Show();//mdi不支持shoedialog()
                }
            }
            else
            {
                FrmStudent frm = new FrmStudent();
                frm.MdiParent= this;
                frm.Show();//mdi不支持shoedialog()
            }
        }

        /// <summary>
        /// 创建班级窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateClass_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length!=0)//判断Mdi容器是否已经存在子窗体
            {
                foreach (Form item in this.MdiChildren)//循环遍历窗体中的控件，是否含有窗体控件，就将其删除
                {
                    item.Close();
                    FrmClass frm = new FrmClass();
                    frm.MdiParent= this;
                    frm.Show();
                }
            }
            else
            {
                FrmClass frm = new FrmClass();
                frm.MdiParent= this;
                frm.Show();
            }
        }

        private void FrmMenustrip_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("退出窗体", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl==DialogResult.OK)
            {
                return;
            }
            else
            {
                e.Cancel = true;
                return;
            }
        }

        /// <summary>
        /// 在程序中添加菜单项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMenustrip_Load(object sender, EventArgs e)
        {
            //菜单项
           ToolStripMenuItem tsi=new ToolStripMenuItem();
            tsi.Text="学生管理(&M)";//快捷键设置，直接在文本后面添加对应的要求就可以
            tsi.Name="MiStudent";
            //子菜单
            ToolStripMenuItem ts=new    ToolStripMenuItem();
            ts.Text="学生窗体";
            ts.Name="CreatStudentForm";
            //添加子菜单的响应事件,就是添加事件
            ts.Click +=Ts_Click; ;
            //主菜单添加子菜单之后，将主菜单添加到菜单项中
            tsi.DropDownItems.Add(ts);

            this.menuStrip1.Items.Add(tsi);
        }

        private void Ts_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 当我鼠标在菜单栏第一项停留时，将自动显示子菜单项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MeStudnet_MouseHover(object sender, EventArgs e)
        {
            //将触发这个事件的的对象sender 转化为ToolStripMenuItems对象
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            //判断是否存在子菜单，并且显示子菜单
            if (item.HasDropDownItems && !item.DropDown.Visible)
            {
                item.ShowDropDown();//显示子菜单
            }
        }
    }
}
