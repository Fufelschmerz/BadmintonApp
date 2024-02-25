namespace BadmintonApp.Desktop.Forms;
public partial class MainForm : Form
{
	public MainForm()
	{
		InitializeComponent();
	}

	private void PlayesButton_Click(object sender, EventArgs e)
	{
		var playerForm = new PlayersForm();

		playerForm.ShowDialog();
	}
}
