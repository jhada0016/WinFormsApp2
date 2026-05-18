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
    public partial class UCDashboard : UserControl
    {
        private void StyleGrid(DataGridView dgv)
        {
            // READ ONLY
            dgv.ReadOnly = true;

            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = false;

            // FULL ROW
            dgv.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgv.MultiSelect = false;

            // HIDE ROW HEADER
            dgv.RowHeadersVisible = false;

            // AUTO FILL
            dgv.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgv.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;

            // CLEAN COLORS
            dgv.BackgroundColor = Color.White;

            dgv.BorderStyle = BorderStyle.None;

            dgv.CellBorderStyle =
                DataGridViewCellBorderStyle.None;

            dgv.GridColor = Color.White;

            // HEADER STYLE
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

            // ROW STYLE
            dgv.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgv.DefaultCellStyle.BackColor = Color.White;

            dgv.DefaultCellStyle.ForeColor = Color.Black;

            dgv.DefaultCellStyle.SelectionBackColor =
                Color.White;

            dgv.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgv.RowTemplate.Height = 38;

            // REMOVE BLUE SELECTION
            dgv.DefaultCellStyle.SelectionBackColor =
                dgv.DefaultCellStyle.BackColor;

            dgv.DefaultCellStyle.SelectionForeColor =
                dgv.DefaultCellStyle.ForeColor;

            // NO FOCUS BORDER
            dgv.CurrentCell = null;

            // ALTERNATE ROWS
            dgv.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 248, 248);
        }
        public UCDashboard()
        {
            InitializeComponent();
            LoadDashboard();
            LoadRecentSales();
            LoadLowStockProducts();
            StyleGrid(dgvRecentSales);
            StyleGrid(dgvLowStock);
            dgvRecentSales.ClearSelection();
            dgvLowStock.ClearSelection();



        }


        private void LoadDashboard()
        {
            MySqlConnection con = DataBase.GetConnection();

            try
            {
                con.Open();

                // TOTAL PRODUCTS
                string productsQuery =
                    "SELECT COUNT(*) FROM products";

                MySqlCommand productsCmd =
                    new MySqlCommand(productsQuery, con);

                lblProducts.Text =
                    productsCmd.ExecuteScalar().ToString();

                // LOW STOCK
                string lowStockQuery =
                    "SELECT COUNT(*) FROM products WHERE stock < 10";

                MySqlCommand lowStockCmd =
                    new MySqlCommand(lowStockQuery, con);

                lblLowStock.Text =
                    lowStockCmd.ExecuteScalar().ToString();

                // OUT OF STOCK
                string outStockQuery =
                    "SELECT COUNT(*) FROM products WHERE stock = 0";

                MySqlCommand outStockCmd =
                    new MySqlCommand(outStockQuery, con);

                lblOutStock.Text =
                    outStockCmd.ExecuteScalar().ToString();

                // SALES TODAY
                string salesTodayQuery =
                    "SELECT IFNULL(SUM(total),0) " +
                    "FROM sales " +
                    "WHERE DATE(sale_date)=CURDATE()";

                MySqlCommand salesTodayCmd =
                    new MySqlCommand(salesTodayQuery, con);

                lblSalesToday.Text =
                    "₱" + Convert.ToDecimal(
                        salesTodayCmd.ExecuteScalar()
                    ).ToString("N2");

                // SALES THIS MONTH
                string salesMonthQuery =
                    "SELECT IFNULL(SUM(total),0) " +
                    "FROM sales " +
                    "WHERE MONTH(sale_date)=MONTH(CURDATE()) " +
                    "AND YEAR(sale_date)=YEAR(CURDATE())";

                MySqlCommand salesMonthCmd =
                    new MySqlCommand(salesMonthQuery, con);

                lblSalesMonth.Text =
                    "₱" + Convert.ToDecimal(
                        salesMonthCmd.ExecuteScalar()
                    ).ToString("N2");

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadRecentSales()
        {
            MySqlConnection con = DataBase.GetConnection();

            try
            {
                con.Open();

                string query =
                    "SELECT id, total, sale_date " +
                    "FROM sales " +
                    "ORDER BY sale_date DESC " +
                    "LIMIT 10";

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, con);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvRecentSales.DataSource = table;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadLowStockProducts()
        {
            MySqlConnection con = DataBase.GetConnection();

            try
            {
                con.Open();

                string query =
                    "SELECT product_name, stock " +
                    "FROM products " +
                    "WHERE stock < 10 " +
                    "AND stock > 0";

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

        private void UCDashboard_Load(object sender, EventArgs e)
        {

        }

        private void dgvRecentSales_SelectionChanged(object sender, EventArgs e)
        {
            dgvRecentSales.ClearSelection();
        }

        private void dgvLowStock_SelectionChanged(object sender, EventArgs e)
        {
            dgvLowStock.ClearSelection();
        }
    }
    
}
