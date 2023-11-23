namespace AllowanceCalculation.WF.Forms
{
	partial class SubjectsForm
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
			checkedListBox_Subjects = new CheckedListBox();
			button_Save = new Button();
			button_Delete = new Button();
			button_Add = new Button();
			button_Update = new Button();
			textBox_SubjectName = new TextBox();
			checkBox_PassFail = new CheckBox();
			SuspendLayout();
			// 
			// checkedListBox_Subjects
			// 
			checkedListBox_Subjects.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			checkedListBox_Subjects.FormattingEnabled = true;
			checkedListBox_Subjects.Location = new Point(12, 12);
			checkedListBox_Subjects.Name = "checkedListBox_Subjects";
			checkedListBox_Subjects.Size = new Size(305, 424);
			checkedListBox_Subjects.TabIndex = 0;
			// 
			// button_Save
			// 
			button_Save.Location = new Point(323, 12);
			button_Save.Name = "button_Save";
			button_Save.Size = new Size(199, 29);
			button_Save.TabIndex = 1;
			button_Save.Text = "Сохранить";
			button_Save.UseVisualStyleBackColor = true;
			button_Save.Click += button_Save_Click;
			// 
			// button_Delete
			// 
			button_Delete.Location = new Point(323, 47);
			button_Delete.Name = "button_Delete";
			button_Delete.Size = new Size(199, 29);
			button_Delete.TabIndex = 2;
			button_Delete.Text = "Удалить";
			button_Delete.UseVisualStyleBackColor = true;
			button_Delete.Click += button_Delete_Click;
			// 
			// button_Add
			// 
			button_Add.Location = new Point(323, 371);
			button_Add.Name = "button_Add";
			button_Add.Size = new Size(199, 29);
			button_Add.TabIndex = 3;
			button_Add.Text = "Добавить";
			button_Add.UseVisualStyleBackColor = true;
			button_Add.Click += button_Add_Click;
			// 
			// button_Update
			// 
			button_Update.Location = new Point(323, 408);
			button_Update.Name = "button_Update";
			button_Update.Size = new Size(199, 29);
			button_Update.TabIndex = 4;
			button_Update.Text = "Изменить";
			button_Update.UseVisualStyleBackColor = true;
			button_Update.Click += button_Update_Click;
			// 
			// textBox_SubjectName
			// 
			textBox_SubjectName.Location = new Point(323, 335);
			textBox_SubjectName.Name = "textBox_SubjectName";
			textBox_SubjectName.Size = new Size(199, 27);
			textBox_SubjectName.TabIndex = 5;
			// 
			// checkBox_PassFail
			// 
			checkBox_PassFail.AutoSize = true;
			checkBox_PassFail.Location = new Point(323, 305);
			checkBox_PassFail.Name = "checkBox_PassFail";
			checkBox_PassFail.Size = new Size(69, 24);
			checkBox_PassFail.TabIndex = 6;
			checkBox_PassFail.Text = "Зачет";
			checkBox_PassFail.UseVisualStyleBackColor = true;
			// 
			// SubjectsForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(534, 450);
			Controls.Add(checkBox_PassFail);
			Controls.Add(textBox_SubjectName);
			Controls.Add(button_Update);
			Controls.Add(button_Add);
			Controls.Add(button_Delete);
			Controls.Add(button_Save);
			Controls.Add(checkedListBox_Subjects);
			Name = "SubjectsForm";
			Text = "Предметы";
			Load += SubjectsForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private CheckedListBox checkedListBox_Subjects;
		private Button button_Save;
		private Button button_Delete;
		private Button button_Add;
		private Button button_Update;
		private TextBox textBox_SubjectName;
		private CheckBox checkBox_PassFail;
	}
}