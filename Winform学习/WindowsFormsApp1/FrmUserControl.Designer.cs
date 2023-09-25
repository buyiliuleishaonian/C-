namespace WindowsFormsApp1
{
    partial class FrmUserControl
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
            this.userBUtton1 = new WindowsFormsApp1.UserBUtton();
            this.SuspendLayout();
            // 
            // userBUtton1
            // 
            this.userBUtton1.BtnText = "提交";
            this.userBUtton1.LabText = "aaaa";
            this.userBUtton1.Location = new System.Drawing.Point(250, 146);
            this.userBUtton1.Name = "userBUtton1";
            this.userBUtton1.Size = new System.Drawing.Size(150, 150);
            this.userBUtton1.TabIndex = 0;
            this.userBUtton1.ShowMsg += new System.Action<object, System.EventArgs>(this.userBUtton1_ShowMsg);
            // 
            // FrmUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userBUtton1);
            this.Name = "FrmUserControl";
            this.Text = "FrmUserControl";
            this.ResumeLayout(false);

        }

        #endregion

        private UserBUtton userBUtton1;
    }
}