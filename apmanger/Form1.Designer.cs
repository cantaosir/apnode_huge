namespace apmanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Memcache = new System.Windows.Forms.Button();
            this.btn_redis = new System.Windows.Forms.Button();
            this.btn_php56 = new System.Windows.Forms.Button();
            this.btn_nginx = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_mysql = new System.Windows.Forms.Button();
            this.btn_filezilla = new System.Windows.Forms.Button();
            this.btn_apache = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rich_main = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Memcache);
            this.panel1.Controls.Add(this.btn_redis);
            this.panel1.Controls.Add(this.btn_php56);
            this.panel1.Controls.Add(this.btn_nginx);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_mysql);
            this.panel1.Controls.Add(this.btn_filezilla);
            this.panel1.Controls.Add(this.btn_apache);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 50);
            this.panel1.TabIndex = 0;
            // 
            // btn_Memcache
            // 
            this.btn_Memcache.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Memcache.Location = new System.Drawing.Point(390, 0);
            this.btn_Memcache.Name = "btn_Memcache";
            this.btn_Memcache.Size = new System.Drawing.Size(65, 48);
            this.btn_Memcache.TabIndex = 7;
            this.btn_Memcache.Text = "Memcache";
            this.btn_Memcache.UseVisualStyleBackColor = true;
            this.btn_Memcache.Click += new System.EventHandler(this.btn_Memcache_Click);
            // 
            // btn_redis
            // 
            this.btn_redis.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_redis.Location = new System.Drawing.Point(325, 0);
            this.btn_redis.Name = "btn_redis";
            this.btn_redis.Size = new System.Drawing.Size(65, 48);
            this.btn_redis.TabIndex = 6;
            this.btn_redis.Text = "Redis";
            this.btn_redis.UseVisualStyleBackColor = true;
            this.btn_redis.Click += new System.EventHandler(this.btn_redis_Click);
            // 
            // btn_php56
            // 
            this.btn_php56.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_php56.Location = new System.Drawing.Point(260, 0);
            this.btn_php56.Name = "btn_php56";
            this.btn_php56.Size = new System.Drawing.Size(65, 48);
            this.btn_php56.TabIndex = 5;
            this.btn_php56.Text = "PHP56";
            this.btn_php56.UseVisualStyleBackColor = true;
            this.btn_php56.Click += new System.EventHandler(this.btn_php56_Click);
            // 
            // btn_nginx
            // 
            this.btn_nginx.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_nginx.Location = new System.Drawing.Point(195, 0);
            this.btn_nginx.Name = "btn_nginx";
            this.btn_nginx.Size = new System.Drawing.Size(65, 48);
            this.btn_nginx.TabIndex = 4;
            this.btn_nginx.Text = "Nginx";
            this.btn_nginx.UseVisualStyleBackColor = true;
            this.btn_nginx.Click += new System.EventHandler(this.btn_nginx_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.Location = new System.Drawing.Point(709, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(65, 48);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_mysql
            // 
            this.btn_mysql.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_mysql.Location = new System.Drawing.Point(130, 0);
            this.btn_mysql.Name = "btn_mysql";
            this.btn_mysql.Size = new System.Drawing.Size(65, 48);
            this.btn_mysql.TabIndex = 2;
            this.btn_mysql.Text = "MYSQL";
            this.btn_mysql.UseVisualStyleBackColor = true;
            this.btn_mysql.Click += new System.EventHandler(this.btn_mysql_Click);
            // 
            // btn_filezilla
            // 
            this.btn_filezilla.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_filezilla.Location = new System.Drawing.Point(65, 0);
            this.btn_filezilla.Name = "btn_filezilla";
            this.btn_filezilla.Size = new System.Drawing.Size(65, 48);
            this.btn_filezilla.TabIndex = 3;
            this.btn_filezilla.Text = "FZilla";
            this.btn_filezilla.UseVisualStyleBackColor = true;
            this.btn_filezilla.Click += new System.EventHandler(this.btn_filezilla_Click);
            // 
            // btn_apache
            // 
            this.btn_apache.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_apache.Location = new System.Drawing.Point(0, 0);
            this.btn_apache.Name = "btn_apache";
            this.btn_apache.Size = new System.Drawing.Size(65, 48);
            this.btn_apache.TabIndex = 1;
            this.btn_apache.Text = "Apache";
            this.btn_apache.UseVisualStyleBackColor = true;
            this.btn_apache.Click += new System.EventHandler(this.btn_apache_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rich_main);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 526);
            this.panel2.TabIndex = 1;
            // 
            // rich_main
            // 
            this.rich_main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rich_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rich_main.Location = new System.Drawing.Point(0, 0);
            this.rich_main.Name = "rich_main";
            this.rich_main.Size = new System.Drawing.Size(774, 524);
            this.rich_main.TabIndex = 0;
            this.rich_main.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 576);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APManger";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_mysql;
        private System.Windows.Forms.Button btn_apache;
        private System.Windows.Forms.RichTextBox rich_main;
        private System.Windows.Forms.Button btn_php56;
        private System.Windows.Forms.Button btn_nginx;
        private System.Windows.Forms.Button btn_filezilla;
        private System.Windows.Forms.Button btn_redis;
        private System.Windows.Forms.Button btn_Memcache;
    }
}

