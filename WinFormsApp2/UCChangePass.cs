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
    public partial class UCChangePass : UserControl
    {
        public UCChangePass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password does not match");
                return;
            }

            MySqlConnection con = DataBase.GetConnection();

            try
            {
                con.Open();

                string query = "UPDATE users SET password=@password WHERE username=@username";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@password", txtNewPassword.Text);

                // GET VERIFIED USERNAME
                cmd.Parameters.AddWithValue("@username", Form1.verifiedUsername);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Password Changed Successfully!");

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
