namespace AllowanceCalculation.WF.Forms
{
	partial class CreateUpdateStudentForm
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
			label_Group = new Label();
			label_Name = new Label();
			label_SocialWork = new Label();
			label_OnBudget = new Label();
			comboBox_Group = new ComboBox();
			textBox_Name = new TextBox();
			checkBox_SocialWork = new CheckBox();
			checkBox_OnBudget = new CheckBox();
			button_Add = new Button();
			SuspendLayout();
			// 
			// label_Group
			// 
			label_Group.AutoSize = true;
			label_Group.Location = new Point(12, 9);
			label_Group.Name = "label_Group";
			label_Group.Size = new Size(61, 20);
			label_Group.TabIndex = 0;
			label_Group.Text = "Группа:";
			// 
			// label_Name
			// 
			label_Name.AutoSize = true;
			label_Name.Location = new Point(12, 43);
			label_Name.Name = "label_Name";
			label_Name.Size = new Size(42, 20);
			label_Name.TabIndex = 1;
			label_Name.Text = "ФИО";
			// 
			// label_SocialWork
			// 
			label_SocialWork.AutoSize = true;
			label_SocialWork.Location = new Point(12, 70);
			label_SocialWork.Name = "label_SocialWork";
			label_SocialWork.Size = new Size(168, 20);
			label_SocialWork.TabIndex = 2;
			label_SocialWork.Text = "Общественная работа:";
			// 
			// label_OnBudget
			// 
			label_OnBudget.AutoSize = true;
			label_OnBudget.Location = new Point(12, 100);
			label_OnBudget.Name = "label_OnBudget";
			label_OnBudget.Size = new Size(97, 20);
			label_OnBudget.TabIndex = 3;
			label_OnBudget.Text = "На бюджете:";
			// 
			// comboBox_Group
			// 
			comboBox_Group.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox_Group.FormattingEnabled = true;
			comboBox_Group.Location = new Point(183, 6);
			comboBox_Group.Name = "comboBox_Group";
			comboBox_Group.Size = new Size(151, 28);
			comboBox_Group.TabIndex = 4;
			// 
			// textBox_Name
			// 
			textBox_Name.Location = new Point(183, 40);
			textBox_Name.Name = "textBox_Name";
			textBox_Name.Size = new Size(151, 27);
			textBox_Name.TabIndex = 5;
			// 
			// checkBox_SocialWork
			// 
			checkBox_SocialWork.AutoSize = true;
			checkBox_SocialWork.Location = new Point(183, 73);
			checkBox_SocialWork.Name = "checkBox_SocialWork";
			checkBox_SocialWork.Size = new Size(18, 17);
			checkBox_SocialWork.TabIndex = 6;
			checkBox_SocialWork.UseVisualStyleBackColor = true;
			// 
			// checkBox_OnBudget
			// 
			checkBox_OnBudget.AutoSize = true;
			checkBox_OnBudget.Location = new Point(183, 103);
			checkBox_OnBudget.Name = "checkBox_OnBudget";
			checkBox_OnBudget.Size = new Size(18, 17);
			checkBox_OnBudget.TabIndex = 7;
			checkBox_OnBudget.UseVisualStyleBackColor = true;
			// 
			// button_Add
			// 
			button_Add.Location = new Point(15, 132);
			button_Add.Name = "button_Add";
			button_Add.Size = new Size(319, 29);
			button_Add.TabIndex = 8;
			button_Add.Text = "Добавить";
			button_Add.UseVisualStyleBackColor = true;
			button_Add.Click += button_Add_Click;
			// 
			// CreateUpdateStudentForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(349, 171);
			Controls.Add(button_Add);
			Controls.Add(checkBox_OnBudget);
			Controls.Add(checkBox_SocialWork);
			Controls.Add(textBox_Name);
			Controls.Add(comboBox_Group);
			Controls.Add(label_OnBudget);
			Controls.Add(label_SocialWork);
			Controls.Add(label_Name);
			Controls.Add(label_Group);
			Name = "CreateUpdateStudentForm";
			Text = "Добавить студента";
			Load += AddStudentForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label_Group;
		private Label label_Name;
		private Label label_SocialWork;
		private Label label_OnBudget;
		private ComboBox comboBox_Group;
		private TextBox textBox_Name;
		private CheckBox checkBox_SocialWork;
		private CheckBox checkBox_OnBudget;
		private Button button_Add;
	}
}