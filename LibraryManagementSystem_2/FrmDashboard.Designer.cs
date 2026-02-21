namespace LibraryManagementSystem_2
{
    partial class FrmDashboard
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
            pnlSlideBar = new Panel();
            btnDashboard = new Button();
            btnProcesses = new Button();
            btnAuthors = new Button();
            btnCategories = new Button();
            btnBooks = new Button();
            btnMembers = new Button();
            pnlContent = new Panel();
            pnlSlideBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSlideBar
            // 
            pnlSlideBar.BackColor = Color.FromArgb(127, 143, 166);
            pnlSlideBar.Controls.Add(btnDashboard);
            pnlSlideBar.Controls.Add(btnProcesses);
            pnlSlideBar.Controls.Add(btnAuthors);
            pnlSlideBar.Controls.Add(btnCategories);
            pnlSlideBar.Controls.Add(btnBooks);
            pnlSlideBar.Controls.Add(btnMembers);
            pnlSlideBar.Dock = DockStyle.Left;
            pnlSlideBar.Location = new Point(0, 0);
            pnlSlideBar.Name = "pnlSlideBar";
            pnlSlideBar.Size = new Size(248, 698);
            pnlSlideBar.TabIndex = 10;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = SystemColors.GradientActiveCaption;
            btnDashboard.Location = new Point(60, 436);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(150, 57);
            btnDashboard.TabIndex = 5;
            btnDashboard.Text = "Gösterge Paneli";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnProcesses
            // 
            btnProcesses.BackColor = SystemColors.GradientActiveCaption;
            btnProcesses.Location = new Point(60, 356);
            btnProcesses.Name = "btnProcesses";
            btnProcesses.Size = new Size(150, 57);
            btnProcesses.TabIndex = 4;
            btnProcesses.Text = "İşlemler";
            btnProcesses.UseVisualStyleBackColor = false;
            btnProcesses.Click += btnProcesses_Click;
            // 
            // btnAuthors
            // 
            btnAuthors.BackColor = SystemColors.GradientActiveCaption;
            btnAuthors.Location = new Point(60, 269);
            btnAuthors.Name = "btnAuthors";
            btnAuthors.Size = new Size(150, 57);
            btnAuthors.TabIndex = 3;
            btnAuthors.Text = "Yazarlar";
            btnAuthors.UseVisualStyleBackColor = false;
            btnAuthors.Click += btnAuthors_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = SystemColors.GradientActiveCaption;
            btnCategories.Location = new Point(60, 187);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(150, 57);
            btnCategories.TabIndex = 2;
            btnCategories.Text = "Kategoriler";
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnBooks
            // 
            btnBooks.BackColor = SystemColors.GradientActiveCaption;
            btnBooks.Location = new Point(60, 105);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(150, 57);
            btnBooks.TabIndex = 1;
            btnBooks.Text = "Kitaplar";
            btnBooks.UseVisualStyleBackColor = false;
            btnBooks.Click += btnBooks_Click;
            // 
            // btnMembers
            // 
            btnMembers.BackColor = SystemColors.GradientActiveCaption;
            btnMembers.Location = new Point(60, 36);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(150, 57);
            btnMembers.TabIndex = 0;
            btnMembers.Text = "Üyeler";
            btnMembers.UseVisualStyleBackColor = false;
            btnMembers.Click += btnMembers_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(64, 115, 158);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(248, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1036, 698);
            pnlContent.TabIndex = 11;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 698);
            Controls.Add(pnlContent);
            Controls.Add(pnlSlideBar);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FrmDashboard";
            Text = "FrmDashboard";
            Load += FrmDashboard_Load;
            pnlSlideBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSlideBar;
        private Panel pnlContent;
        private Button btnDashboard;
        private Button btnProcesses;
        private Button btnAuthors;
        private Button btnCategories;
        private Button btnBooks;
        private Button btnMembers;
    }
}