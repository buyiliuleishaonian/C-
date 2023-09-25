using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmImageList : Form
    {
        public FrmImageList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 在加载窗体时，将ImageList控件添加好图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmImageList_Load(object sender, EventArgs e)
        {
            List<string> key=new List<string>();
            string imageFile = @"F:\wallhaven壁纸下载地";//确定存在图片的文件夹路径
            if (Directory.Exists(imageFile))//判断磁盘下是否存在对应的文件夹
            {
                string[] indexImage = { ".png",".bmp",".ico"};
                string[] fileName=Directory.GetFiles(imageFile);//得到文件夹下的所有文件名
                if (fileName.Length>0)//判断文件夹下存在文件
                {
                    foreach (string file in fileName) //得到fileNam数组的下的每一个文件名
                    {
                        if (indexImage.Contains(Path.GetExtension(file)))//判断文件名的后缀是否满足要求
                        {
                            Image im=Image.FromFile(file);
                            key.Add(Path.GetFileNameWithoutExtension(file));
                            this.imageList1.Images.Add(Path.GetFileNameWithoutExtension(file),im);
                        }
                    }
                }
                this.imageList1.ImageSize = new Size(200,200);
                //一般无法自己显示，一般用于控件的ImageList属性，可以更具ImageList控件对应的ImageIndex和ImageKey得到ImageList控件对应的图片
            }
        }
    }
}
