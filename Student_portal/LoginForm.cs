using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_portal
{
    public partial class LoginForm : Form
    {
        int tries = 0;
        string sid = string.Empty;
        string verificationCode = string.Empty;
        public LoginForm()
        {
            InitializeComponent();
            infolab.Visible = false;
            forgotpassowrd.Visible = false;
        }

        private void loginbtn_MouseClick(object sender, MouseEventArgs e)
        {
            string connection = "Server=DEDEEDEDE\\SQLEXPRESS;Database=studentportaldb;Integrated Security=True;Pooling=True;TrustServerCertificate=True;Encrypt=False;Connection Timeout=30;";
            string function = "SELECT dbo.ufn_getlogin(@studentid, @password)";

            if (!string.IsNullOrEmpty(studentidtxt.Text) && !string.IsNullOrEmpty(passwrodtxt.Text))
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(function, conn))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@studentid", studentidtxt.Text);
                            cmd.Parameters.AddWithValue("@password", passwrodtxt.Text);

                            object resultObj = cmd.ExecuteScalar();
                            int result = 0;
                            if (resultObj != null && resultObj != DBNull.Value)
                            {
                                result = Convert.ToInt32(resultObj);
                            }

                            if (result == 1)
                            {

                                string currentStudentId = studentidtxt.Text;
                                studentidtxt.Clear();
                                passwrodtxt.Clear();
                                passwrodtxt.PasswordChar = '*';
                                eyeofrah.Image = Properties.Resources.icons8_closed_eye_50;

                                Homeform homeform = new Homeform(currentStudentId);
                                this.Hide();
                                homeform.Show();
                                homeform.FormClosed += (s, args) => this.Show();
                            }
                            else
                            {
                                MessageBox.Show("Login not found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tries = tries + 1;
                                if (tries >= 3)
                                {
                                    forgotpassowrd.Visible = true;
                                }

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                infolab.Visible = true;
            }
        }



        private void forgotpassowrd_MouseClick(object sender, MouseEventArgs e)
        {
            showPanel(ForgotPassPanel);
            tries = 0;
        }
        private void Backtologin_MouseClick(object sender, MouseEventArgs e)
        {
            showPanel(LoginPanel);

            forgotpassowrd.Visible = false;
            studentidtxt.Text = "";
            passwrodtxt.Text = "";
        }
        public void showPanel(Panel paneltoshow)
        {
            LoginPanel.Visible = paneltoshow == LoginPanel;
            ForgotPassPanel.Visible = paneltoshow == ForgotPassPanel;
            Verificationpanel.Visible = paneltoshow == Verificationpanel;
            PassResetPanel.Visible = paneltoshow == PassResetPanel;

            paneltoshow.BringToFront();
        }

        private void eyeofrah_Click(object sender, MouseEventArgs e)
        {
            if (passwrodtxt.PasswordChar == '\0')
            {
                passwrodtxt.PasswordChar = '*';
                eyeofrah.Image = Properties.Resources.icons8_closed_eye_50;
            }
            else
            {
                passwrodtxt.PasswordChar = '\0';
                eyeofrah.Image = Properties.Resources.icons8_show_password_50;
            }
        }

        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {
            forgotpassowrd.Visible = false;
            studentidtxt.Text = "";
            passwrodtxt.Text = "";
            showPanel(LoginPanel);
        }

        private void Sendoptbtn_MouseClick(object sender, MouseEventArgs e)
        {
            string studentID = studentidopttxt.Text;
            if (string.IsNullOrEmpty(studentID))
            {
                MessageBox.Show("Please fill the form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Server=DEDEEDEDE\\SQLEXPRESS;Database=studentportaldb;Integrated Security=True;Pooling=True;TrustServerCertificate=True;Encrypt=False;Connection Timeout=30;";


            using (SqlConnection connection_ = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("getid", connection_)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@StudentID", studentID);

                try
                {
                    connection_.Open();
                    sid = command.ExecuteScalar()?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            if (!string.IsNullOrEmpty(sid))
            {


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("getcode", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        command.Parameters.AddWithValue("@StudentID", studentID);

                        verificationCode = command.ExecuteScalar()?.ToString();

                        if (!string.IsNullOrEmpty(verificationCode))
                        {
                            MessageBox.Show("Confirmation Code has been sent to Email!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            showPanel(Verificationpanel);
                        }
                        else
                        {
                            MessageBox.Show("Failed to generate verification code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Student ID not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void backToLoginLink_MouseClick(object sender, MouseEventArgs e)
        {
            forgotpassowrd.Visible = false;
            studentidtxt.Text = "";
            passwrodtxt.Text = "";
            showPanel(LoginPanel);
        }

        private void verifyButton_MouseClick(object sender, MouseEventArgs e)
        {
            string enteredCode = fn + sn + tn + fo + fi;
          

            if (string.Equals(enteredCode, verificationCode, StringComparison.OrdinalIgnoreCase))
            {

     
                showPanel(PassResetPanel);

            }
            else
            {
      
                MessageBox.Show("Invalid confirmation code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetPasswordButton_MouseClick(object sender, MouseEventArgs e)
        {
            string studentId = studentidopttxt.Text;

            string newPassword = newPasswordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in both fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Server=DEDEEDEDE\\SQLEXPRESS;Database=studentportaldb;Integrated Security=True;Pooling=True;TrustServerCertificate=True;Encrypt=False;Connection Timeout=30;";
            string proc = "updatePassword";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(proc, connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    command.Parameters.AddWithValue("@StudentID", studentId);
                    command.Parameters.AddWithValue("@NewPassword", newPassword);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showPanel(LoginPanel);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void linkLabel2_MouseClick(object sender, MouseEventArgs e)
        {
            forgotpassowrd.Visible = false;
            studentidtxt.Text = "";
            passwrodtxt.Text = "";
            showPanel(LoginPanel);
        }

        private void studentidtxt_MouseClick(object sender, MouseEventArgs e)
        {
            infolab.Visible = false;
        }

        private void passwrodtxt_MouseClick(object sender, MouseEventArgs e)
        {
            infolab.Visible = false;
        }

        private void firsttxtbox_MouseClick(object sender, MouseEventArgs e)
        {

        }
        string fn;
        private void firsttxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            firsttxtbox.Text = e.KeyChar.ToString();
            e.Handled = true;
            secondtxtbox.Focus();
            fn = firsttxtbox.Text;
        }
        string sn;
        private void secondtxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            secondtxtbox.Text = e.KeyChar.ToString();
            e.Handled = true;
            thirdtxtbox.Focus();
            sn = secondtxtbox.Text;
        }
        string tn;
        private void thirdtxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            thirdtxtbox.Text = e.KeyChar.ToString();
            e.Handled = true;
            fourthtxtbox.Focus();
            tn = thirdtxtbox.Text;
        }
        string fo;
        private void fourthtxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            fourthtxtbox.Text = e.KeyChar.ToString();
            e.Handled = true;
            fifthtxtbox.Focus();
            fo = fourthtxtbox.Text;
        }
        string fi;
        private void fifthtxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            fifthtxtbox.Text = e.KeyChar.ToString();
            e.Handled = true;
            fi = fifthtxtbox.Text;
        }
    }

}
