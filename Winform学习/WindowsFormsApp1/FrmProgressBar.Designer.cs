namespace WindowsFormsApp1
{
    partial class FrmProgressBar
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblBar = new System.Windows.Forms.Label();
            this.txtBarMax = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(171, 202);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(324, 43);
            this.progressBar1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(112, 320);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(77, 59);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "加载";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(269, 320);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(77, 59);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "暂停";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(450, 320);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(77, 59);
            this.btnContinue.TabIndex = 3;
            this.btnContinue.Text = "继续";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblBar
            // 
            this.lblBar.AutoSize = true;
            this.lblBar.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBar.Location = new System.Drawing.Point(157, 117);
            this.lblBar.Name = "lblBar";
            this.lblBar.Size = new System.Drawing.Size(96, 28);
            this.lblBar.TabIndex = 4;
            this.lblBar.Text = "进度条";
            // 
            // txtBarMax
            // 
            this.txtBarMax.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBarMax.Location = new System.Drawing.Point(287, 114);
            this.txtBarMax.Name = "txtBarMax";
            this.txtBarMax.Size = new System.Drawing.Size(171, 38);
            this.txtBarMax.TabIndex = 5;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNum.Location = new System.Drawing.Point(539, 217);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(96, 28);
            this.lblNum.TabIndex = 6;
            this.lblNum.Text = "进度条";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 644);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtBarMax);
            this.Controls.Add(this.lblBar);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.progressBar1);
            this.Name = "FrmProgressBar";
            this.Text = "FrmProgressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblBar;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtBarMax;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
    }
}