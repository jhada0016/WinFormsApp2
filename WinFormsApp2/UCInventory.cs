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
    public partial class UCInventory : UserControl
    {
        private void ColorStatus()
        {
            foreach (DataGridViewRow row in dgvInventory.Rows)
            {
                string status =
                    row.Cells["status"].Value.ToString();

                if (status == "In Stock")
                {
                    row.Cells["status"].Style.ForeColor =
                        Color.Green;
                }
                else if (status == "Low Stock")
                {
                    row.Cells["status"].Style.ForeColor =
                        Color.Orange;
                }
                else if (status == "Out of Stock")
                {
                    row.Cells["status"].Style.ForeColor =
                        Color.Red;
                }

                row.Cells["status"].Style.Font =
                    new Font("Segoe UI", 9, FontStyle.Bold);
            }
        }

        private void StyleGrid(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;

            dgv.BackgroundColor = Color.White;

            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dgv.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(35, 35, 35);

            dgv.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgv.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgv.ColumnHeadersHeight = 40;

            dgv.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgv.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(230, 230, 230);

            dgv.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgv.RowHeadersVisible = false;

            dgv.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgv.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgv.AllowUserToAddRows = false;

            dgv.CellBorderStyle =
                DataGridViewCellBorderStyle.None;

            dgv.GridColor = Color.White;

            dgv.RowTemplate.Height = 38;
        }

        public UCInventory()
        {
            InitializeComponent();

            StyleGrid(dgvInventory);

            LoadInventory();

            LoadInventorySummary();
        }

        private void LoadInventory()
        {
            MySqlConnection con = DataBase.GetConnection();

            try
            {
                con.Open();

                string query =
                    "SELECT " +
                    "product_name, " +
                    "category, " +
                    "stock, " +

                    "CASE " +
                    "WHEN stock = 0 THEN 'Out of Stock' " +
                    "WHEN stock < 10 THEN 'Low Stock' " +
                    "ELSE 'In Stock' " +
                    "END AS status, " +

                    "last_updated " +

                    "FROM products";

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, con);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvInventory.DataSource = table;

                con.Close();

                ColorStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadInventorySummary()
        {
            MySqlConnection con = DataBase.GetConnection();

            try
            {
                con.Open();

                // TOTAL PRODUCTS
                string totalQuery =
                    "SELECT COUNT(*) FROM products";

                MySqlCommand totalCmd =
                    new MySqlCommand(totalQuery, con);

                lblTotalProducts.Text =
                    totalCmd.ExecuteScalar().ToString();

                // IN STOCK
                string inStockQuery =
                    "SELECT COUNT(*) FROM products " +
                    "WHERE stock >= 10";

                MySqlCommand inStockCmd =
                    new MySqlCommand(inStockQuery, con);

                lblInStock.Text =
                    inStockCmd.ExecuteScalar().ToString();

                // LOW STOCK
                string lowQuery =
                    "SELECT COUNT(*) FROM products " +
                    "WHERE stock < 10 AND stock > 0";

                MySqlCommand lowCmd =
                    new MySqlCommand(lowQuery, con);

                lblLowStock.Text =
                    lowCmd.ExecuteScalar().ToString();

                // OUT OF STOCK
                string outQuery =
                    "SELECT COUNT(*) FROM products " +
                    "WHERE stock = 0";

                MySqlCommand outCmd =
                    new MySqlCommand(outQuery, con);

                lblOutStock.Text =
                    outCmd.ExecuteScalar().ToString();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UCInventory_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = DataBase.GetConnection();

            try
            {
                con.Open();

                string query =
                    "SELECT " +
                    "product_name, " +
                    "category, " +
                    "stock, " +

                    "CASE " +
                    "WHEN stock = 0 THEN 'Out of Stock' " +
                    "WHEN stock < 10 THEN 'Low Stock' " +
                    "ELSE 'In Stock' " +
                    "END AS status, " +

                    "last_updated " +

                    "FROM products " +
                    "WHERE product_name LIKE @search " +
                    "OR category LIKE @search";

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, con);

                adapter.SelectCommand.Parameters.AddWithValue(
                    "@search",
                    "%" + txtSearch.Text.Trim() + "%"
                );

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvInventory.DataSource = table;

                con.Close();

                ColorStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
