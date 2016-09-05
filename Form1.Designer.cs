namespace ProcessKiller
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btn_go = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.btn_stop = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.status1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.MenuItem_show = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem_start = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem_stop = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem_exit = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btn_hotKeyReg = new System.Windows.Forms.Button();
			this.btn_hotKeyUnReg = new System.Windows.Forms.Button();
			this.statusStrip1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_go
			// 
			this.btn_go.Location = new System.Drawing.Point(6, 20);
			this.btn_go.Name = "btn_go";
			this.btn_go.Size = new System.Drawing.Size(157, 23);
			this.btn_go.TabIndex = 0;
			this.btn_go.Text = "开始";
			this.btn_go.UseVisualStyleBackColor = true;
			this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 20;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// btn_stop
			// 
			this.btn_stop.Enabled = false;
			this.btn_stop.Location = new System.Drawing.Point(6, 49);
			this.btn_stop.Name = "btn_stop";
			this.btn_stop.Size = new System.Drawing.Size(157, 23);
			this.btn_stop.TabIndex = 1;
			this.btn_stop.Text = "停止";
			this.btn_stop.UseVisualStyleBackColor = true;
			this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBox1.Location = new System.Drawing.Point(6, 20);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(157, 102);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 266);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(220, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// status1
			// 
			this.status1.Name = "status1";
			this.status1.Size = new System.Drawing.Size(43, 17);
			this.status1.Text = "已准备";
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "ProcessKiller";
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_show,
            this.MenuItem_start,
            this.MenuItem_stop,
            this.MenuItem_exit});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(135, 92);
			// 
			// MenuItem_show
			// 
			this.MenuItem_show.Name = "MenuItem_show";
			this.MenuItem_show.Size = new System.Drawing.Size(134, 22);
			this.MenuItem_show.Text = "显示主窗体";
			this.MenuItem_show.Click += new System.EventHandler(this.MenuItem_show_Click);
			// 
			// MenuItem_start
			// 
			this.MenuItem_start.Name = "MenuItem_start";
			this.MenuItem_start.Size = new System.Drawing.Size(134, 22);
			this.MenuItem_start.Text = "开始";
			this.MenuItem_start.Click += new System.EventHandler(this.MenuItem_start_Click);
			// 
			// MenuItem_stop
			// 
			this.MenuItem_stop.Enabled = false;
			this.MenuItem_stop.Name = "MenuItem_stop";
			this.MenuItem_stop.Size = new System.Drawing.Size(134, 22);
			this.MenuItem_stop.Text = "停止";
			this.MenuItem_stop.Click += new System.EventHandler(this.MenuItem_stop_Click);
			// 
			// MenuItem_exit
			// 
			this.MenuItem_exit.Name = "MenuItem_exit";
			this.MenuItem_exit.Size = new System.Drawing.Size(134, 22);
			this.MenuItem_exit.Text = "退出";
			this.MenuItem_exit.Click += new System.EventHandler(this.MenuItem_exit_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_hotKeyUnReg);
			this.groupBox1.Controls.Add(this.btn_hotKeyReg);
			this.groupBox1.Controls.Add(this.btn_go);
			this.groupBox1.Controls.Add(this.btn_stop);
			this.groupBox1.Location = new System.Drawing.Point(25, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(169, 108);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "操作";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.richTextBox1);
			this.groupBox2.Location = new System.Drawing.Point(25, 126);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(169, 129);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "记录";
			// 
			// btn_hotKeyReg
			// 
			this.btn_hotKeyReg.Location = new System.Drawing.Point(6, 78);
			this.btn_hotKeyReg.Name = "btn_hotKeyReg";
			this.btn_hotKeyReg.Size = new System.Drawing.Size(75, 23);
			this.btn_hotKeyReg.TabIndex = 6;
			this.btn_hotKeyReg.Text = "快捷键注册";
			this.btn_hotKeyReg.UseVisualStyleBackColor = true;
			this.btn_hotKeyReg.Click += new System.EventHandler(this.btn_hotKeyReg_Click);
			// 
			// btn_hotKeyUnReg
			// 
			this.btn_hotKeyUnReg.Location = new System.Drawing.Point(87, 78);
			this.btn_hotKeyUnReg.Name = "btn_hotKeyUnReg";
			this.btn_hotKeyUnReg.Size = new System.Drawing.Size(75, 23);
			this.btn_hotKeyUnReg.TabIndex = 7;
			this.btn_hotKeyUnReg.Text = "快捷键注销";
			this.btn_hotKeyUnReg.UseVisualStyleBackColor = true;
			this.btn_hotKeyUnReg.Click += new System.EventHandler(this.btn_hotKeyUnReg_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(220, 288);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.statusStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(236, 327);
			this.MinimumSize = new System.Drawing.Size(236, 327);
			this.Name = "Form1";
			this.Text = "ProcessKiller";
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_go;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btn_stop;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel status1;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_exit;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_start;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_stop;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_show;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btn_hotKeyUnReg;
		private System.Windows.Forms.Button btn_hotKeyReg;
	}
}

