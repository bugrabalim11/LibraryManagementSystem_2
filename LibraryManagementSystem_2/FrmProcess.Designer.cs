namespace LibraryManagementSystem_2
{
    partial class FrmProcess
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
            cmbChooseBook = new ComboBox();
            cmbChooseMember = new ComboBox();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            chbIsReturned = new CheckBox();
            btnReturn = new Button();
            btnLend = new Button();
            dgvProcessList = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProcessList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, -1);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1215, 48);
            panel1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(13, 10);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 24);
            label3.TabIndex = 5;
            label3.Text = "İşlem Formu";
            // 
            // cmbChooseBook
            // 
            cmbChooseBook.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbChooseBook.FormattingEnabled = true;
            cmbChooseBook.Location = new Point(111, 67);
            cmbChooseBook.Name = "cmbChooseBook";
            cmbChooseBook.Size = new Size(151, 32);
            cmbChooseBook.TabIndex = 10;
            // 
            // cmbChooseMember
            // 
            cmbChooseMember.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbChooseMember.FormattingEnabled = true;
            cmbChooseMember.Location = new Point(111, 105);
            cmbChooseMember.Name = "cmbChooseMember";
            cmbChooseMember.Size = new Size(151, 32);
            cmbChooseMember.TabIndex = 11;
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(451, 75);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(250, 32);
            dtpStart.TabIndex = 12;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(451, 116);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(250, 32);
            dtpEnd.TabIndex = 13;
            // 
            // chbIsReturned
            // 
            chbIsReturned.AutoSize = true;
            chbIsReturned.Location = new Point(777, 124);
            chbIsReturned.Name = "chbIsReturned";
            chbIsReturned.Size = new Size(150, 28);
            chbIsReturned.TabIndex = 14;
            chbIsReturned.Text = "İade Edilenler.";
            chbIsReturned.UseVisualStyleBackColor = true;
            chbIsReturned.CheckedChanged += chbIsReturned_CheckedChanged;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = SystemColors.Info;
            btnReturn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnReturn.ForeColor = Color.Black;
            btnReturn.Location = new Point(867, 67);
            btnReturn.Margin = new Padding(4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(118, 50);
            btnReturn.TabIndex = 20;
            btnReturn.Text = "İade Et";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnLend
            // 
            btnLend.BackColor = SystemColors.Info;
            btnLend.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnLend.ForeColor = SystemColors.InactiveCaptionText;
            btnLend.Location = new Point(722, 67);
            btnLend.Margin = new Padding(4);
            btnLend.Name = "btnLend";
            btnLend.Size = new Size(118, 50);
            btnLend.TabIndex = 19;
            btnLend.Text = "Ödünç Ver";
            btnLend.UseVisualStyleBackColor = false;
            btnLend.Click += btnLend_Click;
            // 
            // dgvProcessList
            // 
            dgvProcessList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProcessList.Location = new Point(0, 181);
            dgvProcessList.Name = "dgvProcessList";
            dgvProcessList.RowHeadersWidth = 51;
            dgvProcessList.Size = new Size(1118, 360);
            dgvProcessList.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 67);
            label1.Name = "label1";
            label1.Size = new Size(92, 24);
            label1.TabIndex = 23;
            label1.Text = "Kitap Seç:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 102);
            label2.Name = "label2";
            label2.Size = new Size(80, 24);
            label2.TabIndex = 24;
            label2.Text = "Üye Seç:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(289, 75);
            label4.Name = "label4";
            label4.Size = new Size(144, 24);
            label4.TabIndex = 25;
            label4.Text = "Başlangıç Tarihi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(330, 113);
            label5.Name = "label5";
            label5.Size = new Size(103, 24);
            label5.TabIndex = 26;
            label5.Text = "Bitiş Tarihi:";
            // 
            // FrmProcess
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1118, 540);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvProcessList);
            Controls.Add(btnReturn);
            Controls.Add(btnLend);
            Controls.Add(chbIsReturned);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(cmbChooseMember);
            Controls.Add(cmbChooseBook);
            Controls.Add(panel1);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FrmProcess";
            Text = "FrmProcess";
            Load += FrmProcess_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProcessList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private ComboBox cmbChooseBook;
        private ComboBox cmbChooseMember;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private CheckBox chbIsReturned;
        private Button btnReturn;
        private Button btnLend;
        private DataGridView dgvProcessList;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
    }
}