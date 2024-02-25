using BadmintonApp.Data;
using BadmintonApp.Desktop.Forms;

namespace BadmintonApp.Desktop;

internal static class Program
{
	private static readonly bool _isUpdateSchema = false;

	[STAThread]
	private static void Main()
	{
		try
		{
			using var dbContext = new AppDbContext();

			if (_isUpdateSchema)
			{
				//TODO: нужно предусмотреть сохранение данных
				dbContext.Database.EnsureDeleted();
				dbContext.Database.EnsureCreated();
			}

			ApplicationConfiguration.Initialize();
			Application.Run(new MainForm());
		}
		catch (Exception ex) 
		{
			MessageBox.Show(ex.Message);
		}
	}
}