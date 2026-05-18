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
    public partial class UCSales : UserControl
    {
        private void StyleGrid(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font =  new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor =  Color.FromArgb(245, 245, 245);
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.LightGray;
            dgv.RowTemplate.Height = 35;
        }

        public UCSales()
        {
            InitializeComponent();
            dgvCart.Columns.Clear();
            dgvCart.Columns.Add("product_id", "Product ID");
            dgvCart.Columns.Add("product_name", "Product");
            dgvCart.Columns.Add("price", "Price");

            // TEXTBOX COLUMN
            DataGridViewTextBoxColumn qtyColumn =
                new DataGridViewTextBoxColumn();

            qtyColumn.Name = "qty";
            qtyColumn.HeaderText = "Quantity";

            dgvCart.Columns.Add(qtyColumn);
            dgvCart.Columns.Add("subtotal", "Subtotal");
            dgvCart.Columns[0].Visible = false;

            StyleGrid(dataGridView1);
            StyleGrid(dgvCart);
            dataGridView1.ReadOnly = true;
            dgvCart.ReadOnly = false;
            dgvCart.Columns["product_name"].ReadOnly = true;
            dgvCart.Columns["price"].ReadOnly = true;
            dgvCart.Columns["subtotal"].ReadOnly = true;

            LoadProducts();
        }

        public void LoadProducts()
        {
            MySqlConnection con = DataBase.GetConnection();

            try
            {
                con.Open();

                string query = "SELECT * FROM products";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dataGridView1.DataSource = table;

                dataGridView1.Columns[0].Visible = false;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComputeTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                total += Convert.ToDecimal(row.Cells["subtotal"].Value);
            }

            lblTotal.Text = "Total: ₱" + total.ToString("N2");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UCSales_Load(object sender, EventArgs e)
        {

        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int productID = Convert.ToInt32(
                    dataGridView1.SelectedRows[0].Cells[0].Value
                );

                string productName =
                    dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                decimal price = Convert.ToDecimal(
                    dataGridView1.SelectedRows[0].Cells[2].Value
                );

                int qty = 1;

                decimal subtotal = price * qty;

                dgvCart.Rows.Add(
                    productID,
                    productName,
                    price,
                    qty,
                    subtotal
                );

                ComputeTotal();
            }
        }

        private void dgvCart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCart.Columns[e.ColumnIndex].Name == "qty")
            {
                decimal price = Convert.ToDecimal(
                    dgvCart.Rows[e.RowIndex].Cells["price"].Value
                );

                int qty = Convert.ToInt32(
                    dgvCart.Rows[e.RowIndex].Cells["qty"].Value
                );

                decimal subtotal = price * qty;

                dgvCart.Rows[e.RowIndex]
                    .Cells["subtotal"].Value = subtotal;

                ComputeTotal();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = DataBase.GetConnection();

            try
            {
                con.Open();

                string query = "SELECT * FROM products " +
                               "WHERE product_name LIKE @search " +
                               "OR category LIKE @search";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

                adapter.SelectCommand.Parameters.AddWithValue(
                    "@search",
                    "%" + txtSearch.Text + "%"
                );

                DataTable table = new DataTable();

                adapter.Fill(table);

                dataGridView1.DataSource = table;

                dataGridView1.Columns[0].Visible = false;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                dgvCart.Rows.RemoveAt(
                    dgvCart.SelectedRows[0].Index
                );

                ComputeTotal();
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            MySqlConnection con = DataBase.GetConnection();

            try
            {
                con.Open();

                decimal total = 0;

                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["subtotal"].Value);
                }

                // SAVE SALE
                string saleQuery =
                    "INSERT INTO sales(total) VALUES(@total)";

                MySqlCommand saleCmd =
                    new MySqlCommand(saleQuery, con);

                saleCmd.Parameters.AddWithValue("@total", total);

                saleCmd.ExecuteNonQuery();

                int saleID = Convert.ToInt32(saleCmd.LastInsertedId);

                // SAVE SALE ITEMS
                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    int productID =
                        Convert.ToInt32(row.Cells["product_id"].Value);

                    int qty =
                        Convert.ToInt32(row.Cells["qty"].Value);

                    decimal subtotal =
                        Convert.ToDecimal(row.Cells["subtotal"].Value);

                    string itemQuery =
                        "INSERT INTO sales_items" +
                        "(sale_id, product_id, quantity, subtotal) " +
                        "VALUES(@sale_id, @product_id, @quantity, @subtotal)";

                    MySqlCommand itemCmd =
                        new MySqlCommand(itemQuery, con);

                    itemCmd.Parameters.AddWithValue("@sale_id", saleID);

                    itemCmd.Parameters.AddWithValue("@product_id", productID);

                    itemCmd.Parameters.AddWithValue("@quantity", qty);

                    itemCmd.Parameters.AddWithValue("@subtotal", subtotal);

                    itemCmd.ExecuteNonQuery();

                    // DEDUCT STOCK
                    string stockQuery =
                        "UPDATE products " +
                        "SET stock = stock - @qty " +
                        "WHERE id=@id";

                    MySqlCommand stockCmd =
                        new MySqlCommand(stockQuery, con);

                    stockCmd.Parameters.AddWithValue("@qty", qty);

                    stockCmd.Parameters.AddWithValue("@id", productID);

                    stockCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Checkout Successful!");

                dgvCart.Rows.Clear();

                ComputeTotal();

                LoadProducts();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
