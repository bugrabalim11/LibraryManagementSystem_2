using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystem_2
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }
        public void FormGetir(Form childForm)
        {
            pnlContent.Controls.Clear();   // Önce panelin içini boşaltıyoruz
            childForm.MdiParent = null;    // Eğer MDI kullanmıyorsak gerek yok ama güvenlik iyidir
            childForm.TopLevel = false;    // Formun bir "pencere" gibi davranmasını engelliyoruz
            childForm.FormBorderStyle = FormBorderStyle.None;     // Kenarlıkları siliyoruz
            childForm.Dock = DockStyle.Fill;    // Paneli tamamen kaplamasını sağlıyoruz

            pnlContent.Controls.Add(childForm);    // Formu panelin içine ekliyoruz
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormGetir(new FrmHome());
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            FormGetir(new FrmMember());
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            FormGetir(new FrmBook());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FormGetir(new FrmCategory());
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            FormGetir(new FrmAuthor());
        }

        private void btnProcesses_Click(object sender, EventArgs e)
        {
            FormGetir(new FrmProcess());
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            FormGetir(new FrmHome());
        }
    }
}
