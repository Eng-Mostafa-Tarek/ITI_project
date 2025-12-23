using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace final_windows
{
    public partial class LoanForm : Form
    {
        public LoanForm()
        {
            InitializeComponent();
            // ربط الأحداث يدوياً هنا يمنع خطأ التكرار (Ambiguous Call)
            //this.Load += LoanForm_Load;
        }

        private void LoanForm_Load(object sender, EventArgs e)
        {
            LoadMembers();
            LoadBooks();
            RefreshGrid();
        }

        private void LoadMembers()
        {
            using (SqlConnection conn = new SqlConnection(DataStore.ConnectionString))
            {
                string query = "SELECT MemberID, Name FROM MEMBER";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbMember.DataSource = dt;
                cmbMember.DisplayMember = "Name";
                cmbMember.ValueMember = "MemberID";
            }
        }

        private void LoadBooks()
        {
            using (SqlConnection conn = new SqlConnection(DataStore.ConnectionString))
            {
                string query = "SELECT BookID, Title FROM BOOK";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbBook.DataSource = dt;
                cmbBook.DisplayMember = "Title";
                cmbBook.ValueMember = "BookID";
            }
        }

        private void RefreshGrid()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DataStore.ConnectionString))
                {
                    string query = @"SELECT L.LoanID, M.Name AS MemberName, B.Title AS BookTitle, L.LoanDate, L.ReturnDate 
                             FROM LOAN L
                             JOIN MEMBER M ON L.MemberID = M.MemberID
                             JOIN BOOK B ON L.BookID = B.BookID";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvLoans.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading grid : " + ex.Message);
            }
        }

        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            // 1. التأكد أن المستخدم اختار عضو وكتاب فعلاً
            if (cmbMember.SelectedValue == null || cmbBook.SelectedValue == null)
            {
                MessageBox.Show("Please select both a Member and a Book before saving.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DataStore.ConnectionString))
                {
                    // ملاحظة: تأكدي أن اسم الجدول في الداتابيز LOAN وليس LOANS
                    string query = "INSERT INTO LOAN (MemberID, BookID, LoanDate) VALUES (@mID, @bID, @date)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // تأكدي من إرسال القيم بشكل صريح
                    cmd.Parameters.AddWithValue("@mID", cmbMember.SelectedValue);
                    cmd.Parameters.AddWithValue("@bID", cmbBook.SelectedValue);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Loan record added successfully!");
                }
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }
    }
}