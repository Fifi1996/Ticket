namespace ticket1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.航班信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退票ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.退票信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.航班信息ToolStripMenuItem,
            this.订单ToolStripMenuItem,
            this.退票ToolStripMenuItem,
            this.退票信息ToolStripMenuItem,
            this.用户信息ToolStripMenuItem,
            this.返回ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1032, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 航班信息ToolStripMenuItem
            // 
            this.航班信息ToolStripMenuItem.Name = "航班信息ToolStripMenuItem";
            this.航班信息ToolStripMenuItem.Size = new System.Drawing.Size(104, 31);
            this.航班信息ToolStripMenuItem.Text = "航班信息";
            this.航班信息ToolStripMenuItem.Click += new System.EventHandler(this.航班信息ToolStripMenuItem_Click);
            // 
            // 订单ToolStripMenuItem
            // 
            this.订单ToolStripMenuItem.Name = "订单ToolStripMenuItem";
            this.订单ToolStripMenuItem.Size = new System.Drawing.Size(64, 31);
            this.订单ToolStripMenuItem.Text = "订单";
            this.订单ToolStripMenuItem.Click += new System.EventHandler(this.订单ToolStripMenuItem_Click);
            // 
            // 退票ToolStripMenuItem
            // 
            this.退票ToolStripMenuItem.Name = "退票ToolStripMenuItem";
            this.退票ToolStripMenuItem.Size = new System.Drawing.Size(104, 31);
            this.退票ToolStripMenuItem.Text = "航空公司";
            this.退票ToolStripMenuItem.Click += new System.EventHandler(this.退票ToolStripMenuItem_Click);
            // 
            // 用户信息ToolStripMenuItem
            // 
            this.用户信息ToolStripMenuItem.Name = "用户信息ToolStripMenuItem";
            this.用户信息ToolStripMenuItem.Size = new System.Drawing.Size(104, 31);
            this.用户信息ToolStripMenuItem.Text = "用户信息";
            this.用户信息ToolStripMenuItem.Click += new System.EventHandler(this.用户信息ToolStripMenuItem_Click);
            // 
            // 返回ToolStripMenuItem
            // 
            this.返回ToolStripMenuItem.Name = "返回ToolStripMenuItem";
            this.返回ToolStripMenuItem.Size = new System.Drawing.Size(64, 31);
            this.返回ToolStripMenuItem.Text = "退出";
            this.返回ToolStripMenuItem.Click += new System.EventHandler(this.返回ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("隶书", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.LightGreen;
            this.label1.Location = new System.Drawing.Point(209, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 84);
            this.label1.TabIndex = 1;
            this.label1.Text = "机票预订系统";
            // 
            // 退票信息ToolStripMenuItem
            // 
            this.退票信息ToolStripMenuItem.Name = "退票信息ToolStripMenuItem";
            this.退票信息ToolStripMenuItem.Size = new System.Drawing.Size(104, 31);
            this.退票信息ToolStripMenuItem.Text = "退票信息";
            this.退票信息ToolStripMenuItem.Click += new System.EventHandler(this.退票信息ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1032, 623);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "机票预订系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 航班信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退票ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 返回ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 退票信息ToolStripMenuItem;
    }
}

