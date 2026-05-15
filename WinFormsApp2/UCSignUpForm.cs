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
    public partial class UCSignUpForm : UserControl
    {
        public UCSignUpForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = DataBase.GetConnection();

            try
            {
                con.Open();

                string query = "INSERT INTO users(fullname, username, storename, birthdate, password) " +
                               "VALUES(@fullname, @username, @storename, @birthdate, @password)";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@fullname", txtFullName.Text);
                cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                cmd.Parameters.AddWithValue("@storename", txtStoreName.Text);
                cmd.Parameters.AddWithValue("@birthdate", dtpBirthDate.Value);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Account Created Successfully!");

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form1 main = (Form1)this.FindForm();

            if (main != null)
            {
                main.LogInPanel.Controls.Clear();

                UCLogInForm signin = new UCLogInForm();


                signin.Dock = DockStyle.Fill;

                main.LogInPanel.Controls.Add(signin);

                signin.Show();
            }
        }
    }
}
