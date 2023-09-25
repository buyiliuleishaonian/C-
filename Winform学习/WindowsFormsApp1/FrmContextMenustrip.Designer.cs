namespace WindowsFormsApp1
{
    partial class FrmContextMenustrip
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
            this.cmsStudent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BackGrounp = new System.Windows.Forms.ToolStripMenuItem();
            this.miClass = new System.Windows.Forms.ToolStripMenuItem();
            this.MiRod = new System.Windows.Forms.ToolStripMenuItem();
            this.MiBlack = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsStudent
            // 
            this.cmsStudent.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackGrounp,
            this.miClass});
            this.cmsStudent.Name = "cmsStudent";
            this.cmsStudent.Size = new System.Drawing.Size(139, 52);
            // 
            // BackGrounp
            // 
            this.BackGrounp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiRod,
            this.MiBlack});
            this.BackGrounp.Name = "BackGrounp";
            this.BackGrounp.Size = new System.Drawing.Size(210, 24);
            this.BackGrounp.Text = "背景颜色";
            // 
            // miClass
            // 
            this.miClass.Name = "miClass";
            this.miClass.Size = new System.Drawing.Size(210, 24);
            this.miClass.Text = "班级窗体";
            // 
            // MiRod
            // 
            this.MiRod.Name = "MiRod";
            this.MiRod.Size = new System.Drawing.Size(122, 26);
            this.MiRod.Text = "红色";
            // 
            // MiBlack
            // 
            this.MiBlack.Name = "MiBlack";
            this.MiBlack.Size = new System.Drawing.Size(122, 26);
            this.MiBlack.Text = "蓝色";
            // 
            // FrmContextMenustrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 719);
            this.ContextMenuStrip = this.cmsStudent;
            this.Name = "FrmContextMenustrip";
            this.Text = "FrmContextMenustrip";
            this.cmsStudent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsStudent;
        private System.Windows.Forms.ToolStripMenuItem BackGrounp;
        private System.Windows.Forms.ToolStripMenuItem MiRod;
        private System.Windows.Forms.ToolStripMenuItem MiBlack;
        private System.Windows.Forms.ToolStripMenuItem miClass;
    }
}