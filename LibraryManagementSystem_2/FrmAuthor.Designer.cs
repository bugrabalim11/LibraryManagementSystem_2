namespace LibraryManagementSystem_2
{
    partial class FrmAuthor
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
            label1 = new Label();
            txtAuthorID = new TextBox();
            txtAuthorName = new TextBox();
            label2 = new Label();
            txtAuthorSurname = new TextBox();
            label4 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnList = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 48);
            panel1.TabIndex = 7;
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
            label3.Text = "Yazar Formu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 99);
            label1.Name = "label1";
            label1.Size = new Size(83, 24);
            label1.TabIndex = 8;
            label1.Text = "Yazar ID:";
            // 
            // txtAuthorID
            // 
            txtAuthorID.Location = new Point(144, 99);
            txtAuthorID.Name = "txtAuthorID";
            txtAuthorID.Size = new Size(125, 32);
            txtAuthorID.TabIndex = 9;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(144, 152);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(125, 32);
            txtAuthorName.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 152);
            label2.Name = "label2";
            label2.Size = new Size(93, 24);
            label2.TabIndex = 10;
            label2.Text = "Yazar Adı:";
            // 
            // txtAuthorSurname
            // 
            txtAuthorSurname.Location = new Point(144, 202);
            txtAuthorSurname.Name = "txtAuthorSurname";
            txtAuthorSurname.Size = new Size(125, 32);
            txtAuthorSurname.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 202);
            label4.Name = "label4";
            label4.Size = new Size(120, 24);
            label4.TabIndex = 12;
            label4.Text = "Yazar Soyadı:";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Info;
            btnUpdate.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(523, 163);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 50);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Info;
            btnDelete.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(360, 163);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 50);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Info;
            btnAdd.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.ForeColor = SystemColors.InactiveCaptionText;
            btnAdd.Location = new Point(360, 99);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 50);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnList
            // 
            btnList.BackColor = SystemColors.Info;
            btnList.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnList.ForeColor = Color.Black;
            btnList.Location = new Point(523, 99);
            btnList.Margin = new Padding(4);
            btnList.Name = "btnList";
            btnList.Size = new Size(118, 50);
            btnList.TabIndex = 14;
            btnList.Text = "Listele";
            btnList.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 270);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1002, 274);
            dataGridView1.TabIndex = 18;
            // 
            // FrmAuthor
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1000, 540);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnList);
            Controls.Add(txtAuthorSurname);
            Controls.Add(label4);
            Controls.Add(txtAuthorName);
            Controls.Add(label2);
            Controls.Add(txtAuthorID);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FrmAuthor";
            Text = "FrmAuthor";
            Load += FrmAuthor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label1;
        private TextBox txtAuthorID;
        private TextBox txtAuthorName;
        private Label label2;
        private TextBox txtAuthorSurname;
        private Label label4;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnList;
        private DataGridView dataGridView1;
    }
}