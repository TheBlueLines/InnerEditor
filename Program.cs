using System;
using System.Windows.Forms;

namespace InnerEditor
{
	static class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			ApplicationConfiguration.Initialize();
			Application.Run(new Main(args));
		}
	}
}