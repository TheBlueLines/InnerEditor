namespace InnerEditor
{
	partial class Main
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TitleBar = new System.Windows.Forms.Panel();
			this.New = new System.Windows.Forms.Panel();
			this.Open = new System.Windows.Forms.Panel();
			this.Save = new System.Windows.Forms.Panel();
			this.Minimize = new System.Windows.Forms.Panel();
			this.Exit = new System.Windows.Forms.Panel();
			this.TXT = new System.Windows.Forms.RichTextBox();
			this.base64button = new System.Windows.Forms.Panel();
			this.TitleBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// TitleBar
			// 
			this.TitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.TitleBar.Controls.Add(this.New);
			this.TitleBar.Controls.Add(this.Open);
			this.TitleBar.Controls.Add(this.Save);
			this.TitleBar.Controls.Add(this.Minimize);
			this.TitleBar.Location = new System.Drawing.Point(0, 0);
			this.TitleBar.Name = "TitleBar";
			this.TitleBar.Size = new System.Drawing.Size(800, 30);
			this.TitleBar.TabIndex = 0;
			this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
			this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
			this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
			// 
			// New
			// 
			this.New.BackColor = System.Drawing.Color.DimGray;
			this.New.Location = new System.Drawing.Point(5, 5);
			this.New.Name = "New";
			this.New.Size = new System.Drawing.Size(20, 20);
			this.New.TabIndex = 4;
			this.New.Click += new System.EventHandler(this.New_Click);
			this.New.MouseEnter += new System.EventHandler(this.New_MouseEnter);
			this.New.MouseLeave += new System.EventHandler(this.New_MouseLeave);
			// 
			// Open
			// 
			this.Open.BackColor = System.Drawing.Color.DimGray;
			this.Open.Location = new System.Drawing.Point(55, 5);
			this.Open.Name = "Open";
			this.Open.Size = new System.Drawing.Size(20, 20);
			this.Open.TabIndex = 4;
			this.Open.Click += new System.EventHandler(this.Open_Click);
			this.Open.MouseEnter += new System.EventHandler(this.Open_MouseEnter);
			this.Open.MouseLeave += new System.EventHandler(this.Open_MouseLeave);
			// 
			// Save
			// 
			this.Save.BackColor = System.Drawing.Color.DimGray;
			this.Save.Location = new System.Drawing.Point(30, 5);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(20, 20);
			this.Save.TabIndex = 4;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			this.Save.MouseEnter += new System.EventHandler(this.Save_MouseEnter);
			this.Save.MouseLeave += new System.EventHandler(this.Save_MouseLeave);
			// 
			// Minimize
			// 
			this.Minimize.BackColor = System.Drawing.Color.DimGray;
			this.Minimize.Location = new System.Drawing.Point(750, 5);
			this.Minimize.Name = "Minimize";
			this.Minimize.Size = new System.Drawing.Size(20, 20);
			this.Minimize.TabIndex = 3;
			this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
			this.Minimize.MouseEnter += new System.EventHandler(this.Minimize_MouseEnter);
			this.Minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
			// 
			// Exit
			// 
			this.Exit.BackColor = System.Drawing.Color.DimGray;
			this.Exit.Location = new System.Drawing.Point(775, 5);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(20, 20);
			this.Exit.TabIndex = 1;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
			this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
			// 
			// TXT
			// 
			this.TXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.TXT.BackColor = System.Drawing.Color.DimGray;
			this.TXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TXT.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TXT.ForeColor = System.Drawing.Color.White;
			this.TXT.Location = new System.Drawing.Point(12, 36);
			this.TXT.Name = "TXT";
			this.TXT.Size = new System.Drawing.Size(776, 402);
			this.TXT.TabIndex = 2;
			this.TXT.Text = "";
			// 
			// base64button
			// 
			this.base64button.BackColor = System.Drawing.Color.DimGray;
			this.base64button.Location = new System.Drawing.Point(80, 5);
			this.base64button.Name = "base64button";
			this.base64button.Size = new System.Drawing.Size(20, 20);
			this.base64button.TabIndex = 5;
			this.base64button.Click += new System.EventHandler(this.Base64button_Click);
			this.base64button.MouseEnter += new System.EventHandler(this.Base64button_MouseEnter);
			this.base64button.MouseLeave += new System.EventHandler(this.Base64button_MouseLeave);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.base64button);
			this.Controls.Add(this.TXT);
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.TitleBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Main";
			this.Text = "InnerEditor";
			this.Activated += new System.EventHandler(this.Form1_Activated);
			this.Deactivate += new System.EventHandler(this.Main_Deactivate);
			this.TitleBar.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel TitleBar;
		private System.Windows.Forms.Panel Exit;
		private System.Windows.Forms.RichTextBox TXT;
		private System.Windows.Forms.Panel Minimize;
		private System.Windows.Forms.Panel New;
		private System.Windows.Forms.Panel Open;
		private System.Windows.Forms.Panel Save;
		private System.Windows.Forms.Panel base64button;
	}
}