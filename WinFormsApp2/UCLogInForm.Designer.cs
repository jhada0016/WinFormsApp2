namespace WinFormsApp2
{
    partial class UCLogInForm
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnSignIn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(138, 148);
            label1.Name = "label1";
            label1.Size = new Size(165, 37);
            label1.TabIndex = 0;
            label1.Text = "WELCOME!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(110, 185);
            label2.Name = "label2";
            label2.Size = new Size(214, 17);
            label2.TabIndex = 1;
            label2.Text = "Sign in to continue to your account.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(85, 283);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 2;
            label3.Text = "User Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(85, 347);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(270, 395);
            label5.Name = "label5";
            label5.Size = new Size(114, 17);
            label5.TabIndex = 4;
            label5.Text = "Forgot password?";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(120, 536);
            label6.Name = "label6";
            label6.Size = new Size(143, 17);
            label6.TabIndex = 5;
            label6.Text = "Don't have an account?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(260, 536);
            label7.Name = "label7";
            label7.Size = new Size(52, 17);
            label7.TabIndex = 6;
            label7.Text = "Sign up";
            label7.Click += label7_Click;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(64, 303);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(320, 25);
            txtUserName.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(64, 367);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(320, 25);
            txtPassword.TabIndex = 8;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.RoyalBlue;
            btnSignIn.FlatStyle = FlatStyle.Popup;
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(64, 483);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(320, 38);
            btnSignIn.TabIndex = 9;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // UCLogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSignIn);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCLogInForm";
            Size = new Size(441, 696);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnSignIn;
    }
}
