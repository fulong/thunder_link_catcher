namespace thunder_link_catch
{
    partial class 迅雷下载地址抓取器
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
            this.url = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.url_sure = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.only_ftp_select = new System.Windows.Forms.Button();
            this.only_magnet_select = new System.Windows.Forms.Button();
            this.only_thunder_select = new System.Windows.Forms.Button();
            this.download = new System.Windows.Forms.Button();
            this.all_select = new System.Windows.Forms.Button();
            this.global_list = new System.Windows.Forms.ListView();
            this.list_select = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_url = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.html_import = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(87, 11);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(580, 25);
            this.url.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(0, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(81, 18);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "页面地址";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // url_sure
            // 
            this.url_sure.Location = new System.Drawing.Point(673, 11);
            this.url_sure.Name = "url_sure";
            this.url_sure.Size = new System.Drawing.Size(56, 27);
            this.url_sure.TabIndex = 2;
            this.url_sure.Text = "确定";
            this.url_sure.UseVisualStyleBackColor = true;
            this.url_sure.Click += new System.EventHandler(this.url_sure_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.only_ftp_select);
            this.panel1.Controls.Add(this.only_magnet_select);
            this.panel1.Controls.Add(this.only_thunder_select);
            this.panel1.Controls.Add(this.download);
            this.panel1.Controls.Add(this.all_select);
            this.panel1.Controls.Add(this.global_list);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 396);
            this.panel1.TabIndex = 4;
            // 
            // only_ftp_select
            // 
            this.only_ftp_select.Location = new System.Drawing.Point(466, 366);
            this.only_ftp_select.Name = "only_ftp_select";
            this.only_ftp_select.Size = new System.Drawing.Size(138, 27);
            this.only_ftp_select.TabIndex = 59;
            this.only_ftp_select.Text = "只选ftp链接";
            this.only_ftp_select.UseVisualStyleBackColor = true;
            this.only_ftp_select.Click += new System.EventHandler(this.only_select_Click);
            // 
            // only_magnet_select
            // 
            this.only_magnet_select.Location = new System.Drawing.Point(322, 366);
            this.only_magnet_select.Name = "only_magnet_select";
            this.only_magnet_select.Size = new System.Drawing.Size(138, 27);
            this.only_magnet_select.TabIndex = 58;
            this.only_magnet_select.Text = "只选magnet链接";
            this.only_magnet_select.UseVisualStyleBackColor = true;
            this.only_magnet_select.Click += new System.EventHandler(this.only_select_Click);
            // 
            // only_thunder_select
            // 
            this.only_thunder_select.Location = new System.Drawing.Point(178, 366);
            this.only_thunder_select.Name = "only_thunder_select";
            this.only_thunder_select.Size = new System.Drawing.Size(138, 27);
            this.only_thunder_select.TabIndex = 57;
            this.only_thunder_select.Text = "只选thunder链接";
            this.only_thunder_select.UseVisualStyleBackColor = true;
            this.only_thunder_select.Click += new System.EventHandler(this.only_select_Click);
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(630, 366);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(56, 27);
            this.download.TabIndex = 56;
            this.download.Text = "下载";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // all_select
            // 
            this.all_select.Location = new System.Drawing.Point(91, 366);
            this.all_select.Name = "all_select";
            this.all_select.Size = new System.Drawing.Size(56, 27);
            this.all_select.TabIndex = 55;
            this.all_select.Text = "全选";
            this.all_select.UseVisualStyleBackColor = true;
            this.all_select.Click += new System.EventHandler(this.all_select_Click);
            // 
            // global_list
            // 
            this.global_list.AllowColumnReorder = true;
            this.global_list.CheckBoxes = true;
            this.global_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_select,
            this.list_name,
            this.list_url});
            this.global_list.FullRowSelect = true;
            this.global_list.GridLines = true;
            this.global_list.HideSelection = false;
            this.global_list.Location = new System.Drawing.Point(4, 4);
            this.global_list.Margin = new System.Windows.Forms.Padding(4);
            this.global_list.Name = "global_list";
            this.global_list.Size = new System.Drawing.Size(802, 355);
            this.global_list.TabIndex = 54;
            this.global_list.UseCompatibleStateImageBehavior = false;
            this.global_list.View = System.Windows.Forms.View.Details;
            // 
            // list_select
            // 
            this.list_select.Text = "选中";
            this.list_select.Width = 44;
            // 
            // list_name
            // 
            this.list_name.Text = "名字";
            this.list_name.Width = 168;
            // 
            // list_url
            // 
            this.list_url.Text = "链接";
            this.list_url.Width = 590;
            // 
            // html_import
            // 
            this.html_import.Location = new System.Drawing.Point(735, 12);
            this.html_import.Name = "html_import";
            this.html_import.Size = new System.Drawing.Size(83, 27);
            this.html_import.TabIndex = 5;
            this.html_import.Text = "html导入";
            this.html_import.UseVisualStyleBackColor = true;
            this.html_import.Click += new System.EventHandler(this.html_import_Click);
            // 
            // 迅雷下载地址抓取器
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.html_import);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.url_sure);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.url);
            this.Name = "迅雷下载地址抓取器";
            this.Text = "迅雷下载链接抓取器v0.0.3";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button url_sure;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView global_list;
        private System.Windows.Forms.ColumnHeader list_select;
        private System.Windows.Forms.ColumnHeader list_name;
        private System.Windows.Forms.ColumnHeader list_url;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button all_select;
        private System.Windows.Forms.Button only_magnet_select;
        private System.Windows.Forms.Button only_thunder_select;
        private System.Windows.Forms.Button html_import;
        private System.Windows.Forms.Button only_ftp_select;
    }
}

