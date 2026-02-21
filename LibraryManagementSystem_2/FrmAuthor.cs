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
    public partial class FrmAuthor : Form
    {
        public FrmAuthor()
        {
            InitializeComponent();
        }

        Context db = new Context();   // Benim C# kodlarımla, SQL'deki veritabanım arasında bir bağlantı (köprü) kur ve bu köprünün adını db koy.

        void Listele()
        {
            var value = db.Authors.ToList();
            dataGridView1.DataSource = value;
        }

        private void FrmAuthor_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 1. Önce TextBox'ların boş olup olmadığını kontrol et
            if (!string.IsNullOrEmpty(txtAuthorName.Text) && !string.IsNullOrEmpty(txtAuthorSurname.Text))
            {
                // 2. Eğer doluysa nesneyi oluştur ve verileri aktar
                Author author = new Author();
                author.AuthorName = txtAuthorName.Text;
                author.AuthorSurname = txtAuthorSurname.Text;
                db.Authors.Add(author);
                db.SaveChanges();
                MessageBox.Show("Yazar ekleme işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            else
            {
                MessageBox.Show("Yazar ekleme işlemi başarısız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtAuthorID.Text);
            var deletedValue = db.Authors.Find(id);
            if (deletedValue != null)   //Veritabanında olmayan bir ID silinmeye çalışıldığında programın hata verip kapanmasını engellemiş oldun.
            {
                db.Authors.Remove(deletedValue);
                db.SaveChanges();
                MessageBox.Show("Silme işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            else
            {
                MessageBox.Show("Silme işlemi başarısız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtAuthorID.Text);
            var updatedValue = db.Authors.Find(id);
            if (updatedValue != null)
            {
                updatedValue.AuthorName = txtAuthorName.Text;
                updatedValue.AuthorSurname = txtAuthorSurname.Text;
                db.SaveChanges();
                MessageBox.Show("Güncellem işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            else
            {
                MessageBox.Show("Ekleme işlemi başarısız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
