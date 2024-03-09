namespace BadmintonApp.Desktop.Forms;

partial class TournamentForm
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
		SaveButton = new Button();
		TournamentDataGridView = new DataGridView();
		Id = new DataGridViewTextBoxColumn();
		Title = new DataGridViewTextBoxColumn();
		DateStart = new DataGridViewTextBoxColumn();
		DateEnd = new DataGridViewTextBoxColumn();
		SingleCategory = new DataGridViewCheckBoxColumn();
		DobelesCategory = new DataGridViewCheckBoxColumn();
		MixedCategory = new DataGridViewCheckBoxColumn();
		AddPlayers = new Button();
		((System.ComponentModel.ISupportInitialize)TournamentDataGridView).BeginInit();
		SuspendLayout();
		// 
		// SaveButton
		// 
		SaveButton.Location = new Point(641, 396);
		SaveButton.Name = "SaveButton";
		SaveButton.Size = new Size(147, 42);
		SaveButton.TabIndex = 2;
		SaveButton.Text = "Сохранить";
		SaveButton.UseVisualStyleBackColor = true;
		SaveButton.Click += SaveButton_Click;
		// 
		// TournamentDataGridView
		// 
		TournamentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		TournamentDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Title, DateStart, DateEnd, SingleCategory, DobelesCategory, MixedCategory });
		TournamentDataGridView.Location = new Point(12, 12);
		TournamentDataGridView.Name = "TournamentDataGridView";
		TournamentDataGridView.RowTemplate.Height = 25;
		TournamentDataGridView.Size = new Size(776, 366);
		TournamentDataGridView.TabIndex = 3;
		// 
		// Id
		// 
		Id.HeaderText = "Id";
		Id.Name = "Id";
		// 
		// Title
		// 
		Title.HeaderText = "Название";
		Title.Name = "Title";
		// 
		// DateStart
		// 
		DateStart.HeaderText = "Дата начала";
		DateStart.Name = "DateStart";
		// 
		// DateEnd
		// 
		DateEnd.HeaderText = "Дата окончания";
		DateEnd.Name = "DateEnd";
		// 
		// SingleCategory
		// 
		SingleCategory.HeaderText = "Одиночная категория";
		SingleCategory.Name = "SingleCategory";
		SingleCategory.Resizable = DataGridViewTriState.True;
		// 
		// DobelesCategory
		// 
		DobelesCategory.HeaderText = "Парная категория";
		DobelesCategory.Name = "DobelesCategory";
		DobelesCategory.Resizable = DataGridViewTriState.True;
		// 
		// MixedCategory
		// 
		MixedCategory.HeaderText = "Смешанная категория";
		MixedCategory.Name = "MixedCategory";
		MixedCategory.Resizable = DataGridViewTriState.True;
		// 
		// AddPlayers
		// 
		AddPlayers.Location = new Point(12, 396);
		AddPlayers.Name = "AddPlayers";
		AddPlayers.Size = new Size(175, 42);
		AddPlayers.TabIndex = 4;
		AddPlayers.Text = "Заявить игроков на турнир";
		AddPlayers.UseVisualStyleBackColor = true;
		AddPlayers.Click += AddPlayers_Click;
		// 
		// TournamentForm
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 450);
		Controls.Add(AddPlayers);
		Controls.Add(TournamentDataGridView);
		Controls.Add(SaveButton);
		Name = "TournamentForm";
		Text = "Турниры";
		((System.ComponentModel.ISupportInitialize)TournamentDataGridView).EndInit();
		ResumeLayout(false);
	}

	#endregion

	private Button SaveButton;
	private DataGridView TournamentDataGridView;
	private DataGridViewTextBoxColumn Id;
	private DataGridViewTextBoxColumn Title;
	private DataGridViewTextBoxColumn DateStart;
	private DataGridViewTextBoxColumn DateEnd;
	private DataGridViewCheckBoxColumn SingleCategory;
	private DataGridViewCheckBoxColumn DobelesCategory;
	private DataGridViewCheckBoxColumn MixedCategory;
	private Button AddPlayers;
}