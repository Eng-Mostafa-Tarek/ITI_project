namespace final_windows
{
    partial class LoanForm
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
            cmbBook = new ComboBox();
            cmbMember = new ComboBox();
            dgvLoans = new DataGridView();
            btnBorrow = new Button();
            btnReturn = new Button();
            cmbStatus = new ComboBox();
            dtReturnDate = new DateTimePicker();
            lblBook = new Label();
            lblMember = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLoans).BeginInit();
            SuspendLayout();
            // 
            // cmbBook
            // 
            cmbBook.FormattingEnabled = true;
            cmbBook.Location = new Point(344, 65);
            cmbBook.Name = "cmbBook";
            cmbBook.Size = new Size(318, 28);
            cmbBook.TabIndex = 0;
            // 
            // cmbMember
            // 
            cmbMember.FormattingEnabled = true;
            cmbMember.Location = new Point(344, 140);
            cmbMember.Name = "cmbMember";
            cmbMember.Size = new Size(322, 28);
            cmbMember.TabIndex = 1;
            // 
            // dgvLoans
            // 
            dgvLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoans.BackgroundColor = SystemColors.ButtonHighlight;
            dgvLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoans.GridColor = SystemColors.InactiveBorder;
            dgvLoans.Location = new Point(209, 310);
            dgvLoans.Name = "dgvLoans";
            dgvLoans.RowHeadersVisible = false;
            dgvLoans.RowHeadersWidth = 51;
            dgvLoans.Size = new Size(635, 243);
            dgvLoans.TabIndex = 2;
            // 
            // btnBorrow
            // 
            btnBorrow.BackColor = SystemColors.HotTrack;
            btnBorrow.Location = new Point(209, 585);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(94, 29);
            btnBorrow.TabIndex = 3;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = false;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = SystemColors.HotTrack;
            btnReturn.Location = new Point(690, 585);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(94, 29);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(344, 203);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 28);
            cmbStatus.TabIndex = 5;
            // 
            // dtReturnDate
            // 
            dtReturnDate.Location = new Point(873, 250);
            dtReturnDate.Name = "dtReturnDate";
            dtReturnDate.Size = new Size(250, 27);
            dtReturnDate.TabIndex = 6;
            // 
            // lblBook
            // 
            lblBook.AutoSize = true;
            lblBook.Location = new Point(209, 65);
            lblBook.Name = "lblBook";
            lblBook.Size = new Size(43, 20);
            lblBook.TabIndex = 8;
            lblBook.Text = "Book";
            // 
            // lblMember
            // 
            lblMember.AutoSize = true;
            lblMember.Location = new Point(209, 148);
            lblMember.Name = "lblMember";
            lblMember.Size = new Size(65, 20);
            lblMember.TabIndex = 9;
            lblMember.Text = "Member";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(745, 250);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 11;
            label4.Text = "Return Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 211);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 12;
            label5.Text = "Status";
            // 
            // LoanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 716);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblMember);
            Controls.Add(lblBook);
            Controls.Add(dtReturnDate);
            Controls.Add(cmbStatus);
            Controls.Add(btnReturn);
            Controls.Add(btnBorrow);
            Controls.Add(dgvLoans);
            Controls.Add(cmbMember);
            Controls.Add(cmbBook);
            Name = "LoanForm";
            Text = "LoanForm";
            Load += LoanForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLoans).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBook;
        private ComboBox cmbMember;
        private DataGridView dgvLoans;
        private Button btnBorrow;
        private Button btnReturn;
        private ComboBox cmbStatus;
        private DateTimePicker dtReturnDate;
        private Label lblBook;
        private Label lblMember;
        private Label label4;
        private Label label5;
    }
}