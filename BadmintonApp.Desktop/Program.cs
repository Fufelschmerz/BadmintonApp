using BadmintonApp.Data;
using BadmintonApp.Desktop.Forms;
using Microsoft.EntityFrameworkCore;

namespace BadmintonApp.Desktop;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		try
		{
			ApplicationConfiguration.Initialize();
			Application.Run(new MainForm());
		}
		catch (Exception ex) 
		{
			MessageBox.Show(ex.Message);
		}
	}
}