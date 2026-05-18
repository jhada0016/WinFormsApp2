namespace WinFormsApp2
{
    partial class UCInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCInventory));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTotalProducts = new Label();
            label1 = new Label();
            label18 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            lblInStock = new Label();
            label4 = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            lblLowStock = new Label();
            label6 = new Label();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            lblOutStock = new Label();
            label8 = new Label();
            dgvInventory = new DataGridView();
            txtSearch = new TextBox();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTotalProducts);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(54, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(193, 82);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.AutoSize = true;
            lblTotalProducts.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalProducts.Location = new Point(68, 33);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(46, 25);
            lblTotalProducts.TabIndex = 1;
            lblTotalProducts.Text = "0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 11);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "TOTAL PRODUCTS";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Navy;
            label18.Location = new Point(18, 17);
            label18.Name = "label18";
            label18.Size = new Size(143, 37);
            label18.TabIndex = 19;
            label18.Text = "Inventory";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblInStock);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(264, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(202, 82);
            panel2.TabIndex = 20;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblInStock
            // 
            lblInStock.AutoSize = true;
            lblInStock.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInStock.Location = new Point(79, 33);
            lblInStock.Name = "lblInStock";
            lblInStock.Size = new Size(46, 25);
            lblInStock.TabIndex = 1;
            lblInStock.Text = "0.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(79, 11);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 0;
            label4.Text = "IN STOCK";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(lblLowStock);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(485, 146);
            panel3.Name = "panel3";
            panel3.Size = new Size(193, 82);
            panel3.TabIndex = 21;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(9, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLowStock.Location = new Point(87, 33);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(46, 25);
            lblLowStock.TabIndex = 1;
            lblLowStock.Text = "0.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(87, 11);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 0;
            label6.Text = "LOW STOCK";
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(lblOutStock);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(700, 146);
            panel4.Name = "panel4";
            panel4.Size = new Size(193, 82);
            panel4.TabIndex = 22;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 11);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(54, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // lblOutStock
            // 
            lblOutStock.AutoSize = true;
            lblOutStock.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutStock.Location = new Point(82, 33);
            lblOutStock.Name = "lblOutStock";
            lblOutStock.Size = new Size(46, 25);
            lblOutStock.TabIndex = 1;
            lblOutStock.Text = "0.00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(82, 11);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 0;
            label8.Text = "OUT OF STOCK";
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(54, 251);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.Size = new Size(839, 406);
            dgvInventory.TabIndex = 23;
            dgvInventory.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(632, 101);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(261, 25);
            txtSearch.TabIndex = 24;
            
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(580, 105);
            label9.Name = "label9";
            label9.Size = new Size(51, 17);
            label9.TabIndex = 25;
            label9.Text = "Search:";
            // 
            // UCInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label9);
            Controls.Add(txtSearch);
            Controls.Add(dgvInventory);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label18);
            Controls.Add(panel1);
            Name = "UCInventory";
            Size = new Size(958, 692);
            Load += UCInventory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTotalProducts;
        private Label label1;
        private Label label18;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label lblInStock;
        private Label label4;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label lblLowStock;
        private Label label6;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Label lblOutStock;
        private Label label8;
        private DataGridView dgvInventory;
        private TextBox txtSearch;
        private Label label9;
    }
}
