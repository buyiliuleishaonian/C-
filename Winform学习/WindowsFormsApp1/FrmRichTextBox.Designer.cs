namespace WindowsFormsApp1
{
    partial class FrmRichTextBox
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnStreamFile = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnDock = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.timer2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(85, 76);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(591, 318);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            // 
            // btnStreamFile
            // 
            this.btnStreamFile.Location = new System.Drawing.Point(85, 434);
            this.btnStreamFile.Name = "btnStreamFile";
            this.btnStreamFile.Size = new System.Drawing.Size(159, 48);
            this.btnStreamFile.TabIndex = 1;
            this.btnStreamFile.Text = "加载";
            this.btnStreamFile.UseVisualStyleBackColor = true;
            this.btnStreamFile.Click += new System.EventHandler(this.btnStreamFile_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(289, 434);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(159, 48);
            this.btnSaveFile.TabIndex = 2;
            this.btnSaveFile.Text = "保存";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(517, 434);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(159, 48);
            this.btnImage.TabIndex = 3;
            this.btnImage.Text = "图片";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(85, 535);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(159, 48);
            this.btnFont.TabIndex = 4;
            this.btnFont.Text = "加粗";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnDock
            // 
            this.btnDock.Location = new System.Drawing.Point(289, 535);
            this.btnDock.Name = "btnDock";
            this.btnDock.Size = new System.Drawing.Size(159, 48);
            this.btnDock.TabIndex = 5;
            this.btnDock.Text = "居中";
            this.btnDock.UseVisualStyleBackColor = true;
            this.btnDock.Click += new System.EventHandler(this.btnDock_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.SynchronizingObject = this;
            // 
            // FrmRichTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 626);
            this.Controls.Add(this.btnDock);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnStreamFile);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FrmRichTextBox";
            this.Text = "FrmRichTextBox";
            ((System.ComponentModel.ISupportInitialize)(this.timer2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnStreamFile;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnDock;
        private System.Windows.Forms.Timer timer1;
        private System.Timers.Timer timer2;
    }
}