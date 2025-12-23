using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace final_windows
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        // 1. Function to fetch data from SQL and display it in the grid
        private void RefreshGrid()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DataStore.ConnectionString))
                {
                    string query = "SELECT CategoryID, CategoryName FROM CATEGORY";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCategories.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }

        // 2. Form Load event (called automatically when the page opens)
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        // 3. Add Button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Verify that the field is not empty
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Please enter a category name.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DataStore.ConnectionString))
                {
                    string query = "INSERT INTO CATEGORY (CategoryName) VALUES (@name)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtCategoryName.Text.Trim());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                // If operation succeeds:
                txtCategoryName.Clear();
                RefreshGrid();
                MessageBox.Show("Category added successfully!");
            }
            catch (SqlException ex)
            {
                // Check error type: 2627 or 2601 means Duplicate Key violation
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("This category name already exists! Please try another name.");
                }
                else
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("General Error: " + ex.Message);
            }
        }

        // 4. Delete Button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Verify a row is selected
            if (dgvCategories.CurrentRow == null)
            {
                MessageBox.Show("Please select a category from the list to delete.");
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvCategories.CurrentRow.Cells["CategoryID"].Value);

                try
                {
                    using (SqlConnection conn = new SqlConnection(DataStore.ConnectionString))
                    {
                        string query = "DELETE FROM CATEGORY WHERE CategoryID = @id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", id);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Category deleted successfully.");
                    }
                    RefreshGrid();
                    txtCategoryName.Clear();
                }
                catch (SqlException ex)
                {
                    // Prevent deletion if linked to existing books (Foreign Key Constraint)
                    if (ex.Number == 547)
                        MessageBox.Show("Cannot delete this category because it contains linked books.");
                    else
                        MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        // 5. Selection Change: Show name in TextBox when a row is selected
        private void dgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow != null)
            {
                var cell = dgvCategories.CurrentRow.Cells["CategoryName"];

                if (cell != null && cell.Value != null)
                {
                    txtCategoryName.Text = cell.Value.ToString();
                }
            }
        }

        // 6. Update Button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Verify a row is selected
            if (dgvCategories.CurrentRow == null)
            {
                MessageBox.Show("Please select a category from the list to update.");
                return;
            }

            int id = Convert.ToInt32(dgvCategories.CurrentRow.Cells["CategoryID"].Value);
            string newName = txtCategoryName.Text.Trim();

            // Verify new name is not empty
            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Please enter the new category name.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DataStore.ConnectionString))
                {
                    string query = "UPDATE CATEGORY SET CategoryName = @name WHERE CategoryID = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", newName);
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Category updated successfully!");
                        RefreshGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Error: " + ex.Message);
            }
        }
    }
}