namespace Wen.TaskAdanceDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_TaskStart = new System.Windows.Forms.Button();
            this.btn_TaskStop = new System.Windows.Forms.Button();
            this.btn_TaskReSet = new System.Windows.Forms.Button();
            this.btn_TaskContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_TaskStart
            // 
            this.btn_TaskStart.AutoSize = true;
            this.btn_TaskStart.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_TaskStart.Location = new System.Drawing.Point(106, 72);
            this.btn_TaskStart.Name = "btn_TaskStart";
            this.btn_TaskStart.Size = new System.Drawing.Size(160, 70);
            this.btn_TaskStart.TabIndex = 0;
            this.btn_TaskStart.Text = "启动Task";
            this.btn_TaskStart.UseVisualStyleBackColor = true;
            this.btn_TaskStart.Click += new System.EventHandler(this.btn_TaskStart_Click);
            // 
            // btn_TaskStop
            // 
            this.btn_TaskStop.AutoSize = true;
            this.btn_TaskStop.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_TaskStop.Location = new System.Drawing.Point(414, 72);
            this.btn_TaskStop.Name = "btn_TaskStop";
            this.btn_TaskStop.Size = new System.Drawing.Size(170, 70);
            this.btn_TaskStop.TabIndex = 1;
            this.btn_TaskStop.Text = "取消Task(停止)";
            this.btn_TaskStop.UseVisualStyleBackColor = true;
            this.btn_TaskStop.Click += new System.EventHandler(this.btn_TaskStop_Click);
            // 
            // btn_TaskReSet
            // 
            this.btn_TaskReSet.AutoSize = true;
            this.btn_TaskReSet.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_TaskReSet.Location = new System.Drawing.Point(106, 224);
            this.btn_TaskReSet.Name = "btn_TaskReSet";
            this.btn_TaskReSet.Size = new System.Drawing.Size(160, 70);
            this.btn_TaskReSet.TabIndex = 2;
            this.btn_TaskReSet.Text = "暂停Task";
            this.btn_TaskReSet.UseVisualStyleBackColor = true;
            this.btn_TaskReSet.Click += new System.EventHandler(this.btn_TaskReSet_Click);
            // 
            // btn_TaskContinue
            // 
            this.btn_TaskContinue.AutoSize = true;
            this.btn_TaskContinue.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_TaskContinue.Location = new System.Drawing.Point(414, 224);
            this.btn_TaskContinue.Name = "btn_TaskContinue";
            this.btn_TaskContinue.Size = new System.Drawing.Size(160, 70);
            this.btn_TaskContinue.TabIndex = 3;
            this.btn_TaskContinue.Text = "继续Task";
            this.btn_TaskContinue.UseVisualStyleBackColor = true;
            this.btn_TaskContinue.Click += new System.EventHandler(this.btn_TaskContinue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_TaskContinue);
            this.Controls.Add(this.btn_TaskReSet);
            this.Controls.Add(this.btn_TaskStop);
            this.Controls.Add(this.btn_TaskStart);
            this.Name = "Form1";
            this.Text = "Task多线程任务四种情况";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TaskStart;
        private System.Windows.Forms.Button btn_TaskStop;
        private System.Windows.Forms.Button btn_TaskReSet;
        private System.Windows.Forms.Button btn_TaskContinue;
    }
}

