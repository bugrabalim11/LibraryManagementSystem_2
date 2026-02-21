using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystem_2
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                lblTotalBooksCount.Text = db.Books.Count().ToString();
                lblBorrowedBooksCount.Text = db.Books.Where(x => x.IsBorrowed == true).Count().ToString();
                lblTotalMembersCount.Text = db.Members.Count().ToString();

                DateTime todey = DateTime.Today;
                lblOverdueBooksCount.Text = db.Processes
                                              .Where(x => x.EndDate < todey && x.IsReturned == false)
                                              .Count().ToString();

                var recentTransactions = db.Processes
                                         .OrderByDescending(x => x.ProcessID)
                                         .Take(10)
                                         .ToList();
                dgvRecentTransactions.DataSource = recentTransactions;
            }
        }
    }
}
