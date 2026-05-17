namespace WinFormsApp2
{
    partial class UCChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCChangePass));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(77, 240);
            label1.Name = "label1";
            label1.Size = new Size(284, 37);
            label1.TabIndex = 0;
            label1.Text = "CHANGE PASSWORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(101, 327);
            label2.Name = "label2";
            label2.Size = new Size(94, 17);
            label2.TabIndex = 1;
            label2.Text = "New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(101, 397);
            label3.Name = "label3";
            label3.Size = new Size(114, 17);
            label3.TabIndex = 2;
            label3.Text = "Confirm Password";
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(77, 508);
            button1.Name = "button1";
            button1.Size = new Size(293, 41);
            button1.TabIndex = 3;
            button1.Text = "Change Password";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(77, 347);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(293, 25);
            txtNewPassword.TabIndex = 4;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(77, 417);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(293, 25);
            txtConfirmPassword.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(172, 563);
            label4.Name = "label4";
            label4.Size = new Size(93, 17);
            label4.TabIndex = 6;
            label4.Text = "Back to Sign In";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(151, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // UCChangePass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCChangePass";
            Size = new Size(441, 696);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox txtNewPassword;
        private Label label4;
        private TextBox txtConfirmPassword;
        private PictureBox pictureBox1;
    }
}
