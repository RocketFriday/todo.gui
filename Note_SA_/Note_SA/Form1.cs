using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;

namespace Note_SA
{
	public partial class Form1 : Form
	{
		#region declare
		private const string pattern = @"<textarea(?:.*)>|<(?:.*)textarea>.*?";
		private const string taskPattern = @"(?:x-|w-|y-|-)(?:.*)";
		private static Dictionary<string, Dev_Task> tasks = new Dictionary<string, Dev_Task>(); 
		static bool hasUploaded = false;
		FileStream myFileStream;
		#endregion
		#region Events
		private void OnSortRequest(object sender, Dev_Task.SortRequestEventArgs e)
		{
			Debug.WriteLine("SortRequestRecieved!");
			SortTasks();
			Dev_Task._TaskState taskState = (Dev_Task._TaskState)e.taskState;
			switch (taskState)
			{
				case Dev_Task._TaskState._none:
					return;
				case Dev_Task._TaskState._broken:
					flow_tasks.Controls.SetChildIndex(e.dev_Task, e.index < 0 ? flow_tasks.Controls.Count - 1 : e.index);
					break;
				case Dev_Task._TaskState._verify:
					flow_verify.Controls.SetChildIndex(e.dev_Task, e.index < 0 ? flow_verify.Controls.Count - 1 : e.index);
					break;
				case Dev_Task._TaskState._fixed:
					flow_fixed.Controls.SetChildIndex(e.dev_Task, e.index < 0 ? flow_fixed.Controls.Count - 1 : e.index);
					break;
				case Dev_Task._TaskState._wait:
					flow_tasks.Controls.SetChildIndex(e.dev_Task, e.index < 0 ? flow_tasks.Controls.Count - 1 : e.index);
					break;
				default:
					break;
			}
			UpdateTasks();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			Hide();
			LoadAllLocal();
		}
		private static void AddText(FileStream fs, string value)
		{
			byte[] info = new UTF8Encoding(true).GetBytes(value);
			fs.Write(info, 0, info.Length);
		}
		private void OnEnableDelegate(object sender, EventArgs e)
		{
			//this.Shown -= OnEnableDelegate;
		}
		private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{

		}
		private void flowPanelShow(object sender, PaintEventArgs e)
		{

		}
		private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			//System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
			//messageBoxCS.AppendFormat("{0} = {1}", "Alt", e.Alt);
			//messageBoxCS.AppendLine();
			//messageBoxCS.AppendFormat("{0} = {1}", "Control", e.Control);
			//messageBoxCS.AppendLine();
			//messageBoxCS.AppendFormat("{0} = {1}", "KeyCode", e.KeyCode);
			//messageBoxCS.AppendLine();
			//messageBoxCS.AppendFormat("{0} = {1}", "KeyValue", e.KeyValue);
			//messageBoxCS.AppendLine();
			//messageBoxCS.AppendFormat("{0} = {1}", "KeyData", e.KeyData);
			//messageBoxCS.AppendLine();
			//messageBoxCS.AppendFormat("{0} = {1}", "Modifiers", e.Modifiers);
			//messageBoxCS.AppendLine();
			//messageBoxCS.AppendFormat("{0} = {1}", "Shift", e.Shift);
			//messageBoxCS.AppendLine();
			//messageBoxCS.AppendFormat("{0} = {1}", "IsInputKey", e.IsInputKey);
			//messageBoxCS.AppendLine();
			//MessageBox.Show(messageBoxCS.ToString(), "PreviewKeyDown Event");
		}
		private void tabControl1_Click(object sender, EventArgs e)
		{

		}
		private void splitContainer1_Panel1_MouseClick(object sender, EventArgs e)
		{
			flow_tasks.Select();
		}
		private void splitContainer1_Panel2_MouseClick(object sender, EventArgs e)
		{
			flow_verify.Select();
		}
		private void splitContainer2_Panel1_MouseClick(object sender, EventArgs e)
		{
			flow_fixed.Select();
		}
		private void splitContainer2_Panel2_MouseClick(object sender, EventArgs e)
		{
			flow_waiting.Select();
		}
		private void flow_fixed_MouseEnter(object sender, EventArgs e)
		{
			flow_fixed.Select();
		}
		private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			SortTasks();
		}
		private void label1_Click(object sender, EventArgs e)
		{

		}
		private void btn_Create(object sender, EventArgs e)
		{
			panel_create.Visible = true;
			panel_create.BringToFront();
			dev_Task1.taskState = Dev_Task._TaskState._broken;
			dev_Task1.SetTaskState();
			dev_Task1.Task = "";
		}
		private void btn_submit_Click(object sender, EventArgs e)
		{
			Dev_Task dev_Task = new Dev_Task();
			dev_Task.TabStop = false;
			string taskText = "";
			taskText = this.dev_Task1.Task;
			if (taskText != "")
			{
				switch (this.dev_Task1.taskState)
				{
					case Dev_Task._TaskState._broken:
						dev_Task.taskState = Dev_Task._TaskState._broken;
						tasks.Add(taskText, dev_Task); // add to dict
						dev_Task.Task = taskText; // set name
						dev_Task.SetTaskState(); // update color
						flow_tasks.Controls.Add(dev_Task); // parent to flow
						break;
					case Dev_Task._TaskState._verify:
						dev_Task.taskState = Dev_Task._TaskState._verify;
						tasks.Add(taskText, dev_Task);
						dev_Task.Task = taskText; // set name
						dev_Task.SetTaskState(); // update color
						flow_verify.Controls.Add(dev_Task);
						break;
					case Dev_Task._TaskState._fixed:
						dev_Task.taskState = Dev_Task._TaskState._fixed; // set
						tasks.Add(taskText, dev_Task); // add to dict
						dev_Task.Task = taskText; // set name
						dev_Task.SetTaskState(); // update color
						flow_fixed.Controls.Add(dev_Task); // parent to flow
						break;
					default:
						break;
				}
				SortTasks();
				panel_create.Visible = false;
			}
			else { MessageBox.Show("Error: Task cannot be empty"); }
		}
		private void btn_cancel_Click(object sender, EventArgs e)
		{
			panel_create.Visible = false;
		}
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Dev_Task.sortRequest -= OnSortRequest;
		}
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{

			//if (e.Modifiers == Keys.Shift && e.KeyCode == Keys.Escape)
			if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S) 
			{
				SortTasks();
				SaveAllLocal();
				SavedMessage();
			}

			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}

			if (e.KeyCode == Keys.Tab)
			{
				//panel1.Visible = true;
			}
		}
		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Tab)
			{
				//panel1.Visible = false;
			}
		}
		private void btn_load_local_Click(object sender, EventArgs e)
		{
			DelAll();
			LoadAllLocal();
		}
		private void btn_load_net_Click(object sender, EventArgs e)
		{
			DelAll();
			LoadAllNet();
		}
		private void btn_save_Click(object sender, EventArgs e)
		{
			SortTasks();
			SaveAllLocal();
			SavedMessage();
		}
		private void btn_save_net_Click(object sender, EventArgs e)
		{
			SortTasks();
			SaveAllNet();
		}
		#endregion
		public Form1()
		{
			InitializeComponent();
			//this.Shown += OnEnableDelegate;
			Dev_Task.sortRequest += OnSortRequest;
			panel_saveMSG.Visible = false;
			panel_uploadMSG.Visible = false;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
			this.WindowState = FormWindowState.Maximized;
			Hide();
		}
		public IEnumerable<Control> GetAll(Control control, Type type)
		{
			var controls = control.Controls.Cast<Control>();

			return controls.SelectMany(ctrl => GetAll(ctrl, type))
									  .Concat(controls)
									  .Where(c => c.GetType() == type);
		}

		public async void SavedMessage()
		{
			panel_saveMSG.Visible = true;
			await Task.Delay(2000);
			await Task.Yield();
			panel_saveMSG.Visible = false;
		}
		public async void NetSavedMessage(bool b)
		{
			uploadMSG.Text = b ? "Uploaded" : "Timed out";
			panel_uploadMSG.Visible = true;
			await Task.Delay(2000);
			await Task.Yield();
			panel_uploadMSG.Visible = false;
		}
		public class WebClientEx : WebClient
		{
			public int Timeout { get; set; }

			protected override WebRequest GetWebRequest(Uri address)
			{
				var request = base.GetWebRequest(address);
				request.Timeout = Timeout;
				return request;
			}
		}


		private void SaveAllNet()
		{
			SaveAllLocal(); // replace this with temp file one day maybe
			bool finished = false;
			try
			{
				var myClient = new WebClientEx();
				myClient.Timeout = 1000;
				string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
				string myFile = string.Format("{0}Resources\\note.txt", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
				myClient.Credentials = CredentialCache.DefaultCredentials;
				//myClient.UploadFile(@"http://192.168.2.38/upload/put.php", "PUT", myFile);
				myClient.UploadFile(@"http://192.168.2.38/upload/put.php", "PUT", myFile);
				myClient.Dispose();
				finished = true;
			}
			catch (Exception err)
			{
				Debug.WriteLine(err.Message);
				//MessageBox.Show(err.Message);
				finished = false;
			}
			NetSavedMessage(finished);
		}
		private void SaveAllLocal()
		{
			string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
			string FileName = string.Format("{0}Resources\\note.txt", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
			myFileStream = new FileStream(FileName, FileMode.OpenOrCreate);
			myFileStream.SetLength(0);
			myFileStream.Close(); // This flushes the content.
			myFileStream = new FileStream(FileName, FileMode.OpenOrCreate);
			foreach (var kv in tasks)
			{
				string s = "";
				switch (kv.Value.taskState)
				{
					case Dev_Task._TaskState._broken:
						s = "- " + kv.Value.Task;
						break;
					case Dev_Task._TaskState._fixed:
						s = "x- " + kv.Value.Task;
						break;
					case Dev_Task._TaskState._verify:
						s = "y- " + kv.Value.Task;
						break;
					case Dev_Task._TaskState._wait:
						s = "w- " + kv.Value.Task;
						break;
					default:
						break;
				}
				AddText(myFileStream, s + Environment.NewLine);
			}
			myFileStream.Close();
			myFileStream.Dispose();
		}
		private void UpdateTasks()
		{
			#region sort the tasks
			Dictionary<string, int> orderedKeys = new Dictionary<string, int>();
			foreach (KeyValuePair<string, Dev_Task> kv in tasks)
			{
				switch (kv.Value.taskState)
				{
					case Dev_Task._TaskState._broken:
						orderedKeys.Add(kv.Key, flow_tasks.Controls.GetChildIndex(kv.Value));
						break;
					default:
						break;
				}
			}
			foreach (KeyValuePair<string, Dev_Task> kv in tasks)
			{
				switch (kv.Value.taskState)
				{
					case Dev_Task._TaskState._verify:
						orderedKeys.Add(kv.Key, flow_verify.Controls.GetChildIndex(kv.Value));
						break;
					default:
						break;
				}
			}
			foreach (KeyValuePair<string, Dev_Task> kv in tasks)
			{
				switch (kv.Value.taskState)
				{
					case Dev_Task._TaskState._wait:
						orderedKeys.Add(kv.Key, flow_waiting.Controls.GetChildIndex(kv.Value));
						break;
					default:
						break;
				}
			}
			foreach (KeyValuePair<string, Dev_Task> kv in tasks)
			{
				switch (kv.Value.taskState)
				{
					case Dev_Task._TaskState._fixed:
						orderedKeys.Add(kv.Key, flow_fixed.Controls.GetChildIndex(kv.Value));
						break;
					default:
						break;
				}
			}
			var sortedDict = orderedKeys.OrderBy(entry => orderedKeys.Keys.ToList().IndexOf(entry.Key)).ThenBy(entry => entry.Value);
			//foreach (var kv in sortedDict) { Debug.WriteLine(kv.Value + "|" + kv.Key); }

			var orderedPairs = from entry in tasks orderby sortedDict.ToDictionary(kv => kv.Key, kv => kv.Value).Keys.ToList().IndexOf(entry.Key) ascending select entry;
			tasks = null;
			tasks = orderedPairs.ToDictionary(kv => kv.Key, kv => kv.Value);
			foreach (var kv in tasks) { Debug.WriteLine(kv.Value + "|" + kv.Key); }
			#endregion
		}
		private void SortTasks()
		{
			//sort here
			//var c = GetAll(this, typeof(Dev_Task));
			//MessageBox.Show("Total Controls: " + c.Count());
			//List<Control> selectedCollection = c.ToList();
			
			foreach (var kv in tasks)
			{
				if(kv.Value.Task == ".") { tasks.Remove(kv.Key); SortTasks(); return; }
				switch (kv.Value.taskState)
				{
					case Dev_Task._TaskState._broken:
						if (kv.Value.Parent != flow_tasks) { kv.Value.Parent = flow_tasks; flow_tasks.Controls.SetChildIndex(kv.Value, 0); }
						else { kv.Value.Parent = flow_tasks; }
						break;
					case Dev_Task._TaskState._fixed:
						if (kv.Value.Parent != flow_fixed) { kv.Value.Parent = flow_fixed; flow_fixed.Controls.SetChildIndex(kv.Value, 0); }
						else { kv.Value.Parent = flow_fixed; }
						break;
					case Dev_Task._TaskState._verify:
						if (kv.Value.Parent != flow_verify) { kv.Value.Parent = flow_verify; flow_verify.Controls.SetChildIndex(kv.Value, 0); }
						else { kv.Value.Parent = flow_verify; }
						break;
					case Dev_Task._TaskState._wait:
						if (kv.Value.Parent != flow_waiting) { kv.Value.Parent = flow_waiting; flow_waiting.Controls.SetChildIndex(kv.Value, 0); }
						else { kv.Value.Parent = flow_waiting; }
						break;
					default:
						break;
				}
			}
		}
		private void LoadAllLocal()
		{
			panel_create.Visible = false;
			List<string> result = new List<string>();
			string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
			string FileName = string.Format("{0}Resources\\note.txt", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
			try
			{
				using (StreamReader sr = new StreamReader(FileName))
				{
					while (sr.Peek() >= 0)
					{
						result.Add(sr.ReadLine());
					}
				}
			}
			catch (Exception e)
			{
				Debug.WriteLine("The process failed: {0}", e.ToString());
			}
			PopulateTasks(result);
		}
		private void LoadAllNet()
		{
			panel_create.Visible = false;
			List<string> result = new List<string>();
			try
			{
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				var myClient = new WebClient();
				Stream response = myClient.OpenRead("http://192.168.2.38/upload/uploads/note.txt");
				StreamReader sr = new StreamReader(response);
				string data = sr.ReadToEnd();
				//var stringArr = Regex.Split(data, pattern);
				//string data2 = stringArr[1];
				foreach (Match m in Regex.Matches(data, taskPattern))
				{
					Debug.WriteLine(m.Value);
					result.Add(m.Value);
				}
				response.Close();
			}
			catch (Exception ex)
			{
				// handle error
				MessageBox.Show(ex.Message);
			}
			PopulateTasks(result);
		}
		private void PopulateTasks(List<string> result)
		{
			for (int i = 0; i < result.Count; i++)
			{
				if (result[i].StartsWith("x-"))
				{
					Dev_Task dev_Task = new Dev_Task(); // init
					dev_Task.TabStop = false;
					dev_Task.taskState = Dev_Task._TaskState._fixed; // set
					result[i] = result[i].Replace("x-", ""); // name
					result[i] = result[i].Trim(' ');
					tasks.Add(result[i], dev_Task); // add to dict
					dev_Task.Task = result[i]; // set name
					dev_Task.SetTaskState(); // update color
					flow_fixed.Controls.Add(dev_Task); // parent to flow
				}
				if (result[i].StartsWith("y-"))
				{
					Dev_Task dev_Task = new Dev_Task();
					dev_Task.TabStop = false;
					dev_Task.taskState = Dev_Task._TaskState._verify;
					result[i] = result[i].Replace("y-", "");
					result[i] = result[i].Trim(' ');
					tasks.Add(result[i], dev_Task);
					dev_Task.Task = result[i]; // set name
					dev_Task.SetTaskState(); // update color
					flow_verify.Controls.Add(dev_Task);
				}
				if (result[i].StartsWith("-"))
				{
					Dev_Task dev_Task = new Dev_Task();
					dev_Task.TabStop = false;
					dev_Task.taskState = Dev_Task._TaskState._broken;
					result[i] = result[i].Replace("- ", "");
					result[i] = result[i].Trim(' ');
					tasks.Add(result[i], dev_Task); // add to dict
					dev_Task.Task = result[i]; // set name
					dev_Task.SetTaskState(); // update color
					flow_tasks.Controls.Add(dev_Task); // parent to flow
				}
				if (result[i].StartsWith("w-"))
				{
					Dev_Task dev_Task = new Dev_Task();
					dev_Task.TabStop = false;
					dev_Task.taskState = Dev_Task._TaskState._wait;
					result[i] = result[i].Replace("w-", "");
					result[i] = result[i].Trim(' ');
					tasks.Add(result[i], dev_Task); // add to dict
					dev_Task.Task = result[i]; // set name
					dev_Task.SetTaskState(); // update color
					flow_waiting.Controls.Add(dev_Task); // parent to flow
				}
			}
		}
		private void DelAll()
		{
			tasks.Clear();
			while (flow_fixed.Controls.Count > 0)
			{
				foreach (Control cf in flow_fixed.Controls)
				{
					cf.Dispose();
				}
			}
			while (flow_tasks.Controls.Count > 0)
			{
				foreach (Control ct in flow_tasks.Controls)
				{
					ct.Dispose();
				}
			}
			while (flow_verify.Controls.Count > 0)
			{
				foreach (Control cv in flow_verify.Controls)
				{
					cv.Dispose();
				}
			}
			while (flow_waiting.Controls.Count > 0)
			{
				foreach (Control cw in flow_waiting.Controls)
				{
					cw.Dispose();
				}
			}
		}

		private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.Visible) { this.Hide(); }
			else
			{
				this.WindowState = FormWindowState.Minimized;
				this.Show();
				this.WindowState = FormWindowState.Normal;
				this.WindowState = FormWindowState.Maximized;
			}
		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
		}//Form.Activate() or Form.Focus()
	}
}
