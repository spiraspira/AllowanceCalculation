namespace AllowanceCalculation.WF.Forms
{
	partial class UserForm
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
			groupBox_UserData = new GroupBox();
			label_IsExcellent = new Label();
			label_GradePointAverage = new Label();
			label_UserStatus = new Label();
			label_UserSocialWork = new Label();
			label_UserGroup = new Label();
			label_UserName = new Label();
			listBox_Grades = new ListBox();
			label_Allowance = new Label();
			groupBox_UserData.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox_UserData
			// 
			groupBox_UserData.Controls.Add(label_IsExcellent);
			groupBox_UserData.Controls.Add(label_GradePointAverage);
			groupBox_UserData.Controls.Add(label_UserStatus);
			groupBox_UserData.Controls.Add(label_UserSocialWork);
			groupBox_UserData.Controls.Add(label_UserGroup);
			groupBox_UserData.Controls.Add(label_UserName);
			groupBox_UserData.Location = new Point(12, 12);
			groupBox_UserData.Name = "groupBox_UserData";
			groupBox_UserData.Size = new Size(280, 153);
			groupBox_UserData.TabIndex = 0;
			groupBox_UserData.TabStop = false;
			groupBox_UserData.Text = "Данные";
			// 
			// label_IsExcellent
			// 
			label_IsExcellent.AutoSize = true;
			label_IsExcellent.Location = new Point(9, 129);
			label_IsExcellent.Name = "label_IsExcellent";
			label_IsExcellent.Size = new Size(50, 20);
			label_IsExcellent.TabIndex = 5;
			label_IsExcellent.Text = "label4";
			// 
			// label_GradePointAverage
			// 
			label_GradePointAverage.AutoSize = true;
			label_GradePointAverage.Location = new Point(9, 109);
			label_GradePointAverage.Name = "label_GradePointAverage";
			label_GradePointAverage.Size = new Size(50, 20);
			label_GradePointAverage.TabIndex = 4;
			label_GradePointAverage.Text = "label4";
			// 
			// label_UserStatus
			// 
			label_UserStatus.AutoSize = true;
			label_UserStatus.Location = new Point(9, 89);
			label_UserStatus.Name = "label_UserStatus";
			label_UserStatus.Size = new Size(50, 20);
			label_UserStatus.TabIndex = 3;
			label_UserStatus.Text = "label4";
			// 
			// label_UserSocialWork
			// 
			label_UserSocialWork.AutoSize = true;
			label_UserSocialWork.Location = new Point(9, 67);
			label_UserSocialWork.Name = "label_UserSocialWork";
			label_UserSocialWork.Size = new Size(50, 20);
			label_UserSocialWork.TabIndex = 2;
			label_UserSocialWork.Text = "label3";
			// 
			// label_UserGroup
			// 
			label_UserGroup.AutoSize = true;
			label_UserGroup.Location = new Point(8, 45);
			label_UserGroup.Name = "label_UserGroup";
			label_UserGroup.Size = new Size(50, 20);
			label_UserGroup.TabIndex = 1;
			label_UserGroup.Text = "label2";
			// 
			// label_UserName
			// 
			label_UserName.AutoSize = true;
			label_UserName.Location = new Point(8, 23);
			label_UserName.Name = "label_UserName";
			label_UserName.Size = new Size(50, 20);
			label_UserName.TabIndex = 0;
			label_UserName.Text = "label1";
			// 
			// listBox_Grades
			// 
			listBox_Grades.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
			listBox_Grades.FormattingEnabled = true;
			listBox_Grades.ItemHeight = 18;
			listBox_Grades.Location = new Point(298, 23);
			listBox_Grades.Name = "listBox_Grades";
			listBox_Grades.Size = new Size(320, 166);
			listBox_Grades.TabIndex = 1;
			// 
			// label_Allowance
			// 
			label_Allowance.AutoSize = true;
			label_Allowance.Location = new Point(21, 186);
			label_Allowance.Name = "label_Allowance";
			label_Allowance.Size = new Size(50, 20);
			label_Allowance.TabIndex = 4;
			label_Allowance.Text = "label4";
			// 
			// UserForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(629, 215);
			Controls.Add(label_Allowance);
			Controls.Add(listBox_Grades);
			Controls.Add(groupBox_UserData);
			Name = "UserForm";
			Text = "Расчет стипендии";
			Load += UserForm_Load;
			groupBox_UserData.ResumeLayout(false);
			groupBox_UserData.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox groupBox_UserData;
		private Label label_UserStatus;
		private Label label_UserSocialWork;
		private Label label_UserGroup;
		private Label label_UserName;
		private ListBox listBox_Grades;
		private Label label_Allowance;
		private Label label_GradePointAverage;
		private Label label_IsExcellent;
	}
}