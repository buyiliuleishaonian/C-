namespace WindowsFormsApp1
{
    partial class FrmMenustrip
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
            this.StudentMenus = new System.Windows.Forms.MenuStrip();
            this.MeStudnet = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateStudentForm = new System.Windows.Forms.ToolStripMenuItem();
            this.MeClass = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateClass = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StudentMenus.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentMenus
            // 
            this.StudentMenus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StudentMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MeStudnet,
            this.MeClass,
            this.CloseForm});
            this.StudentMenus.Location = new System.Drawing.Point(0, 0);
            this.StudentMenus.Name = "StudentMenus";
            this.StudentMenus.Size = new System.Drawing.Size(1153, 28);
            this.StudentMenus.TabIndex = 0;
            this.StudentMenus.Text = "主菜单";
            // 
            // MeStudnet
            // 
            this.MeStudnet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateStudentForm});
            this.MeStudnet.Name = "MeStudnet";
            this.MeStudnet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.MeStudnet.Size = new System.Drawing.Size(101, 24);
            this.MeStudnet.Text = "学生管理(&F)";
            this.MeStudnet.MouseHover += new System.EventHandler(this.MeStudnet_MouseHover);
            // 
            // CreateStudentForm
            // 
            this.CreateStudentForm.Name = "CreateStudentForm";
            this.CreateStudentForm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.CreateStudentForm.Size = new System.Drawing.Size(224, 26);
            this.CreateStudentForm.Text = "学生窗体";
            this.CreateStudentForm.Click += new System.EventHandler(this.CreateStudentForm_Click);
            // 
            // MeClass
            // 
            this.MeClass.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateClass});
            this.MeClass.Name = "MeClass";
            this.MeClass.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.MeClass.Size = new System.Drawing.Size(105, 24);
            this.MeClass.Text = "班级管理(&N)";
            // 
            // CreateClass
            // 
            this.CreateClass.Name = "CreateClass";
            this.CreateClass.Size = new System.Drawing.Size(152, 26);
            this.CreateClass.Text = "班级窗体";
            this.CreateClass.Click += new System.EventHandler(this.CreateClass_Click);
            // 
            // CloseForm
            // 
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(83, 24);
            this.CloseForm.Text = "退出程序";
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 660);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1153, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmMenustrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 684);
            this.Controls.Add(this.StudentMenus);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.StudentMenus;
            this.Name = "FrmMenustrip";
            this.Text = "FrmMenustrip";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenustrip_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenustrip_Load);
            this.StudentMenus.ResumeLayout(false);
            this.StudentMenus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip StudentMenus;
        private System.Windows.Forms.ToolStripMenuItem MeStudnet;
        private System.Windows.Forms.ToolStripMenuItem CreateStudentForm;
        private System.Windows.Forms.ToolStripMenuItem MeClass;
        private System.Windows.Forms.ToolStripMenuItem CreateClass;
        private System.Windows.Forms.ToolStripMenuItem CloseForm;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}