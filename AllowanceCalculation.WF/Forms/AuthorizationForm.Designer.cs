namespace AllowanceCalculation.WF.Forms
{
	partial class AuthorizationForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			button_AdminLogin = new Button();
			button_UserLogin = new Button();
			comboBox_UserName = new ComboBox();
			comboBox_UserGroup = new ComboBox();
			label_UserGroup = new Label();
			label_UserName = new Label();
			label_AdminPassword = new Label();
			maskedTextBox_AdminPassword = new MaskedTextBox();
			pictureBox1 = new PictureBox();
			label_AllowanceCalculation = new Label();
			((ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// button_AdminLogin
			// 
			button_AdminLogin.Location = new Point(358, 212);
			button_AdminLogin.Name = "button_AdminLogin";
			button_AdminLogin.Size = new Size(212, 29);
			button_AdminLogin.TabIndex = 1;
			button_AdminLogin.Text = "Войти как администратор";
			button_AdminLogin.UseVisualStyleBackColor = true;
			button_AdminLogin.Click += button_AdminLogin_Click;
			// 
			// button_UserLogin
			// 
			button_UserLogin.Location = new Point(358, 163);
			button_UserLogin.Name = "button_UserLogin";
			button_UserLogin.Size = new Size(212, 29);
			button_UserLogin.TabIndex = 2;
			button_UserLogin.Text = "Войти как пользователь";
			button_UserLogin.UseVisualStyleBackColor = true;
			button_UserLogin.Click += button_UserLogin_Click;
			// 
			// comboBox_UserName
			// 
			comboBox_UserName.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox_UserName.FormattingEnabled = true;
			comboBox_UserName.Location = new Point(127, 163);
			comboBox_UserName.Name = "comboBox_UserName";
			comboBox_UserName.Size = new Size(225, 28);
			comboBox_UserName.TabIndex = 3;
			// 
			// comboBox_UserGroup
			// 
			comboBox_UserGroup.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox_UserGroup.FormattingEnabled = true;
			comboBox_UserGroup.Location = new Point(12, 163);
			comboBox_UserGroup.Name = "comboBox_UserGroup";
			comboBox_UserGroup.Size = new Size(109, 28);
			comboBox_UserGroup.TabIndex = 4;
			comboBox_UserGroup.SelectedIndexChanged += comboBox_UserGroup_SelectedIndexChanged;
			// 
			// label_UserGroup
			// 
			label_UserGroup.AutoSize = true;
			label_UserGroup.Location = new Point(12, 140);
			label_UserGroup.Name = "label_UserGroup";
			label_UserGroup.Size = new Size(58, 20);
			label_UserGroup.TabIndex = 5;
			label_UserGroup.Text = "Группа";
			// 
			// label_UserName
			// 
			label_UserName.AutoSize = true;
			label_UserName.Location = new Point(127, 140);
			label_UserName.Name = "label_UserName";
			label_UserName.Size = new Size(42, 20);
			label_UserName.TabIndex = 6;
			label_UserName.Text = "ФИО";
			// 
			// label_AdminPassword
			// 
			label_AdminPassword.AutoSize = true;
			label_AdminPassword.Location = new Point(12, 217);
			label_AdminPassword.Name = "label_AdminPassword";
			label_AdminPassword.Size = new Size(65, 20);
			label_AdminPassword.TabIndex = 7;
			label_AdminPassword.Text = "Пароль:";
			// 
			// maskedTextBox_AdminPassword
			// 
			maskedTextBox_AdminPassword.Location = new Point(127, 212);
			maskedTextBox_AdminPassword.Name = "maskedTextBox_AdminPassword";
			maskedTextBox_AdminPassword.PasswordChar = '●';
			maskedTextBox_AdminPassword.Size = new Size(225, 27);
			maskedTextBox_AdminPassword.TabIndex = 8;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Resources.Resources.authorizationFormPicture;
			pictureBox1.Location = new Point(12, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(340, 125);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 9;
			pictureBox1.TabStop = false;
			// 
			// label_AllowanceCalculation
			// 
			label_AllowanceCalculation.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
			label_AllowanceCalculation.Location = new Point(358, 12);
			label_AllowanceCalculation.Name = "label_AllowanceCalculation";
			label_AllowanceCalculation.Size = new Size(218, 134);
			label_AllowanceCalculation.TabIndex = 10;
			label_AllowanceCalculation.Text = "Программа расчета стипендии";
			// 
			// AuthorizationForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(582, 253);
			Controls.Add(label_AllowanceCalculation);
			Controls.Add(pictureBox1);
			Controls.Add(maskedTextBox_AdminPassword);
			Controls.Add(label_AdminPassword);
			Controls.Add(label_UserName);
			Controls.Add(label_UserGroup);
			Controls.Add(comboBox_UserGroup);
			Controls.Add(comboBox_UserName);
			Controls.Add(button_UserLogin);
			Controls.Add(button_AdminLogin);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "AuthorizationForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Авторизация";
			Load += AuthorizationForm_Load;
			((ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button button_AdminLogin;
		private Button button_UserLogin;
		private ComboBox comboBox_UserName;
		private ComboBox comboBox_UserGroup;
		private Label label_UserGroup;
		private Label label_UserName;
		private Label label_AdminPassword;
		private MaskedTextBox maskedTextBox_AdminPassword;
		private PictureBox pictureBox1;
		private Label label_AllowanceCalculation;
	}
}