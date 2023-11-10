namespace AllowanceCalculation.WF.Forms
{
	partial class StudentGradesForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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
			groupBox_PassFails = new GroupBox();
			checkedListBox_PassFails = new CheckedListBox();
			button_Save = new Button();
			groupBox_NumericGrades = new GroupBox();
			dataGridView_NumericGrades = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			SubjectName = new DataGridViewTextBoxColumn();
			Grade = new DataGridViewTextBoxColumn();
			groupBox_PassFails.SuspendLayout();
			groupBox_NumericGrades.SuspendLayout();
			((ISupportInitialize)dataGridView_NumericGrades).BeginInit();
			SuspendLayout();
			// 
			// groupBox_PassFails
			// 
			groupBox_PassFails.Controls.Add(checkedListBox_PassFails);
			groupBox_PassFails.Location = new Point(12, 12);
			groupBox_PassFails.Name = "groupBox_PassFails";
			groupBox_PassFails.Size = new Size(271, 362);
			groupBox_PassFails.TabIndex = 1;
			groupBox_PassFails.TabStop = false;
			groupBox_PassFails.Text = "Зачеты";
			// 
			// checkedListBox_PassFails
			// 
			checkedListBox_PassFails.FormattingEnabled = true;
			checkedListBox_PassFails.Location = new Point(16, 26);
			checkedListBox_PassFails.Name = "checkedListBox_PassFails";
			checkedListBox_PassFails.Size = new Size(237, 312);
			checkedListBox_PassFails.TabIndex = 3;
			// 
			// button_Save
			// 
			button_Save.Location = new Point(12, 380);
			button_Save.Name = "button_Save";
			button_Save.Size = new Size(94, 29);
			button_Save.TabIndex = 2;
			button_Save.Text = "Сохранить";
			button_Save.UseVisualStyleBackColor = true;
			button_Save.Click += button_Save_Click;
			// 
			// groupBox_NumericGrades
			// 
			groupBox_NumericGrades.Controls.Add(dataGridView_NumericGrades);
			groupBox_NumericGrades.Location = new Point(289, 12);
			groupBox_NumericGrades.Name = "groupBox_NumericGrades";
			groupBox_NumericGrades.Size = new Size(344, 362);
			groupBox_NumericGrades.TabIndex = 3;
			groupBox_NumericGrades.TabStop = false;
			groupBox_NumericGrades.Text = "Оценки";
			// 
			// dataGridView_NumericGrades
			// 
			dataGridView_NumericGrades.AllowUserToAddRows = false;
			dataGridView_NumericGrades.AllowUserToDeleteRows = false;
			dataGridView_NumericGrades.AllowUserToResizeColumns = false;
			dataGridView_NumericGrades.AllowUserToResizeRows = false;
			dataGridView_NumericGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dataGridView_NumericGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView_NumericGrades.Columns.AddRange(new DataGridViewColumn[] { Id, SubjectName, Grade });
			dataGridView_NumericGrades.Location = new Point(15, 26);
			dataGridView_NumericGrades.MultiSelect = false;
			dataGridView_NumericGrades.Name = "dataGridView_NumericGrades";
			dataGridView_NumericGrades.RowHeadersVisible = false;
			dataGridView_NumericGrades.RowHeadersWidth = 51;
			dataGridView_NumericGrades.RowTemplate.Height = 29;
			dataGridView_NumericGrades.Size = new Size(312, 312);
			dataGridView_NumericGrades.TabIndex = 0;
			// 
			// Id
			// 
			Id.HeaderText = "Id";
			Id.MinimumWidth = 6;
			Id.Name = "Id";
			Id.ReadOnly = true;
			Id.Visible = false;
			Id.Width = 125;
			// 
			// SubjectName
			// 
			SubjectName.HeaderText = "Предмет";
			SubjectName.MinimumWidth = 6;
			SubjectName.Name = "SubjectName";
			SubjectName.ReadOnly = true;
			SubjectName.Width = 99;
			// 
			// Grade
			// 
			Grade.HeaderText = "Оценка";
			Grade.MinimumWidth = 6;
			Grade.Name = "Grade";
			Grade.Width = 90;
			// 
			// StudentGradesForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(646, 425);
			Controls.Add(groupBox_NumericGrades);
			Controls.Add(button_Save);
			Controls.Add(groupBox_PassFails);
			Name = "StudentGradesForm";
			Text = "Оценки";
			Load += StudentGradesForm_Load;
			groupBox_PassFails.ResumeLayout(false);
			groupBox_NumericGrades.ResumeLayout(false);
			((ISupportInitialize)dataGridView_NumericGrades).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox_PassFails;
		private CheckedListBox checkedListBox_PassFails;
		private Button button_Save;
		private GroupBox groupBox_NumericGrades;
		private DataGridView dataGridView_NumericGrades;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn SubjectName;
		private DataGridViewTextBoxColumn Grade;
	}
}