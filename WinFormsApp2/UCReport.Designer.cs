namespace WinFormsApp2
{
    partial class UCReport
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label18 = new Label();
            BestSeller = new TabControl();
            tabSalesHistory = new TabPage();
            label4 = new Label();
            txtSearchSales = new TextBox();
            dgvSalesHistory = new DataGridView();
            tabBestSeller = new TabPage();
            txtSearchBestSeller = new TextBox();
            label3 = new Label();
            dgvBestSeller = new DataGridView();
            tabLowstock = new TabPage();
            txtSearchLowStock = new TextBox();
            dgvLowStock = new DataGridView();
            label2 = new Label();
            tabSalesSummary = new TabPage();
            label1 = new Label();
            txtSearchSummary = new TextBox();
            dgvSalesSummary = new DataGridView();
            BestSeller.SuspendLayout();
            tabSalesHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalesHistory).BeginInit();
            tabBestSeller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBestSeller).BeginInit();
            tabLowstock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).BeginInit();
            tabSalesSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalesSummary).BeginInit();
            SuspendLayout();
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Navy;
            label18.Location = new Point(17, 24);
            label18.Name = "label18";
            label18.Size = new Size(178, 37);
            label18.TabIndex = 18;
            label18.Text = "Sales Report";
            // 
            // BestSeller
            // 
            BestSeller.Controls.Add(tabSalesHistory);
            BestSeller.Controls.Add(tabBestSeller);
            BestSeller.Controls.Add(tabLowstock);
            BestSeller.Controls.Add(tabSalesSummary);
            BestSeller.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BestSeller.Location = new Point(17, 123);
            BestSeller.Name = "BestSeller";
            BestSeller.SelectedIndex = 0;
            BestSeller.Size = new Size(917, 519);
            BestSeller.TabIndex = 26;
            // 
            // tabSalesHistory
            // 
            tabSalesHistory.Controls.Add(label4);
            tabSalesHistory.Controls.Add(txtSearchSales);
            tabSalesHistory.Controls.Add(dgvSalesHistory);
            tabSalesHistory.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabSalesHistory.Location = new Point(4, 29);
            tabSalesHistory.Name = "tabSalesHistory";
            tabSalesHistory.Padding = new Padding(3);
            tabSalesHistory.Size = new Size(909, 486);
            tabSalesHistory.TabIndex = 0;
            tabSalesHistory.Text = "Sales History";
            tabSalesHistory.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 20);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 29;
            label4.Text = "Search:";
            // 
            // txtSearchSales
            // 
            txtSearchSales.Location = new Point(102, 20);
            txtSearchSales.Name = "txtSearchSales";
            txtSearchSales.Size = new Size(266, 27);
            txtSearchSales.TabIndex = 28;
            txtSearchSales.TextChanged += txtSearchSales_TextChanged;
            // 
            // dgvSalesHistory
            // 
            dgvSalesHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalesHistory.Location = new Point(0, 63);
            dgvSalesHistory.Name = "dgvSalesHistory";
            dgvSalesHistory.Size = new Size(909, 423);
            dgvSalesHistory.TabIndex = 27;
            // 
            // tabBestSeller
            // 
            tabBestSeller.Controls.Add(txtSearchBestSeller);
            tabBestSeller.Controls.Add(label3);
            tabBestSeller.Controls.Add(dgvBestSeller);
            tabBestSeller.Location = new Point(4, 29);
            tabBestSeller.Name = "tabBestSeller";
            tabBestSeller.Padding = new Padding(3);
            tabBestSeller.Size = new Size(909, 486);
            tabBestSeller.TabIndex = 1;
            tabBestSeller.Text = "Best Seller";
            tabBestSeller.UseVisualStyleBackColor = true;
            // 
            // txtSearchBestSeller
            // 
            txtSearchBestSeller.Location = new Point(99, 24);
            txtSearchBestSeller.Name = "txtSearchBestSeller";
            txtSearchBestSeller.Size = new Size(275, 27);
            txtSearchBestSeller.TabIndex = 33;
            txtSearchBestSeller.TextChanged += txtSearchBestSeller_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 24);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 32;
            label3.Text = "Search:";
            // 
            // dgvBestSeller
            // 
            dgvBestSeller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBestSeller.Location = new Point(-3, 63);
            dgvBestSeller.Name = "dgvBestSeller";
            dgvBestSeller.Size = new Size(909, 423);
            dgvBestSeller.TabIndex = 29;
            // 
            // tabLowstock
            // 
            tabLowstock.Controls.Add(txtSearchLowStock);
            tabLowstock.Controls.Add(dgvLowStock);
            tabLowstock.Controls.Add(label2);
            tabLowstock.Location = new Point(4, 29);
            tabLowstock.Name = "tabLowstock";
            tabLowstock.Size = new Size(909, 486);
            tabLowstock.TabIndex = 2;
            tabLowstock.Text = "LowStock";
            tabLowstock.UseVisualStyleBackColor = true;
            // 
            // txtSearchLowStock
            // 
            txtSearchLowStock.Location = new Point(95, 24);
            txtSearchLowStock.Name = "txtSearchLowStock";
            txtSearchLowStock.Size = new Size(275, 27);
            txtSearchLowStock.TabIndex = 31;
            txtSearchLowStock.TextChanged += txtSearchLowStock_TextChanged;
            // 
            // dgvLowStock
            // 
            dgvLowStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLowStock.Location = new Point(0, 63);
            dgvLowStock.Name = "dgvLowStock";
            dgvLowStock.Size = new Size(909, 423);
            dgvLowStock.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 24);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 31;
            label2.Text = "Search:";
            // 
            // tabSalesSummary
            // 
            tabSalesSummary.Controls.Add(label1);
            tabSalesSummary.Controls.Add(txtSearchSummary);
            tabSalesSummary.Controls.Add(dgvSalesSummary);
            tabSalesSummary.Location = new Point(4, 29);
            tabSalesSummary.Name = "tabSalesSummary";
            tabSalesSummary.Size = new Size(909, 486);
            tabSalesSummary.TabIndex = 3;
            tabSalesSummary.Text = "Sales Summary";
            tabSalesSummary.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 23);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 30;
            label1.Text = "Search:";
            // 
            // txtSearchSummary
            // 
            txtSearchSummary.Location = new Point(90, 23);
            txtSearchSummary.Name = "txtSearchSummary";
            txtSearchSummary.Size = new Size(275, 27);
            txtSearchSummary.TabIndex = 29;
            txtSearchSummary.TextChanged += txtSearchSummary_TextChanged;
            // 
            // dgvSalesSummary
            // 
            dgvSalesSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalesSummary.Location = new Point(0, 63);
            dgvSalesSummary.Name = "dgvSalesSummary";
            dgvSalesSummary.Size = new Size(909, 423);
            dgvSalesSummary.TabIndex = 28;
            // 
            // UCReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BestSeller);
            Controls.Add(label18);
            Name = "UCReport";
            Size = new Size(958, 692);
            Load += UCReport_Load;
            BestSeller.ResumeLayout(false);
            tabSalesHistory.ResumeLayout(false);
            tabSalesHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalesHistory).EndInit();
            tabBestSeller.ResumeLayout(false);
            tabBestSeller.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBestSeller).EndInit();
            tabLowstock.ResumeLayout(false);
            tabLowstock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).EndInit();
            tabSalesSummary.ResumeLayout(false);
            tabSalesSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalesSummary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label18;
        private TabControl BestSeller;
        private TabPage tabSalesHistory;
        private TabPage tabBestSeller;
        private TabPage tabLowstock;
        private TabPage tabSalesSummary;
        private DataGridView dgvSalesHistory;
        private DataGridView dgvBestSeller;
        private DataGridView dgvLowStock;
        private DataGridView dgvSalesSummary;
        private TextBox txtSearchLowStock;
        private Label label2;
        private Label label1;
        private TextBox txtSearchSummary;
        private Label label4;
        private TextBox txtSearchSales;
        private TextBox txtSearchBestSeller;
        private Label label3;
    }
}
