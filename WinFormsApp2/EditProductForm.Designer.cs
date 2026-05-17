namespace WinFormsApp2
{
    partial class EditProductForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblProduct = new Label();
            lblCategory = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            txtProductName = new TextBox();
            txtStock = new TextBox();
            btnUpdate = new Button();
            cbCategory = new ComboBox();
            txtPrice = new TextBox();
            SuspendLayout();
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProduct.Location = new Point(30, 192);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(95, 17);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Product Name:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(61, 228);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(64, 17);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(86, 272);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(39, 17);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(83, 310);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(42, 17);
            lblStock.TabIndex = 3;
            lblStock.Text = "Stock:";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(131, 189);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(178, 25);
            txtProductName.TabIndex = 4;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStock.Location = new Point(131, 310);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(178, 25);
            txtStock.TabIndex = 7;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(131, 368);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(99, 40);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "Drinks", "", "Snacks", "", "Canned Goods", "", "Frozen Foods", "", "Toiletries", "", "School Supplies" });
            cbCategory.Location = new Point(131, 228);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(178, 25);
            cbCategory.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(130, 269);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(179, 25);
            txtPrice.TabIndex = 10;
            // 
            // EditProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 450);
            Controls.Add(txtPrice);
            Controls.Add(cbCategory);
            Controls.Add(btnUpdate);
            Controls.Add(txtStock);
            Controls.Add(txtProductName);
            Controls.Add(lblStock);
            Controls.Add(lblPrice);
            Controls.Add(lblCategory);
            Controls.Add(lblProduct);
            Name = "EditProductForm";
            Text = "EditProductForm";
            Load += EditProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduct;
        private Label lblCategory;
        private Label lblPrice;
        private Label lblStock;
        private TextBox txtProductName;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txtStock;
        private Button btnUpdate;
        private ComboBox cbCategory;
        private TextBox txtPrice;
    }
}