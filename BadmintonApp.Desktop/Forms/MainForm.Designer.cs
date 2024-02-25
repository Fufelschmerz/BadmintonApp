namespace BadmintonApp.Desktop.Forms;

partial class MainForm
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
		Add_Match = new Button();
		Export_Mathes = new Button();
		Menu = new MenuStrip();
		PlayesButton = new ToolStripMenuItem();
		Menu.SuspendLayout();
		SuspendLayout();
		// 
		// Add_Match
		// 
		Add_Match.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
		Add_Match.Location = new Point(12, 394);
		Add_Match.Name = "Add_Match";
		Add_Match.Size = new Size(229, 53);
		Add_Match.TabIndex = 1;
		Add_Match.Text = "Добавить матч";
		Add_Match.UseVisualStyleBackColor = true;
		// 
		// Export_Mathes
		// 
		Export_Mathes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
		Export_Mathes.Location = new Point(292, 394);
		Export_Mathes.Name = "Export_Mathes";
		Export_Mathes.Size = new Size(229, 53);
		Export_Mathes.TabIndex = 2;
		Export_Mathes.Text = "Экспорт матчей";
		Export_Mathes.UseVisualStyleBackColor = true;
		// 
		// Menu
		// 
		Menu.Items.AddRange(new ToolStripItem[] { PlayesButton });
		Menu.Location = new Point(0, 0);
		Menu.Name = "Menu";
		Menu.Size = new Size(533, 29);
		Menu.TabIndex = 3;
		Menu.Text = "menuStrip1";
		// 
		// PlayesButton
		// 
		PlayesButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
		PlayesButton.Name = "PlayesButton";
		PlayesButton.Size = new Size(78, 25);
		PlayesButton.Text = "Игроки";
		PlayesButton.Click += PlayesButton_Click;
		// 
		// MainForm
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(533, 459);
		Controls.Add(Export_Mathes);
		Controls.Add(Add_Match);
		Controls.Add(Menu);
		MainMenuStrip = Menu;
		Name = "MainForm";
		Text = "MainForm";
		Menu.ResumeLayout(false);
		Menu.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Button Add_Match;
	private Button Export_Mathes;
	private MenuStrip Menu;
	private ToolStripMenuItem PlayesButton;
}