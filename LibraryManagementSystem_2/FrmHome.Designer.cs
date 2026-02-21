namespace LibraryManagementSystem_2
{
    partial class FrmHome
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
            label5 = new Label();
            dgvRecentTransactions = new DataGridView();
            pnlOverdueBooks = new Panel();
            label4 = new Label();
            lblOverdueBooksCount = new Label();
            pnlTotalMembers = new Panel();
            label3 = new Label();
            lblTotalMembersCount = new Label();
            pnlBorrowedBooks = new Panel();
            label2 = new Label();
            lblBorrowedBooksCount = new Label();
            pnlTotalBooks = new Panel();
            label1 = new Label();
            lblTotalBooksCount = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRecentTransactions).BeginInit();
            pnlOverdueBooks.SuspendLayout();
            pnlTotalMembers.SuspendLayout();
            pnlBorrowedBooks.SuspendLayout();
            pnlTotalBooks.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 178);
            label5.Name = "label5";
            label5.Size = new Size(105, 24);
            label5.TabIndex = 11;
            label5.Text = "Son 5 İşlem";
            // 
            // dgvRecentTransactions
            // 
            dgvRecentTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentTransactions.Location = new Point(12, 205);
            dgvRecentTransactions.Name = "dgvRecentTransactions";
            dgvRecentTransactions.RowHeadersWidth = 51;
            dgvRecentTransactions.Size = new Size(1024, 473);
            dgvRecentTransactions.TabIndex = 10;
            // 
            // pnlOverdueBooks
            // 
            pnlOverdueBooks.BackColor = Color.FromArgb(192, 0, 0);
            pnlOverdueBooks.Controls.Add(label4);
            pnlOverdueBooks.Controls.Add(lblOverdueBooksCount);
            pnlOverdueBooks.Location = new Point(783, 17);
            pnlOverdueBooks.Name = "pnlOverdueBooks";
            pnlOverdueBooks.Size = new Size(250, 125);
            pnlOverdueBooks.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 16);
            label4.Name = "label4";
            label4.Size = new Size(104, 24);
            label4.TabIndex = 4;
            label4.Text = "Gecikenler:";
            // 
            // lblOverdueBooksCount
            // 
            lblOverdueBooksCount.AutoSize = true;
            lblOverdueBooksCount.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOverdueBooksCount.Location = new Point(3, 63);
            lblOverdueBooksCount.Name = "lblOverdueBooksCount";
            lblOverdueBooksCount.Size = new Size(160, 41);
            lblOverdueBooksCount.TabIndex = 4;
            lblOverdueBooksCount.Text = "gecikenler";
            // 
            // pnlTotalMembers
            // 
            pnlTotalMembers.BackColor = Color.FromArgb(255, 128, 0);
            pnlTotalMembers.Controls.Add(label3);
            pnlTotalMembers.Controls.Add(lblTotalMembersCount);
            pnlTotalMembers.Location = new Point(530, 17);
            pnlTotalMembers.Name = "pnlTotalMembers";
            pnlTotalMembers.Size = new Size(250, 125);
            pnlTotalMembers.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 16);
            label3.Name = "label3";
            label3.Size = new Size(114, 24);
            label3.TabIndex = 4;
            label3.Text = "Toplam Üye:";
            // 
            // lblTotalMembersCount
            // 
            lblTotalMembersCount.AutoSize = true;
            lblTotalMembersCount.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTotalMembersCount.Location = new Point(4, 52);
            lblTotalMembersCount.Name = "lblTotalMembersCount";
            lblTotalMembersCount.Size = new Size(170, 41);
            lblTotalMembersCount.TabIndex = 2;
            lblTotalMembersCount.Text = "toplamüye";
            // 
            // pnlBorrowedBooks
            // 
            pnlBorrowedBooks.BackColor = Color.FromArgb(0, 192, 0);
            pnlBorrowedBooks.Controls.Add(label2);
            pnlBorrowedBooks.Controls.Add(lblBorrowedBooksCount);
            pnlBorrowedBooks.Location = new Point(274, 16);
            pnlBorrowedBooks.Name = "pnlBorrowedBooks";
            pnlBorrowedBooks.Size = new Size(250, 125);
            pnlBorrowedBooks.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 10);
            label2.Name = "label2";
            label2.Size = new Size(125, 24);
            label2.TabIndex = 2;
            label2.Text = "Ödünçtekiler:";
            // 
            // lblBorrowedBooksCount
            // 
            lblBorrowedBooksCount.AutoSize = true;
            lblBorrowedBooksCount.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBorrowedBooksCount.Location = new Point(16, 66);
            lblBorrowedBooksCount.Name = "lblBorrowedBooksCount";
            lblBorrowedBooksCount.Size = new Size(194, 41);
            lblBorrowedBooksCount.TabIndex = 1;
            lblBorrowedBooksCount.Text = "ödünçtekiler";
            // 
            // pnlTotalBooks
            // 
            pnlTotalBooks.BackColor = Color.FromArgb(0, 0, 192);
            pnlTotalBooks.Controls.Add(label1);
            pnlTotalBooks.Controls.Add(lblTotalBooksCount);
            pnlTotalBooks.Location = new Point(18, 16);
            pnlTotalBooks.Name = "pnlTotalBooks";
            pnlTotalBooks.Size = new Size(250, 125);
            pnlTotalBooks.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 10);
            label1.Name = "label1";
            label1.Size = new Size(126, 24);
            label1.TabIndex = 1;
            label1.Text = "Toplam Kitap:";
            // 
            // lblTotalBooksCount
            // 
            lblTotalBooksCount.AutoSize = true;
            lblTotalBooksCount.Font = new Font("Calibri", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTotalBooksCount.Location = new Point(4, 62);
            lblTotalBooksCount.Name = "lblTotalBooksCount";
            lblTotalBooksCount.Size = new Size(208, 45);
            lblTotalBooksCount.TabIndex = 0;
            lblTotalBooksCount.Text = "toplamkitap";
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 115, 158);
            ClientSize = new Size(1058, 678);
            Controls.Add(label5);
            Controls.Add(dgvRecentTransactions);
            Controls.Add(pnlOverdueBooks);
            Controls.Add(pnlTotalMembers);
            Controls.Add(pnlBorrowedBooks);
            Controls.Add(pnlTotalBooks);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmHome";
            Text = "FrmHome";
            Load += FrmHome_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecentTransactions).EndInit();
            pnlOverdueBooks.ResumeLayout(false);
            pnlOverdueBooks.PerformLayout();
            pnlTotalMembers.ResumeLayout(false);
            pnlTotalMembers.PerformLayout();
            pnlBorrowedBooks.ResumeLayout(false);
            pnlBorrowedBooks.PerformLayout();
            pnlTotalBooks.ResumeLayout(false);
            pnlTotalBooks.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DataGridView dgvRecentTransactions;
        private Panel pnlOverdueBooks;
        private Label label4;
        private Label lblOverdueBooksCount;
        private Panel pnlTotalMembers;
        private Label label3;
        private Label lblTotalMembersCount;
        private Panel pnlBorrowedBooks;
        private Label label2;
        private Label lblBorrowedBooksCount;
        private Panel pnlTotalBooks;
        private Label label1;
        private Label lblTotalBooksCount;
    }
}