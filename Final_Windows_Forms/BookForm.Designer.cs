namespace final_windows
{
    partial class BookForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtPrice = new TextBox();
            cmbCategory = new ComboBox();
            dgvBooks = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(150, 30);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(200, 27);
            txtTitle.TabIndex = 10;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(150, 70);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(200, 27);
            txtAuthor.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(150, 110);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 27);
            txtPrice.TabIndex = 8;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Location = new Point(150, 150);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(200, 28);
            cmbCategory.TabIndex = 7;
            // 
            // dgvBooks
            // 
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.BackgroundColor = Color.LavenderBlush;
            dgvBooks.ColumnHeadersHeight = 29;
            dgvBooks.Location = new Point(30, 200);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(740, 250);
            dgvBooks.TabIndex = 6;
            dgvBooks.SelectionChanged += dgvBooks_SelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Pink;
            btnAdd.Location = new Point(400, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 40);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add Book";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Pink;
            btnDelete.Location = new Point(400, 80);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 3;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.Location = new Point(30, 70);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 2;
            label2.Text = "Author:";
            // 
            // label3
            // 
            label3.Location = new Point(30, 110);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 1;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.Location = new Point(30, 150);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 0;
            label4.Text = "Category:";
            // 
            // BookForm
            // 
            ClientSize = new Size(800, 500);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvBooks);
            Controls.Add(cmbCategory);
            Controls.Add(txtPrice);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Name = "BookForm";
            Text = "Books Management";
            Load += BookForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtPrice;
        private ComboBox cmbCategory;
        private DataGridView dgvBooks;
        private Button btnAdd;
        private Button btnDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}