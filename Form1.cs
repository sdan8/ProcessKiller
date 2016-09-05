using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProcessKiller
{
	public partial class Form1 : Form
	{
		HotKeys h = new HotKeys();
		public Form1()
		{
			InitializeComponent();
		}

		private void btn_go_Click(object sender, EventArgs e)
		{
			timer1.Start();
			status1.Text = "运行中...";

			btn_go.Enabled = false;
			btn_stop.Enabled = true;
			MenuItem_start.Enabled = false;
			MenuItem_stop.Enabled = true;
			//CloseProcess("REDAgent", "ePointer", "checkrs","rscheck");
		}

		private void btn_stop_Click(object sender, EventArgs e)
		{
			timer1.Stop();
			status1.Text = "已准备";

			btn_go.Enabled = true;
			btn_stop.Enabled = false;
			MenuItem_start.Enabled = true;
			MenuItem_stop.Enabled = false;
		}

		#region 托盘右键菜单栏

		private void MenuItem_show_Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.Show();
				this.notifyIcon1.Visible = false;
				this.ShowInTaskbar = true;
			}
		}

		private void MenuItem_start_Click(object sender, EventArgs e)
		{
			timer1.Start();
			status1.Text = "运行中...";
			btn_go.Enabled = false;
			btn_stop.Enabled = true;
			MenuItem_start.Enabled = false;
			MenuItem_stop.Enabled = true;
		}

		private void MenuItem_stop_Click(object sender, EventArgs e)
		{
			timer1.Stop();
			status1.Text = "已准备";
			btn_go.Enabled = true;
			btn_stop.Enabled = false;
			MenuItem_start.Enabled = true;
			MenuItem_stop.Enabled = false;
		}

		private void MenuItem_exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		#endregion

		#region 托盘区

		private void Form1_Resize(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.Hide();
				//在任务栏中隐藏
				this.ShowInTaskbar = false;
				this.notifyIcon1.Visible = true;
			}
		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.Show();
				//在任务栏中显示
				this.ShowInTaskbar = true;
				this.notifyIcon1.Visible = false;
			}
		}

		#endregion

		private void timer1_Tick(object sender, EventArgs e)
		{
			CloseProcess("REDAgent", "ePointer", "checkrs", "rscheck");
		}

		private bool CloseProcess(string processName1, string processName2, string processName3, string processName4)
		{
			bool result = false;
			System.Collections.ArrayList processList = new System.Collections.ArrayList();
			processList.Clear();
			string tempName = "";
			//int beginPos;
			//int endPos;
			foreach (System.Diagnostics.Process thisProcess in System.Diagnostics.Process.GetProcesses())
			{
				tempName = thisProcess.ProcessName;
				processList.Add(tempName);
				if (tempName == processName1 || tempName == processName2 || tempName == processName3 || tempName == processName4)
				{
					if (!thisProcess.CloseMainWindow())
					{
						try
						{
							thisProcess.Kill();
							richTextBox1.Text = richTextBox1.Text + tempName + "  已停止\n";
						}
						catch (Exception){}
					}
					result = true;
				}
			}
			return result;
		}

		private void btn_hotKeyReg_Click(object sender, EventArgs e)
		{
			h.Regist(this.Handle, (int)HotKeys.HotkeyModifiers.Control + (int)HotKeys.HotkeyModifiers.Alt, Keys.E, CallBack);
			MessageBox.Show("注册成功！");
		}

		private void btn_hotKeyUnReg_Click(object sender, EventArgs e)
		{
			h.UnRegist(this.Handle, CallBack);
			MessageBox.Show("注销成功！");
		}
		protected override void WndProc(ref Message m)
		{
			h.ProcessHotKey(m);
			base.WndProc(ref m);
		}
		public void CallBack()
		{
			timer1.Start();
			status1.Text = "运行中...";

			btn_go.Enabled = false;
			btn_stop.Enabled = true;
			MenuItem_start.Enabled = false;
			MenuItem_stop.Enabled = true;
		}

	}
}
