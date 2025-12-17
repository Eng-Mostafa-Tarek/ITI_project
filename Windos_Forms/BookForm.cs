using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
            cmbCategory.DataSource = DataStore.Categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";

            
            dgvBooks.DataSource = DataStore.Books;

            
            if (dgvBooks.Columns.Count > 0)
            {
                dgvBooks.Columns["Title"].HeaderText = "Title";
                dgvBooks.Columns["Author"].HeaderText = "Author";
                dgvBooks.Columns["PublishYear"].HeaderText = "Year";
                dgvBooks.Columns["Available"].HeaderText = "Available";
                dgvBooks.Columns["CategoryID"].HeaderText = "Category";
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
        string.IsNullOrWhiteSpace(txtAuthor.Text) ||
        !int.TryParse(txtYear.Text, out int year) ||
        cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Please enter valid book details.");
                return;
            }

            DataStore.Books.Add(new Book
            {
                BookID = DataStore.Books.Count + 1,
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                PublishYear = year,
                Available = chkAvailable.Checked,
                CategoryID = (int)cmbCategory.SelectedValue
            });

            RefreshGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("Please select a book to update.");
                return;
            }

            var book = dgvBooks.CurrentRow.DataBoundItem as Book;
            if (book != null)
            {

                if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                    string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                    !int.TryParse(txtYear.Text, out int year) ||
                    cmbCategory.SelectedValue == null)
                {
                    MessageBox.Show("Please enter valid book details.");
                    return;
                }

                book.Title = txtTitle.Text;
                book.Author = txtAuthor.Text;
                book.PublishYear = year;
                book.Available = chkAvailable.Checked;
                book.CategoryID = (int)cmbCategory.SelectedValue;

                RefreshGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("Please select a book to delete.");
                return;
            }

            var book = dgvBooks.CurrentRow.DataBoundItem as Book;
            if (book != null)
            {
                DataStore.Books.Remove(book);
                RefreshGrid();
            }
        }
        private void RefreshGrid()
        {
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = DataStore.Books;
        }
    }
}
