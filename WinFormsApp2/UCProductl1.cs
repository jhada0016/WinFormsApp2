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
        public UCProductl1()
        {
            InitializeComponent();
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
    }
}
