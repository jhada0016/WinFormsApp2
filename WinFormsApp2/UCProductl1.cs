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
        public UCProductl1()
        {
            InitializeComponent();

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            // IMPORTANT
            dataGridView1.ReadOnly = true;

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
                selectedID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(
                    dataGridView1.SelectedRows[0].Cells[0].Value
                );

                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();



                decimal price = Convert.ToDecimal(
                    dataGridView1.SelectedRows[0].Cells[2].Value
                );

                int stock = Convert.ToInt32(
                    dataGridView1.SelectedRows[0].Cells[3].Value

                );
                string category = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

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

                dataGridView1.DataSource = table;

                // HIDE ID COLUMN
                dataGridView1.Columns[0].Visible = false;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
