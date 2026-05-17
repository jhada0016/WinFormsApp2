using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp2
{
    public partial class EditProductForm : Form
    {
        int productID;
        public EditProductForm(int id, string name, string category, decimal price, int stock)
        {
            InitializeComponent();

            productID = id;

            txtProductName.Text = name;

            cbCategory.Text = category;

            txtPrice.Text = price.ToString();

            txtStock.Text = stock.ToString();
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int stock;
            decimal price;

            if (!int.TryParse(txtStock.Text.Trim(), out stock))
            {
                MessageBox.Show("Invalid stock input.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out price))
            {
                MessageBox.Show("Invalid price input.");
                return;
            }

            MySqlConnection con = DataBase.GetConnection();

            try
            {
                con.Open();

                string query = "UPDATE products SET " +
                               "product_name=@product_name, " +
                               "category=@category, " +
                               "price=@price, " +
                               "stock=@stock " +
                               "WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@product_name", txtProductName.Text);

                cmd.Parameters.AddWithValue("@category", cbCategory.Text);

                cmd.Parameters.AddWithValue("@price", price);

                cmd.Parameters.AddWithValue("@stock", stock);

                cmd.Parameters.AddWithValue("@id", productID);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Product Updated Successfully!");

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
