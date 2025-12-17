using System;
using System.Windows.Forms;
using System.Collections.Generic;

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
            dgvMembers.DataSource = null;
            dgvMembers.DataSource = DataStore.Members;

            if (dgvMembers.Columns.Count > 0)
            {
                dgvMembers.Columns["Name"].HeaderText = "Member Name";
                dgvMembers.Columns["Phone"].HeaderText = "Phone Number";
                dgvMembers.Columns["Email"].HeaderText = "Email Address";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataStore.Members.Add(new Member
            {
                MemberID = DataStore.Members.Count + 1,
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text
            });

            RefreshGrid(); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow != null)
            {
                var member = dgvMembers.CurrentRow.DataBoundItem as Member;
                if (member != null)
                {
                    member.Name = txtName.Text;
                    member.Phone = txtPhone.Text;
                    member.Email = txtEmail.Text;
                    RefreshGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a member first.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow != null)
            {
                var member = dgvMembers.CurrentRow.DataBoundItem as Member;
                if (member != null)
                {
                    DataStore.Members.Remove(member);
                    RefreshGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a member first.");
            }
        }
    }
}
