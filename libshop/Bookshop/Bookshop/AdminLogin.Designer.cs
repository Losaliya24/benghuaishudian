namespace Bookshop
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.llogin = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Uname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Upasswd = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ulogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // llogin
            // 
            this.llogin.BackColor = System.Drawing.Color.Thistle;
            this.llogin.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush;
            this.llogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.llogin.Location = new System.Drawing.Point(435, 433);
            this.llogin.Name = "llogin";
            this.llogin.Size = new System.Drawing.Size(147, 47);
            this.llogin.TabIndex = 18;
            this.llogin.Text = "登     录";
            this.llogin.UseVisualStyleBackColor = false;
            this.llogin.Click += new System.EventHandler(this.llogin_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("思源黑体 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(1019, -3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 46);
            this.label7.TabIndex = 13;
            this.label7.Text = "×";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Thistle;
            this.label8.Font = new System.Drawing.Font("思源黑体 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(321, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 46);
            this.label8.TabIndex = 16;
            this.label8.Text = "用户名";
            // 
            // Uname
            // 
            this.Uname.Font = new System.Drawing.Font("思源黑体 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Uname.Location = new System.Drawing.Point(461, 298);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(236, 54);
            this.Uname.TabIndex = 10;
           
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.Font = new System.Drawing.Font("思源黑体 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(321, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 46);
            this.label2.TabIndex = 17;
            this.label2.Text = "密     码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("思源黑体 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(396, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 46);
            this.label4.TabIndex = 8;
            this.label4.Text = "云书店管理系统";
            // 
            // Upasswd
            // 
            this.Upasswd.Font = new System.Drawing.Font("思源黑体 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Upasswd.Location = new System.Drawing.Point(461, 369);
            this.Upasswd.Name = "Upasswd";
            this.Upasswd.Size = new System.Drawing.Size(236, 54);
            this.Upasswd.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Thistle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1072, 604);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Ulogin
            // 
            this.Ulogin.AutoSize = true;
            this.Ulogin.BackColor = System.Drawing.Color.Thistle;
            this.Ulogin.Font = new System.Drawing.Font("幼圆", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ulogin.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Ulogin.Location = new System.Drawing.Point(457, 483);
            this.Ulogin.Name = "Ulogin";
            this.Ulogin.Size = new System.Drawing.Size(95, 37);
            this.Ulogin.TabIndex = 20;
            this.Ulogin.Text = "返回";
            this.Ulogin.Click += new System.EventHandler(this.Ulogin_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1073, 783);
            this.Controls.Add(this.Ulogin);
            this.Controls.Add(this.llogin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Uname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Upasswd);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button llogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Uname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Upasswd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Ulogin;
    }
}