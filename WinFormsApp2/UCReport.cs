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
    public partial class UCReport : UserControl
    {
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

            dgv.DefaultCellStyle.BackColor = Color.White;

            dgv.DefaultCellStyle.ForeColor = Color.Black;

            dgv.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(230, 230, 230);

            dgv.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgv.AlternatingRowsDefaultCellStyle.BackColor =
                Color.White;

            dgv.RowHeadersVisible = false;

            dgv.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgv.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgv.AllowUserToAddRows = false;

            // REMOVE ALL LINES
            dgv.CellBorderStyle =
                DataGridViewCellBorderStyle.None;

            dgv.GridColor = Color.White;

            dgv.AdvancedCellBorderStyle.All =
                DataGridViewAdvancedCellBorderStyle.None;

            dgv.RowTemplate.Height = 38;
        }

        private void LoadSalesHistory()
        {
            MySqlConnection con = DataBase.GetConnection();

            try
            {
                con.Open();

                string query =
                    "SELECT id, total, sale_date " +
                    "FROM sales " +
                    "ORDER BY sale_date DESC";

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, con);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvSalesHistory.DataSource = table;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadBestSeller()
        {
            MySqlConnection con = DataBase.GetConnection();

            try
            {
                con.Open();

                string query =
                    "SELECT " +
                    "products.product_name, " +
                    "SUM(sales_items.quantity) AS total_sold " +
                    "FROM sales_items " +
                    "INNER JOIN products " +
                    "ON sales_items.product_id = products.id " +
                    "GROUP BY products.product_name " +
                    "ORDER BY total_sold DESC";

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, con);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvBestSeller.DataSource = table;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadLowStock()
        {
            MySqlConnection con = DataBase.GetConnection();

            try
            {
                con.Open();

                string query =
                    "SELECT product_name, stock " +
                    "FROM products " +
                    "WHERE stock < 10";

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, con);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvLowStock.DataSource = table;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadSalesSummary()
        {
            MySqlConnection con = DataBase.GetConnection();

            try
            {
                con.Open();

                string query =
                    "SELECT " +
                    "DATE(sale_date) AS sale_day, " +
                    "SUM(total) AS total_sales " +
                    "FROM sales " +
                    "GROUP BY DATE(sale_date) " +
                    "ORDER BY sale_day DESC";

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, con);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvSalesSummary.DataSource = table;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public UCReport()
        {
            InitializeComponent();
            LoadSalesHistory();

            LoadBestSeller();

            LoadLowStock();

            LoadSalesSummary();

            StyleGrid(dgvSalesHistory);

            StyleGrid(dgvBestSeller);

            StyleGrid(dgvLowStock);

            StyleGrid(dgvSalesSummary);
        }

        private void UCReport_Load(object sender, EventArgs e)
        {

        }

        private void txtSearchSales_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = DataBase.GetConnection();

            try
            {
                con.Open();

                string query =
                    "SELECT id, total, sale_date " +
                    "FROM sales " +

                    "WHERE id LIKE @search " +
                    "OR sale_date LIKE @search " +

                    "ORDER BY sale_date DESC";

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, con);

                adapter.SelectCommand.Parameters.AddWithValue(
                    "@search",
                    "%" + txtSearchSales.Text.Trim() + "%"
                );

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvSalesHistory.DataSource = table;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchBestSeller_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = DataBase.GetConnection();

            try
            {
                con.Open();

                string query =
                    "SELECT " +
                    "products.product_name, " +
                    "SUM(sales_items.quantity) AS total_sold " +

                    "FROM sales_items " +

                    "INNER JOIN products " +
                    "ON sales_items.product_id = products.id " +

                    "WHERE products.product_name LIKE @search " +

                    "GROUP BY products.product_name " +

                    "ORDER BY total_sold DESC";

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, con);

                adapter.SelectCommand.Parameters.AddWithValue(
                    "@search",
                    "%" + txtSearchBestSeller.Text.Trim() + "%"
                );

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvBestSeller.DataSource = table;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchLowStock_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = DataBase.GetConnection();

            try
            {
                con.Open();

                string query =
                    "SELECT product_name, category, stock " +

                    "FROM products " +

                    "WHERE stock < 10 " +

                    "AND (" +
                    "product_name LIKE @search " +
                    "OR category LIKE @search" +
                    ")";

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, con);

                adapter.SelectCommand.Parameters.AddWithValue(
                    "@search",
                    "%" + txtSearchLowStock.Text.Trim() + "%"
                );

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvLowStock.DataSource = table;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchSummary_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = DataBase.GetConnection();

            try
            {
                con.Open();

                string query =
                    "SELECT " +
                    "DATE(sale_date) AS sale_day, " +
                    "SUM(total) AS total_sales " +

                    "FROM sales " +

                    "WHERE sale_date LIKE @search " +

                    "GROUP BY DATE(sale_date) " +

                    "ORDER BY sale_day DESC";

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, con);

                adapter.SelectCommand.Parameters.AddWithValue(
                    "@search",
                    "%" + txtSearchSummary.Text.Trim() + "%"
                );

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvSalesSummary.DataSource = table;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
