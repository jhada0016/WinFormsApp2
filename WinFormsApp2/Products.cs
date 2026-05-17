using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySqlConnector;


namespace WinFormsApp2
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        

        private void Products_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

            int stock;
            decimal price;

            // VALIDATE STOCK
            if (!int.TryParse(txtStock.Text, out stock))
            {
                MessageBox.Show("Please enter valid stock number.");
                return;
            }

            // VALIDATE PRICE
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please enter valid price.");
                return;
            }

            MySqlConnection con = DataBase.GetConnection();

            try
            {
                con.Open();

                string query = "INSERT INTO products(product_name, category, price, stock) " +
                               "VALUES(@product_name, @category, @price, @stock)";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@product_name", txtName.Text);
                cmd.Parameters.AddWithValue("@category", cbCategory.Text);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Product Added Successfully!");

                con.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
