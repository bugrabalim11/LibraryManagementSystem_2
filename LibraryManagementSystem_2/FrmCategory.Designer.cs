namespace LibraryManagementSystem_2
{
    partial class FrmCategory
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
            label1 = new Label();
            txtCategoryId = new TextBox();
            txtCategoryName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            btnList = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(26, 97);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 24);
            label1.TabIndex = 0;
            label1.Text = "Kategori ID:";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtCategoryId.Location = new Point(143, 97);
            txtCategoryId.Margin = new Padding(4);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(155, 32);
            txtCategoryId.TabIndex = 1;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtCategoryName.Location = new Point(143, 161);
            txtCategoryName.Margin = new Padding(4);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(155, 32);
            txtCategoryName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(16, 161);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 24);
            label2.TabIndex = 2;
            label2.Text = "Kategori Adı:";
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
            label3.Size = new Size(139, 24);
            label3.TabIndex = 5;
            label3.Text = "Kategori Formu";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-2, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 48);
            panel1.TabIndex = 6;
            // 
            // btnList
            // 
            btnList.BackColor = SystemColors.Info;
            btnList.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnList.ForeColor = Color.Black;
            btnList.Location = new Point(517, 97);
            btnList.Margin = new Padding(4);
            btnList.Name = "btnList";
            btnList.Size = new Size(118, 50);
            btnList.TabIndex = 7;
            btnList.Text = "Listele";
            btnList.UseVisualStyleBackColor = false;
            btnList.Click += btnList_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Info;
            btnSave.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.ForeColor = SystemColors.InactiveCaptionText;
            btnSave.Location = new Point(354, 97);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 50);
            btnSave.TabIndex = 8;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Info;
            btnDelete.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(354, 161);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 50);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Info;
            btnUpdate.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(517, 161);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 50);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-2, 251);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1002, 290);
            dataGridView1.TabIndex = 11;
            // 
            // FrmCategory
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(999, 540);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnList);
            Controls.Add(panel1);
            Controls.Add(txtCategoryName);
            Controls.Add(label2);
            Controls.Add(txtCategoryId);
            Controls.Add(label1);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = SystemColors.ControlDarkDark;
            Margin = new Padding(4);
            Name = "FrmCategory";
            Text = "FrmCategory";
            Load += FrmCategory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCategoryId;
        private TextBox txtCategoryName;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Button btnList;
        private Button btnSave;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView dataGridView1;
    }
}