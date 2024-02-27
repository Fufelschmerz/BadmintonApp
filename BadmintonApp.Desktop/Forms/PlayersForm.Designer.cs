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
            this.PlayersDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayersDataGridView
            // 
            this.PlayersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Surname,
            this.Name,
            this.Patronymic,
            this.DateBirthday,
            this.Gender});
            this.PlayersDataGridView.Location = new System.Drawing.Point(12, 14);
            this.PlayersDataGridView.Name = "PlayersDataGridView";
            this.PlayersDataGridView.RowTemplate.Height = 25;
            this.PlayersDataGridView.Size = new System.Drawing.Size(594, 425);
            this.PlayersDataGridView.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id.Width = 50;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            // 
            // Name
            // 
            this.Name.HeaderText = "Имя";
            this.Name.Name = "Name";
            // 
            // Patronymic
            // 
            this.Patronymic.HeaderText = "Отчество";
            this.Patronymic.Name = "Patronymic";
            // 
            // DateBirthday
            // 
            this.DateBirthday.HeaderText = "Дата рождения";
            this.DateBirthday.Name = "DateBirthday";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Пол";
            this.Gender.Items.AddRange(new object[] {
            "Мужчина",
            "Женщина",
            "Другое"});
            this.Gender.Name = "Gender";
            this.Gender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Gender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(459, 474);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(147, 48);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // PlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 535);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PlayersDataGridView);
            this.Text = "Игроки";
            ((System.ComponentModel.ISupportInitialize)(this.PlayersDataGridView)).EndInit();
            this.ResumeLayout(false);

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