namespace LibraryManagementSystem_2
{
    partial class FrmMember
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
            txtMemberID = new TextBox();
            label1 = new Label();
            txtMemberName = new TextBox();
            label2 = new Label();
            txtMemberSurname = new TextBox();
            label4 = new Label();
            txtMemberEmail = new TextBox();
            label5 = new Label();
            txtMemberPhone = new TextBox();
            label6 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
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
            panel1.Size = new Size(1106, 48);
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
            label3.Size = new Size(101, 24);
            label3.TabIndex = 5;
            label3.Text = "Üye Formu";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(147, 75);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(125, 32);
            txtMemberID.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 75);
            label1.Name = "label1";
            label1.Size = new Size(71, 24);
            label1.TabIndex = 10;
            label1.Text = "Üye ID:";
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(147, 124);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(125, 32);
            txtMemberName.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 124);
            label2.Name = "label2";
            label2.Size = new Size(81, 24);
            label2.TabIndex = 12;
            label2.Text = "Üye Adı:";
            // 
            // txtMemberSurname
            // 
            txtMemberSurname.Location = new Point(147, 171);
            txtMemberSurname.Name = "txtMemberSurname";
            txtMemberSurname.Size = new Size(125, 32);
            txtMemberSurname.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 171);
            label4.Name = "label4";
            label4.Size = new Size(108, 24);
            label4.TabIndex = 14;
            label4.Text = "Üye Soyadı:";
            // 
            // txtMemberEmail
            // 
            txtMemberEmail.Location = new Point(147, 224);
            txtMemberEmail.Name = "txtMemberEmail";
            txtMemberEmail.Size = new Size(125, 32);
            txtMemberEmail.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 224);
            label5.Name = "label5";
            label5.Size = new Size(129, 24);
            label5.TabIndex = 16;
            label5.Text = "Üye E-postası:";
            // 
            // txtMemberPhone
            // 
            txtMemberPhone.Location = new Point(147, 279);
            txtMemberPhone.Name = "txtMemberPhone";
            txtMemberPhone.Size = new Size(125, 32);
            txtMemberPhone.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 279);
            label6.Name = "label6";
            label6.Size = new Size(133, 24);
            label6.TabIndex = 18;
            label6.Text = "Üye Numarası:";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Info;
            btnUpdate.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(147, 396);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 50);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Info;
            btnDelete.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(147, 454);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 50);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Info;
            btnAdd.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.ForeColor = SystemColors.InactiveCaptionText;
            btnAdd.Location = new Point(147, 338);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 50);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(279, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(827, 453);
            dataGridView1.TabIndex = 24;
            // 
            // FrmMember
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1105, 540);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtMemberPhone);
            Controls.Add(label6);
            Controls.Add(txtMemberEmail);
            Controls.Add(label5);
            Controls.Add(txtMemberSurname);
            Controls.Add(label4);
            Controls.Add(txtMemberName);
            Controls.Add(label2);
            Controls.Add(txtMemberID);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "FrmMember";
            Text = "FrmMember";
            Load += FrmMember_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private TextBox txtMemberID;
        private Label label1;
        private TextBox txtMemberName;
        private Label label2;
        private TextBox txtMemberSurname;
        private Label label4;
        private TextBox txtMemberEmail;
        private Label label5;
        private TextBox txtMemberPhone;
        private Label label6;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dataGridView1;
    }
}