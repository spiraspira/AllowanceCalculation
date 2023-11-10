namespace AllowanceCalculation.WF.Forms
{
	partial class GroupsForm
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
			listBox_Groups = new ListBox();
			button_Add = new Button();
			button_Update = new Button();
			button_Delete = new Button();
			button_Subjects = new Button();
			textBox_GroupName = new TextBox();
			SuspendLayout();
			// 
			// listBox_Groups
			// 
			listBox_Groups.FormattingEnabled = true;
			listBox_Groups.ItemHeight = 20;
			listBox_Groups.Location = new Point(12, 12);
			listBox_Groups.Name = "listBox_Groups";
			listBox_Groups.Size = new Size(198, 304);
			listBox_Groups.TabIndex = 0;
			// 
			// button_Add
			// 
			button_Add.Location = new Point(216, 43);
			button_Add.Name = "button_Add";
			button_Add.Size = new Size(144, 29);
			button_Add.TabIndex = 1;
			button_Add.Text = "Добавить";
			button_Add.UseVisualStyleBackColor = true;
			button_Add.Click += button_Add_Click;
			// 
			// button_Update
			// 
			button_Update.Location = new Point(216, 78);
			button_Update.Name = "button_Update";
			button_Update.Size = new Size(144, 29);
			button_Update.TabIndex = 2;
			button_Update.Text = "Изменить";
			button_Update.UseVisualStyleBackColor = true;
			button_Update.Click += button_Update_Click;
			// 
			// button_Delete
			// 
			button_Delete.Location = new Point(216, 113);
			button_Delete.Name = "button_Delete";
			button_Delete.Size = new Size(144, 29);
			button_Delete.TabIndex = 3;
			button_Delete.Text = "Удалить";
			button_Delete.UseVisualStyleBackColor = true;
			button_Delete.Click += button_Delete_Click;
			// 
			// button_Subjects
			// 
			button_Subjects.Location = new Point(216, 148);
			button_Subjects.Name = "button_Subjects";
			button_Subjects.Size = new Size(144, 29);
			button_Subjects.TabIndex = 4;
			button_Subjects.Text = "Предметы";
			button_Subjects.UseVisualStyleBackColor = true;
			// 
			// textBox_GroupName
			// 
			textBox_GroupName.Location = new Point(216, 12);
			textBox_GroupName.Name = "textBox_GroupName";
			textBox_GroupName.Size = new Size(144, 27);
			textBox_GroupName.TabIndex = 5;
			// 
			// GroupsForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(372, 327);
			Controls.Add(textBox_GroupName);
			Controls.Add(button_Subjects);
			Controls.Add(button_Delete);
			Controls.Add(button_Update);
			Controls.Add(button_Add);
			Controls.Add(listBox_Groups);
			Name = "GroupsForm";
			Text = "Группы";
			FormClosing += GroupsForm_FormClosing;
			Load += GroupsForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListBox listBox_Groups;
		private Button button_Add;
		private Button button_Update;
		private Button button_Delete;
		private Button button_Subjects;
		private TextBox textBox_GroupName;
	}
}