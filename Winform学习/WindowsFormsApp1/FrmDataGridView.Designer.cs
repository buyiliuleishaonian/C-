namespace WindowsFormsApp1
{
    partial class FrmDataGridView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuImageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsInfosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.学生学习系统管理DBDataSet = new WindowsFormsApp1.学生学习系统管理DBDataSet();
            this.studentsInfosTableAdapter = new WindowsFormsApp1.学生学习系统管理DBDataSetTableAdapters.StudentsInfosTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.KeMu = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.adminname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGet = new System.Windows.Forms.Button();
            this.学生学习系统管理DBDataSet1 = new WindowsFormsApp1.学生学习系统管理DBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsInfosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生学习系统管理DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生学习系统管理DBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.studentIdNoDataGridViewTextBoxColumn,
            this.cardNoDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.studentAddressDataGridViewTextBoxColumn,
            this.classidDataGridViewTextBoxColumn,
            this.stuImageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentsInfosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(707, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIDDataGridViewTextBoxColumn.Width = 71;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.Width = 70;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 71;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.Width = 71;
            // 
            // studentIdNoDataGridViewTextBoxColumn
            // 
            this.studentIdNoDataGridViewTextBoxColumn.DataPropertyName = "StudentIdNo";
            this.studentIdNoDataGridViewTextBoxColumn.HeaderText = "StudentIdNo";
            this.studentIdNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIdNoDataGridViewTextBoxColumn.Name = "studentIdNoDataGridViewTextBoxColumn";
            this.studentIdNoDataGridViewTextBoxColumn.Width = 71;
            // 
            // cardNoDataGridViewTextBoxColumn
            // 
            this.cardNoDataGridViewTextBoxColumn.DataPropertyName = "CardNo";
            this.cardNoDataGridViewTextBoxColumn.HeaderText = "CardNo";
            this.cardNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cardNoDataGridViewTextBoxColumn.Name = "cardNoDataGridViewTextBoxColumn";
            this.cardNoDataGridViewTextBoxColumn.Width = 70;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 71;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 71;
            // 
            // studentAddressDataGridViewTextBoxColumn
            // 
            this.studentAddressDataGridViewTextBoxColumn.DataPropertyName = "StudentAddress";
            this.studentAddressDataGridViewTextBoxColumn.HeaderText = "StudentAddress";
            this.studentAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentAddressDataGridViewTextBoxColumn.Name = "studentAddressDataGridViewTextBoxColumn";
            this.studentAddressDataGridViewTextBoxColumn.Width = 71;
            // 
            // classidDataGridViewTextBoxColumn
            // 
            this.classidDataGridViewTextBoxColumn.DataPropertyName = "Classid";
            this.classidDataGridViewTextBoxColumn.HeaderText = "Classid";
            this.classidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classidDataGridViewTextBoxColumn.Name = "classidDataGridViewTextBoxColumn";
            this.classidDataGridViewTextBoxColumn.Width = 70;
            // 
            // stuImageDataGridViewTextBoxColumn
            // 
            this.stuImageDataGridViewTextBoxColumn.DataPropertyName = "StuImage";
            this.stuImageDataGridViewTextBoxColumn.HeaderText = "StuImage";
            this.stuImageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stuImageDataGridViewTextBoxColumn.Name = "stuImageDataGridViewTextBoxColumn";
            this.stuImageDataGridViewTextBoxColumn.Width = 71;
            // 
            // studentsInfosBindingSource
            // 
            this.studentsInfosBindingSource.DataMember = "StudentsInfos";
            this.studentsInfosBindingSource.DataSource = this.学生学习系统管理DBDataSet;
            // 
            // 学生学习系统管理DBDataSet
            // 
            this.学生学习系统管理DBDataSet.DataSetName = "学生学习系统管理DBDataSet";
            this.学生学习系统管理DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsInfosTableAdapter
            // 
            this.studentsInfosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(35, 370);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(707, 212);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(808, 122);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(505, 270);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KeMu,
            this.StudentName,
            this.Gender,
            this.StudentChecked});
            this.dataGridView4.Location = new System.Drawing.Point(794, 427);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 27;
            this.dataGridView4.Size = new System.Drawing.Size(551, 140);
            this.dataGridView4.TabIndex = 3;
            // 
            // KeMu
            // 
            this.KeMu.DataPropertyName = "classid";
            this.KeMu.HeaderText = "科目";
            this.KeMu.MinimumWidth = 6;
            this.KeMu.Name = "KeMu";
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "studentname";
            this.StudentName.HeaderText = "姓名";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "gender";
            this.Gender.HeaderText = "性别";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            // 
            // StudentChecked
            // 
            this.StudentChecked.HeaderText = "删除";
            this.StudentChecked.MinimumWidth = 6;
            this.StudentChecked.Name = "StudentChecked";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(931, 589);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 27);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.delete,
            this.adminname});
            this.dataGridView5.Location = new System.Drawing.Point(113, 122);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 27;
            this.dataGridView5.Size = new System.Drawing.Size(513, 164);
            this.dataGridView5.TabIndex = 5;
            this.dataGridView5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn1.HeaderText = "列数";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn2.HeaderText = "密码";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // delete
            // 
            this.delete.HeaderText = "删除";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.ToolTipText = "删除";
            // 
            // adminname
            // 
            this.adminname.DataPropertyName = "adminname";
            this.adminname.HeaderText = "管理员";
            this.adminname.MinimumWidth = 6;
            this.adminname.Name = "adminname";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(401, 19);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(149, 21);
            this.btnGet.TabIndex = 6;
            this.btnGet.Text = "提交";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // 学生学习系统管理DBDataSet1
            // 
            this.学生学习系统管理DBDataSet1.DataSetName = "学生学习系统管理DBDataSet";
            this.学生学习系统管理DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 822);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmDataGridView";
            this.Text = "FrmDataGridView";
            this.Load += new System.EventHandler(this.FrmDataGridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsInfosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生学习系统管理DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生学习系统管理DBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private 学生学习系统管理DBDataSet 学生学习系统管理DBDataSet;
        private System.Windows.Forms.BindingSource studentsInfosBindingSource;
        private 学生学习系统管理DBDataSetTableAdapters.StudentsInfosTableAdapter studentsInfosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuImageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewComboBoxColumn KeMu;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewCheckBoxColumn StudentChecked;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminname;
        private 学生学习系统管理DBDataSet 学生学习系统管理DBDataSet1;
    }
}