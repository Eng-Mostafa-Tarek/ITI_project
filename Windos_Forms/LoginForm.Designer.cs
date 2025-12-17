namespace final_windows
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbIUsername = new Label();
            txtUsername = new TextBox();
            lbLPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblErrors = new Label();
            SuspendLayout();
            // 
            // lbIUsername
            // 
            lbIUsername.AutoSize = true;
            lbIUsername.BackColor = SystemColors.ActiveCaption;
            lbIUsername.Location = new Point(254, 111);
            lbIUsername.Name = "lbIUsername";
            lbIUsername.Size = new Size(75, 20);
            lbIUsername.TabIndex = 0;
            lbIUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(447, 108);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 1;
            // 
            // lbLPassword
            // 
            lbLPassword.AutoSize = true;
            lbLPassword.BackColor = SystemColors.ActiveCaption;
            lbLPassword.Location = new Point(259, 206);
            lbLPassword.Name = "lbLPassword";
            lbLPassword.Size = new Size(70, 20);
            lbLPassword.TabIndex = 2;
            lbLPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(447, 199);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Location = new Point(338, 305);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblErrors
            // 
            lblErrors.AutoSize = true;
            lblErrors.Location = new Point(549, 305);
            lblErrors.Name = "lblErrors";
            lblErrors.Size = new Size(0, 20);
            lblErrors.TabIndex = 5;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblErrors);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lbLPassword);
            Controls.Add(txtUsername);
            Controls.Add(lbIUsername);
            Name = "LoginForm";
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbIUsername;
        private TextBox txtUsername;
        private Label lbLPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblErrors;
    }
}
