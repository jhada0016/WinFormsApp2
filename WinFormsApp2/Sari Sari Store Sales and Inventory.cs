using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Sari_Sari_Store_Sales_and_Inventory : Form
    {
        public Sari_Sari_Store_Sales_and_Inventory()
        {
            InitializeComponent();
        }

        private void ResetButtonColors()
        {
            button1.BackColor = Color.FromArgb(0, 51, 153);
            btnProduct.BackColor = Color.FromArgb(0, 51, 153);
            btnSales.BackColor = Color.FromArgb(0, 51, 153);
            btnInventory.BackColor = Color.FromArgb(0, 51, 153);
            btnReport.BackColor = Color.FromArgb(0, 51, 153);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sari_Sari_Store_Sales_and_Inventory_Load(object sender, EventArgs e)
        {
            ResetButtonColors();
            button1.BackColor = Color.FromArgb(30, 144, 255);

            UCDashboard dashboard = new UCDashboard();
            dashboard.Dock = DockStyle.Fill;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(dashboard);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            button1.BackColor = Color.FromArgb(30, 144, 255);

            UCDashboard dashboard = new UCDashboard();
            dashboard.Dock = DockStyle.Fill;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(dashboard);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnProduct.BackColor = Color.FromArgb(30, 144, 255);

            UCProductl1 product = new UCProductl1();
            product.Dock = DockStyle.Fill;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(product);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnSales.BackColor = Color.FromArgb(30, 144, 255);

            UCSales sales = new UCSales();
            sales.Dock = DockStyle.Fill;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(sales);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnInventory.BackColor = Color.FromArgb(30, 144, 255);

            UCInventory inventory = new UCInventory();
            inventory.Dock = DockStyle.Fill;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(inventory);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnReport.BackColor = Color.FromArgb(30, 144, 255);

            UCReport report = new UCReport();
            report.Dock = DockStyle.Fill;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(report);
        }
    }
}
