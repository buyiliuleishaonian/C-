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
    public partial class FrmRichTextBox : Form
    {
        public FrmRichTextBox()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 选择文本，之后在RichtextBox中显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStreamFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd=new OpenFileDialog();
            ofd.Filter="文本文件|*.txt|PDF|*.PDF";
            ofd.InitialDirectory=@"F:\桌面";
            ofd.Multiselect=false;//只能选择一个文件
            ofd.Title="选择文件";
            DialogResult result = ofd.ShowDialog();
            if(result==DialogResult.Cancel)
            {
                return;
            }
            //暂时我只知道可以显示Text中ASNI的编码格式
            this.richTextBox1.LoadFile(ofd.FileName,RichTextBoxStreamType.PlainText);
        }

        /// <summary>
        /// 保存到rft文件的后缀名 文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd= new FolderBrowserDialog();
            fbd.Description="请选择保存路径";
            fbd.SelectedPath=@"F:\";
            DialogResult ds= fbd.ShowDialog();
            if (ds==DialogResult.Cancel) return;
            this.richTextBox1.SaveFile(fbd.SelectedPath+@"\保存文件.ref");
        }

        /// <summary>
        /// 打开超链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        /// <summary>
        /// 通过winform中的剪切板将图片插入到RichTextBox中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImage_Click(object sender, EventArgs e)
        {
            //将应用程序中的ClipBoard剪切板
            Clipboard.Clear();
            //将图片路径得到图片粘贴到剪切板中
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter="所有文件|*.*";
            ofd.InitialDirectory=@"F:\桌面";
            ofd.Multiselect=false;//只能选择一个文件
            ofd.Title="选择文件";
            DialogResult result = ofd.ShowDialog();
            if (result==DialogResult.Cancel)
            {
                return;
            }
            //Bitmap bmp = new Bitmap(ofd.FileName);
            Image im = Image.FromFile(ofd.FileName);
            Clipboard.SetImage(im);
            this.richTextBox1.Paste();//直接粘贴剪切板上的图片
        }

        /// <summary>
        /// 将选中文本字体，判断是否加粗，
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFont_Click(object sender, EventArgs e)
        {
            //创建两个字体样式
            Font oldFont, newFont;
            oldFont=this.richTextBox1.Font;
            if (oldFont.Bold)//判断得到文本的字体样式是否加粗
            {
                newFont=new Font(this.richTextBox1.Font, FontStyle.Bold);
            }
            else//取消加粗文本
            {
                newFont=new Font(this.richTextBox1.Font,FontStyle.Regular);
            }
        }

        private void btnDock_Click(object sender, EventArgs e)
        {
            //判断选择的文本的对齐方式
            if (this.richTextBox1.SelectionAlignment==HorizontalAlignment.Center)
            {
                this.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
            else if(this.richTextBox1.SelectionAlignment == HorizontalAlignment.Left)
            {
                this.richTextBox1.SelectionAlignment=HorizontalAlignment.Center;
            }
        }
    }
}
