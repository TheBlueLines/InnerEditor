using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.Runtime.InteropServices;

namespace InnerEditor
{
	public partial class Main : Form
	{
		private Color focusColor = Color.DimGray;
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
		bool base64 = false;
		string original;
		public static string Base64Encode(string plainText)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
		}
		public static string Base64Decode(string base64EncodedData)
		{
			return Encoding.UTF8.GetString(Convert.FromBase64String(base64EncodedData));
		}
		private bool mouseIsDown;
		private Point firstPoint;
		public List<string> lines = new();
		public int selected = 0;
		public bool FirstDownloading = false;
		public string file = null;
		public Main(string[] args)
		{
			InitializeComponent();
			KeyDown += new KeyEventHandler(Form1_KeyDown);
			Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
			Exit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Exit.Width, Exit.Height, 5, 5));
			Minimize.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Minimize.Width, Minimize.Height, 5, 5));
			Save.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Save.Width, Save.Height, 5, 5));
			New.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, New.Width, New.Height, 5, 5));
			Open.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Open.Width, Open.Height, 5, 5));
			base64button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, base64button.Width, base64button.Height, 5, 5));
			if (args.Length != 0)
			{
				file = args[0];
				original = File.ReadAllText(file);
				LoadText(original);
			}
			KeyPreview = true;
			focusColor = Color.DimGray;
			RePaint();
		}
		private void RePaint()
		{
			BackColor = focusColor;
			TXT.BackColor = focusColor;
			Exit.BackColor = focusColor;
			Minimize.BackColor = focusColor;
			Save.BackColor = focusColor;
			New.BackColor = focusColor;
			Open.BackColor = focusColor;
			base64button.BackColor = focusColor;
		}
		private void LoadText(string text)
		{
			try
			{
				base64 = true;
				TXT.Text = Base64Decode(text);
			}
			catch
			{
				base64 = false;
				TXT.Text = text;
			}
		}
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (ModifierKeys == Keys.Control)
			{
				switch (e.KeyCode)
				{
					case Keys.S:
						SaveFile();
						return;
					case Keys.O:
						OpenFile();
						return;
					case Keys.N:
						NewFile();
						return;
					case Keys.W:
						Close();
						return;
					case Keys.Z:
						TXT.Undo();
						return;
					case Keys.Y:
						TXT.Redo();
						return;
					default:
						return;
				}
			}
		}
		void SaveFile()
		{
			if (string.IsNullOrEmpty(file))
			{
				SaveFileDialog save = new()
				{
					Title = "Save Text File",
					DefaultExt = "txt",
					Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
				};
				if (save.ShowDialog() != DialogResult.OK)
				{
					return;
				}
				file = save.FileName;
			}
			File.WriteAllText(file, base64 ? Base64Encode(TXT.Text) : TXT.Text);
		}
		void OpenFile()
		{
			OpenFileDialog open = new();
			open.Title = "Open Text File";
			open.DefaultExt = "txt";
			open.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			if (open.ShowDialog() == DialogResult.OK)
			{
				file = open.FileName;
				original = Encoding.UTF8.GetString(File.ReadAllBytes(file));
				LoadText(original);
			}
		}
		void NewFile()
		{
			original = string.Empty;
			TXT.Text = string.Empty;
			file = string.Empty;
		}
		private void Exit_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void Exit_MouseLeave(object sender, EventArgs e)
		{
			Exit.BackColor = focusColor;
		}
		private void Exit_MouseEnter(object sender, EventArgs e)
		{
			Exit.BackColor = Color.Red;
		}
		private void TitleBar_MouseDown(object sender, MouseEventArgs e)
		{
			firstPoint = e.Location;
			mouseIsDown = true;
		}
		private void Minimize_MouseEnter(object sender, EventArgs e)
		{
			Minimize.BackColor = Color.LimeGreen;
		}
		private void Minimize_MouseLeave(object sender, EventArgs e)
		{
			Minimize.BackColor = focusColor;
		}
		private void Minimize_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}
		private void New_MouseEnter(object sender, EventArgs e)
		{
			New.BackColor = Color.Gold;
		}
		private void New_MouseLeave(object sender, EventArgs e)
		{
			New.BackColor = focusColor;
		}
		private void Save_MouseEnter(object sender, EventArgs e)
		{
			Save.BackColor = Color.Magenta;
		}
		private void Save_MouseLeave(object sender, EventArgs e)
		{
			Save.BackColor = focusColor;
		}
		private void Open_MouseEnter(object sender, EventArgs e)
		{
			Open.BackColor = Color.Aqua;
		}
		private void Open_MouseLeave(object sender, EventArgs e)
		{
			Open.BackColor = focusColor;
		}
		private void New_Click(object sender, EventArgs e)
		{
			NewFile();
		}
		private void Save_Click(object sender, EventArgs e)
		{
			SaveFile();
		}
		private void Open_Click(object sender, EventArgs e)
		{
			OpenFile();
		}
		private void TitleBar_MouseUp(object sender, MouseEventArgs e)
		{
			mouseIsDown = false;
		}
		private void TitleBar_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseIsDown)
			{
				int xDiff = firstPoint.X - e.Location.X;
				int yDiff = firstPoint.Y - e.Location.Y;
				int x = Location.X - xDiff;
				int y = Location.Y - yDiff;
				Location = new Point(x, y);
			}
		}
		private void Base64button_MouseEnter(object sender, EventArgs e)
		{
			base64button.BackColor = Color.RoyalBlue;
		}
		private void Base64button_MouseLeave(object sender, EventArgs e)
		{
			base64button.BackColor = focusColor;
		}
		private void Base64button_Click(object sender, EventArgs e)
		{
			base64 = !base64;
		}
		private void Form1_Activated(object sender, EventArgs e)
		{
			focusColor = Color.DimGray;
			TXT.ForeColor = Color.White;
			RePaint();
		}
		private void Main_Deactivate(object sender, EventArgs e)
		{
			focusColor = Color.FromArgb(255, 80, 80, 80);
			TXT.ForeColor = Color.Gray;
			RePaint();
		}
	}
}