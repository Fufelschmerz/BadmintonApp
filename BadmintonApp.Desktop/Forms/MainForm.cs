namespace BadmintonApp.Desktop.Forms;
public partial class MainForm : Form
{
	public MainForm()
	{
		InitializeComponent();

		pictureBox1.Image = Image.FromFile("1.jpg");
	}

	private void PlayesButton_Click(object sender, EventArgs e)
	{
		var playerForm = new PlayersForm();

		playerForm.ShowDialog();
	}

	private void Tornaments_Click(object sender, EventArgs e)
	{
		var tournamentForm = new TournamentForm();

		tournamentForm.ShowDialog();
	}
}
