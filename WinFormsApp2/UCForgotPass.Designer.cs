namespace WinFormsApp2
{
    partial class UCForgotPass
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUserName = new TextBox();
            label6 = new Label();
            txtStoreName = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            dtpBirthDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(95, 233);
            label1.Name = "label1";
            label1.Size = new Size(252, 30);
            label1.TabIndex = 0;
            label1.Text = "VERIFY YOUR ACCOUNT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 287);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(85, 348);
            label3.Name = "label3";
            label3.Size = new Size(131, 17);
            label3.TabIndex = 2;
            label3.Text = "Sari-Sari Store Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(86, 406);
            label4.Name = "label4";
            label4.Size = new Size(65, 17);
            label4.TabIndex = 3;
            label4.Text = "Birth Date";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(58, 307);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(321, 25);
            txtUserName.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(171, 596);
            label6.Name = "label6";
            label6.Size = new Size(93, 17);
            label6.TabIndex = 6;
            label6.Text = "Back to Sign In";
            label6.Click += label6_Click;
            // 
            // txtStoreName
            // 
            txtStoreName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStoreName.Location = new Point(58, 368);
            txtStoreName.Name = "txtStoreName";
            txtStoreName.Size = new Size(321, 25);
            txtStoreName.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(58, 544);
            button1.Name = "button1";
            button1.Size = new Size(321, 39);
            button1.TabIndex = 9;
            button1.Text = "Verify";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.browser;
            pictureBox1.Location = new Point(156, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBirthDate.Location = new Point(60, 426);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(319, 25);
            dtpBirthDate.TabIndex = 11;
            // 
            // UCForgotPass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtpBirthDate);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(txtStoreName);
            Controls.Add(label6);
            Controls.Add(txtUserName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCForgotPass";
            Size = new Size(441, 696);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUserName;
        private Label label6;
        private TextBox txtStoreName;
        private Button button1;
        private PictureBox pictureBox1;
        private DateTimePicker dtpBirthDate;
    }
}
