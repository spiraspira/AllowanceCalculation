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
			button_Students = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			SuspendLayout();
			// 
			// button_Students
			// 
			button_Students.Cursor = Cursors.Hand;
			button_Students.FlatStyle = FlatStyle.Flat;
			button_Students.Image = Resources.Resources.studentIcon;
			button_Students.Location = new Point(12, 12);
			button_Students.Name = "button_Students";
			button_Students.Size = new Size(125, 125);
			button_Students.TabIndex = 0;
			button_Students.Text = "Студенты";
			button_Students.TextAlign = ContentAlignment.BottomCenter;
			button_Students.UseVisualStyleBackColor = true;
			button_Students.Click += button_Students_Click;
			// 
			// button2
			// 
			button2.Cursor = Cursors.Hand;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Image = Resources.Resources.groupIcon;
			button2.Location = new Point(143, 12);
			button2.Name = "button2";
			button2.Size = new Size(125, 125);
			button2.TabIndex = 1;
			button2.Text = "button2";
			button2.TextAlign = ContentAlignment.BottomCenter;
			button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Cursor = Cursors.Hand;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Image = Resources.Resources.subjectIcon;
			button3.Location = new Point(12, 143);
			button3.Name = "button3";
			button3.Size = new Size(125, 125);
			button3.TabIndex = 2;
			button3.Text = "button3";
			button3.TextAlign = ContentAlignment.BottomCenter;
			button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			button4.Cursor = Cursors.Hand;
			button4.FlatStyle = FlatStyle.Flat;
			button4.Image = Resources.Resources.studentIcon;
			button4.Location = new Point(143, 143);
			button4.Name = "button4";
			button4.Size = new Size(125, 125);
			button4.TabIndex = 3;
			button4.Text = "button4";
			button4.TextAlign = ContentAlignment.BottomCenter;
			button4.UseVisualStyleBackColor = true;
			// 
			// AdminForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(284, 285);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button_Students);
			Name = "AdminForm";
			Text = "Панель администратора";
			FormClosing += AdminForm_FormClosing;
			ResumeLayout(false);
		}

		#endregion

		private Button button_Students;
		private Button button2;
		private Button button3;
		private Button button4;
	}
}