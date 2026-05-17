namespace WinFormsApp2
{
    partial class Products
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
            label1 = new Label();
            label2 = new Label();
            lblStock = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            btnSave = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 118);
            label1.Name = "label1";
            label1.Size = new Size(99, 17);
            label1.TabIndex = 0;
            label1.Text = "Product Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 163);
            label2.Name = "label2";
            label2.Size = new Size(40, 17);
            label2.TabIndex = 1;
            label2.Text = "Price:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(35, 207);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 17);
            lblStock.TabIndex = 2;
            lblStock.Text = "Stock:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(140, 118);
            txtName.Name = "txtName";
            txtName.Size = new Size(194, 25);
            txtName.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(140, 155);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(194, 25);
            txtPrice.TabIndex = 4;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStock.Location = new Point(140, 199);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(194, 25);
            txtStock.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(62, 294);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(87, 34);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(212, 294);
            button2.Name = "button2";
            button2.Size = new Size(87, 34);
            button2.TabIndex = 7;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 374);
            Controls.Add(button2);
            Controls.Add(btnSave);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(lblStock);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Products";
            Text = "Products";
            Load += Products_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblStock;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtStock;
        private Button btnSave;
        private Button button2;
    }
}