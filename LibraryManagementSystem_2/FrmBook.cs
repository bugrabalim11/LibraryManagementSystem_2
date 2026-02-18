using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq; // LINQ sorguları için gerekli
using LibraryManagementSystem_2.Entities;
using System.Security.Cryptography; // Book sınıfına ulaşmak için


namespace LibraryManagementSystem_2
{
    public partial class FrmBook : Form
    {
        public FrmBook()
        {
            InitializeComponent();
        }

        Context db = new Context(); //KODLARKEN EKLE YOKSA KODLAR KARIŞIYOR!!!!!!   
        private void YazarlariGetir()
        {
            using (Context db = new Context())
            {
                // LINQ ile isim ve soyismi tek bir satırda "FullName" adıyla birleştiriyoruz
                var authorList = db.Authors.Select(a => new
                {
                    a.AuthorID,
                    FullName = a.AuthorName + " " + a.AuthorSurname
                }).ToList();

                cmbAuthor.DataSource = authorList;
                cmbAuthor.DisplayMember = "FullName"; // Artık birleşmiş halini gösterecek
                cmbAuthor.ValueMember = "AuthorID";   // Arka planda ID'yi tutmaya devam edecek
            }
        }
        private void KategorilileriGetir()
        {
            using (Context db = new Context())
            {
                cmbCategory.DataSource = db.Categories.ToList();
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryID";

            }
        }
        private void KitaplariGetir()    // BURAYA BAK VE ANLAMAYA ÇALIŞ!!!!!!!!!!!!!!
        {
            using (Context db = new Context())
            {
                // LINQ ile tabloları birleştiriyoruz (JOIN) ki DataGrid'de ID yerine isimler görünsün.
                var bookList = (from b in db.Books
                                join a in db.Authors on b.AuthorID equals a.AuthorID
                                join c in db.Categories on b.CategoryID equals c.CategoryID
                                select new
                                {
                                    b.BookID,
                                    b.BookName,
                                    b.PageCount,
                                    Category = c.CategoryName,
                                    Author = a.AuthorName + " " + a.AuthorSurname,
                                    BorrowStatus = b.IsBorrowed
                                }).ToList();

                // İŞTE EKLENECEK SİHİRLİ SATIR BURASI:
                dgvBooks.DataSource = null;

                // Sonra yeni listeyi veriyoruz:
                dgvBooks.DataSource = bookList;
            }
        }
        private void FrmBook_Load(object sender, EventArgs e)
        {
            YazarlariGetir();
            KategorilileriGetir();
            KitaplariGetir();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Seçim yapılmamışsa uyarı ver
            if (string.IsNullOrWhiteSpace(txtBookName.Text) || cmbAuthor.SelectedValue == null || cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Lütfen Kitap Adı, Yazar ve Kategori alanlarını doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Entitiy Framework ile veritabanına kayıt işlemi
            using (Context db = new Context())
            {
                // Yeni bir Book nesnesi (Entity) oluşturuyoruz   Çünkü yeni kayıt yapıyoruz
                Book newBook = new Book()
                {
                    BookName = txtBookName.Text,
                    PageCount = Convert.ToInt32(nudPageCount.Value),
                    CategoryID = Convert.ToInt32(cmbCategory.SelectedValue),
                    AuthorID = Convert.ToInt32(cmbAuthor.SelectedValue),
                    IsBorrowed = chkIsBorrowed.Checked
                };
                db.Books.Add(newBook);   // Nesneyi context'e ekle
                db.SaveChanges();      // Veritabanına kaydet (INSERT sorgusunu EF Core kendi yazar)

                MessageBox.Show("Kitap başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            KitaplariGetir(); // Liste yenilenir

            txtBookName.Clear(); // Kutular temizlenir
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // db nesnesi zaten yukarıda tanımlı olduğu için direkt kullanıyoruz
            int id = int.Parse(txtBookID.Text);
            var updatedValue = db.Books.Find(id);
            if (updatedValue != null)
            {
                updatedValue.BookName = txtBookName.Text;
                updatedValue.AuthorID = Convert.ToInt32(cmbAuthor.SelectedValue);
                updatedValue.CategoryID = Convert.ToInt32(cmbCategory.SelectedValue);
                updatedValue.PageCount = Convert.ToInt32(nudPageCount.Value);
                updatedValue.IsBorrowed = chkIsBorrowed.Checked;
                db.SaveChanges();
                MessageBox.Show("Güncelleme işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KitaplariGetir();
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi başarısız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtBookID.Text);
            var deletedValue= db.Books.Find(id);
            if (deletedValue != null)
            {
                db.Books.Remove(deletedValue);
                db.SaveChanges();
                MessageBox.Show("Silme işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KitaplariGetir();
            }
            else
            {
                MessageBox.Show("Silme işlemi başarısız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
