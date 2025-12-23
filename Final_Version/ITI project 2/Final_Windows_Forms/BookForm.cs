using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace final_windows
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            RefreshGrid();
        }

        private void LoadCategories()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DataStore.ConnectionString))
                {
                    string query = "SELECT CategoryID, CategoryName FROM CATEGORY";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbCategory.DataSource = dt;
                    cmbCategory.DisplayMember = "CategoryName";
                    cmbCategory.ValueMember = "CategoryID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }

        private void RefreshGrid()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DataStore.ConnectionString))
                {
                    string query = @"SELECT B.BookID, B.Title, B.Author, B.Price, C.CategoryName 
                                   FROM BOOK B 
                                   JOIN CATEGORY C ON B.CategoryID = C.CategoryID";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvBooks.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || !decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Please provide a valid Title and Price.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DataStore.ConnectionString))
                {
                    string query = "INSERT INTO BOOK (Title, Author, Price, CategoryID) VALUES (@title, @author, @price, @catID)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@author", txtAuthor.Text.Trim());
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@catID", cmbCategory.SelectedValue ?? DBNull.Value);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Book added successfully!");
                RefreshGrid();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("Please select a book from the list to update.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid price format.");
                return;
            }

            int id = Convert.ToInt32(dgvBooks.CurrentRow.Cells["BookID"].Value);

            try
            {
                using (SqlConnection conn = new SqlConnection(DataStore.ConnectionString))
                {
                    string query = @"UPDATE BOOK
                                   SET Title = @title, Author = @author, Price = @price, CategoryID = @catID 
                                   WHERE BookID = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@author", txtAuthor.Text.Trim());
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@catID", cmbCategory.SelectedValue);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Book updated successfully!");
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null) return;

            DialogResult result = MessageBox.Show("Are you sure?", "Delete Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvBooks.CurrentRow.Cells["BookID"].Value);
                try
                {
                    using (SqlConnection conn = new SqlConnection(DataStore.ConnectionString))
                    {
                        string query = "DELETE FROM BOOK WHERE BookID = @id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    RefreshGrid();
                }
                catch (SqlException ex) when (ex.Number == 547)
                {
                    MessageBox.Show("Cannot delete: Book is currently borrowed.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow != null)
            {
                txtTitle.Text = dgvBooks.CurrentRow.Cells["Title"]?.Value?.ToString() ?? "";
                txtAuthor.Text = dgvBooks.CurrentRow.Cells["Author"]?.Value?.ToString() ?? "";
                txtPrice.Text = dgvBooks.CurrentRow.Cells["Price"]?.Value?.ToString() ?? "";
                // لاختيار القسم الصحيح في الـ ComboBox
                string catName = dgvBooks.CurrentRow.Cells["CategoryName"]?.Value?.ToString() ?? "";
                cmbCategory.Text = catName;
            }
        }

        private void ClearFields()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtPrice.Clear();
            if (cmbCategory.Items.Count > 0) cmbCategory.SelectedIndex = 0;
        }
    }
}