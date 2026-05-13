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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Navy;
            label18.Location = new Point(15, 16);
            label18.Name = "label18";
            label18.Size = new Size(76, 32);
            label18.TabIndex = 18;
            label18.Text = "Sales";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(519, 312);
            dataGridView1.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(550, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 382);
            panel1.TabIndex = 20;
            // 
            // button2
            // 
            button2.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(143, 329);
            button2.Name = "button2";
            button2.Size = new Size(105, 35);
            button2.TabIndex = 11;
            button2.Text = "Complete Sale";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(62, 329);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 10;
            button1.Text = "Hold Sale";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 297);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 9;
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 261);
            label4.Name = "label4";
            label4.Size = new Size(59, 19);
            label4.TabIndex = 8;
            label4.Text = "Change";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 224);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 23);
            textBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 193);
            label3.Name = "label3";
            label3.Size = new Size(133, 19);
            label3.TabIndex = 6;
            label3.Text = "Amount Tendered";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(27, 161);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(57, 19);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "CARD";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(27, 136);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(65, 19);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "GCASH";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(27, 111);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(57, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "CASH";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 89);
            label2.Name = "label2";
            label2.Size = new Size(129, 19);
            label2.TabIndex = 2;
            label2.Text = "Payment Method";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(18, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(252, 23);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(74, 19);
            label1.TabIndex = 0;
            label1.Text = "Costumer";
            label1.Click += label1_Click;
            // 
            // UCSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label18);
            Name = "UCSales";
            Size = new Size(861, 532);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label18;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label5;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private Button button2;
        private Button button1;
    }
}
