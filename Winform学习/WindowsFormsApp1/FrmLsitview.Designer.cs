namespace WindowsFormsApp1
{
    partial class FrmLsitview
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.largeImage = new System.Windows.Forms.ImageList(this.components);
            this.smallImage = new System.Windows.Forms.ImageList(this.components);
            this.btnLarge = new System.Windows.Forms.Button();
            this.btnSmall = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btntile = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(127, 73);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(691, 505);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // largeImage
            // 
            this.largeImage.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.largeImage.ImageSize = new System.Drawing.Size(16, 16);
            this.largeImage.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // smallImage
            // 
            this.smallImage.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.smallImage.ImageSize = new System.Drawing.Size(16, 16);
            this.smallImage.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnLarge
            // 
            this.btnLarge.Location = new System.Drawing.Point(62, 30);
            this.btnLarge.Name = "btnLarge";
            this.btnLarge.Size = new System.Drawing.Size(113, 30);
            this.btnLarge.TabIndex = 1;
            this.btnLarge.Text = "大图标";
            this.btnLarge.UseVisualStyleBackColor = true;
            this.btnLarge.Click += new System.EventHandler(this.btnLarge_Click);
            // 
            // btnSmall
            // 
            this.btnSmall.Location = new System.Drawing.Point(223, 30);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(113, 30);
            this.btnSmall.TabIndex = 2;
            this.btnSmall.Text = "小图标";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(409, 30);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(113, 30);
            this.btnDetail.TabIndex = 3;
            this.btnDetail.Text = "详细图标";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(590, 30);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(113, 30);
            this.btnList.TabIndex = 4;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btntile
            // 
            this.btntile.Location = new System.Drawing.Point(769, 30);
            this.btntile.Name = "btntile";
            this.btntile.Size = new System.Drawing.Size(113, 30);
            this.btntile.TabIndex = 5;
            this.btntile.Text = "Tile";
            this.btntile.UseVisualStyleBackColor = true;
            this.btntile.Click += new System.EventHandler(this.btntile_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(62, 611);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(113, 30);
            this.btnGroup.TabIndex = 6;
            this.btnGroup.Text = "分组显示";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // FrmLsitview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 719);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.btntile);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnSmall);
            this.Controls.Add(this.btnLarge);
            this.Controls.Add(this.listView1);
            this.Name = "FrmLsitview";
            this.Text = "FrmLsitview";
            this.Load += new System.EventHandler(this.FrmLsitview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList largeImage;
        private System.Windows.Forms.ImageList smallImage;
        private System.Windows.Forms.Button btnLarge;
        private System.Windows.Forms.Button btnSmall;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btntile;
        private System.Windows.Forms.Button btnGroup;
    }
}