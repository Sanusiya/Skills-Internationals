namespace Skills_international
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lnkLogout = new System.Windows.Forms.LinkLabel();
			this.lnkExit = new System.Windows.Forms.LinkLabel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbRegNo = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbFemale = new System.Windows.Forms.RadioButton();
			this.rbMale = new System.Windows.Forms.RadioButton();
			this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtHomePhone = new System.Windows.Forms.TextBox();
			this.txtMobilePhone = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.lable10 = new System.Windows.Forms.Label();
			this.lable9 = new System.Windows.Forms.Label();
			this.lable8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txtContactNo = new System.Windows.Forms.TextBox();
			this.txtNIC = new System.Windows.Forms.TextBox();
			this.txtParentName = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.btnRegister = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Navy;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(355, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(85, 64);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkBlue;
			this.label1.Location = new System.Drawing.Point(270, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(245, 32);
			this.label1.TabIndex = 2;
			this.label1.Text = "Skills International";
			// 
			// lnkLogout
			// 
			this.lnkLogout.AutoSize = true;
			this.lnkLogout.Location = new System.Drawing.Point(38, 94);
			this.lnkLogout.Name = "lnkLogout";
			this.lnkLogout.Size = new System.Drawing.Size(48, 16);
			this.lnkLogout.TabIndex = 3;
			this.lnkLogout.TabStop = true;
			this.lnkLogout.Text = "Logout";
			this.lnkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogout_LinkClicked);
			// 
			// lnkExit
			// 
			this.lnkExit.AutoSize = true;
			this.lnkExit.Location = new System.Drawing.Point(663, 91);
			this.lnkExit.Name = "lnkExit";
			this.lnkExit.Size = new System.Drawing.Size(28, 16);
			this.lnkExit.TabIndex = 4;
			this.lnkExit.TabStop = true;
			this.lnkExit.Text = "Exit";
			this.lnkExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkExit_LinkClicked);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.groupBox1.Controls.Add(this.cmbRegNo);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(41, 153);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(708, 77);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Student Registration";
			// 
			// cmbRegNo
			// 
			this.cmbRegNo.FormattingEnabled = true;
			this.cmbRegNo.Location = new System.Drawing.Point(208, 24);
			this.cmbRegNo.Name = "cmbRegNo";
			this.cmbRegNo.Size = new System.Drawing.Size(121, 27);
			this.cmbRegNo.TabIndex = 1;
			this.cmbRegNo.SelectedIndexChanged += new System.EventHandler(this.cmbRegNo_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(15, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Reg No";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.groupBox2.Controls.Add(this.rbFemale);
			this.groupBox2.Controls.Add(this.rbMale);
			this.groupBox2.Controls.Add(this.dtpDateOfBirth);
			this.groupBox2.Controls.Add(this.txtLastName);
			this.groupBox2.Controls.Add(this.txtFirstName);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(41, 236);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(708, 180);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Basic Inforation ";
			// 
			// rbFemale
			// 
			this.rbFemale.AutoSize = true;
			this.rbFemale.Location = new System.Drawing.Point(362, 137);
			this.rbFemale.Name = "rbFemale";
			this.rbFemale.Size = new System.Drawing.Size(80, 23);
			this.rbFemale.TabIndex = 9;
			this.rbFemale.TabStop = true;
			this.rbFemale.Text = "Female";
			this.rbFemale.UseVisualStyleBackColor = true;
			// 
			// rbMale
			// 
			this.rbMale.AutoSize = true;
			this.rbMale.Location = new System.Drawing.Point(208, 137);
			this.rbMale.Name = "rbMale";
			this.rbMale.Size = new System.Drawing.Size(65, 23);
			this.rbMale.TabIndex = 8;
			this.rbMale.TabStop = true;
			this.rbMale.Text = "Male";
			this.rbMale.UseVisualStyleBackColor = true;
			// 
			// dtpDateOfBirth
			// 
			this.dtpDateOfBirth.Location = new System.Drawing.Point(208, 94);
			this.dtpDateOfBirth.Name = "dtpDateOfBirth";
			this.dtpDateOfBirth.Size = new System.Drawing.Size(479, 27);
			this.dtpDateOfBirth.TabIndex = 7;
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(208, 60);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(479, 27);
			this.txtLastName.TabIndex = 6;
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(208, 22);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(479, 27);
			this.txtFirstName.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(15, 137);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 23);
			this.label6.TabIndex = 4;
			this.label6.Text = "Gender";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(15, 102);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(127, 23);
			this.label5.TabIndex = 3;
			this.label5.Text = "Date Of Birth";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(15, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(107, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Last Name ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(15, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "First Name ";
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.groupBox3.Controls.Add(this.txtHomePhone);
			this.groupBox3.Controls.Add(this.txtMobilePhone);
			this.groupBox3.Controls.Add(this.txtEmail);
			this.groupBox3.Controls.Add(this.txtAddress);
			this.groupBox3.Controls.Add(this.lable10);
			this.groupBox3.Controls.Add(this.lable9);
			this.groupBox3.Controls.Add(this.lable8);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(41, 422);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(708, 221);
			this.groupBox3.TabIndex = 10;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Contact Details ";
			// 
			// txtHomePhone
			// 
			this.txtHomePhone.Location = new System.Drawing.Point(208, 184);
			this.txtHomePhone.Name = "txtHomePhone";
			this.txtHomePhone.Size = new System.Drawing.Size(479, 27);
			this.txtHomePhone.TabIndex = 8;
			// 
			// txtMobilePhone
			// 
			this.txtMobilePhone.Location = new System.Drawing.Point(208, 137);
			this.txtMobilePhone.Name = "txtMobilePhone";
			this.txtMobilePhone.Size = new System.Drawing.Size(479, 27);
			this.txtMobilePhone.TabIndex = 7;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(208, 90);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(479, 27);
			this.txtEmail.TabIndex = 6;
			// 
			// txtAddress
			// 
			this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAddress.Location = new System.Drawing.Point(208, 22);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(479, 62);
			this.txtAddress.TabIndex = 5;
			// 
			// lable10
			// 
			this.lable10.AutoSize = true;
			this.lable10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lable10.Location = new System.Drawing.Point(17, 188);
			this.lable10.Name = "lable10";
			this.lable10.Size = new System.Drawing.Size(117, 23);
			this.lable10.TabIndex = 4;
			this.lable10.Text = "Home Phone";
			// 
			// lable9
			// 
			this.lable9.AutoSize = true;
			this.lable9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lable9.Location = new System.Drawing.Point(17, 141);
			this.lable9.Name = "lable9";
			this.lable9.Size = new System.Drawing.Size(125, 23);
			this.lable9.TabIndex = 3;
			this.lable9.Text = "Mobile Phone";
			// 
			// lable8
			// 
			this.lable8.AutoSize = true;
			this.lable8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lable8.Location = new System.Drawing.Point(17, 94);
			this.lable8.Name = "lable8";
			this.lable8.Size = new System.Drawing.Size(58, 23);
			this.lable8.TabIndex = 2;
			this.lable8.Text = "Email";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(15, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(78, 23);
			this.label7.TabIndex = 0;
			this.label7.Text = "Address";
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.groupBox4.Controls.Add(this.txtContactNo);
			this.groupBox4.Controls.Add(this.txtNIC);
			this.groupBox4.Controls.Add(this.txtParentName);
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(41, 649);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(708, 170);
			this.groupBox4.TabIndex = 11;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Parent Detail";
			// 
			// txtContactNo
			// 
			this.txtContactNo.Location = new System.Drawing.Point(208, 116);
			this.txtContactNo.Name = "txtContactNo";
			this.txtContactNo.Size = new System.Drawing.Size(479, 27);
			this.txtContactNo.TabIndex = 7;
			// 
			// txtNIC
			// 
			this.txtNIC.Location = new System.Drawing.Point(208, 68);
			this.txtNIC.Name = "txtNIC";
			this.txtNIC.Size = new System.Drawing.Size(479, 27);
			this.txtNIC.TabIndex = 6;
			// 
			// txtParentName
			// 
			this.txtParentName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtParentName.Location = new System.Drawing.Point(208, 22);
			this.txtParentName.Name = "txtParentName";
			this.txtParentName.Size = new System.Drawing.Size(479, 27);
			this.txtParentName.TabIndex = 5;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(15, 120);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(154, 23);
			this.label13.TabIndex = 3;
			this.label13.Text = "Contact Number ";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(15, 68);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(45, 23);
			this.label12.TabIndex = 2;
			this.label12.Text = "NIC";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(15, 26);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(121, 23);
			this.label11.TabIndex = 0;
			this.label11.Text = "Parent Name";
			// 
			// btnRegister
			// 
			this.btnRegister.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnRegister.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnRegister.Location = new System.Drawing.Point(41, 837);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(107, 36);
			this.btnRegister.TabIndex = 12;
			this.btnRegister.Text = "Register";
			this.btnRegister.UseVisualStyleBackColor = false;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnUpdate.Location = new System.Drawing.Point(249, 837);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(107, 36);
			this.btnUpdate.TabIndex = 13;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnDelete.Location = new System.Drawing.Point(451, 837);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(107, 36);
			this.btnDelete.TabIndex = 14;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnClear.Location = new System.Drawing.Point(642, 837);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(107, 36);
			this.btnClear.TabIndex = 15;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 906);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lnkExit);
			this.Controls.Add(this.lnkLogout);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form2";
			this.Text = "Registration form ";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel lnkLogout;
		private System.Windows.Forms.LinkLabel lnkExit;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbRegNo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton rbFemale;
		private System.Windows.Forms.RadioButton rbMale;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtHomePhone;
		private System.Windows.Forms.TextBox lable12;
		private System.Windows.Forms.TextBox lable11;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label lable10;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox txtContactNo;
		private System.Windows.Forms.TextBox txtNIC;
		private System.Windows.Forms.TextBox txtParentName;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Label lable9;
		private System.Windows.Forms.Label lable8;
		private System.Windows.Forms.TextBox txtMobilePhone;
		private System.Windows.Forms.TextBox txtEmail;
	}
}