namespace final_windows
{
    partial class MemberForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            dgvMembers = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(120, 110);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 27);
            txtPhone.TabIndex = 5;
            // 
            // dgvMembers
            // 
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.BackgroundColor = Color.LavenderBlush;
            dgvMembers.ColumnHeadersHeight = 29;
            dgvMembers.Location = new Point(30, 160);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.Size = new Size(740, 300);
            dgvMembers.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Pink;
            btnAdd.Location = new Point(350, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 40);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Member";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Pink;
            btnDelete.Location = new Point(350, 80);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 40);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 6;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.Location = new Point(30, 70);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 7;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.Location = new Point(30, 110);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 8;
            label3.Text = "Phone:";
            // 
            // MemberForm
            // 
            ClientSize = new Size(800, 500);
            Controls.Add(dgvMembers);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Name = "MemberForm";
            Text = "Member Management";
            Load += MemberForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtName, txtEmail, txtPhone;
        private DataGridView dgvMembers;
        private Button btnAdd, btnDelete;
        private Label label1, label2, label3;
    }
}