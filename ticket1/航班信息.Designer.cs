namespace ticket1
{
    partial class 航班信息
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(航班信息));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1_mudi = new System.Windows.Forms.ComboBox();
            this.comboBox1_chufa = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yupiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1_查询 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBox1_mudi);
            this.groupBox1.Controls.Add(this.comboBox1_chufa);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1_查询);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "航班查询";
            // 
            // comboBox1_mudi
            // 
            this.comboBox1_mudi.FormattingEnabled = true;
            this.comboBox1_mudi.Items.AddRange(new object[] {
            "Chongqing",
            "Guangzhou",
            "Shanghai",
            "Shenzhen",
            "Beijing"});
            this.comboBox1_mudi.Location = new System.Drawing.Point(316, 88);
            this.comboBox1_mudi.Name = "comboBox1_mudi";
            this.comboBox1_mudi.Size = new System.Drawing.Size(121, 26);
            this.comboBox1_mudi.TabIndex = 13;
            // 
            // comboBox1_chufa
            // 
            this.comboBox1_chufa.FormattingEnabled = true;
            this.comboBox1_chufa.Items.AddRange(new object[] {
            "Fuzhou",
            "Xiamen",
            "Nanjing"});
            this.comboBox1_chufa.Location = new System.Drawing.Point(84, 88);
            this.comboBox1_chufa.Name = "comboBox1_chufa";
            this.comboBox1_chufa.Size = new System.Drawing.Size(121, 26);
            this.comboBox1_chufa.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(789, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 50);
            this.button3.TabIndex = 11;
            this.button3.Text = "购票";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(550, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 28);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.fclass,
            this.price,
            this.yupiao});
            this.dataGridView1.Location = new System.Drawing.Point(0, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(780, 249);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "fno";
            this.Column1.HeaderText = "航班号";
            this.Column1.Name = "Column1";
            // 
            // fclass
            // 
            this.fclass.DataPropertyName = "fclass";
            this.fclass.HeaderText = "等级";
            this.fclass.Name = "fclass";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "票价";
            this.price.Name = "price";
            // 
            // yupiao
            // 
            this.yupiao.DataPropertyName = "yupiao";
            this.yupiao.HeaderText = "余票";
            this.yupiao.Name = "yupiao";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "出发地";
            // 
            // button1_查询
            // 
            this.button1_查询.ForeColor = System.Drawing.Color.Black;
            this.button1_查询.Location = new System.Drawing.Point(789, 91);
            this.button1_查询.Name = "button1_查询";
            this.button1_查询.Size = new System.Drawing.Size(86, 33);
            this.button1_查询.TabIndex = 5;
            this.button1_查询.Text = "查询";
            this.button1_查询.UseVisualStyleBackColor = true;
            this.button1_查询.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "目的地";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // 航班信息
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(906, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "航班信息";
            this.Text = "用户预定航班信息";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_查询;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1_chufa;
        private System.Windows.Forms.ComboBox comboBox1_mudi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn yupiao;
    }
}