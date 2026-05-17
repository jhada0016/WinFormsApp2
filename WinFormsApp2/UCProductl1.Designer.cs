namespace WinFormsApp2
{
    partial class UCProductl1
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
            btnAdd = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Navy;
            label18.Location = new Point(49, 14);
            label18.Name = "label18";
            label18.Size = new Size(135, 37);
            label18.TabIndex = 17;
            label18.Text = "Product";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(513, 104);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 36);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "+ Add product";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(654, 105);
            button2.Name = "button2";
            button2.Size = new Size(115, 35);
            button2.TabIndex = 19;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(775, 105);
            button3.Name = "button3";
            button3.Size = new Size(127, 34);
            button3.TabIndex = 20;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(853, 459);
            dataGridView1.TabIndex = 21;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(49, 113);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(431, 27);
            txtSearch.TabIndex = 22;
            txtSearch.Text = "   Search product here...";
            // 
            // UCProductl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnAdd);
            Controls.Add(label18);
            Name = "UCProductl1";
            Size = new Size(958, 692);
            Load += UCProductl1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label18;
        private Button btnAdd;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private TextBox txtSearch;
    }
}
