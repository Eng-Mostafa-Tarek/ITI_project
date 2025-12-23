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
            btnBooks.BackColor = Color.DimGray;
            btnBooks.Cursor = Cursors.Hand;
            btnBooks.FlatStyle = FlatStyle.Flat;
            btnBooks.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold);
            btnBooks.ForeColor = SystemColors.ButtonHighlight;
            btnBooks.Location = new Point(209, 159);
            btnBooks.Margin = new Padding(3, 2, 3, 2);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(215, 32);
            btnBooks.TabIndex = 0;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = false;
            btnBooks.Click += btnBooks_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.DimGray;
            btnCategories.Cursor = Cursors.Hand;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold);
            btnCategories.ForeColor = SystemColors.ButtonHighlight;
            btnCategories.Location = new Point(209, 118);
            btnCategories.Margin = new Padding(3, 2, 3, 2);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(215, 32);
            btnCategories.TabIndex = 1;
            btnCategories.Text = "Categories";
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategory_Click;
            // 
            // btnMembers
            // 
            btnMembers.BackColor = Color.DimGray;
            btnMembers.Cursor = Cursors.Hand;
            btnMembers.FlatStyle = FlatStyle.Flat;
            btnMembers.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold);
            btnMembers.ForeColor = SystemColors.ButtonHighlight;
            btnMembers.Location = new Point(209, 196);
            btnMembers.Margin = new Padding(3, 2, 3, 2);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(215, 32);
            btnMembers.TabIndex = 2;
            btnMembers.Text = "Members";
            btnMembers.UseVisualStyleBackColor = false;
            btnMembers.Click += btnMembers_Click;
            // 
            // btnLoans
            // 
            btnLoans.BackColor = Color.DimGray;
            btnLoans.Cursor = Cursors.Hand;
            btnLoans.FlatStyle = FlatStyle.Flat;
            btnLoans.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold);
            btnLoans.ForeColor = SystemColors.ButtonHighlight;
            btnLoans.Location = new Point(209, 232);
            btnLoans.Margin = new Padding(3, 2, 3, 2);
            btnLoans.Name = "btnLoans";
            btnLoans.Size = new Size(215, 32);
            btnLoans.TabIndex = 3;
            btnLoans.Text = "Loans";
            btnLoans.UseVisualStyleBackColor = false;
            btnLoans.Click += btnLoans_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DimGray;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(209, 269);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(215, 32);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.ButtonHighlight;
            lblWelcome.Location = new Point(-1, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(132, 22);
            lblWelcome.TabIndex = 5;
            lblWelcome.Text = "Welcome Back";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImage = Properties.Resources.Main;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(lblWelcome);
            Controls.Add(btnLogout);
            Controls.Add(btnLoans);
            Controls.Add(btnMembers);
            Controls.Add(btnCategories);
            Controls.Add(btnBooks);
            Margin = new Padding(3, 2, 3, 2);
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