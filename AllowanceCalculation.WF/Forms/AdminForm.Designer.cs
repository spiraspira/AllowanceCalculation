namespace AllowanceCalculation.WF.Forms
{
	partial class AdminForm
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
			listBox_Students = new ListBox();
			button_Add = new Button();
			button_Update = new Button();
			button_Delete = new Button();
			button_Sort = new Button();
			button_Reset = new Button();
			comboBox_Groups = new ComboBox();
			button_StudentGrades = new Button();
			button_AddGroup = new Button();
			SuspendLayout();
			// 
			// listBox_Students
			// 
			listBox_Students.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			listBox_Students.FormattingEnabled = true;
			listBox_Students.ItemHeight = 18;
			listBox_Students.Location = new Point(12, 12);
			listBox_Students.Name = "listBox_Students";
			listBox_Students.Size = new Size(611, 418);
			listBox_Students.TabIndex = 0;
			// 
			// button_Add
			// 
			button_Add.Location = new Point(629, 12);
			button_Add.Name = "button_Add";
			button_Add.Size = new Size(165, 29);
			button_Add.TabIndex = 1;
			button_Add.Text = "Добавить";
			button_Add.UseVisualStyleBackColor = true;
			button_Add.Click += button_Add_Click;
			// 
			// button_Update
			// 
			button_Update.Location = new Point(629, 47);
			button_Update.Name = "button_Update";
			button_Update.Size = new Size(165, 29);
			button_Update.TabIndex = 2;
			button_Update.Text = "Изменить";
			button_Update.UseVisualStyleBackColor = true;
			button_Update.Click += button_Update_Click;
			// 
			// button_Delete
			// 
			button_Delete.Location = new Point(629, 82);
			button_Delete.Name = "button_Delete";
			button_Delete.Size = new Size(165, 29);
			button_Delete.TabIndex = 3;
			button_Delete.Text = "Удалить";
			button_Delete.UseVisualStyleBackColor = true;
			button_Delete.Click += button_Delete_Click;
			// 
			// button_Sort
			// 
			button_Sort.Location = new Point(629, 366);
			button_Sort.Name = "button_Sort";
			button_Sort.Size = new Size(165, 29);
			button_Sort.TabIndex = 4;
			button_Sort.Text = "Сортировка";
			button_Sort.UseVisualStyleBackColor = true;
			button_Sort.Click += button_Sort_Click;
			// 
			// button_Reset
			// 
			button_Reset.Location = new Point(629, 401);
			button_Reset.Name = "button_Reset";
			button_Reset.Size = new Size(165, 29);
			button_Reset.TabIndex = 5;
			button_Reset.Text = "Сброс";
			button_Reset.UseVisualStyleBackColor = true;
			button_Reset.Click += button_Reset_Click;
			// 
			// comboBox_Groups
			// 
			comboBox_Groups.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox_Groups.FormattingEnabled = true;
			comboBox_Groups.Location = new Point(629, 332);
			comboBox_Groups.Name = "comboBox_Groups";
			comboBox_Groups.Size = new Size(165, 28);
			comboBox_Groups.TabIndex = 6;
			// 
			// button_StudentGrades
			// 
			button_StudentGrades.Location = new Point(629, 117);
			button_StudentGrades.Name = "button_StudentGrades";
			button_StudentGrades.Size = new Size(165, 29);
			button_StudentGrades.TabIndex = 7;
			button_StudentGrades.Text = "Изменить оценки";
			button_StudentGrades.UseVisualStyleBackColor = true;
			button_StudentGrades.Click += button_StudentGrades_Click;
			// 
			// button_AddGroup
			// 
			button_AddGroup.Location = new Point(629, 297);
			button_AddGroup.Name = "button_AddGroup";
			button_AddGroup.Size = new Size(165, 29);
			button_AddGroup.TabIndex = 8;
			button_AddGroup.Text = "Изменить группы";
			button_AddGroup.UseVisualStyleBackColor = true;
			button_AddGroup.Click += button_AddGroup_Click;
			// 
			// AdminForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(806, 450);
			Controls.Add(button_AddGroup);
			Controls.Add(button_StudentGrades);
			Controls.Add(comboBox_Groups);
			Controls.Add(button_Reset);
			Controls.Add(button_Sort);
			Controls.Add(button_Delete);
			Controls.Add(button_Update);
			Controls.Add(button_Add);
			Controls.Add(listBox_Students);
			Name = "AdminForm";
			Text = "Панель администратора";
			FormClosing += StudentsForm_FormClosing;
			Load += StudentsForm_Load;
			ResumeLayout(false);
		}

		#endregion

		private ListBox listBox_Students;
		private Button button_Add;
		private Button button_Update;
		private Button button_Delete;
		private Button button_Sort;
		private Button button_Reset;
		private ComboBox comboBox_Groups;
		private Button button_StudentGrades;
		private Button button_AddGroup;
	}
}