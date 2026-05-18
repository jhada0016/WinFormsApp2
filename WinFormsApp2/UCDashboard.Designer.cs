namespace WinFormsApp2
{
    partial class UCDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDashboard));
            panel1 = new Panel();
            lblSalesToday = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            lblLowStock = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            lblSalesMonth = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            lblOutStock = new Label();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            lblProducts = new Label();
            label10 = new Label();
            pictureBox5 = new PictureBox();
            panel9 = new Panel();
            dgvRecentSales = new DataGridView();
            label17 = new Label();
            panel10 = new Panel();
            dgvLowStock = new DataGridView();
            label2 = new Label();
            label18 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentSales).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblSalesToday);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(30, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 82);
            panel1.TabIndex = 0;
            // 
            // lblSalesToday
            // 
            lblSalesToday.AutoSize = true;
            lblSalesToday.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalesToday.Location = new Point(61, 37);
            lblSalesToday.Name = "lblSalesToday";
            lblSalesToday.Size = new Size(41, 21);
            lblSalesToday.TabIndex = 1;
            lblSalesToday.Text = "0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 11);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 0;
            label1.Text = "TOTAL SALES (TODAY)";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = Properties.Resources.app_store1;
            pictureBox1.Location = new Point(3, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblLowStock);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(579, 102);
            panel3.Name = "panel3";
            panel3.Size = new Size(172, 82);
            panel3.TabIndex = 7;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStock.Location = new Point(72, 37);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(41, 21);
            lblLowStock.TabIndex = 1;
            lblLowStock.Text = "0.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(53, 11);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 0;
            label4.Text = "LOW STOCK ITEMS";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblSalesMonth);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(216, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(182, 82);
            panel2.TabIndex = 8;
            // 
            // lblSalesMonth
            // 
            lblSalesMonth.AutoSize = true;
            lblSalesMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalesMonth.Location = new Point(75, 37);
            lblSalesMonth.Name = "lblSalesMonth";
            lblSalesMonth.Size = new Size(41, 21);
            lblSalesMonth.TabIndex = 1;
            lblSalesMonth.Text = "0.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(44, 11);
            label6.Name = "label6";
            label6.Size = new Size(135, 15);
            label6.TabIndex = 0;
            label6.Text = "TOTAL SALES (MONTH)";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.economy;
            pictureBox3.Location = new Point(3, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(66, 58);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lblOutStock);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(757, 102);
            panel4.Name = "panel4";
            panel4.Size = new Size(170, 82);
            panel4.TabIndex = 9;
            // 
            // lblOutStock
            // 
            lblOutStock.AutoSize = true;
            lblOutStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutStock.Location = new Point(63, 37);
            lblOutStock.Name = "lblOutStock";
            lblOutStock.Size = new Size(41, 21);
            lblOutStock.TabIndex = 1;
            lblOutStock.Text = "0.00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(25, 11);
            label8.Name = "label8";
            label8.Size = new Size(127, 15);
            label8.TabIndex = 0;
            label8.Text = "OUT OF STOCK ITEMS";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(54, 56);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(lblProducts);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(pictureBox5);
            panel5.Location = new Point(404, 102);
            panel5.Name = "panel5";
            panel5.Size = new Size(169, 82);
            panel5.TabIndex = 10;
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducts.Location = new Point(65, 37);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(41, 21);
            lblProducts.TabIndex = 1;
            lblProducts.Text = "0.00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(45, 11);
            label10.Name = "label10";
            label10.Size = new Size(99, 15);
            label10.TabIndex = 0;
            label10.Text = "TOTAL PRODUCT";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 11);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(56, 58);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(dgvRecentSales);
            panel9.Controls.Add(label17);
            panel9.Location = new Point(30, 210);
            panel9.Name = "panel9";
            panel9.Size = new Size(897, 194);
            panel9.TabIndex = 14;
            // 
            // dgvRecentSales
            // 
            dgvRecentSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentSales.Location = new Point(0, 44);
            dgvRecentSales.Name = "dgvRecentSales";
            dgvRecentSales.Size = new Size(897, 150);
            dgvRecentSales.TabIndex = 1;
            dgvRecentSales.SelectionChanged += dgvRecentSales_SelectionChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(4, 11);
            label17.Name = "label17";
            label17.Size = new Size(151, 17);
            label17.TabIndex = 0;
            label17.Text = "RECENT TRANSACTION";
            // 
            // panel10
            // 
            panel10.Controls.Add(dgvLowStock);
            panel10.Controls.Add(label2);
            panel10.Location = new Point(30, 450);
            panel10.Name = "panel10";
            panel10.Size = new Size(897, 216);
            panel10.TabIndex = 15;
            // 
            // dgvLowStock
            // 
            dgvLowStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLowStock.Location = new Point(0, 50);
            dgvLowStock.Name = "dgvLowStock";
            dgvLowStock.Size = new Size(897, 163);
            dgvLowStock.TabIndex = 2;
            dgvLowStock.SelectionChanged += dgvLowStock_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 14);
            label2.Name = "label2";
            label2.Size = new Size(155, 17);
            label2.TabIndex = 1;
            label2.Text = "LOW STOCK PRODUCTS";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Navy;
            label18.Location = new Point(22, 22);
            label18.Name = "label18";
            label18.Size = new Size(184, 45);
            label18.TabIndex = 16;
            label18.Text = "Dashboard";
            // 
            // UCDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(label18);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "UCDashboard";
            Size = new Size(958, 692);
            Load += UCDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentSales).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblSalesToday;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label lblLowStock;
        private Label label4;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Label lblSalesMonth;
        private Label label6;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Label lblOutStock;
        private Label label8;
        private Panel panel5;
        private PictureBox pictureBox5;
        private Label lblProducts;
        private Label label10;
        private Panel panel9;
        private Panel panel10;
        private Label label17;
        private Label label18;
        private Label label2;
        private DataGridView dgvRecentSales;
        private DataGridView dgvLowStock;
    }
}
