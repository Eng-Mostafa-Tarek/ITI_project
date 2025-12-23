namespace final_windows
{
    partial class LoanForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cmbMember = new ComboBox();
            cmbBook = new ComboBox();
            dgvLoans = new DataGridView();
            btnAddLoan = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLoans).BeginInit();
            SuspendLayout();
            // 
            // cmbMember
            // 
            cmbMember.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMember.Location = new Point(120, 27);
            cmbMember.Name = "cmbMember";
            cmbMember.Size = new Size(200, 28);
            cmbMember.TabIndex = 5;
            // 
            // cmbBook
            // 
            cmbBook.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBook.Location = new Point(120, 67);
            cmbBook.Name = "cmbBook";
            cmbBook.Size = new Size(200, 28);
            cmbBook.TabIndex = 4;
            // 
            // dgvLoans
            // 
            dgvLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoans.BackgroundColor = Color.LavenderBlush;
            dgvLoans.ColumnHeadersHeight = 29;
            dgvLoans.Location = new Point(30, 143);
            dgvLoans.Name = "dgvLoans";
            dgvLoans.RowHeadersWidth = 51;
            dgvLoans.Size = new Size(707, 262);
            dgvLoans.TabIndex = 3;
            // 
            // btnAddLoan
            // 
            btnAddLoan.BackColor = Color.Gray;
            btnAddLoan.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold);
            btnAddLoan.Location = new Point(364, 30);
            btnAddLoan.Name = "btnAddLoan";
            btnAddLoan.Size = new Size(136, 65);
            btnAddLoan.TabIndex = 2;
            btnAddLoan.Text = "Add Loan Record";
            btnAddLoan.UseVisualStyleBackColor = false;
            btnAddLoan.Click += btnAddLoan_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(83, 23);
            label1.TabIndex = 1;
            label1.Text = "Member:";
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(30, 70);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 0;
            label2.Text = "Book:";
            // 
            // LoanForm
            // 
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.christmas_gold_background_golden_holiday_glowing_backdrop_defocused_background_with_blinking_stars_blurred_bokeh_curtain_photo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(812, 500);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddLoan);
            Controls.Add(dgvLoans);
            Controls.Add(cmbBook);
            Controls.Add(cmbMember);
            Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold);
            ForeColor = SystemColors.ButtonFace;
            Name = "LoanForm";
            Text = "Loan Management System";
            Load += LoanForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLoans).EndInit();
            ResumeLayout(false);
        }

        private ComboBox cmbMember;
        private ComboBox cmbBook;
        private DataGridView dgvLoans;
        private Button btnAddLoan;
        private Label label1;
        private Label label2;
    }
}