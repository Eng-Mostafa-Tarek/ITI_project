using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace final_windows
{
    partial class CategoryForm
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
            txtCategoryName = new TextBox();
            btnAdd = new Button();
            dgvCategories = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // txtCategoryName
            // 
            txtCategoryName.BackColor = Color.LavenderBlush;
            txtCategoryName.Location = new Point(416, 199);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(260, 27);
            txtCategoryName.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Pink;
            btnAdd.Location = new Point(95, 621);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvCategories
            // 
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.BackgroundColor = Color.LavenderBlush;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(95, 329);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.Size = new Size(890, 219);
            dgvCategories.TabIndex = 2;
            dgvCategories.SelectionChanged += dgvCategories_SelectionChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Pink;
            btnUpdate.Location = new Point(484, 621);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Pink;
            btnDelete.Location = new Point(891, 621);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(271, 202);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 5;
            label1.Text = "Category";
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 727);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dgvCategories);
            Controls.Add(btnAdd);
            Controls.Add(txtCategoryName);
            Name = "CategoryForm";
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCategoryName;
        private Button btnAdd;
        private DataGridView dgvCategories;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label1;
    }
}
