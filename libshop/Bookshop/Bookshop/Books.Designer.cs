namespace Bookshop
{
    partial class Books
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Bleixingtbl = new System.Windows.Forms.ComboBox();
            this.BTbllib = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delet = new System.Windows.Forms.Button();
            this.chongzhi = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.bshaixuan = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Bprice = new System.Windows.Forms.TextBox();
            this.Bmany = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Bleixing = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTitile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTbllib)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.Bleixingtbl);
            this.panel2.Controls.Add(this.BTbllib);
            this.panel2.Controls.Add(this.delet);
            this.panel2.Controls.Add(this.chongzhi);
            this.panel2.Controls.Add(this.update);
            this.panel2.Controls.Add(this.bshaixuan);
            this.panel2.Controls.Add(this.save);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.Bprice);
            this.panel2.Controls.Add(this.Bmany);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.Bleixing);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Author);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BTitile);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Font = new System.Drawing.Font("思源黑体 Medium", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.Location = new System.Drawing.Point(403, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1505, 1032);
            this.panel2.TabIndex = 3;
            // 
            // Bleixingtbl
            // 
            this.Bleixingtbl.FormattingEnabled = true;
            this.Bleixingtbl.Items.AddRange(new object[] {
            "儿童读物",
            "文学艺术",
            "人文历史",
            "生活美食",
            "经济管理",
            "科学技术",
            "其他类型"});
            this.Bleixingtbl.Location = new System.Drawing.Point(435, 287);
            this.Bleixingtbl.Name = "Bleixingtbl";
            this.Bleixingtbl.Size = new System.Drawing.Size(234, 49);
            this.Bleixingtbl.TabIndex = 19;
            this.Bleixingtbl.Text = "选定类型";
            this.Bleixingtbl.SelectedIndexChanged += new System.EventHandler(this.Bleixingtbl_SelectedIndexChanged);
            // 
            // BTbllib
            // 
            this.BTbllib.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BTbllib.BackgroundColor = System.Drawing.Color.White;
            this.BTbllib.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("思源黑体 Medium", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BTbllib.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BTbllib.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BTbllib.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.BTbllib.GridColor = System.Drawing.Color.LightGray;
            this.BTbllib.Location = new System.Drawing.Point(3, 357);
            this.BTbllib.Name = "BTbllib";
            this.BTbllib.ReadOnly = true;
            this.BTbllib.RowHeadersVisible = false;
            this.BTbllib.RowHeadersWidth = 82;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Lime;
            this.BTbllib.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.BTbllib.RowTemplate.Height = 37;
            this.BTbllib.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BTbllib.Size = new System.Drawing.Size(1448, 634);
            this.BTbllib.TabIndex = 18;
            this.BTbllib.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BTbllib_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "BId";
            this.Column1.HeaderText = "书籍编号";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BTitle";
            this.Column2.HeaderText = "书籍名称";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "BAuthor";
            this.Column3.HeaderText = "作者";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "BCat";
            this.Column4.HeaderText = "书籍类型";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "BQty";
            this.Column5.HeaderText = "数量";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Bprice";
            this.Column6.HeaderText = "价格";
            this.Column6.MinimumWidth = 10;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // delet
            // 
            this.delet.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.delet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delet.Location = new System.Drawing.Point(435, 205);
            this.delet.Name = "delet";
            this.delet.Size = new System.Drawing.Size(183, 53);
            this.delet.TabIndex = 17;
            this.delet.Text = "删    除";
            this.delet.UseVisualStyleBackColor = true;
            this.delet.Click += new System.EventHandler(this.delet_Click_1);
            // 
            // chongzhi
            // 
            this.chongzhi.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.chongzhi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chongzhi.Location = new System.Drawing.Point(638, 208);
            this.chongzhi.Name = "chongzhi";
            this.chongzhi.Size = new System.Drawing.Size(183, 53);
            this.chongzhi.TabIndex = 16;
            this.chongzhi.Text = "重    置";
            this.chongzhi.UseVisualStyleBackColor = true;
            this.chongzhi.Click += new System.EventHandler(this.chongzhi_Click_1);
            // 
            // update
            // 
            this.update.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Location = new System.Drawing.Point(229, 205);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(183, 53);
            this.update.TabIndex = 15;
            this.update.Text = "编    辑";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click_1);
            // 
            // bshaixuan
            // 
            this.bshaixuan.BackColor = System.Drawing.Color.LimeGreen;
            this.bshaixuan.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.bshaixuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bshaixuan.Location = new System.Drawing.Point(675, 283);
            this.bshaixuan.Name = "bshaixuan";
            this.bshaixuan.Size = new System.Drawing.Size(124, 53);
            this.bshaixuan.TabIndex = 14;
            this.bshaixuan.Text = "刷   新";
            this.bshaixuan.UseVisualStyleBackColor = false;
            this.bshaixuan.Click += new System.EventHandler(this.bshaixuan_Click_1);
            // 
            // save
            // 
            this.save.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Location = new System.Drawing.Point(25, 205);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(183, 53);
            this.save.TabIndex = 14;
            this.save.Text = "保    存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Window;
            this.label11.Font = new System.Drawing.Font("思源黑体 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label11.Location = new System.Drawing.Point(920, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 46);
            this.label11.TabIndex = 13;
            this.label11.Text = "价格";
            // 
            // Bprice
            // 
            this.Bprice.Font = new System.Drawing.Font("思源黑体 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Bprice.Location = new System.Drawing.Point(928, 97);
            this.Bprice.Name = "Bprice";
            this.Bprice.Size = new System.Drawing.Size(89, 54);
            this.Bprice.TabIndex = 12;
            // 
            // Bmany
            // 
            this.Bmany.Font = new System.Drawing.Font("思源黑体 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Bmany.Location = new System.Drawing.Point(805, 97);
            this.Bmany.Name = "Bmany";
            this.Bmany.Size = new System.Drawing.Size(96, 54);
            this.Bmany.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.Font = new System.Drawing.Font("思源黑体 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label10.Location = new System.Drawing.Point(797, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 46);
            this.label10.TabIndex = 10;
            this.label10.Text = "数量";
            // 
            // Bleixing
            // 
            this.Bleixing.FormattingEnabled = true;
            this.Bleixing.Items.AddRange(new object[] {
            "儿童读物",
            "文学艺术",
            "人文历史",
            "生活美食",
            "经济管理",
            "科学技术",
            "其他类型"});
            this.Bleixing.Location = new System.Drawing.Point(555, 97);
            this.Bleixing.Name = "Bleixing";
            this.Bleixing.Size = new System.Drawing.Size(234, 49);
            this.Bleixing.TabIndex = 9;
            this.Bleixing.Text = "选择类型";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("思源黑体 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(282, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 46);
            this.label8.TabIndex = 8;
            this.label8.Text = "作者";
            // 
            // Author
            // 
            this.Author.Font = new System.Drawing.Font("思源黑体 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Author.Location = new System.Drawing.Point(290, 92);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(236, 54);
            this.Author.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Window;
            this.label12.Font = new System.Drawing.Font("思源黑体 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label12.Location = new System.Drawing.Point(17, 308);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 46);
            this.label12.TabIndex = 6;
            this.label12.Text = "书籍列表";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("思源黑体 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(547, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "书籍类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("思源黑体 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(17, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "书籍名称";
            // 
            // BTitile
            // 
            this.BTitile.Font = new System.Drawing.Font("思源黑体 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTitile.Location = new System.Drawing.Point(25, 92);
            this.BTitile.Name = "BTitile";
            this.BTitile.Size = new System.Drawing.Size(236, 54);
            this.BTitile.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("思源黑体 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(1398, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 46);
            this.label7.TabIndex = 3;
            this.label7.Text = "×";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 1034);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(38, 255);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 59);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(36, 416);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 571);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(37, 706);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 59);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("幼圆", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Location = new System.Drawing.Point(96, 706);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(271, 59);
            this.label9.TabIndex = 3;
            this.label9.Text = "退    出";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("幼圆", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(93, 569);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 59);
            this.label5.TabIndex = 3;
            this.label5.Text = "账户管理";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("幼圆", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(93, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 59);
            this.label6.TabIndex = 3;
            this.label6.Text = "用户管理";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("幼圆", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(93, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 59);
            this.label1.TabIndex = 3;
            this.label1.Text = "图书管理";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("思源黑体 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(111, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 46);
            this.label4.TabIndex = 1;
            this.label4.Text = "云书店管理系统";
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1950, 1080);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTbllib)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox Bleixingtbl;
        private System.Windows.Forms.DataGridView BTbllib;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button delet;
        private System.Windows.Forms.Button chongzhi;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button bshaixuan;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Bprice;
        private System.Windows.Forms.TextBox Bmany;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Bleixing;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BTitile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}