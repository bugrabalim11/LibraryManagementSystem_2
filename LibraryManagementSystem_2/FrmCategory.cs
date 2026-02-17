
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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        Context db = new Context();

        void Listele()  // Listeleme Metodu
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            Listele(); //Form açılınca listeleme metodunu çağırıyoruz
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCategoryName.Text))
            {
                Category category = new Category();  // Yeni kategori nesensi // yeni veri eklediğimiz için yeni nesneye ihtiyacımız var
                category.CategoryName = txtCategoryName.Text;  // Kullanıcının girdiği ismi bu nesneye atıyoruz
                db.Categories.Add(category);   // Veri tababnına ekledik
                db.SaveChanges();
                MessageBox.Show("Kaydetme işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            else
            {
                MessageBox.Show("Kaydetme işlemi başarısız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);     // Senin textbox adın txtId ise bunu kullan
            var deletedValue = db.Categories.Find(id);
            if (deletedValue != null)
            {
                db.Categories.Remove(deletedValue);
                db.SaveChanges();
                MessageBox.Show("Silme işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            else
            {
                MessageBox.Show("ID bulunamdı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtCategoryId.Text);
            var updatedValues = db.Categories.Find(id);    // Yeni ismi atadık
            if (updatedValues != null)
            {
                updatedValues.CategoryName = txtCategoryName.Text;     // Yeni ismi atadık
                db.SaveChanges();
                MessageBox.Show("Güncelleme işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            else
            {
                MessageBox.Show("Güncellem işlemi başarısız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
