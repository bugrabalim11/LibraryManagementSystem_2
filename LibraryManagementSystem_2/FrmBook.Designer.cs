namespace LibraryManagementSystem_2
{
    partial class FrmBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label3 = new Label();
            cmbAuthor = new ComboBox();
            cmbCategory = new ComboBox();
            nudPageCount = new NumericUpDown();
            btnSave = new Button();
            dgvBooks = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            chkIsBorrowed = new CheckBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            LBL = new Label();
            txtBookID = new TextBox();
            txtBookName = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPageCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1272, 48);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(18, 11);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 24);
            label3.TabIndex = 5;
            label3.Text = "Kitap Formu";
            // 
            // cmbAuthor
            // 
            cmbAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAuthor.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cmbAuthor.FormattingEnabled = true;
            cmbAuthor.Location = new Point(197, 164);
            cmbAuthor.Name = "cmbAuthor";
            cmbAuthor.Size = new Size(151, 32);
            cmbAuthor.TabIndex = 10;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(197, 214);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 32);
            cmbCategory.TabIndex = 11;
            // 
            // nudPageCount
            // 
            nudPageCount.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            nudPageCount.Location = new Point(197, 273);
            nudPageCount.Margin = new Padding(4);
            nudPageCount.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudPageCount.Name = "nudPageCount";
            nudPageCount.Size = new Size(188, 32);
            nudPageCount.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Info;
            btnSave.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.Location = new Point(197, 384);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(151, 41);
            btnSave.TabIndex = 13;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(392, 89);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(870, 425);
            dgvBooks.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(93, 116);
            label1.Name = "label1";
            label1.Size = new Size(99, 24);
            label1.TabIndex = 15;
            label1.Text = "Kitap İsmi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(70, 167);
            label2.Name = "label2";
            label2.Size = new Size(121, 24);
            label2.TabIndex = 16;
            label2.Text = "Yazar Seçiniz:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(45, 217);
            label4.Name = "label4";
            label4.Size = new Size(147, 24);
            label4.TabIndex = 17;
            label4.Text = "Kategori Seçiniz:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(5, 273);
            label5.Name = "label5";
            label5.Size = new Size(186, 24);
            label5.TabIndex = 18;
            label5.Text = "Sayfa Sayısını Giriniz:";
            // 
            // chkIsBorrowed
            // 
            chkIsBorrowed.AutoSize = true;
            chkIsBorrowed.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            chkIsBorrowed.Location = new Point(197, 336);
            chkIsBorrowed.Name = "chkIsBorrowed";
            chkIsBorrowed.Size = new Size(144, 28);
            chkIsBorrowed.TabIndex = 19;
            chkIsBorrowed.Text = "Ödünç verildi";
            chkIsBorrowed.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Info;
            btnUpdate.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUpdate.Location = new Point(197, 431);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(151, 41);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Info;
            btnDelete.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.Location = new Point(197, 478);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 41);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // LBL
            // 
            LBL.AutoSize = true;
            LBL.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LBL.Location = new Point(93, 64);
            LBL.Name = "LBL";
            LBL.Size = new Size(83, 24);
            LBL.TabIndex = 23;
            LBL.Text = "Kitap ID:";
            // 
            // txtBookID
            // 
            txtBookID.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtBookID.Location = new Point(197, 64);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(125, 32);
            txtBookID.TabIndex = 22;
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtBookName.Location = new Point(197, 116);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(125, 32);
            txtBookName.TabIndex = 24;
            // 
            // FrmBook
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1265, 540);
            Controls.Add(txtBookName);
            Controls.Add(LBL);
            Controls.Add(txtBookID);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(chkIsBorrowed);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvBooks);
            Controls.Add(btnSave);
            Controls.Add(nudPageCount);
            Controls.Add(cmbCategory);
            Controls.Add(cmbAuthor);
            Controls.Add(panel1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FrmBook";
            Text = "FrmBook";
            Load += FrmBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPageCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private ComboBox cmbAuthor;
        private ComboBox cmbCategory;
        private NumericUpDown nudPageCount;
        private Button btnSave;
        private DataGridView dgvBooks;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private CheckBox chkIsBorrowed;
        private Button btnUpdate;
        private Button btnDelete;
        private Label LBL;
        private TextBox txtBookID;
        private TextBox txtBookName;
    }
}