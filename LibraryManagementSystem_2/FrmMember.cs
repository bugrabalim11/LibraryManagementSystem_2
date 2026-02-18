using LibraryManagementSystem_2.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystem_2
{
    public partial class FrmMember : Form
    {
        public FrmMember()
        {
            InitializeComponent();
        }

        Context db = new Context();

        void MemberList()
        {
            var values = db.Members.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmMember_Load(object sender, EventArgs e)
        {
            MemberList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMemberName.Text) && !string.IsNullOrEmpty(txtMemberSurname.Text) && !string.IsNullOrEmpty(txtMemberEmail.Text) && !string.IsNullOrEmpty(txtMemberPhone.Text))
            {
                Member member = new Member();
                member.MemberName = txtMemberName.Text;
                member.MemberSurname = txtMemberSurname.Text;
                member.MemberEmail = txtMemberEmail.Text;
                member.MemberPhone = txtMemberPhone.Text;
                db.Members.Add(member);
                db.SaveChanges();
                MessageBox.Show("Üye ekleme işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MemberList();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMemberID.Text);
            var deletedValue = db.Members.Find(id);

            // Eğer silinecek kayıt veritabanında gerçekten varsa işlemleri yap
            if (deletedValue != null)
            {
                DialogResult result = MessageBox.Show("Bu üyeyi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    db.Members.Remove(deletedValue);
                    db.SaveChanges();
                    MessageBox.Show("Üye silme işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MemberList();
                }
            }
            else
            {
                MessageBox.Show("Silinecek üye bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMemberID.Text);
            var updatedValue = db.Members.Find(id);

            // Güncellenecek üye veritabanında var mı diye kontrol ediyoruz. 
            // Eğer Find metodu ID'yi bulamazsa 'null' döner.
            // Bu kontrol, boş bir nesne üzerinde işlem yapıp programın çökmesini (Runtime Error) engeller.
            if (updatedValue != null)
            {
                updatedValue.MemberName = txtMemberName.Text;
                updatedValue.MemberSurname = txtMemberSurname.Text;
                updatedValue.MemberEmail = txtMemberEmail.Text;
                updatedValue.MemberPhone = txtMemberPhone.Text;
                db.SaveChanges();
                MessageBox.Show("Üye güncelleme işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MemberList();
            }
            else
            {
                MessageBox.Show("Güncellencek üye bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
