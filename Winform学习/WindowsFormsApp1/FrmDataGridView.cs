using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmDataGridView : Form
    {
        public FrmDataGridView()
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
        }

        private void FrmDataGridView_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“学生学习系统管理DBDataSet.StudentsInfos”中。您可以根据需要移动或移除它。
            //this.studentsInfosTableAdapter.Fill(this.学生学习系统管理DBDataSet.StudentsInfos);
            //this.dataGridView1.SelectedRows[1].Cells[0].Selected = true;

            #region 在代码中添加列,添加什么列，就创建对应的对象
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.Name= "User";
            col1.HeaderText="用户名";
            col1.DataPropertyName="";//或许数据源对应的名称或者与DataGridViewColumns绑定的数据库列的名称
            this.dataGridView2.Columns.Add(col1);
            DataGridViewCheckBoxColumn col2 = new DataGridViewCheckBoxColumn();
            col2.Name= "Password";
            col2.HeaderText="密码";
            col2.DataPropertyName="";//或许数据源对应的名称或者与DataGridViewColumns绑定的数据库列的名称
            this.dataGridView2.Columns.Add(col2);
            DataGridViewLinkColumn col3 = new DataGridViewLinkColumn();
            col3.Name= "baidu";
            col3.HeaderText="百度";
            col3.DataPropertyName="";//或许数据源对应的名称或者与DataGridViewColumns绑定的数据库列的名称
            this.dataGridView2.Columns.Add(col3);
            DataGridViewComboBoxColumn col4 = new DataGridViewComboBoxColumn();
            col4.Name="Class";
            col4.HeaderText="班级";
            this.dataGridView2.Columns.Add(col4);

            //添加数据,添加行
            //首先创建行对象
            DataGridViewRow dr = new DataGridViewRow();
            //之后创建单元格，然后给单元格赋值，之后传递给行
            DataGridViewCell cel1 = new DataGridViewTextBoxCell();
            cel1.Value="admin";
            DataGridViewCell cel2 = new DataGridViewCheckBoxCell();
            cel2.Value=false;
            DataGridViewCell cel3 = new DataGridViewLinkCell();
            cel3.Value="抖音";
            DataGridViewCell cel4 = new DataGridViewComboBoxCell();
            cel4.Value="机器人1902";
            dr.Cells.AddRange(new DataGridViewCell[] { cel1, cel2, cel3 });

            this.dataGridView2.Rows.Add(dr);

            #endregion

            //通过连接数据库来显示数据
            #region 连接数据库 来显示数据
            DataTable dt = SQLHelper.GetDataTable("select * from studentsinfos");
            this.dataGridView3.DataSource=null;
            this.dataGridView3.DataSource=dt;
            #endregion


            #region  定义好DataGridView列的数据来源之后，通过List来实现显示数据
            //选择DataGridViewComboBoxColumn
            DataTable dt1 = SQLHelper.GetDataTable("select classid,classname from classinfos");
            DataGridViewComboBoxColumn dgvcbo = this.dataGridView4.Columns["KeMu"] as DataGridViewComboBoxColumn;
            dgvcbo.DataSource=dt1;
            dgvcbo.ValueMember="classid";//每个内容对应index
            dgvcbo.DisplayMember="classname";//下拉款内容


            //连接List来显示 数据，List里面是对象
            //做的太多，我不想做了
            List<StudentClass> list = new List<StudentClass>();
            SqlDataReader sqlread = SQLHelper.GetExecuteReader("select studentname,gender,classid from studentsinfos");
            while (sqlread.Read())
            {
                list.Add(new StudentClass()
                {
                    StudentName=sqlread["studentname"].ToString(),
                    Gender=sqlread["gender"].ToString(),
                    Classid=Convert.ToInt32(sqlread["classid"])
                });
            }
            this.dataGridView4.DataSource=null;
            this.dataGridView4.DataSource=list;
            #endregion


            DataTable dt2 = SQLHelper.GetDataTable("select * from admins");
            this.dataGridView5.DataSource=null;

            this.dataGridView5.DataSource=dt2;
        }

        /// <summary>
        /// 判断DataGridView中选中的行，进行删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<StudentClass> list = new List<StudentClass>();
            if (this.dataGridView4.RowCount==0)
            {
                MessageBox.Show("没有数据");
                return;
            }
            for (int i = 0; i<this.dataGridView4.RowCount; i++)
            {
                DataGridViewCheckBoxCell chk = this.dataGridView4.Rows[i].Cells["StudentChecked"] as DataGridViewCheckBoxCell;
                if (chk.FormattedValue.ToString()=="True")
                {
                    StudentClass student = this.dataGridView4.Rows[i].DataBoundItem as StudentClass;
                    list.Add(student);
                }
            }
            if (list.Count>0)
            {

            }
            else
            {
                MessageBox.Show("请选择删除对象");
                return;
            }
        }


        /// <summary>
        /// 点击单元格发生对应的变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell dgvc = this.dataGridView5.Rows[e.RowIndex].Cells["delete"] as DataGridViewCheckBoxCell;
            if (dgvc.Value.ToString()=="True")
            {
                DataRow dr = (this.dataGridView5.Rows[e.RowIndex].DataBoundItem as DataRowView).Row;
                dr.Delete();
            }

        }
            /// <summary>
            /// 用来提交datagridview控件改变，对应的数据库也做出的改变
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnGet_Click(object sender, EventArgs e)
            {
                //SqlComandBuilder Adapter自动配置要执行操作命令
                //必须定位要操作的表
                using (SqlConnection con = new SqlConnection(SQLHelper.sql1))
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from admins", con);//需要定位到需要操作的表
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    DataTable dt = this.dataGridView5.DataSource as DataTable;
                    sda.Update(dt);
                }
            }

        
    }
}
