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
    public partial class FrmLsitview : Form
    {
        //用来存储ImageList的index
        private List<string> keyList=new List<string>();    
        public FrmLsitview()
        {
            InitializeComponent();
        }

        // 通过字典将index索引和路径全部存取进去
        Dictionary<int,string>  dic=new Dictionary<int,string>();
        //通过字典将ListView中的文本与Group对应起来
        Dictionary<string, string> dic1 = new Dictionary<string, string>();

        /// <summary>
        /// 加载窗体之前将对ListView进行项的添加和对于
        /// 属性LargeImage和SmallImage的进行添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLsitview_Load(object sender, EventArgs e)
        {
            //给ListView添加项，给LargeImage，SmallImage添加项，并且默认其为大图标显示，
            AddImageList();
            LargeView(this.largeImage,this.listView1);
            this.listView1.View=View.LargeIcon;
            //创建分组
            this.listView1.Groups.Clear();
            this.listView1.Groups.Add(new ListViewGroup("11", HorizontalAlignment.Left));
            this.listView1.Groups.Add(new ListViewGroup("22", HorizontalAlignment.Left));
            this.listView1.Groups.Add(new ListViewGroup("33", HorizontalAlignment.Left));
            this.listView1.Groups.Add(new ListViewGroup("44", HorizontalAlignment.Left));
            this.listView1.Groups.Add(new ListViewGroup("55", HorizontalAlignment.Left));
            this.listView1.Groups.Add(new ListViewGroup("66", HorizontalAlignment.Left));
            //添加对应关系
            dic1.Add("11", "01");
            dic1.Add("22", "02");
            dic1.Add("33", "03");
            dic1.Add("44", "04");
            dic1.Add("55", "05");
            dic1.Add("66", "06");
        }

        /// <summary>
        /// 将路径下的图片放入到ImageList控件中
        /// </summary>
        private void AddImageList()
        {
            //清空ImageList集合中图片
            this.largeImage.Images.Clear();
            this.smallImage.Images.Clear();
            int num = 0;
            string path = @"F:\wallhaven壁纸下载地";//得到图片所在的文件夹
            if (Directory.Exists(path))//判断该文件夹的路径是否存在
            {
                string[] imageName = Directory.GetFiles(path);//得到文件夹下的所有文件全路径
                string[] imagepath = { ".png", ".jpg" };//将图片格式全部放在string数组中
                if (imageName.Length>0)//判断是否存在文件
                {
                    foreach (var item in imageName)
                    {
                        if (imagepath.Contains(Path.GetExtension(item)))//判断文件的扩展名是否存在图片格式中
                        {
                            Image im = Image.FromFile(item);
                            string s = null;
                            s= (Path.GetFileNameWithoutExtension(item));
                            keyList.Add(s);
                            this.largeImage.Images.Add(s, im);
                            this.smallImage.Images.Add(s, im);
                            dic.Add(num,item);
                            num++;
                        }
                    }
                }
            }
            //设定图标的大小
            this.largeImage.ImageSize=new Size(50,50);
            this.smallImage.ImageSize=new Size(50, 50);
        }

        /// <summary>
        /// 选择ListView控件的Items项和View视图的Large大图标
        /// </summary>
        /// <param name="il">imagelist的对象</param>
        /// <param name="lv">ListView的对象</param>
        private void LargeView(ImageList il,ListView lv)
        {
            lv.Items.Clear();//先将ListView的item项清空
            //先判断ImageList中Images不为空
            if (il.Images!=null && il.Images.Count!=0)
            {
                for (int i=0;i<il.Images.Count;i++)
                {
                    //在代码层中想要给ListView控件添加项需要先创建ListViewItem对象之后将其添加进去
                    ListViewItem lvm=new  ListViewItem();
                    //初始化对象
                    lvm.Text=il.Images.Keys[i];
                    lvm.ImageIndex =i;
                    lv.Items.Add(lvm);
                }
            }
            lv.LargeImageList=il;
            lv.SmallImageList=il;
        }

        /// <summary>
        /// 大图标显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLarge_Click(object sender, EventArgs e)
        {
            this.listView1.View=View.LargeIcon;
        }

        /// <summary>
        /// 小图标显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSmall_Click(object sender, EventArgs e)
        {
            this.listView1.View= View.SmallIcon;
        }

        /// <summary>
        /// List图标显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnList_Click(object sender, EventArgs e)
        {
            this.listView1.View= View.List;
        }

        /// <summary>
        /// tile图表显示，显示大图标，右边显示文本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btntile_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.Tile;
        }


        /// <summary>
        /// 详细视图，首先将ListView中的项全部删除，之后添加需要的项和列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDetail_Click(object sender, EventArgs e)
        {
            //清空项
            this.listView1.Items.Clear();
            //清空列
            this.listView1.Columns.Clear();
            //不能以组进行显示
            this.listView1.ShowGroups=false;
            this.listView1.View=View.Details;
            //添加列
            this.listView1.Columns.Add("文件名",200,HorizontalAlignment.Left);
            this.listView1.Columns.Add("修改时间",100,HorizontalAlignment.Left);
            this.listView1.Columns.Add("文件类型",100,HorizontalAlignment.Left);
            this.listView1.Columns.Add("大小",100,HorizontalAlignment.Left);
            //添加项
            for (int i = 0; i<dic.Count; i++)
            {
                //创建listviewitem的项的对象，给定listimage的索引index和文本Text
                //添加子项
                ListViewItem li = new ListViewItem( this.smallImage.Images.Keys[i],i);
                li.SubItems.Add(File.GetCreationTime(dic[i]).ToString());//修改日期
                li.SubItems.Add(Path.GetExtension(dic[i]));//文件的后缀名
                long lg=new FileInfo(dic[i]).Length;//获取文件的大小
                li.SubItems.Add((lg/1024).ToString()+"/kb");
                this.listView1.Items.Add(li);
                //因为详细视图显示的时候，将ListView中的项全部清空了
                //所以需要判断是否分组，如果存在就分组，不存在就保存原样
                if (this.listView1.ShowGroups)
                {
                    foreach (ListViewGroup item in this.listView1.Groups)
                    {
                        //item.header可以在判断时，自动更换
                        if (li.Text.Substring(0,2)==dic1[item.Header])
                        {
                           li.Group=item;
                            break;
                        }
                    }
                }
            }
            this.listView1.GridLines=true;//显示网格
        }

       /// <summary>
       /// 将ListView中的项，进行分组
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnGroup_Click(object sender, EventArgs e)
        {
            //首先确定可以开启分组
            this.listView1.ShowGroups = true ;
            //将ListView中的文件进行分组
            for (int i=0;i<this.listView1.Items.Count;i++)
            {
                foreach (ListViewGroup item in this.listView1.Groups)
                {
                    //item.header可以在判断时，自动更换
                    if (this.listView1.Items[i].Text.Substring(0, 2)==dic1[item.Header])
                    {
                        this.listView1.Items[i].Group=item;
                        break;
                    }
                }
            }
        }
    }
}
