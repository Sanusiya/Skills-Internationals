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
	public partial class Form2 : Form
	{
		public Form2()

		{
			InitializeComponent();
			this.Text = "Student Registration";
			LoadRegNumbers();
		}

		private void LoadRegNumbers()
		{
			cmbRegNo.Items.Clear();
			try
			{
				SqlConnection con = DBConnection.GetConnection();
				con.Open();
				SqlCommand cmd = new SqlCommand("SELECT regNo FROM Registration ORDER BY regNo", con);
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					cmbRegNo.Items.Add(reader["regNo"].ToString());
				}
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading Reg Numbers: " + ex.Message);
			}
		}

		private void cmbRegNo_SelectedIndexChanged(object sender, EventArgs e)
		{
			{
				if (cmbRegNo.SelectedItem == null) return;
				string regNo = cmbRegNo.SelectedItem.ToString();
				try
				{
					SqlConnection con = DBConnection.GetConnection();
					con.Open();
					string query = "SELECT * FROM Registration WHERE regNo = @regNo";
					SqlCommand cmd = new SqlCommand(query, con);
					cmd.Parameters.AddWithValue("@regNo", regNo);
					SqlDataReader reader = cmd.ExecuteReader();
					if (reader.Read())
					{
						txtFirstName.Text = reader["firstName"].ToString();
						txtLastName.Text = reader["lastName"].ToString();
						dtpDateOfBirth.Value = Convert.ToDateTime(reader["dateOfBirth"]);
						string gender = reader["gender"].ToString();
						rbMale.Checked = (gender == "Male");
						rbFemale.Checked = (gender == "Female");
						txtAddress.Text = reader["address"].ToString();
						txtEmail.Text = reader["email"].ToString();
						txtMobilePhone.Text = reader["mobilePhone"].ToString();
						txtHomePhone.Text = reader["homePhone"].ToString();
						txtParentName.Text = reader["parentName"].ToString();
						txtNIC.Text = reader["nic"].ToString();
						txtContactNo.Text = reader["contactNo"].ToString();
					}
					con.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message);
				}
			}
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			{
				if (!ValidateFields()) return;
				try
				{
					SqlConnection con = DBConnection.GetConnection();
					con.Open();
					string query = @"INSERT INTO Registration 
                    (regNo, firstName, lastName, dateOfBirth, gender, address, email,
                     mobilePhone, homePhone, parentName, nic, contactNo)
                    VALUES 
                    (@regNo, @firstName, @lastName, @dob, @gender, @address, @email,
                     @mobile, @home, @parentName, @nic, @contactNo)";
					SqlCommand cmd = new SqlCommand(query, con);
					cmd.Parameters.AddWithValue("@regNo", int.Parse(cmbRegNo.Text));
					cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text.Trim());
					cmd.Parameters.AddWithValue("@lastName", txtLastName.Text.Trim());
					cmd.Parameters.AddWithValue("@dob", dtpDateOfBirth.Value);
					cmd.Parameters.AddWithValue("@gender", rbMale.Checked ? "Male" : "Female");
					cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
					cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
					cmd.Parameters.AddWithValue("@mobile", long.Parse(txtMobilePhone.Text.Trim()));
					cmd.Parameters.AddWithValue("@home", long.Parse(txtHomePhone.Text.Trim()));
					cmd.Parameters.AddWithValue("@parentName", txtParentName.Text.Trim());
					cmd.Parameters.AddWithValue("@nic", txtNIC.Text.Trim());
					cmd.Parameters.AddWithValue("@contactNo", long.Parse(txtContactNo.Text.Trim()));
					cmd.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Record Added Succesfully", "Register Student",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadRegNumbers();
					ClearFields();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			{
				if (cmbRegNo.SelectedItem == null)
				{
					MessageBox.Show("Please select a Reg No to update.", "Warning",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				if (!ValidateFields()) return;
				try
				{
					SqlConnection con = DBConnection.GetConnection();
					con.Open();
					string query = @"UPDATE Registration SET
                    firstName=@firstName, lastName=@lastName, dateOfBirth=@dob,
                    gender=@gender, address=@address, email=@email,
                    mobilePhone=@mobile, homePhone=@home, parentName=@parentName,
                    nic=@nic, contactNo=@contactNo
                    WHERE regNo=@regNo";
					SqlCommand cmd = new SqlCommand(query, con);
					cmd.Parameters.AddWithValue("@regNo", int.Parse(cmbRegNo.Text));
					cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text.Trim());
					cmd.Parameters.AddWithValue("@lastName", txtLastName.Text.Trim());
					cmd.Parameters.AddWithValue("@dob", dtpDateOfBirth.Value);
					cmd.Parameters.AddWithValue("@gender", rbMale.Checked ? "Male" : "Female");
					cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
					cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
					cmd.Parameters.AddWithValue("@mobile", long.Parse(txtMobilePhone.Text.Trim()));
					cmd.Parameters.AddWithValue("@home", long.Parse(txtHomePhone.Text.Trim()));
					cmd.Parameters.AddWithValue("@parentName", txtParentName.Text.Trim());
					cmd.Parameters.AddWithValue("@nic", txtNIC.Text.Trim());
					cmd.Parameters.AddWithValue("@contactNo", long.Parse(txtContactNo.Text.Trim()));
					cmd.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Record Updated Succesfully", "Update Student",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadRegNumbers();
					ClearFields();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			{
				if (cmbRegNo.SelectedItem == null)
				{
					MessageBox.Show("Please select a Reg No to delete.", "Warning",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				DialogResult confirm = MessageBox.Show(
					"Are you sure, Do you really want to Delete this Record...?",
					"Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (confirm == DialogResult.Yes)
				{
					try
					{
						SqlConnection con = DBConnection.GetConnection();
						con.Open();
						string query = "DELETE FROM Registration WHERE regNo = @regNo";
						SqlCommand cmd = new SqlCommand(query, con);
						cmd.Parameters.AddWithValue("@regNo", int.Parse(cmbRegNo.Text));
						cmd.ExecuteNonQuery();
						con.Close();
						MessageBox.Show("Record Deleted Succesfully", "Delete Student",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
						LoadRegNumbers();
						ClearFields();
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: " + ex.Message, "Error",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			{
				ClearFields();
			}
		}

		private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			{
				this.Hide();
				Form1 loginForm = new Form1();
				loginForm.Show();
			}
		}

		private void lnkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			        {
            DialogResult result = MessageBox.Show(
                "Are you sure, Do you really want to Exit...?",
                "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
		}
		private void ClearFields()
		{
			cmbRegNo.SelectedIndex = -1;
			cmbRegNo.Text = "";
			txtFirstName.Clear();
			txtLastName.Clear();
			dtpDateOfBirth.Value = DateTime.Now;
			rbMale.Checked = false;
			rbFemale.Checked = false;
			txtAddress.Clear();
			txtEmail.Clear();
			txtMobilePhone.Clear();
			txtHomePhone.Clear();
			txtParentName.Clear();
			txtNIC.Clear();
			txtContactNo.Clear();
			cmbRegNo.Focus();
		}

		private bool ValidateFields()
		{
			if (string.IsNullOrEmpty(cmbRegNo.Text))
			{
				MessageBox.Show("Please enter a Registration Number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text))
			{
				MessageBox.Show("Please enter First Name and Last Name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (!rbMale.Checked && !rbFemale.Checked)
			{
				MessageBox.Show("Please select a Gender.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}
	}
}
