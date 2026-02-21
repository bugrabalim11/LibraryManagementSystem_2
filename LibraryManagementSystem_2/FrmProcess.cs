using LibraryManagementSystem_2.Entities;
using Microsoft.EntityFrameworkCore.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystem_2
{
    public partial class FrmProcess : Form
    {

        public FrmProcess()
        {
            InitializeComponent();
        }

        private void FrmProcess_Load(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                // 1. KİTAPLAR (Önce kurallar, sonra veri)
                cmbChooseBook.DisplayMember = "BookName";
                cmbChooseBook.ValueMember = "BookID";
                cmbChooseBook.DataSource = db.Books.ToList();

                // 2. ÜYELER (Önce kurallar, sonra veri)
                cmbChooseMember.DisplayMember = "MemberName";
                cmbChooseMember.ValueMember = "MemberID";
                cmbChooseMember.DataSource = db.Members.ToList();

                // DataGridView
                dgvProcessList.DataSource = db.Processes.ToList();
            }
        }

        private void btnLend_Click(object sender, EventArgs e) // **** BUNA BAK ****
        {
            // Önce UI'daki ComboBox'lardan gelen verilerin geçerli ve dolu olup olmadığını kontrol ediyoruz.
            // && (VE) operatörü ile her iki seçimin de başarılı bir şekilde int (sayı) dönmesini şart koşuyoruz.
            if (cmbChooseBook.SelectedValue is int bookId && cmbChooseMember.SelectedValue is int memberId)
            {
                // Seçimler sorunsuzsa veritabanı işlemlerine başlıyoruz
                using (Context db = new Context())
                {
                    // 1. ADIM: Yeni bir İşlem (Process) kaydı oluşturuyoruz
                    Process newProcess = new Process();

                    // EKSİK OLAN KONTROL BURAYA EKLENDİ:
                    // Veritabanından o kitabı buluyoruz ki durumuna bakalım
                    var currentBook = db.Books.Find(bookId);

                    // Eğer kitap bulunduysa VE şu an zaten başkasındaysa (IsBorrowed == true)
                    if (currentBook != null && currentBook.IsBorrowed == true)
                    {
                        // Kullanıcıya uyarı verip işlemi burada kesiyoruz (return)
                        MessageBox.Show("Bu kitap şu an başka bir üyede. İade edilmeden tekrar verilemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Aşağıdaki kayıt adımlarına geçmesini engeller.
                    }

                    // Artık null kontrolünden geçtiğimiz için bookId ve memberId değişkenlerini güvenle kullanabiliriz
                    newProcess.BookID = bookId;
                    newProcess.MemberID = memberId;
                    newProcess.StartDate = dtpStart.Value;
                    newProcess.EndDate = dtpEnd.Value;
                    newProcess.IsReturned = false;   // Kitap yeni verildiği için henüz iade edilmedi

                    //İşlemi context e ekliyoruz
                    db.Processes.Add(newProcess);


                    // 2. ADIM: Kitabın durumunu "Ödünç Alındı" (IsBorrowed = true) olarak güncelliyoruz
                    // Yukarıda güvenle elde ettiğimiz bookId'yi kullanıyoruz
                    var borrowedBook = db.Books.Find(bookId);    // Veritabanından o kitabı buluyoruz

                    if (borrowedBook != null)
                    {
                        borrowedBook.IsBorrowed = true;  //Kitabın durumu güncellendi
                    }
                    db.SaveChanges();
                    MessageBox.Show("Kitap başarıyla ödünç verildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvProcessList.DataSource = db.Processes.ToList();
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir kitap ve üye seçtiğinizden emin olun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (cmbChooseBook.SelectedValue is int bookId)
            {
                using Context db = new Context();
                {
                    // 1. ADIM: Aktif İşlemi Bulma
                    // LINQ kullanarak bu kitabın ID'sine sahip ve IsReturned durumu 'false' olan kaydı getiriyoruz.
                    var activeProcess = db.Processes.FirstOrDefault(x => x.BookID == bookId && x.IsReturned == false);

                    // 2. ADIM: Kitabın kendisini bulma
                    var returnedBook = db.Books.Find(bookId);

                    // Eğer veritabanında bu kitaba ait aktif bir ödünç alma işlemi varsa işlemlere başla
                    if (returnedBook != null && returnedBook != null)
                    {
                        // İşlem (Process) tablosunu güncelle
                        activeProcess!.IsReturned = true;

                        // Kitap (Book) tablosunu güncelle (Artık ödünçte değil, başkası alabilir)
                        returnedBook.IsBorrowed = false;
                        db.SaveChanges();
                        MessageBox.Show("Kitap başarıyla geri alındı ve rafa eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvProcessList.DataSource = db.Processes.ToList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Bu kitabın aktif bir ödünç kaydı bulunamadı. Zaten iade edilmiş olabilir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chbIsReturned_CheckedChanged(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                // CheckBox işaretlendiyse (True ise)
                if (chbIsReturned.Checked)
                {
                    // Sadece iade edilmiş olanları (IsReturned == true) filtrele ve DataGridView'a yansıt
                    dgvProcessList.DataSource = db.Processes.Where(x => x.IsReturned == true).ToList();
                }
                else
                {
                    // Filtreyi kaldır ve sistemdeki tüm işlemleri tekrar listele
                    dgvProcessList.DataSource = db.Processes.ToList();
                }
            }
        }
    }
}
