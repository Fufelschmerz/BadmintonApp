namespace BadmintonApp.Desktop.Forms;

partial class PlayersForm
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
		PlayersDataGridView = new DataGridView();
		Id = new DataGridViewTextBoxColumn();
		Surname = new DataGridViewTextBoxColumn();
		Name = new DataGridViewTextBoxColumn();
		Patronymic = new DataGridViewTextBoxColumn();
		DateBirthday = new DataGridViewTextBoxColumn();
		Gender = new DataGridViewComboBoxColumn();
		SaveButton = new Button();
		((System.ComponentModel.ISupportInitialize)PlayersDataGridView).BeginInit();
		SuspendLayout();
		// 
		// PlayersDataGridView
		// 
		PlayersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		PlayersDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Surname, Name, Patronymic, DateBirthday, Gender });
		PlayersDataGridView.Location = new Point(12, 12);
		PlayersDataGridView.Name = "PlayersDataGridView";
		PlayersDataGridView.RowTemplate.Height = 25;
		PlayersDataGridView.Size = new Size(790, 375);
		PlayersDataGridView.TabIndex = 0;
		// 
		// Id
		// 
		Id.HeaderText = "Id";
		Id.Name = "Id";
		Id.ReadOnly = true;
		Id.Resizable = DataGridViewTriState.True;
		Id.Width = 50;
		// 
		// Surname
		// 
		Surname.HeaderText = "Фамилия";
		Surname.Name = "Surname";
		// 
		// Name
		// 
		Name.HeaderText = "Имя";
		Name.Name = "Name";
		// 
		// Patronymic
		// 
		Patronymic.HeaderText = "Отчество";
		Patronymic.Name = "Patronymic";
		// 
		// DateBirthday
		// 
		DateBirthday.HeaderText = "Дата рождения";
		DateBirthday.Name = "DateBirthday";
		// 
		// Gender
		// 
		Gender.HeaderText = "Пол";
		Gender.Items.AddRange(new object[] { "Мужчина", "Женщина", "Другое" });
		Gender.Name = "Gender";
		Gender.Resizable = DataGridViewTriState.True;
		Gender.SortMode = DataGridViewColumnSortMode.Automatic;
		// 
		// SaveButton
		// 
		SaveButton.Location = new Point(658, 404);
		SaveButton.Name = "SaveButton";
		SaveButton.Size = new Size(147, 42);
		SaveButton.TabIndex = 1;
		SaveButton.Text = "Сохранить";
		SaveButton.UseVisualStyleBackColor = true;
		SaveButton.Click += SaveButton_Click;
		// 
		// PlayersForm
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(814, 463);
		Controls.Add(SaveButton);
		Controls.Add(PlayersDataGridView);
		Text = "Игроки";
		((System.ComponentModel.ISupportInitialize)PlayersDataGridView).EndInit();
		ResumeLayout(false);
	}

	#endregion

	private DataGridView PlayersDataGridView;
	private Button SaveButton;
	private DataGridViewTextBoxColumn Id;
	private DataGridViewTextBoxColumn Surname;
	private DataGridViewTextBoxColumn Name;
	private DataGridViewTextBoxColumn Patronymic;
	private DataGridViewTextBoxColumn DateBirthday;
	private DataGridViewComboBoxColumn Gender;
}