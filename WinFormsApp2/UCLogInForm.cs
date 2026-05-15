using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class UCLogInForm : UserControl
    {
        public UCLogInForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = DataBase.GetConnection();

            try
            {
                con.Open();

                string query = "SELECT * FROM users WHERE username=@username AND password=@password";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Login Success!");

                    Sari_Sari_Store_Sales_and_Inventory dashboard = new Sari_Sari_Store_Sales_and_Inventory();
                    dashboard.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form1 main = (Form1)this.FindForm();

            if (main != null)
            {
                main.LogInPanel.Controls.Clear();

                UCSignUpForm signup = new UCSignUpForm();


                signup.Dock = DockStyle.Fill;

                main.LogInPanel.Controls.Add(signup);

                signup.Show();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 main = (Form1)this.FindForm();

            if (main != null)
            {
                main.LogInPanel.Controls.Clear();

                UCForgotPass ForgotPass = new UCForgotPass();


                ForgotPass.Dock = DockStyle.Fill;

                main.LogInPanel.Controls.Add(ForgotPass);

                ForgotPass.Show();
            }
        }
    }
}
