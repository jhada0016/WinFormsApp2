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
    public partial class UCForgotPass : UserControl
    {
        public UCForgotPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = DataBase.GetConnection();

            try
            {
                con.Open();

                string query = "SELECT * FROM users WHERE username=@username AND storename=@storename AND birthdate=@birthdate";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                cmd.Parameters.AddWithValue("@storename", txtStoreName.Text);
                cmd.Parameters.AddWithValue("@birthdate", dtpBirthDate.Value.Date);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Account Verified!");

                    // SAVE VERIFIED USERNAME
                    Form1.verifiedUsername = txtUserName.Text;

                    UCChangePass change = new UCChangePass();
                    change.Dock = DockStyle.Fill;

                    Form1 main = (Form1)this.FindForm();

                    main.LogInPanel.Controls.Clear();
                    main.LogInPanel.Controls.Add(change);
                }
                else
                {
                    MessageBox.Show("Account Not Found");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
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
