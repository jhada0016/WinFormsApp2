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
    public partial class UCProductl1 : UserControl
    {
        int selectedID;

        private void StyleGrid(DataGridView dgv)
        {
            // READ ONLY
            dgv.ReadOnly = true;

            // DISABLE EXTRA FEATURES
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;

            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = false;

            // SELECT WHOLE ROW
            dgv.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgv.MultiSelect = false;

            // HIDE ROW HEADER
            dgv.RowHeadersVisible = false;

            // AUTO FILL COLUMNS
            dgv.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            // CLEAN BACKGROUND
            dgv.BackgroundColor = Color.White;

            dgv.BorderStyle = BorderStyle.None;

            // REMOVE GRID LINES
            dgv.CellBorderStyle =
                DataGridViewCellBorderStyle.None;

            dgv.GridColor = Color.White;

            // HEADER DESIGN
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

            // ROW DESIGN
            dgv.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgv.DefaultCellStyle.BackColor =
                Color.White;

            dgv.DefaultCellStyle.ForeColor =
                Color.Black;

            // MODERN SELECTION COLOR
            dgv.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(230, 230, 230);

            dgv.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            // ALTERNATE ROW COLOR
            dgv.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 248, 248);

            // ROW HEIGHT
            dgv.RowTemplate.Height = 38;
        }
        public UCProductl1()
        {
            InitializeComponent();

            StyleGrid(dgvProduct);

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

                dgvProduct.DataSource = table;
                dgvProduct.Columns[0].Visible = false;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products frm = new Products();
            frm.ShowDialog();

            LoadProducts();
        }

        private void UCProductl1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedID = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm Delete",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                MySqlConnection con = DataBase.GetConnection();

                try
                {
                    con.Open();

                    string query = "DELETE FROM products WHERE id=@id";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", selectedID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product Deleted Successfully!");

                    LoadProducts();

                    selectedID = 0;

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(
                    dgvProduct.SelectedRows[0].Cells[0].Value
                );

                string name = dgvProduct.SelectedRows[0].Cells[1].Value.ToString();



                decimal price = Convert.ToDecimal(
                    dgvProduct.SelectedRows[0].Cells[2].Value
                );

                int stock = Convert.ToInt32(
                    dgvProduct.SelectedRows[0].Cells[3].Value

                );
                string category = dgvProduct.SelectedRows[0].Cells[4].Value.ToString();

                EditProductForm editForm = new EditProductForm(
                    id,
                    name,
                    category,
                    price,
                    stock
                );

                editForm.ShowDialog();

                LoadProducts();
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
                    "%" + txtSearch.Text.Trim() + "%"
                );

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvProduct.DataSource = table;

                // HIDE ID COLUMN
                dgvProduct.Columns[0].Visible = false;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
