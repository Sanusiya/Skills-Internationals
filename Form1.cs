using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkillsInternational;

namespace Skills_international
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.Text = "Login - Skills International";
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnlogin_Click(object sender, EventArgs e)
		{    // Check if the entered username is "admin" and password is "@123"
			if (txtusername.Text == "Admin" && txtpassword.Text == "skills@123")

			{   // Display success message if credentials are correct
				MessageBox.Show("Login Successfull!");
				// Create a new instance of the Employee Details Form
				Form2 Emp = new Form2();
				// Open the Employee Details Form
				Emp.Show();
				// Hide the Login Form
				this.Hide();
			}
			else
			{   // Display error message if credentials are incorrect
				MessageBox.Show("Invalid User Name or Password");
			}
		}
		private void btnclear_Click(object sender, EventArgs e)
		{
			txtusername.Clear();
			txtpassword.Clear();
			txtusername.Focus();
			
		}

		private void btnexit_Click(object sender, EventArgs e)
		{
		DialogResult result = MessageBox.Show(
		"Are you sure, Do you really want to Exit...?",
		"Exit",
		MessageBoxButtons.YesNo,
		MessageBoxIcon.Question);

		if (result == DialogResult.Yes)
		{
			Application.Exit();
		}
		}
	}
}
