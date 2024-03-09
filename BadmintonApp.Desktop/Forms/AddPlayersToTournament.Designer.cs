namespace BadmintonApp.Desktop.Forms;

partial class AddPlayersToTournament
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
		Gender = new DataGridViewTextBoxColumn();
		City = new DataGridViewTextBoxColumn();
		Rank = new DataGridViewTextBoxColumn();
		IsAddPlayer = new DataGridViewCheckBoxColumn();
		TournamentsComboBox = new ComboBox();
		groupBox1 = new GroupBox();
		SaveButton = new Button();
		groupBox2 = new GroupBox();
		FilterByRank = new ComboBox();
		label4 = new Label();
		ClearFilters = new Label();
		label3 = new Label();
		FilterByYearBirthday = new ComboBox();
		label2 = new Label();
		FilterByGender = new ComboBox();
		label1 = new Label();
		FilterByCity = new ComboBox();
		((System.ComponentModel.ISupportInitialize)PlayersDataGridView).BeginInit();
		groupBox1.SuspendLayout();
		groupBox2.SuspendLayout();
		SuspendLayout();
		// 
		// PlayersDataGridView
		// 
		PlayersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		PlayersDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Surname, Name, Patronymic, DateBirthday, Gender, City, Rank, IsAddPlayer });
		PlayersDataGridView.Location = new Point(12, 259);
		PlayersDataGridView.Name = "PlayersDataGridView";
		PlayersDataGridView.RowTemplate.Height = 25;
		PlayersDataGridView.Size = new Size(694, 385);
		PlayersDataGridView.TabIndex = 1;
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
		Surname.ReadOnly = true;
		// 
		// Name
		// 
		Name.HeaderText = "Имя";
		Name.Name = "Name";
		Name.ReadOnly = true;
		// 
		// Patronymic
		// 
		Patronymic.HeaderText = "Отчество";
		Patronymic.Name = "Patronymic";
		Patronymic.ReadOnly = true;
		// 
		// DateBirthday
		// 
		DateBirthday.HeaderText = "Дата рождения";
		DateBirthday.Name = "DateBirthday";
		DateBirthday.ReadOnly = true;
		// 
		// Gender
		// 
		Gender.HeaderText = "Пол";
		Gender.Name = "Gender";
		Gender.ReadOnly = true;
		Gender.Resizable = DataGridViewTriState.True;
		// 
		// City
		// 
		City.HeaderText = "Город";
		City.Name = "City";
		City.ReadOnly = true;
		// 
		// Rank
		// 
		Rank.HeaderText = "Разряд";
		Rank.Name = "Rank";
		Rank.ReadOnly = true;
		// 
		// IsAddPlayer
		// 
		IsAddPlayer.HeaderText = "Заявить";
		IsAddPlayer.Name = "IsAddPlayer";
		IsAddPlayer.Resizable = DataGridViewTriState.True;
		IsAddPlayer.SortMode = DataGridViewColumnSortMode.Automatic;
		// 
		// TournamentsComboBox
		// 
		TournamentsComboBox.FormattingEnabled = true;
		TournamentsComboBox.Location = new Point(6, 22);
		TournamentsComboBox.Name = "TournamentsComboBox";
		TournamentsComboBox.Size = new Size(200, 23);
		TournamentsComboBox.TabIndex = 2;
		TournamentsComboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
		// 
		// groupBox1
		// 
		groupBox1.Controls.Add(TournamentsComboBox);
		groupBox1.Location = new Point(12, 176);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new Size(212, 60);
		groupBox1.TabIndex = 3;
		groupBox1.TabStop = false;
		groupBox1.Text = "Турнир";
		// 
		// SaveButton
		// 
		SaveButton.Location = new Point(559, 662);
		SaveButton.Name = "SaveButton";
		SaveButton.Size = new Size(147, 42);
		SaveButton.TabIndex = 4;
		SaveButton.Text = "Сохранить";
		SaveButton.UseVisualStyleBackColor = true;
		SaveButton.Click += SaveButton_Click;
		// 
		// groupBox2
		// 
		groupBox2.Controls.Add(FilterByRank);
		groupBox2.Controls.Add(label4);
		groupBox2.Controls.Add(ClearFilters);
		groupBox2.Controls.Add(label3);
		groupBox2.Controls.Add(FilterByYearBirthday);
		groupBox2.Controls.Add(label2);
		groupBox2.Controls.Add(FilterByGender);
		groupBox2.Controls.Add(label1);
		groupBox2.Controls.Add(FilterByCity);
		groupBox2.Location = new Point(391, 13);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new Size(315, 223);
		groupBox2.TabIndex = 5;
		groupBox2.TabStop = false;
		groupBox2.Text = "Фильтры по игрокам";
		// 
		// FilterByRank
		// 
		FilterByRank.FormattingEnabled = true;
		FilterByRank.Location = new Point(104, 146);
		FilterByRank.Name = "FilterByRank";
		FilterByRank.Size = new Size(201, 23);
		FilterByRank.TabIndex = 8;
		FilterByRank.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
		// 
		// label4
		// 
		label4.AutoSize = true;
		label4.Location = new Point(54, 149);
		label4.Name = "label4";
		label4.Size = new Size(44, 15);
		label4.TabIndex = 7;
		label4.Text = "Разряд";
		// 
		// ClearFilters
		// 
		ClearFilters.AutoSize = true;
		ClearFilters.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
		ClearFilters.ForeColor = SystemColors.HotTrack;
		ClearFilters.Location = new Point(192, 188);
		ClearFilters.Name = "ClearFilters";
		ClearFilters.Size = new Size(113, 15);
		ClearFilters.TabIndex = 6;
		ClearFilters.Text = "Сбросить фильтры";
		ClearFilters.Click += ClearFilters_Click;
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.Location = new Point(14, 109);
		label3.Name = "label3";
		label3.Size = new Size(84, 15);
		label3.TabIndex = 5;
		label3.Text = "Год рождения";
		// 
		// FilterByYearBirthday
		// 
		FilterByYearBirthday.FormattingEnabled = true;
		FilterByYearBirthday.Location = new Point(104, 106);
		FilterByYearBirthday.Name = "FilterByYearBirthday";
		FilterByYearBirthday.Size = new Size(201, 23);
		FilterByYearBirthday.TabIndex = 4;
		FilterByYearBirthday.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Location = new Point(68, 63);
		label2.Name = "label2";
		label2.Size = new Size(30, 15);
		label2.TabIndex = 3;
		label2.Text = "Пол";
		// 
		// FilterByGender
		// 
		FilterByGender.FormattingEnabled = true;
		FilterByGender.Items.AddRange(new object[] { "Мужчина", "Женщина", "Другое" });
		FilterByGender.Location = new Point(104, 63);
		FilterByGender.Name = "FilterByGender";
		FilterByGender.Size = new Size(201, 23);
		FilterByGender.TabIndex = 2;
		FilterByGender.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Location = new Point(58, 24);
		label1.Name = "label1";
		label1.Size = new Size(40, 15);
		label1.TabIndex = 1;
		label1.Text = "Город";
		// 
		// FilterByCity
		// 
		FilterByCity.FormattingEnabled = true;
		FilterByCity.Location = new Point(104, 24);
		FilterByCity.Name = "FilterByCity";
		FilterByCity.Size = new Size(201, 23);
		FilterByCity.TabIndex = 0;
		FilterByCity.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
		// 
		// AddPlayersToTournament
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(720, 714);
		Controls.Add(groupBox2);
		Controls.Add(SaveButton);
		Controls.Add(groupBox1);
		Controls.Add(PlayersDataGridView);
		Text = "Заявить игроков на турнир";
		((System.ComponentModel.ISupportInitialize)PlayersDataGridView).EndInit();
		groupBox1.ResumeLayout(false);
		groupBox2.ResumeLayout(false);
		groupBox2.PerformLayout();
		ResumeLayout(false);
	}

	#endregion

	private DataGridView PlayersDataGridView;
	private ComboBox TournamentsComboBox;
	private GroupBox groupBox1;
	private Button SaveButton;
	private DataGridViewTextBoxColumn Id;
	private DataGridViewTextBoxColumn Surname;
	private DataGridViewTextBoxColumn Name;
	private DataGridViewTextBoxColumn Patronymic;
	private DataGridViewTextBoxColumn DateBirthday;
	private DataGridViewTextBoxColumn Gender;
	private DataGridViewTextBoxColumn City;
	private DataGridViewTextBoxColumn Rank;
	private DataGridViewCheckBoxColumn IsAddPlayer;
	private GroupBox groupBox2;
	private ComboBox FilterByYearBirthday;
	private Label label2;
	private ComboBox FilterByGender;
	private Label label1;
	private ComboBox FilterByCity;
	private Label label3;
	private Label ClearFilters;
	private ComboBox FilterByRank;
	private Label label4;
}