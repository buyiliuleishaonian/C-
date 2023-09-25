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
    public partial class FrmTreeView : Form
    {
        public FrmTreeView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 给TreeView手动代码添加节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTreeView_Load(object sender, EventArgs e)
        {
            this.treeView1.Nodes.Clear();
            #region  手动加载节点
            //如果一个节点下面有子节点，是应该先把这个节点添加到
            //TreeView中，还是先添加好子节点，再添加到TreeView？
            //都可以

            //添加节点过程：创建一个节点，将这个节点添加到TreeView的Nodes集合中
            //创捷节点，将这个节点添加到当前节点的Nodes集合中

            //更多的应用不是这样，而采用递归的方式，加载节点及子节点
            //数据来源：制作成一张表，ParentId--父节点编号
            TreeNode node1 = new TreeNode();
            node1.Name="StudentMange";
            node1.Text="学生管理系统";
            this.treeView1.Nodes.Add(node1);

            TreeNode node2 = new TreeNode();
            node2.Name="Classmanege";
            node2.Name="班级管理系统";
            this.treeView1.Nodes.Add(node2);

            TreeNode node3 = new TreeNode();
            node3.Name="AddStudent";
            node3.Text="新增学生";
            node1.Nodes.Add(node3);

            TreeNode node4 = new TreeNode();
            node4.Name="DeleteStudent";
            node4.Text="毕业学生";
            node1.Nodes.Add(node4);
            #endregion


            this.treeView2.Nodes.Clear();
            //1、获取数据库
            DataTable dt = SQLHelper.GetDataTable("select ID,MName,ParentID from MenuInfo");
            //3、使用方法
            CreateNode(dt,null,0);//这里规定好了根节点
        }


        //2、创建方法
        //首先将根节点确定好，也就是第一次递归时ParentID变为了1，此时在执行这个方法时，得到dr只会是ParentID为1的行
        //以此内推，在执行ParentID为1之后的CreateNode方法时，再次递归时，就执行第一个ParentID为1的行的ID变为新的ParentID
        //判断dt是否有ParentID满足新要求的行，没有则退出递归，以此循环完第一次执行CraeteNode产生的根节点的ID对应的ParentID的值;
        //有则再次执行上诉操作

        /// <summary>
        /// 方法的递归，就是自己调用自己
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="pNode"></param>
        /// <param name="ParentId"></param>
        public void CreateNode(DataTable dt, TreeNode pNode, int ParentId)
        {
            //1、获取要创建的节点数据，Name，Text
            DataRow[] dr = dt.Select("ParentID="+ParentId);
            //2、创建节点对象
            if (dr.Length>0)
            {
                foreach (DataRow r in dr)
                {
                    TreeNode node = new TreeNode();
                    node.Text=r["mName"].ToString();
                    node.Name=r["ID"].ToString();
                    //3、直接添加到TreeView中，还是添加到节点中当子节点
                    if (pNode!=null)
                    {
                        pNode.Nodes.Add(node);
                    }
                    else
                    {
                        this.treeView2.Nodes.Add(node);
                    }
                    //4、创建的节点下面有不有子节点
                    CreateNode(dt,node,Convert.ToInt32(node.Name));
                }
            }
        }

        /// <summary>
        /// 利用递归让父节点勾选之后，所有子节点，子节点中的节点全部勾选
        /// </summary>
        /// <param name="node"></param>
        public void SetCheckNode(TreeNode node)
        {
            //判断其节点是否存在子节点
            if (node.Nodes.Count>0)
            {
                foreach(TreeNode n in node.Nodes) 
                {
                    n.Checked=node.Checked;
                    SetCheckNode(n);
                }
            }
        }

        bool isMouseClick = true;
        
        private void treeView2_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            isMouseClick=false;
            SetCheckNode(e.Node);
            SetParentNode(e.Node);
            isMouseClick=true;
        }

        private void treeView2_AfterCheck(object sender, TreeViewEventArgs e)
        {
            
        }

        /// <summary>
        /// 任何一个子节点勾选之后，父节点就自动勾选
        /// </summary>
        /// <param name="node"></param>
        public void SetParentNode(TreeNode node)
        {
            bool b = true;
            TreeNode nParent = node.Parent;
            if (nParent!=null)
            {
                if (node.Checked==true)
                {
                    nParent.Checked=b;
                }
                SetParentNode(nParent);
            }
            else
            {
                return;
            }
        }
    }
}
