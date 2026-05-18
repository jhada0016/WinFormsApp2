namespace WinFormsApp2
{
    partial class UCSales
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
            dataGridView1 = new DataGridView();
            dgvCart = new DataGridView();
            btnAddtoCart = new Button();
            btnRemove = new Button();
            btnCheckout = new Button();
            txtSearch = new TextBox();
            lblTotal = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Navy;
            label18.Location = new Point(40, 28);
            label18.Name = "label18";
            label18.Size = new Size(82, 37);
            label18.TabIndex = 18;
            label18.Text = "Sales";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(389, 406);
            dataGridView1.TabIndex = 19;
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(473, 112);
            dgvCart.Name = "dgvCart";
            dgvCart.Size = new Size(442, 317);
            dgvCart.TabIndex = 20;
            dgvCart.CellEndEdit += dgvCart_CellEndEdit;
            // 
            // btnAddtoCart
            // 
            btnAddtoCart.BackColor = Color.Orange;
            btnAddtoCart.FlatStyle = FlatStyle.Popup;
            btnAddtoCart.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddtoCart.ForeColor = Color.White;
            btnAddtoCart.Location = new Point(21, 23);
            btnAddtoCart.Name = "btnAddtoCart";
            btnAddtoCart.Size = new Size(110, 38);
            btnAddtoCart.TabIndex = 21;
            btnAddtoCart.Text = "Add to cart";
            btnAddtoCart.UseVisualStyleBackColor = false;
            btnAddtoCart.Click += btnAddtoCart_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.FlatStyle = FlatStyle.Popup;
            btnRemove.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(151, 23);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(99, 38);
            btnRemove.TabIndex = 22;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.Green;
            btnCheckout.FlatStyle = FlatStyle.Popup;
            btnCheckout.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(278, 23);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(134, 38);
            btnCheckout.TabIndex = 23;
            btnCheckout.Text = "Check out";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(155, 131);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(274, 25);
            txtSearch.TabIndex = 24;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(20, 9);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(65, 25);
            lblTotal.TabIndex = 25;
            lblTotal.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnAddtoCart);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(btnCheckout);
            panel1.Location = new Point(473, 488);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 85);
            panel1.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(473, 72);
            label2.Name = "label2";
            label2.Size = new Size(72, 37);
            label2.TabIndex = 28;
            label2.Text = "Cart";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(lblTotal);
            panel2.Location = new Point(473, 435);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 47);
            panel2.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 134);
            label1.Name = "label1";
            label1.Size = new Size(110, 17);
            label1.TabIndex = 30;
            label1.Text = "Search Products:";
            // 
            // UCSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(txtSearch);
            Controls.Add(dgvCart);
            Controls.Add(dataGridView1);
            Controls.Add(label18);
            Name = "UCSales";
            Size = new Size(958, 692);
            Load += UCSales_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label18;
        private DataGridView dataGridView1;
        private DataGridView dgvCart;
        private Button btnAddtoCart;
        private Button btnRemove;
        private Button btnCheckout;
        private TextBox txtSearch;
        private Label lblTotal;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label1;
    }
}
