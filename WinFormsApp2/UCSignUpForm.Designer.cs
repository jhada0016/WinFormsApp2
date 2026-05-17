namespace WinFormsApp2
{
    partial class UCSignUpForm
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
            FullName = new Label();
            UserName = new Label();
            StoreName = new Label();
            Password = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            txtFullName = new TextBox();
            txtUserName = new TextBox();
            txtStoreName = new TextBox();
            txtPassword = new TextBox();
            textBox6 = new TextBox();
            BirthDate = new Label();
            dtpBirthDate = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(84, 80);
            label1.Name = "label1";
            label1.Size = new Size(261, 37);
            label1.TabIndex = 0;
            label1.Text = "CREATE ACCOUNT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 117);
            label2.Name = "label2";
            label2.Size = new Size(282, 17);
            label2.TabIndex = 1;
            label2.Text = "Join us and start managing your store smarter.";
            // 
            // FullName
            // 
            FullName.AutoSize = true;
            FullName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FullName.Location = new Point(84, 172);
            FullName.Name = "FullName";
            FullName.Size = new Size(66, 17);
            FullName.TabIndex = 2;
            FullName.Text = "Full Name";
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserName.Location = new Point(84, 234);
            UserName.Name = "UserName";
            UserName.Size = new Size(74, 17);
            UserName.TabIndex = 3;
            UserName.Text = "User Name";
            // 
            // StoreName
            // 
            StoreName.AutoSize = true;
            StoreName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StoreName.Location = new Point(84, 300);
            StoreName.Name = "StoreName";
            StoreName.Size = new Size(131, 17);
            StoreName.TabIndex = 4;
            StoreName.Text = "Sari-Sari Store Name";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(84, 426);
            Password.Name = "Password";
            Password.Size = new Size(64, 17);
            Password.TabIndex = 5;
            Password.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(84, 492);
            label7.Name = "label7";
            label7.Size = new Size(114, 17);
            label7.TabIndex = 6;
            label7.Text = "Confirm Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(99, 639);
            label8.Name = "label8";
            label8.Size = new Size(156, 17);
            label8.TabIndex = 7;
            label8.Text = "Already have an account?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(261, 639);
            label9.Name = "label9";
            label9.Size = new Size(47, 17);
            label9.TabIndex = 8;
            label9.Text = "Sign In";
            label9.Click += label9_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(58, 581);
            button1.Name = "button1";
            button1.Size = new Size(323, 40);
            button1.TabIndex = 9;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(58, 192);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(323, 25);
            txtFullName.TabIndex = 10;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(58, 254);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(323, 25);
            txtUserName.TabIndex = 11;
            // 
            // txtStoreName
            // 
            txtStoreName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStoreName.Location = new Point(58, 320);
            txtStoreName.Name = "txtStoreName";
            txtStoreName.Size = new Size(323, 25);
            txtStoreName.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(58, 446);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(323, 25);
            txtPassword.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(58, 512);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(323, 25);
            textBox6.TabIndex = 15;
            // 
            // BirthDate
            // 
            BirthDate.AutoSize = true;
            BirthDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BirthDate.Location = new Point(84, 363);
            BirthDate.Name = "BirthDate";
            BirthDate.Size = new Size(65, 17);
            BirthDate.TabIndex = 16;
            BirthDate.Text = "Birth Date";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBirthDate.Location = new Point(58, 383);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(323, 25);
            dtpBirthDate.TabIndex = 17;
            // 
            // UCSignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtpBirthDate);
            Controls.Add(BirthDate);
            Controls.Add(textBox6);
            Controls.Add(txtPassword);
            Controls.Add(txtStoreName);
            Controls.Add(txtUserName);
            Controls.Add(txtFullName);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(Password);
            Controls.Add(StoreName);
            Controls.Add(UserName);
            Controls.Add(FullName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCSignUpForm";
            Size = new Size(441, 696);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label FullName;
        private Label UserName;
        private Label StoreName;
        private Label Password;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button1;
        private TextBox txtFullName;
        private TextBox txtUserName;
        private TextBox txtStoreName;
        private TextBox txtPassword;
        private TextBox textBox6;
        private Label BirthDate;
        private DateTimePicker dtpBirthDate;
    }
}
