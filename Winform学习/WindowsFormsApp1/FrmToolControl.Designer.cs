namespace WindowsFormsApp1
{
    partial class FrmToolControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabText = new System.Windows.Forms.TabPage();
            this.tabFile = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabText.SuspendLayout();
            this.tabFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabText);
            this.tabControl1.Controls.Add(this.tabFile);
            this.tabControl1.Location = new System.Drawing.Point(52, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(524, 407);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabText
            // 
            this.tabText.Controls.Add(this.textBox1);
            this.tabText.Location = new System.Drawing.Point(4, 25);
            this.tabText.Name = "tabText";
            this.tabText.Padding = new System.Windows.Forms.Padding(3);
            this.tabText.Size = new System.Drawing.Size(516, 378);
            this.tabText.TabIndex = 0;
            this.tabText.Text = "文本";
            this.tabText.UseVisualStyleBackColor = true;
            // 
            // tabFile
            // 
            this.tabFile.Controls.Add(this.textBox2);
            this.tabFile.Location = new System.Drawing.Point(4, 25);
            this.tabFile.Name = "tabFile";
            this.tabFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabFile.Size = new System.Drawing.Size(516, 378);
            this.tabFile.TabIndex = 1;
            this.tabFile.Text = "文件";
            this.tabFile.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 25);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(187, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 25);
            this.textBox2.TabIndex = 0;
            // 
            // FrmToolControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 632);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmToolControl";
            this.Text = "FrmToolControl";
            this.Load += new System.EventHandler(this.FrmToolControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabText.ResumeLayout(false);
            this.tabText.PerformLayout();
            this.tabFile.ResumeLayout(false);
            this.tabFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabText;
        private System.Windows.Forms.TabPage tabFile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}