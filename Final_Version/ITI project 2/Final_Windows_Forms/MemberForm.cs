using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace final_windows
{
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DataStore.ConnectionString))
                {
                    string query = "SELECT MemberID, Name, Email, Phone FROM MEMBER";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvMembers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading members: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 1. التحقق من إدخال الاسم
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the member's name.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DataStore.ConnectionString))
                {
                    string query = "INSERT INTO MEMBER (Name, Email, Phone) VALUES (@name, @email, @phone)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Member added successfully!");
                }
                ClearFields();
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding member: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 1. التأكد من اختيار عضو من الجدول
            if (dgvMembers.CurrentRow == null)
            {
                MessageBox.Show("Please select a member to delete.");
                return;
            }

            // 2. رسالة تأكيد قبل الحذف
            DialogResult result = MessageBox.Show("Are you sure you want to delete this member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvMembers.CurrentRow.Cells["MemberID"].Value);

                using (SqlConnection conn = new SqlConnection(DataStore.ConnectionString))
                {
                    string query = "DELETE FROM MEMBER WHERE MemberID = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Member deleted successfully.");
                    }
                    catch (SqlException ex)
                    {
                        // إذا كان العضو مرتبط بعمليات استعارة (Foreign Key Constraint)
                        if (ex.Number == 547)
                        {
                            MessageBox.Show("Cannot delete this member because they have active or past book loans.");
                        }
                        else
                        {
                            MessageBox.Show("Database Error: " + ex.Message);
                        }
                    }
                }
                RefreshGrid();
            }
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }
    }
}
