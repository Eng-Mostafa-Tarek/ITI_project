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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {

            InitializeComponent();
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            dgvCategories.SelectionChanged += dgvCategories_SelectionChanged;
            this.Load += CategoryForm_Load;


        }
        private void CategoryForm_Load(object? sender, EventArgs e)
        {
            dgvCategories.DataSource = DataStore.Categories;
            dgvCategories.AutoGenerateColumns = true;
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.RowHeadersVisible = false;

            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.MultiSelect = false;


        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            string name = txtCategoryName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a category name.");
                return;
            }

            DataStore.Categories.Add(new Category
            {
                CategoryID = DataStore.Categories.Count + 1,
                CategoryName = name
            });

            txtCategoryName.Clear();
            txtCategoryName.Focus();
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow?.DataBoundItem is Category cat)
            {
                string name = txtCategoryName.Text.Trim();
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Please enter a category name.");
                    return;
                }

                cat.CategoryName = name;
                dgvCategories.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a category first.");
            }
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow?.DataBoundItem is Category cat)
            {
                DataStore.Categories.Remove(cat);
                txtCategoryName.Clear();
            }
            else
            {
                MessageBox.Show("Please select a category first.");
            }
        }
        private void dgvCategories_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow?.DataBoundItem is Category cat)
            {
                txtCategoryName.Text = cat.CategoryName;
            }
        }
    }

}
