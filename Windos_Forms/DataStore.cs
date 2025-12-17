using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_windows
{
    public static class DataStore
    {
        public static BindingList<Category> Categories = new BindingList<Category>
{
    new Category { CategoryID = 1, CategoryName = "Default Category" }
};

        public static BindingList<Book> Books = new BindingList<Book>();
        public static BindingList<Member> Members = new BindingList<Member>();
        public static BindingList<Staff> Staffs = new BindingList<Staff>();
        public static BindingList<Loan> Loans = new BindingList<Loan>();

        static DataStore()
        {
            Staffs.Add(new Staff
            {
                StaffID = 1,
                Name = "Admin",
                Username = "admin",
                Password = "123"
            });
        }
    }

}
