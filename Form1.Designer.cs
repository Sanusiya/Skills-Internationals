namespace Skills_international
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtusername = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtpassword = new System.Windows.Forms.TextBox();
			this.btnlogin = new System.Windows.Forms.Button();
			this.btnclear = new System.Windows.Forms.Button();
			this.btnexit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(362, 32);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(87, 65);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkBlue;
			this.label1.Location = new System.Drawing.Point(285, 100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(245, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Skills International";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnclear);
			this.groupBox1.Controls.Add(this.btnlogin);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtpassword);
			this.groupBox1.Controls.Add(this.txtusername);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(92, 159);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(682, 292);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Login";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(24, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "User Name ";
			// 
			// txtusername
			// 
			this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtusername.Location = new System.Drawing.Point(28, 55);
			this.txtusername.Name = "txtusername";
			this.txtusername.Size = new System.Drawing.Size(410, 30);
			this.txtusername.TabIndex = 4;
			this.txtusername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(24, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Password ";
			// 
			// txtpassword
			// 
			this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtpassword.Location = new System.Drawing.Point(28, 148);
			this.txtpassword.Name = "txtpassword";
			this.txtpassword.Size = new System.Drawing.Size(410, 30);
			this.txtpassword.TabIndex = 4;
			// 
			// btnlogin
			// 
			this.btnlogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnlogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnlogin.Location = new System.Drawing.Point(28, 213);
			this.btnlogin.Name = "btnlogin";
			this.btnlogin.Size = new System.Drawing.Size(91, 37);
			this.btnlogin.TabIndex = 6;
			this.btnlogin.Text = "Login";
			this.btnlogin.UseVisualStyleBackColor = false;
			this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
			// 
			// btnclear
			// 
			this.btnclear.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnclear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnclear.Location = new System.Drawing.Point(508, 213);
			this.btnclear.Name = "btnclear";
			this.btnclear.Size = new System.Drawing.Size(75, 37);
			this.btnclear.TabIndex = 7;
			this.btnclear.Text = "Clear";
			this.btnclear.UseVisualStyleBackColor = false;
			this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
			// 
			// btnexit
			// 
			this.btnexit.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnexit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnexit.Location = new System.Drawing.Point(120, 510);
			this.btnexit.Name = "btnexit";
			this.btnexit.Size = new System.Drawing.Size(75, 41);
			this.btnexit.TabIndex = 3;
			this.btnexit.Text = "Exit";
			this.btnexit.UseVisualStyleBackColor = false;
			this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(886, 596);
			this.Controls.Add(this.btnexit);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Log in - Skills International";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtpassword;
		private System.Windows.Forms.TextBox txtusername;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnclear;
		private System.Windows.Forms.Button btnlogin;
		private System.Windows.Forms.Button btnexit;
	}
}

