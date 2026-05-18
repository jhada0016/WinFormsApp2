namespace WinFormsApp2
{
    partial class Sari_Sari_Store_Sales_and_Inventory
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
            panel1 = new Panel();
            button6 = new Button();
            btnReport = new Button();
            btnInventory = new Button();
            button1 = new Button();
            btnSales = new Button();
            btnProduct = new Button();
            label2 = new Label();
            label1 = new Label();
            panelMain = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(btnReport);
            panel1.Controls.Add(btnInventory);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnSales);
            panel1.Controls.Add(btnProduct);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 692);
            panel1.TabIndex = 0;
            // 
            // button6
            // 
            button6.BackColor = Color.MidnightBlue;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(27, 631);
            button6.Name = "button6";
            button6.Size = new Size(197, 39);
            button6.TabIndex = 9;
            button6.Text = "Log Out";
            button6.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.MidnightBlue;
            btnReport.FlatStyle = FlatStyle.Popup;
            btnReport.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.ForeColor = SystemColors.ButtonHighlight;
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(27, 462);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(197, 48);
            btnReport.TabIndex = 8;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.MidnightBlue;
            btnInventory.FlatStyle = FlatStyle.Popup;
            btnInventory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventory.ForeColor = SystemColors.ButtonHighlight;
            btnInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventory.Location = new Point(27, 381);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(197, 50);
            btnInventory.TabIndex = 6;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(27, 149);
            button1.Name = "button1";
            button1.Size = new Size(197, 50);
            button1.TabIndex = 7;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.MidnightBlue;
            btnSales.FlatStyle = FlatStyle.Popup;
            btnSales.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSales.ForeColor = SystemColors.ButtonHighlight;
            btnSales.ImageAlign = ContentAlignment.MiddleLeft;
            btnSales.Location = new Point(27, 298);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(197, 48);
            btnSales.TabIndex = 6;
            btnSales.Text = "Sales";
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.MidnightBlue;
            btnProduct.FlatStyle = FlatStyle.Popup;
            btnProduct.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduct.ForeColor = SystemColors.ButtonHighlight;
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(27, 222);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(197, 44);
            btnProduct.TabIndex = 5;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(46, 67);
            label2.Name = "label2";
            label2.Size = new Size(164, 13);
            label2.TabIndex = 1;
            label2.Text = "INVENTORY AND SALES SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(61, 47);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 0;
            label1.Text = "SARI-SARI STORE";
            label1.Click += label1_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.Transparent;
            panelMain.Location = new Point(260, 1);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(958, 692);
            panelMain.TabIndex = 1;
            // 
            // Sari_Sari_Store_Sales_and_Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 692);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Name = "Sari_Sari_Store_Sales_and_Inventory";
            Text = "Sari_Sari_Store_Sales_and_Inventory";
            Load += Sari_Sari_Store_Sales_and_Inventory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panelMain;
        private Label label2;
        private Button button1;
        private Button btnSales;
        private Button btnProduct;
        private Button button6;
        private Button btnReport;
        private Button btnInventory;
    }
}