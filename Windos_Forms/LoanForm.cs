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
    public partial class LoanForm : Form
    {
        public LoanForm()
        {
            InitializeComponent();
        }

        private void LoanForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            dgvLoans.DataSource = DataStore.Loans;
        }

        private void LoadComboBoxes()
        {
            cmbBook.DataSource = DataStore.Books.Where(b => b.Available).ToList();
            cmbBook.DisplayMember = "Title";
            cmbBook.ValueMember = "BookID";

            cmbMember.DataSource = DataStore.Members.ToList();
            cmbMember.DisplayMember = "Name";
            cmbMember.ValueMember = "MemberID";
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (cmbBook.SelectedValue != null && cmbMember.SelectedValue != null)
            {
                int bookId = (int)cmbBook.SelectedValue;
                int memberId = (int)cmbMember.SelectedValue;

                var book = DataStore.Books.FirstOrDefault(b => b.BookID == bookId);
                if (book != null)
                {
                    book.Available = false;

                    DataStore.Loans.Add(new Loan
                    {
                        LoanID = DataStore.Loans.Count + 1,
                        BookID = bookId,
                        MemberID = memberId,
                        StaffID = 1, 
                        LoanDate = DateTime.Now,
                        Status = "Borrowed"
                    });

                    RefreshGrid();
                }
                else
                {
                    MessageBox.Show("Selected book not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a book and a member first.");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvLoans.CurrentRow != null)
            {
                var loan = dgvLoans.CurrentRow.DataBoundItem as Loan;
                if (loan != null)
                {
                    loan.Status = "Returned";
                    loan.ReturnDate = dtReturnDate.Value;

                    var book = DataStore.Books.FirstOrDefault(b => b.BookID == loan.BookID);
                    if (book != null)
                    {
                        book.Available = true;
                    }

                    RefreshGrid();
                }
                else
                {
                    MessageBox.Show("Selected loan is invalid.");
                }
            }
            else
            {
                MessageBox.Show("Please select a loan to return.");
            }
        }

        private void RefreshGrid()
        {
            dgvLoans.DataSource = null;
            dgvLoans.DataSource = DataStore.Loans;

            LoadComboBoxes();
        }
    }
}