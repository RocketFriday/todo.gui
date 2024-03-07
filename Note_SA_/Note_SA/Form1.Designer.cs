namespace Note_SA
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_createTask = new System.Windows.Forms.Button();
			this.btn_save = new System.Windows.Forms.Button();
			this.btn_load_local = new System.Windows.Forms.Button();
			this.btn_load_net = new System.Windows.Forms.Button();
			this.btn_save_net = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.panel_saveMSG = new System.Windows.Forms.Panel();
			this.saveMSG = new System.Windows.Forms.Label();
			this.panel_uploadMSG = new System.Windows.Forms.Panel();
			this.uploadMSG = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.Tab_Tasks = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.flow_tasks = new System.Windows.Forms.FlowLayoutPanel();
			this.flow_verify = new System.Windows.Forms.FlowLayoutPanel();
			this.Tab_Fixed = new System.Windows.Forms.TabPage();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.flow_fixed = new System.Windows.Forms.FlowLayoutPanel();
			this.flow_waiting = new System.Windows.Forms.FlowLayoutPanel();
			this.panel_create = new System.Windows.Forms.Panel();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_submit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dev_Task1 = new Note_SA.Dev_Task();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.panel1.SuspendLayout();
			this.panel_saveMSG.SuspendLayout();
			this.panel_uploadMSG.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.Tab_Tasks.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.Tab_Fixed.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.panel_create.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.btn_createTask);
			this.panel1.Controls.Add(this.btn_save);
			this.panel1.Controls.Add(this.btn_load_local);
			this.panel1.Controls.Add(this.btn_load_net);
			this.panel1.Controls.Add(this.btn_save_net);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.panel_saveMSG);
			this.panel1.Controls.Add(this.panel_uploadMSG);
			this.panel1.Controls.Add(this.tabControl1);
			this.panel1.Controls.Add(this.panel_create);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
			this.panel1.Size = new System.Drawing.Size(1920, 1000);
			this.panel1.TabIndex = 0;
			// 
			// btn_createTask
			// 
			this.btn_createTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.btn_createTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_createTask.FlatAppearance.BorderSize = 0;
			this.btn_createTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btn_createTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn_createTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_createTask.ForeColor = System.Drawing.Color.Transparent;
			this.btn_createTask.Image = global::Note_SA.Properties.Resources.create_icon_128;
			this.btn_createTask.Location = new System.Drawing.Point(1005, 1);
			this.btn_createTask.Margin = new System.Windows.Forms.Padding(0);
			this.btn_createTask.Name = "btn_createTask";
			this.btn_createTask.Size = new System.Drawing.Size(43, 43);
			this.btn_createTask.TabIndex = 3;
			this.btn_createTask.TabStop = false;
			this.btn_createTask.UseVisualStyleBackColor = false;
			this.btn_createTask.Click += new System.EventHandler(this.btn_Create);
			// 
			// btn_save
			// 
			this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_save.FlatAppearance.BorderSize = 0;
			this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_save.ForeColor = System.Drawing.Color.Transparent;
			this.btn_save.Image = global::Note_SA.Properties.Resources.save_icon_128;
			this.btn_save.Location = new System.Drawing.Point(1148, 1);
			this.btn_save.Margin = new System.Windows.Forms.Padding(0);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(43, 43);
			this.btn_save.TabIndex = 5;
			this.btn_save.TabStop = false;
			this.btn_save.UseVisualStyleBackColor = false;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// btn_load_local
			// 
			this.btn_load_local.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.btn_load_local.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_load_local.FlatAppearance.BorderSize = 0;
			this.btn_load_local.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btn_load_local.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn_load_local.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_load_local.ForeColor = System.Drawing.Color.Transparent;
			this.btn_load_local.Image = global::Note_SA.Properties.Resources.net_load_icon_128;
			this.btn_load_local.Location = new System.Drawing.Point(1291, 1);
			this.btn_load_local.Margin = new System.Windows.Forms.Padding(0);
			this.btn_load_local.Name = "btn_load_local";
			this.btn_load_local.Size = new System.Drawing.Size(43, 43);
			this.btn_load_local.TabIndex = 6;
			this.btn_load_local.TabStop = false;
			this.btn_load_local.UseVisualStyleBackColor = false;
			this.btn_load_local.Click += new System.EventHandler(this.btn_load_local_Click);
			// 
			// btn_load_net
			// 
			this.btn_load_net.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.btn_load_net.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_load_net.FlatAppearance.BorderSize = 0;
			this.btn_load_net.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btn_load_net.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn_load_net.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_load_net.ForeColor = System.Drawing.Color.Transparent;
			this.btn_load_net.Image = global::Note_SA.Properties.Resources.local_load_icon_1281;
			this.btn_load_net.Location = new System.Drawing.Point(1584, 1);
			this.btn_load_net.Margin = new System.Windows.Forms.Padding(0);
			this.btn_load_net.Name = "btn_load_net";
			this.btn_load_net.Size = new System.Drawing.Size(43, 43);
			this.btn_load_net.TabIndex = 7;
			this.btn_load_net.TabStop = false;
			this.btn_load_net.UseVisualStyleBackColor = false;
			this.btn_load_net.Click += new System.EventHandler(this.btn_load_net_Click);
			// 
			// btn_save_net
			// 
			this.btn_save_net.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.btn_save_net.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_save_net.FlatAppearance.BorderSize = 0;
			this.btn_save_net.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btn_save_net.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn_save_net.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_save_net.ForeColor = System.Drawing.Color.Transparent;
			this.btn_save_net.Image = global::Note_SA.Properties.Resources.net_save_icon_128;
			this.btn_save_net.Location = new System.Drawing.Point(1459, 1);
			this.btn_save_net.Margin = new System.Windows.Forms.Padding(0);
			this.btn_save_net.Name = "btn_save_net";
			this.btn_save_net.Size = new System.Drawing.Size(43, 43);
			this.btn_save_net.TabIndex = 10;
			this.btn_save_net.TabStop = false;
			this.btn_save_net.UseVisualStyleBackColor = false;
			this.btn_save_net.Click += new System.EventHandler(this.btn_save_net_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label2.Location = new System.Drawing.Point(1050, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "New";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label3.Location = new System.Drawing.Point(1190, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "Save";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label4.Location = new System.Drawing.Point(1335, 5);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 16);
			this.label4.TabIndex = 9;
			this.label4.Text = "Load";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.label6.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label6.Location = new System.Drawing.Point(1500, 5);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 16);
			this.label6.TabIndex = 11;
			this.label6.Text = "Upload";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.label7.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label7.Location = new System.Drawing.Point(1627, 5);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 16);
			this.label7.TabIndex = 12;
			this.label7.Text = "Download";
			// 
			// panel_saveMSG
			// 
			this.panel_saveMSG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.panel_saveMSG.Controls.Add(this.saveMSG);
			this.panel_saveMSG.Location = new System.Drawing.Point(1087, 45);
			this.panel_saveMSG.Name = "panel_saveMSG";
			this.panel_saveMSG.Size = new System.Drawing.Size(165, 61);
			this.panel_saveMSG.TabIndex = 3;
			// 
			// saveMSG
			// 
			this.saveMSG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.saveMSG.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic);
			this.saveMSG.ForeColor = System.Drawing.SystemColors.WindowText;
			this.saveMSG.Location = new System.Drawing.Point(0, 0);
			this.saveMSG.Name = "saveMSG";
			this.saveMSG.Size = new System.Drawing.Size(162, 61);
			this.saveMSG.TabIndex = 10;
			this.saveMSG.Text = "Saved";
			this.saveMSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel_uploadMSG
			// 
			this.panel_uploadMSG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.panel_uploadMSG.Controls.Add(this.uploadMSG);
			this.panel_uploadMSG.Location = new System.Drawing.Point(1400, 45);
			this.panel_uploadMSG.Name = "panel_uploadMSG";
			this.panel_uploadMSG.Size = new System.Drawing.Size(165, 61);
			this.panel_uploadMSG.TabIndex = 11;
			// 
			// uploadMSG
			// 
			this.uploadMSG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.uploadMSG.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic);
			this.uploadMSG.ForeColor = System.Drawing.SystemColors.WindowText;
			this.uploadMSG.Location = new System.Drawing.Point(0, 0);
			this.uploadMSG.Name = "uploadMSG";
			this.uploadMSG.Size = new System.Drawing.Size(162, 61);
			this.uploadMSG.TabIndex = 10;
			this.uploadMSG.Text = "Uploaded";
			this.uploadMSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabControl1
			// 
			this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
			this.tabControl1.CausesValidation = false;
			this.tabControl1.Controls.Add(this.Tab_Tasks);
			this.tabControl1.Controls.Add(this.Tab_Fixed);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(10);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(200, 3);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1920, 975);
			this.tabControl1.TabIndex = 3;
			this.tabControl1.TabStop = false;
			this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
			this.tabControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
			// 
			// Tab_Tasks
			// 
			this.Tab_Tasks.AutoScroll = true;
			this.Tab_Tasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
			this.Tab_Tasks.CausesValidation = false;
			this.Tab_Tasks.Controls.Add(this.splitContainer1);
			this.Tab_Tasks.ForeColor = System.Drawing.Color.Chocolate;
			this.Tab_Tasks.Location = new System.Drawing.Point(4, 47);
			this.Tab_Tasks.Name = "Tab_Tasks";
			this.Tab_Tasks.Padding = new System.Windows.Forms.Padding(3);
			this.Tab_Tasks.Size = new System.Drawing.Size(1912, 924);
			this.Tab_Tasks.TabIndex = 0;
			this.Tab_Tasks.Text = "Tasks";
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.AutoScroll = true;
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.splitContainer1.Panel1.Controls.Add(this.flow_tasks);
			this.splitContainer1.Panel1.Click += new System.EventHandler(this.splitContainer1_Panel1_MouseClick);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.AutoScroll = true;
			this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.splitContainer1.Panel2.Controls.Add(this.flow_verify);
			this.splitContainer1.Panel2.Click += new System.EventHandler(this.splitContainer1_Panel2_MouseClick);
			this.splitContainer1.Size = new System.Drawing.Size(1906, 918);
			this.splitContainer1.SplitterDistance = 950;
			this.splitContainer1.TabIndex = 4;
			this.splitContainer1.TabStop = false;
			// 
			// flow_tasks
			// 
			this.flow_tasks.AutoSize = true;
			this.flow_tasks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flow_tasks.BackColor = System.Drawing.Color.Transparent;
			this.flow_tasks.CausesValidation = false;
			this.flow_tasks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flow_tasks.ForeColor = System.Drawing.SystemColors.ControlText;
			this.flow_tasks.Location = new System.Drawing.Point(18, 18);
			this.flow_tasks.Margin = new System.Windows.Forms.Padding(0);
			this.flow_tasks.Name = "flow_tasks";
			this.flow_tasks.Size = new System.Drawing.Size(0, 0);
			this.flow_tasks.TabIndex = 2;
			this.flow_tasks.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
			this.flow_tasks.Paint += new System.Windows.Forms.PaintEventHandler(this.flowPanelShow);
			// 
			// flow_verify
			// 
			this.flow_verify.AutoSize = true;
			this.flow_verify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flow_verify.BackColor = System.Drawing.Color.Transparent;
			this.flow_verify.CausesValidation = false;
			this.flow_verify.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flow_verify.Location = new System.Drawing.Point(19, 18);
			this.flow_verify.Margin = new System.Windows.Forms.Padding(0);
			this.flow_verify.Name = "flow_verify";
			this.flow_verify.Size = new System.Drawing.Size(0, 0);
			this.flow_verify.TabIndex = 3;
			this.flow_verify.WrapContents = false;
			// 
			// Tab_Fixed
			// 
			this.Tab_Fixed.AutoScroll = true;
			this.Tab_Fixed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
			this.Tab_Fixed.CausesValidation = false;
			this.Tab_Fixed.Controls.Add(this.splitContainer2);
			this.Tab_Fixed.ForeColor = System.Drawing.Color.OliveDrab;
			this.Tab_Fixed.Location = new System.Drawing.Point(4, 47);
			this.Tab_Fixed.Name = "Tab_Fixed";
			this.Tab_Fixed.Padding = new System.Windows.Forms.Padding(3);
			this.Tab_Fixed.Size = new System.Drawing.Size(1912, 924);
			this.Tab_Fixed.TabIndex = 1;
			this.Tab_Fixed.Text = "Fixed";
			this.Tab_Fixed.Click += new System.EventHandler(this.flow_fixed_MouseEnter);
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.IsSplitterFixed = true;
			this.splitContainer2.Location = new System.Drawing.Point(3, 3);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.AutoScroll = true;
			this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.splitContainer2.Panel1.Controls.Add(this.flow_fixed);
			this.splitContainer2.Panel1.Click += new System.EventHandler(this.splitContainer2_Panel1_MouseClick);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.AutoScroll = true;
			this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.splitContainer2.Panel2.Controls.Add(this.flow_waiting);
			this.splitContainer2.Panel2.Click += new System.EventHandler(this.splitContainer2_Panel2_MouseClick);
			this.splitContainer2.Size = new System.Drawing.Size(1906, 918);
			this.splitContainer2.SplitterDistance = 950;
			this.splitContainer2.TabIndex = 5;
			this.splitContainer2.TabStop = false;
			// 
			// flow_fixed
			// 
			this.flow_fixed.AutoScroll = true;
			this.flow_fixed.AutoSize = true;
			this.flow_fixed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flow_fixed.CausesValidation = false;
			this.flow_fixed.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flow_fixed.Location = new System.Drawing.Point(18, 18);
			this.flow_fixed.Margin = new System.Windows.Forms.Padding(0);
			this.flow_fixed.Name = "flow_fixed";
			this.flow_fixed.Size = new System.Drawing.Size(0, 0);
			this.flow_fixed.TabIndex = 3;
			this.flow_fixed.WrapContents = false;
			this.flow_fixed.MouseEnter += new System.EventHandler(this.flow_fixed_MouseEnter);
			// 
			// flow_waiting
			// 
			this.flow_waiting.AutoSize = true;
			this.flow_waiting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flow_waiting.BackColor = System.Drawing.Color.Transparent;
			this.flow_waiting.CausesValidation = false;
			this.flow_waiting.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flow_waiting.Location = new System.Drawing.Point(19, 18);
			this.flow_waiting.Margin = new System.Windows.Forms.Padding(0);
			this.flow_waiting.Name = "flow_waiting";
			this.flow_waiting.Size = new System.Drawing.Size(0, 0);
			this.flow_waiting.TabIndex = 3;
			this.flow_waiting.WrapContents = false;
			// 
			// panel_create
			// 
			this.panel_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.panel_create.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel_create.Controls.Add(this.btn_cancel);
			this.panel_create.Controls.Add(this.btn_submit);
			this.panel_create.Controls.Add(this.label1);
			this.panel_create.Controls.Add(this.dev_Task1);
			this.panel_create.ForeColor = System.Drawing.SystemColors.InfoText;
			this.panel_create.Location = new System.Drawing.Point(584, 200);
			this.panel_create.Name = "panel_create";
			this.panel_create.Size = new System.Drawing.Size(750, 235);
			this.panel_create.TabIndex = 3;
			// 
			// btn_cancel
			// 
			this.btn_cancel.BackColor = System.Drawing.Color.OliveDrab;
			this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_cancel.FlatAppearance.BorderSize = 0;
			this.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.btn_cancel.Location = new System.Drawing.Point(475, 175);
			this.btn_cancel.Margin = new System.Windows.Forms.Padding(0);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(200, 30);
			this.btn_cancel.TabIndex = 7;
			this.btn_cancel.TabStop = false;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.UseVisualStyleBackColor = false;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// btn_submit
			// 
			this.btn_submit.BackColor = System.Drawing.Color.OliveDrab;
			this.btn_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_submit.FlatAppearance.BorderSize = 0;
			this.btn_submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btn_submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.btn_submit.Location = new System.Drawing.Point(75, 175);
			this.btn_submit.Margin = new System.Windows.Forms.Padding(0);
			this.btn_submit.Name = "btn_submit";
			this.btn_submit.Size = new System.Drawing.Size(200, 30);
			this.btn_submit.TabIndex = 6;
			this.btn_submit.TabStop = false;
			this.btn_submit.Text = "Submit";
			this.btn_submit.UseVisualStyleBackColor = false;
			this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
			this.label1.Location = new System.Drawing.Point(305, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Create New Task";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// dev_Task1
			// 
			this.dev_Task1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.dev_Task1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.dev_Task1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.dev_Task1.CausesValidation = false;
			this.dev_Task1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.dev_Task1.Location = new System.Drawing.Point(25, 50);
			this.dev_Task1.Margin = new System.Windows.Forms.Padding(0);
			this.dev_Task1.Name = "dev_Task1";
			this.dev_Task1.Padding = new System.Windows.Forms.Padding(1);
			this.dev_Task1.Size = new System.Drawing.Size(702, 108);
			this.dev_Task1.TabIndex = 3;
			this.dev_Task1.TabStop = false;
			this.dev_Task1.Task = "";
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(890, 461);
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.Color.SlateGray;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(3840, 2160);
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "TaskStat";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel_saveMSG.ResumeLayout(false);
			this.panel_uploadMSG.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.Tab_Tasks.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.Tab_Fixed.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.panel_create.ResumeLayout(false);
			this.panel_create.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage Tab_Tasks;
		private System.Windows.Forms.TabPage Tab_Fixed;
		private System.Windows.Forms.FlowLayoutPanel flow_tasks;
		private System.Windows.Forms.FlowLayoutPanel flow_verify;
		private System.Windows.Forms.FlowLayoutPanel flow_fixed;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btn_createTask;
		private Dev_Task dev_Task1;
		private System.Windows.Forms.Panel panel_create;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_submit;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.FlowLayoutPanel flow_waiting;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_load_local;
		private System.Windows.Forms.Button btn_load_net;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel_saveMSG;
		private System.Windows.Forms.Label saveMSG;
		private System.Windows.Forms.Button btn_save_net;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel_uploadMSG;
		private System.Windows.Forms.Label uploadMSG;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
	}
}

