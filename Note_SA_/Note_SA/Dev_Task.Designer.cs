namespace Note_SA
{
	partial class Dev_Task
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_needfix = new System.Windows.Forms.Button();
			this.panel_main = new System.Windows.Forms.Panel();
			this.btn_top = new System.Windows.Forms.Button();
			this.btn_bottom = new System.Windows.Forms.Button();
			this.flow_btns = new System.Windows.Forms.FlowLayoutPanel();
			this.panel_btn_fixed = new System.Windows.Forms.Panel();
			this.btn_fixed = new System.Windows.Forms.Button();
			this.panel_btn_broken = new System.Windows.Forms.Panel();
			this.panel_btn_verify = new System.Windows.Forms.Panel();
			this.btn_needVerify = new System.Windows.Forms.Button();
			this.panel_wait = new System.Windows.Forms.Panel();
			this.btn_wait = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel_light_bar = new System.Windows.Forms.Panel();
			this.panel_main.SuspendLayout();
			this.flow_btns.SuspendLayout();
			this.panel_btn_fixed.SuspendLayout();
			this.panel_btn_broken.SuspendLayout();
			this.panel_btn_verify.SuspendLayout();
			this.panel_wait.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_needfix
			// 
			this.btn_needfix.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_needfix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.btn_needfix.CausesValidation = false;
			this.btn_needfix.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_needfix.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btn_needfix.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn_needfix.Location = new System.Drawing.Point(2, 2);
			this.btn_needfix.Margin = new System.Windows.Forms.Padding(0);
			this.btn_needfix.Name = "btn_needfix";
			this.btn_needfix.Size = new System.Drawing.Size(60, 40);
			this.btn_needfix.TabIndex = 2;
			this.btn_needfix.TabStop = false;
			this.btn_needfix.Text = "Broken";
			this.btn_needfix.UseMnemonic = false;
			this.btn_needfix.UseVisualStyleBackColor = false;
			this.btn_needfix.Click += new System.EventHandler(this.Needs_Fix_Click);
			// 
			// panel_main
			// 
			this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.panel_main.CausesValidation = false;
			this.panel_main.Controls.Add(this.btn_top);
			this.panel_main.Controls.Add(this.btn_bottom);
			this.panel_main.Controls.Add(this.flow_btns);
			this.panel_main.Controls.Add(this.textBox1);
			this.panel_main.Controls.Add(this.panel_light_bar);
			this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_main.Location = new System.Drawing.Point(1, 1);
			this.panel_main.Margin = new System.Windows.Forms.Padding(5);
			this.panel_main.Name = "panel_main";
			this.panel_main.Padding = new System.Windows.Forms.Padding(0, 20, 30, 10);
			this.panel_main.Size = new System.Drawing.Size(694, 110);
			this.panel_main.TabIndex = 5;
			this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// btn_top
			// 
			this.btn_top.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_top.ForeColor = System.Drawing.Color.Maroon;
			this.btn_top.Image = global::Note_SA.Properties.Resources.to_Top_icon_128;
			this.btn_top.Location = new System.Drawing.Point(654, 13);
			this.btn_top.Name = "btn_top";
			this.btn_top.Size = new System.Drawing.Size(23, 23);
			this.btn_top.TabIndex = 8;
			this.btn_top.TabStop = false;
			this.btn_top.UseVisualStyleBackColor = true;
			this.btn_top.Click += new System.EventHandler(this.btn_top_Click);
			// 
			// btn_bottom
			// 
			this.btn_bottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_bottom.Image = global::Note_SA.Properties.Resources.to_bottom_icon_128;
			this.btn_bottom.Location = new System.Drawing.Point(654, 47);
			this.btn_bottom.Name = "btn_bottom";
			this.btn_bottom.Size = new System.Drawing.Size(23, 23);
			this.btn_bottom.TabIndex = 9;
			this.btn_bottom.TabStop = false;
			this.btn_bottom.UseVisualStyleBackColor = true;
			this.btn_bottom.Click += new System.EventHandler(this.btn_bottom_Click);
			// 
			// flow_btns
			// 
			this.flow_btns.AutoSize = true;
			this.flow_btns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flow_btns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.flow_btns.CausesValidation = false;
			this.flow_btns.Controls.Add(this.panel_btn_fixed);
			this.flow_btns.Controls.Add(this.panel_btn_broken);
			this.flow_btns.Controls.Add(this.panel_btn_verify);
			this.flow_btns.Controls.Add(this.panel_wait);
			this.flow_btns.Location = new System.Drawing.Point(8, 23);
			this.flow_btns.Name = "flow_btns";
			this.flow_btns.Size = new System.Drawing.Size(284, 50);
			this.flow_btns.TabIndex = 7;
			this.flow_btns.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
			// 
			// panel_btn_fixed
			// 
			this.panel_btn_fixed.BackColor = System.Drawing.Color.DarkOliveGreen;
			this.panel_btn_fixed.CausesValidation = false;
			this.panel_btn_fixed.Controls.Add(this.btn_fixed);
			this.panel_btn_fixed.Location = new System.Drawing.Point(3, 3);
			this.panel_btn_fixed.Name = "panel_btn_fixed";
			this.panel_btn_fixed.Size = new System.Drawing.Size(65, 44);
			this.panel_btn_fixed.TabIndex = 5;
			// 
			// btn_fixed
			// 
			this.btn_fixed.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_fixed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.btn_fixed.CausesValidation = false;
			this.btn_fixed.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_fixed.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btn_fixed.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn_fixed.Location = new System.Drawing.Point(2, 2);
			this.btn_fixed.Margin = new System.Windows.Forms.Padding(0);
			this.btn_fixed.Name = "btn_fixed";
			this.btn_fixed.Size = new System.Drawing.Size(60, 40);
			this.btn_fixed.TabIndex = 2;
			this.btn_fixed.TabStop = false;
			this.btn_fixed.Text = "Fixed";
			this.btn_fixed.UseVisualStyleBackColor = false;
			this.btn_fixed.Click += new System.EventHandler(this.Done_Click);
			// 
			// panel_btn_broken
			// 
			this.panel_btn_broken.BackColor = System.Drawing.Color.IndianRed;
			this.panel_btn_broken.CausesValidation = false;
			this.panel_btn_broken.Controls.Add(this.btn_needfix);
			this.panel_btn_broken.Location = new System.Drawing.Point(74, 3);
			this.panel_btn_broken.Name = "panel_btn_broken";
			this.panel_btn_broken.Size = new System.Drawing.Size(65, 44);
			this.panel_btn_broken.TabIndex = 4;
			// 
			// panel_btn_verify
			// 
			this.panel_btn_verify.BackColor = System.Drawing.Color.Peru;
			this.panel_btn_verify.CausesValidation = false;
			this.panel_btn_verify.Controls.Add(this.btn_needVerify);
			this.panel_btn_verify.Location = new System.Drawing.Point(145, 3);
			this.panel_btn_verify.Name = "panel_btn_verify";
			this.panel_btn_verify.Size = new System.Drawing.Size(65, 44);
			this.panel_btn_verify.TabIndex = 6;
			// 
			// btn_needVerify
			// 
			this.btn_needVerify.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_needVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.btn_needVerify.CausesValidation = false;
			this.btn_needVerify.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_needVerify.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btn_needVerify.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn_needVerify.Location = new System.Drawing.Point(2, 2);
			this.btn_needVerify.Margin = new System.Windows.Forms.Padding(0);
			this.btn_needVerify.Name = "btn_needVerify";
			this.btn_needVerify.Size = new System.Drawing.Size(60, 40);
			this.btn_needVerify.TabIndex = 2;
			this.btn_needVerify.TabStop = false;
			this.btn_needVerify.Text = "Verify";
			this.btn_needVerify.UseMnemonic = false;
			this.btn_needVerify.UseVisualStyleBackColor = false;
			this.btn_needVerify.Click += new System.EventHandler(this.btn_needVerify_Click);
			// 
			// panel_wait
			// 
			this.panel_wait.BackColor = System.Drawing.Color.DarkSlateGray;
			this.panel_wait.CausesValidation = false;
			this.panel_wait.Controls.Add(this.btn_wait);
			this.panel_wait.Location = new System.Drawing.Point(216, 3);
			this.panel_wait.Name = "panel_wait";
			this.panel_wait.Size = new System.Drawing.Size(65, 44);
			this.panel_wait.TabIndex = 7;
			// 
			// btn_wait
			// 
			this.btn_wait.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_wait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.btn_wait.CausesValidation = false;
			this.btn_wait.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_wait.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btn_wait.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn_wait.Location = new System.Drawing.Point(2, 2);
			this.btn_wait.Margin = new System.Windows.Forms.Padding(0);
			this.btn_wait.Name = "btn_wait";
			this.btn_wait.Size = new System.Drawing.Size(60, 40);
			this.btn_wait.TabIndex = 2;
			this.btn_wait.TabStop = false;
			this.btn_wait.Text = "Wait";
			this.btn_wait.UseMnemonic = false;
			this.btn_wait.UseVisualStyleBackColor = false;
			this.btn_wait.Click += new System.EventHandler(this.btn_wait_Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.CausesValidation = false;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.textBox1.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.textBox1.Location = new System.Drawing.Point(2, 77);
			this.textBox1.Margin = new System.Windows.Forms.Padding(5);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(662, 23);
			this.textBox1.TabIndex = 5;
			this.textBox1.TabStop = false;
			this.textBox1.Text = "This is a test task and it is current not completed";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
			// 
			// panel_light_bar
			// 
			this.panel_light_bar.BackColor = System.Drawing.Color.Turquoise;
			this.panel_light_bar.CausesValidation = false;
			this.panel_light_bar.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel_light_bar.Location = new System.Drawing.Point(0, 20);
			this.panel_light_bar.Name = "panel_light_bar";
			this.panel_light_bar.Size = new System.Drawing.Size(2, 80);
			this.panel_light_bar.TabIndex = 6;
			// 
			// Dev_Task
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = System.Drawing.Color.OliveDrab;
			this.CausesValidation = false;
			this.Controls.Add(this.panel_main);
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Dev_Task";
			this.Padding = new System.Windows.Forms.Padding(1);
			this.Size = new System.Drawing.Size(696, 112);
			this.panel_main.ResumeLayout(false);
			this.panel_main.PerformLayout();
			this.flow_btns.ResumeLayout(false);
			this.panel_btn_fixed.ResumeLayout(false);
			this.panel_btn_broken.ResumeLayout(false);
			this.panel_btn_verify.ResumeLayout(false);
			this.panel_wait.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel_main;
		private System.Windows.Forms.Panel panel_light_bar;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.FlowLayoutPanel flow_btns;
		private System.Windows.Forms.Panel panel_btn_fixed;
		private System.Windows.Forms.Button btn_fixed;
		private System.Windows.Forms.Panel panel_btn_broken;
		private System.Windows.Forms.Button btn_needfix;
		private System.Windows.Forms.Panel panel_btn_verify;
		private System.Windows.Forms.Button btn_needVerify;
		private System.Windows.Forms.Panel panel_wait;
		private System.Windows.Forms.Button btn_wait;
		private System.Windows.Forms.Button btn_top;
		private System.Windows.Forms.Button btn_bottom;
	}
}
