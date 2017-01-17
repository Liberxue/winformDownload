namespace WinBatchDownload
{
    partial class FrmBatchDownload
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
            this.dgvDownLoad = new System.Windows.Forms.DataGridView();
            this.btnStartDownLoad = new System.Windows.Forms.Button();
            this.shisan13ListView1 = new shisan13.Controls.Shisan13ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shisan13FlatButton1 = new shisan13.Controls.Shisan13FlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.shisan13TabControl1 = new shisan13.Controls.Shisan13TabControl();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.shisan13TabSelector1 = new shisan13.Controls.Shisan13TabSelector();
            this.shisan13SingleLineTextField1 = new shisan13.Controls.Shisan13SingleLineTextField();
            this.shisan13ContextMenuStrip1 = new shisan13.Controls.Shisan13ContextMenuStrip();
            this.shisan13RaisedButton1 = new shisan13.Controls.Shisan13RaisedButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDownLoad)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.shisan13TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDownLoad
            // 
            this.dgvDownLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDownLoad.Location = new System.Drawing.Point(0, 252);
            this.dgvDownLoad.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDownLoad.Name = "dgvDownLoad";
            this.dgvDownLoad.RowTemplate.Height = 23;
            this.dgvDownLoad.Size = new System.Drawing.Size(1112, 377);
            this.dgvDownLoad.TabIndex = 0;
            // 
            // btnStartDownLoad
            // 
            this.btnStartDownLoad.Location = new System.Drawing.Point(1089, 1);
            this.btnStartDownLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartDownLoad.Name = "btnStartDownLoad";
            this.btnStartDownLoad.Size = new System.Drawing.Size(112, 61);
            this.btnStartDownLoad.TabIndex = 1;
            this.btnStartDownLoad.Text = "开始下载";
            this.btnStartDownLoad.UseVisualStyleBackColor = true;
            this.btnStartDownLoad.Click += new System.EventHandler(this.btnStartDownLoad_Click);
            // 
            // shisan13ListView1
            // 
            this.shisan13ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shisan13ListView1.Depth = 0;
            this.shisan13ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shisan13ListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.shisan13ListView1.FullRowSelect = true;
            this.shisan13ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.shisan13ListView1.Location = new System.Drawing.Point(0, 0);
            this.shisan13ListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.shisan13ListView1.MouseState = shisan13.MouseState.OUT;
            this.shisan13ListView1.Name = "shisan13ListView1";
            this.shisan13ListView1.OwnerDraw = true;
            this.shisan13ListView1.Size = new System.Drawing.Size(286, 687);
            this.shisan13ListView1.TabIndex = 3;
            this.shisan13ListView1.UseCompatibleStateImageBehavior = false;
            this.shisan13ListView1.View = System.Windows.Forms.View.Details;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.shisan13FlatButton1);
            this.panel1.Controls.Add(this.shisan13ListView1);
            this.panel1.Location = new System.Drawing.Point(-1, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 687);
            this.panel1.TabIndex = 4;
            // 
            // shisan13FlatButton1
            // 
            this.shisan13FlatButton1.AutoSize = true;
            this.shisan13FlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.shisan13FlatButton1.Depth = 0;
            this.shisan13FlatButton1.Icon = null;
            this.shisan13FlatButton1.Location = new System.Drawing.Point(34, 125);
            this.shisan13FlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.shisan13FlatButton1.MouseState = shisan13.MouseState.HOVER;
            this.shisan13FlatButton1.Name = "shisan13FlatButton1";
            this.shisan13FlatButton1.Primary = false;
            this.shisan13FlatButton1.Size = new System.Drawing.Size(179, 36);
            this.shisan13FlatButton1.TabIndex = 8;
            this.shisan13FlatButton1.Text = "shisan13FlatButton1";
            this.shisan13FlatButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.webBrowser1);
            this.panel2.Controls.Add(this.dgvDownLoad);
            this.panel2.Controls.Add(this.shisan13TabControl1);
            this.panel2.Location = new System.Drawing.Point(285, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1112, 633);
            this.panel2.TabIndex = 5;
            // 
            // shisan13TabControl1
            // 
            this.shisan13TabControl1.Controls.Add(this.tabPage1);
            this.shisan13TabControl1.Controls.Add(this.tabPage2);
            this.shisan13TabControl1.Depth = 0;
            this.shisan13TabControl1.Location = new System.Drawing.Point(36, 3);
            this.shisan13TabControl1.MouseState = shisan13.MouseState.HOVER;
            this.shisan13TabControl1.Name = "shisan13TabControl1";
            this.shisan13TabControl1.SelectedIndex = 0;
            this.shisan13TabControl1.Size = new System.Drawing.Size(762, 284);
            this.shisan13TabControl1.TabIndex = 7;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Top;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(1112, 255);
            this.webBrowser1.TabIndex = 6;
            this.webBrowser1.Url = new System.Uri("http://demo.sc.chinaz.com//Files/DownLoad/webjs1/201507/jiaoben3482/", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // shisan13TabSelector1
            // 
            this.shisan13TabSelector1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.shisan13TabSelector1.BaseTabControl = this.shisan13TabControl1;
            this.shisan13TabSelector1.Depth = 0;
            this.shisan13TabSelector1.Location = new System.Drawing.Point(321, 2);
            this.shisan13TabSelector1.MouseState = shisan13.MouseState.HOVER;
            this.shisan13TabSelector1.Name = "shisan13TabSelector1";
            this.shisan13TabSelector1.Size = new System.Drawing.Size(471, 61);
            this.shisan13TabSelector1.TabIndex = 6;
            this.shisan13TabSelector1.Text = "shisan13TabSelector1";
            // 
            // shisan13SingleLineTextField1
            // 
            this.shisan13SingleLineTextField1.Depth = 0;
            this.shisan13SingleLineTextField1.Hint = "";
            this.shisan13SingleLineTextField1.Location = new System.Drawing.Point(863, 30);
            this.shisan13SingleLineTextField1.MaxLength = 32767;
            this.shisan13SingleLineTextField1.MouseState = shisan13.MouseState.HOVER;
            this.shisan13SingleLineTextField1.Name = "shisan13SingleLineTextField1";
            this.shisan13SingleLineTextField1.PasswordChar = '\0';
            this.shisan13SingleLineTextField1.SelectedText = "";
            this.shisan13SingleLineTextField1.SelectionLength = 0;
            this.shisan13SingleLineTextField1.SelectionStart = 0;
            this.shisan13SingleLineTextField1.Size = new System.Drawing.Size(237, 23);
            this.shisan13SingleLineTextField1.TabIndex = 7;
            this.shisan13SingleLineTextField1.TabStop = false;
            this.shisan13SingleLineTextField1.Text = "shisan13SingleLineTextField1";
            this.shisan13SingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // shisan13ContextMenuStrip1
            // 
            this.shisan13ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shisan13ContextMenuStrip1.Depth = 0;
            this.shisan13ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.shisan13ContextMenuStrip1.MouseState = shisan13.MouseState.HOVER;
            this.shisan13ContextMenuStrip1.Name = "shisan13ContextMenuStrip1";
            this.shisan13ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // shisan13RaisedButton1
            // 
            this.shisan13RaisedButton1.AutoSize = true;
            this.shisan13RaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.shisan13RaisedButton1.Depth = 0;
            this.shisan13RaisedButton1.Icon = null;
            this.shisan13RaisedButton1.Location = new System.Drawing.Point(12, 12);
            this.shisan13RaisedButton1.MouseState = shisan13.MouseState.HOVER;
            this.shisan13RaisedButton1.Name = "shisan13RaisedButton1";
            this.shisan13RaisedButton1.Primary = true;
            this.shisan13RaisedButton1.Size = new System.Drawing.Size(194, 36);
            this.shisan13RaisedButton1.TabIndex = 8;
            this.shisan13RaisedButton1.Text = "shisan13RaisedButton1";
            this.shisan13RaisedButton1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(754, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(754, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FrmBatchDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1397, 755);
            this.Controls.Add(this.shisan13RaisedButton1);
            this.Controls.Add(this.shisan13SingleLineTextField1);
            this.Controls.Add(this.shisan13TabSelector1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStartDownLoad);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBatchDownload";
            this.Text = "多线程批量下载";
            this.Load += new System.EventHandler(this.FrmBatchDownload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDownLoad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.shisan13TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDownLoad;
        private System.Windows.Forms.Button btnStartDownLoad;
        private shisan13.Controls.Shisan13ListView shisan13ListView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private shisan13.Controls.Shisan13TabSelector shisan13TabSelector1;
        private shisan13.Controls.Shisan13TabControl shisan13TabControl1;
        private shisan13.Controls.Shisan13SingleLineTextField shisan13SingleLineTextField1;
        private shisan13.Controls.Shisan13ContextMenuStrip shisan13ContextMenuStrip1;
        private shisan13.Controls.Shisan13RaisedButton shisan13RaisedButton1;
        private shisan13.Controls.Shisan13FlatButton shisan13FlatButton1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

