using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_SA
{
	public partial class Dev_Task : UserControl
	{
		public Dev_Task()
		{
			InitializeComponent();
		}
		#region event

		public class SortRequestEventArgs : EventArgs
		{
			public SortRequestEventArgs(Dev_Task _dev_Task, int _taskState, int _index)
			{
				this.dev_Task = _dev_Task;
				this.taskState = _taskState;
				this.index = _index;
			}

			public Dev_Task dev_Task { get; private set; }
			public int taskState { get; private set; }
			public int index { get; private set; }
		}

		public static event EventHandler<SortRequestEventArgs> sortRequest;

		private void OnSortRequest(int index = 0)
		{
			var handler = sortRequest;
			if (sortRequest != null)
			{
				sortRequest.Invoke(this, e: new SortRequestEventArgs(this, (int)this.taskState, index));
			}
		}

		#endregion
		[Category("SA_Task_Props")]
		private string _task;

		public string Task
		{
			get { return _task; }
			set { _task = value; textBox1.Text = value; }
		}
		[Category("SA_Task_Props")]
		public enum _TaskState { _none = 0, _broken = 1, _verify = 2, _fixed = 3, _wait = 4};
		public _TaskState taskState;

		public void SetTaskState()
		{
			_TaskState _taskState = taskState == _TaskState._none ? _TaskState._broken : taskState;
			
			this.btn_fixed.Parent.BackColor = _taskState == _TaskState._fixed ? Color.DarkOliveGreen : Color.Transparent;
			this.btn_needfix.Parent.BackColor = _taskState == _TaskState._broken ? Color.IndianRed : Color.Transparent;
			this.btn_needVerify.Parent.BackColor = _taskState == _TaskState._verify ? Color.Peru : Color.Transparent;
			this.btn_wait.Parent.BackColor = _taskState == _TaskState._wait ? Color.DarkSlateGray : Color.Transparent;
			switch (_taskState)
			{
				case _TaskState._broken:
					this.textBox1.ForeColor = Color.IndianRed;
					this.BackColor = Color.Firebrick;
					this.panel_light_bar.BackColor = Color.Firebrick;
					this.btn_bottom.ForeColor = Color.Firebrick;
					this.btn_top.ForeColor = Color.Firebrick;
					break;
				case _TaskState._verify:
					this.textBox1.ForeColor = Color.Peru;
					this.BackColor = Color.DarkGoldenrod;
					this.panel_light_bar.BackColor = Color.DarkGoldenrod;
					this.btn_bottom.ForeColor = Color.DarkGoldenrod;
					this.btn_top.ForeColor = Color.DarkGoldenrod;
					break;
				case _TaskState._fixed:
					this.textBox1.ForeColor = Color.DarkOliveGreen;
					this.BackColor = Color.OliveDrab;
					this.panel_light_bar.BackColor = Color.OliveDrab;
					this.btn_bottom.ForeColor = Color.OliveDrab;
					this.btn_top.ForeColor = Color.OliveDrab;
					break;
				case _TaskState._wait:
					this.textBox1.ForeColor = Color.DarkSlateGray;
					this.BackColor = Color.Turquoise;
					this.panel_light_bar.BackColor = Color.Turquoise;
					this.btn_bottom.ForeColor = Color.Turquoise;
					this.btn_top.ForeColor = Color.Turquoise;
					break;
				default:
					break;
			}
		}
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			this.Task = textBox1.Text;
			//if this.Task
		}
		
		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}
		private void textBox1_Leave(object sender, EventArgs e)
		{
			if(textBox1.Text == ".")
			{
				if (this.Name != "dev_Task1")
				{
					TopLevelControl.Controls.Remove(this);

					this.Visible = false;
					this.Dispose();
				}
			}
		}
		private void Done_Click(object sender, EventArgs e)
		{
			taskState = _TaskState._fixed;
			SetTaskState();
		}

		private void Needs_Fix_Click(object sender, EventArgs e)
		{
			taskState = _TaskState._broken;
			SetTaskState();
		}

		private void btn_needVerify_Click(object sender, EventArgs e)
		{
			taskState = _TaskState._verify;
			SetTaskState();
		}
		private void btn_top_Click(object sender, EventArgs e)
		{
			OnSortRequest();
		}
		private void btn_bottom_Click(object sender, EventArgs e)
		{
			OnSortRequest(-1);
		}

		private void btn_wait_Click(object sender, EventArgs e)
		{
			taskState = _TaskState._wait;
			SetTaskState();
		}
	}
}
