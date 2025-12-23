namespace final_windows
{
    partial class MainForm
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
            btnBooks = new Button();
            btnCategories = new Button();
            btnMembers = new Button();
            btnLoans = new Button();
            btnLogout = new Button();
            lblWelcome = new Label();
            SuspendLayout();
            // 
            // btnBooks
            // 
            btnBooks.BackColor = Color.LightPink;
            btnBooks.Location = new Point(239, 212);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(243, 33);
            btnBooks.TabIndex = 0;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = false;
            btnBooks.Click += btnBooks_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.LightPink;
            btnCategories.Location = new Point(239, 157);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(243, 33);
            btnCategories.TabIndex = 1;
            btnCategories.Text = "Categories";
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategory_Click;
            // 
            // btnMembers
            // 
            btnMembers.BackColor = Color.LightPink;
            btnMembers.Location = new Point(239, 261);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(243, 33);
            btnMembers.TabIndex = 2;
            btnMembers.Text = "Members";
            btnMembers.UseVisualStyleBackColor = false;
            btnMembers.Click += btnMembers_Click;
            // 
            // btnLoans
            // 
            btnLoans.BackColor = Color.LightPink;
            btnLoans.Location = new Point(239, 310);
            btnLoans.Name = "btnLoans";
            btnLoans.Size = new Size(243, 33);
            btnLoans.TabIndex = 3;
            btnLoans.Text = "Loans";
            btnLoans.UseVisualStyleBackColor = false;
            btnLoans.Click += btnLoans_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.LightPink;
            btnLogout.Location = new Point(239, 359);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(243, 33);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Pink;
            lblWelcome.Location = new Point(273, 81);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(159, 20);
            lblWelcome.TabIndex = 5;
            lblWelcome.Text = "Welcome, [StaffName]";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblWelcome);
            Controls.Add(btnLogout);
            Controls.Add(btnLoans);
            Controls.Add(btnMembers);
            Controls.Add(btnCategories);
            Controls.Add(btnBooks);
            Name = "MainForm";
            Text = "Dashboard";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBooks;
        private Button btnCategories;
        private Button btnMembers;
        private Button btnLoans;
        private Button btnLogout;
        private Label lblWelcome;
    }
}