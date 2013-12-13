namespace LINQ_Project__mittegna_
{
    partial class AuthorBook
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
            this.components = new System.ComponentModel.Container();
            this.AuthorBS = new System.Windows.Forms.BindingSource(this.components);
            this.AuthorsNBooks = new System.Windows.Forms.TabControl();
            this.AuthorsNBooksTab = new System.Windows.Forms.TabPage();
            this.AuthorClearBtn = new System.Windows.Forms.Button();
            this.AuthorSearchBtn = new System.Windows.Forms.Button();
            this.AuthorSearchTbx = new System.Windows.Forms.TextBox();
            this.AuthorRemoveBtn = new System.Windows.Forms.Button();
            this.AuthorChangeBtn = new System.Windows.Forms.Button();
            this.AuthorSaveBtn = new System.Windows.Forms.Button();
            this.AuthorGenreLbl = new System.Windows.Forms.Label();
            this.AuthorStartYearLbl = new System.Windows.Forms.Label();
            this.AuthorHomeTownLbl = new System.Windows.Forms.Label();
            this.AuthorAgeLbl = new System.Windows.Forms.Label();
            this.AuthorNameLbl = new System.Windows.Forms.Label();
            this.AuthorGenreTbx = new System.Windows.Forms.TextBox();
            this.AuthorStartYearTbx = new System.Windows.Forms.TextBox();
            this.AuthorAgeTbx = new System.Windows.Forms.TextBox();
            this.AuthorHomeTownTbx = new System.Windows.Forms.TextBox();
            this.AuthorNameTbx = new System.Windows.Forms.TextBox();
            this.AuthorDGV = new System.Windows.Forms.DataGridView();
            this.AuthorsNBooksTab2 = new System.Windows.Forms.TabPage();
            this.BooksAuthorNameCbx = new System.Windows.Forms.ComboBox();
            this.BooksClearBtn = new System.Windows.Forms.Button();
            this.BooksSearchBtn = new System.Windows.Forms.Button();
            this.BooksSrchTbx = new System.Windows.Forms.TextBox();
            this.BooksRemoveBtn = new System.Windows.Forms.Button();
            this.BooksChangeBtn = new System.Windows.Forms.Button();
            this.BooksSaveBtn = new System.Windows.Forms.Button();
            this.BooksReleaseYearLbl = new System.Windows.Forms.Label();
            this.BooksLanguageLbl = new System.Windows.Forms.Label();
            this.BooksBookNameLbl = new System.Windows.Forms.Label();
            this.BooksAuthorNameLbl = new System.Windows.Forms.Label();
            this.BooksReleaseYearTbx = new System.Windows.Forms.TextBox();
            this.BooksBookNameTbx = new System.Windows.Forms.TextBox();
            this.BooksLanguageTbx = new System.Windows.Forms.TextBox();
            this.BooksDGV = new System.Windows.Forms.DataGridView();
            this.BooksBS = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AuthorBS)).BeginInit();
            this.AuthorsNBooks.SuspendLayout();
            this.AuthorsNBooksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorDGV)).BeginInit();
            this.AuthorsNBooksTab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksBS)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthorsNBooks
            // 
            this.AuthorsNBooks.Controls.Add(this.AuthorsNBooksTab);
            this.AuthorsNBooks.Controls.Add(this.AuthorsNBooksTab2);
            this.AuthorsNBooks.Location = new System.Drawing.Point(1, 0);
            this.AuthorsNBooks.Name = "AuthorsNBooks";
            this.AuthorsNBooks.SelectedIndex = 0;
            this.AuthorsNBooks.Size = new System.Drawing.Size(675, 410);
            this.AuthorsNBooks.TabIndex = 0;
            // 
            // AuthorsNBooksTab
            // 
            this.AuthorsNBooksTab.Controls.Add(this.AuthorClearBtn);
            this.AuthorsNBooksTab.Controls.Add(this.AuthorSearchBtn);
            this.AuthorsNBooksTab.Controls.Add(this.AuthorSearchTbx);
            this.AuthorsNBooksTab.Controls.Add(this.AuthorRemoveBtn);
            this.AuthorsNBooksTab.Controls.Add(this.AuthorChangeBtn);
            this.AuthorsNBooksTab.Controls.Add(this.AuthorSaveBtn);
            this.AuthorsNBooksTab.Controls.Add(this.AuthorGenreLbl);
            this.AuthorsNBooksTab.Controls.Add(this.AuthorStartYearLbl);
            this.AuthorsNBooksTab.Controls.Add(this.AuthorHomeTownLbl);
            this.AuthorsNBooksTab.Controls.Add(this.AuthorAgeLbl);
            this.AuthorsNBooksTab.Controls.Add(this.AuthorNameLbl);
            this.AuthorsNBooksTab.Controls.Add(this.AuthorGenreTbx);
            this.AuthorsNBooksTab.Controls.Add(this.AuthorStartYearTbx);
            this.AuthorsNBooksTab.Controls.Add(this.AuthorAgeTbx);
            this.AuthorsNBooksTab.Controls.Add(this.AuthorHomeTownTbx);
            this.AuthorsNBooksTab.Controls.Add(this.AuthorNameTbx);
            this.AuthorsNBooksTab.Controls.Add(this.AuthorDGV);
            this.AuthorsNBooksTab.Location = new System.Drawing.Point(4, 22);
            this.AuthorsNBooksTab.Name = "AuthorsNBooksTab";
            this.AuthorsNBooksTab.Padding = new System.Windows.Forms.Padding(3);
            this.AuthorsNBooksTab.Size = new System.Drawing.Size(667, 384);
            this.AuthorsNBooksTab.TabIndex = 0;
            this.AuthorsNBooksTab.Text = "Author";
            this.AuthorsNBooksTab.UseVisualStyleBackColor = true;
            // 
            // AuthorClearBtn
            // 
            this.AuthorClearBtn.Location = new System.Drawing.Point(583, 19);
            this.AuthorClearBtn.Name = "AuthorClearBtn";
            this.AuthorClearBtn.Size = new System.Drawing.Size(75, 23);
            this.AuthorClearBtn.TabIndex = 33;
            this.AuthorClearBtn.Text = "Clear";
            this.AuthorClearBtn.UseVisualStyleBackColor = true;
            this.AuthorClearBtn.Click += new System.EventHandler(this.AuthorClearBtn_Click);
            // 
            // AuthorSearchBtn
            // 
            this.AuthorSearchBtn.Location = new System.Drawing.Point(502, 19);
            this.AuthorSearchBtn.Name = "AuthorSearchBtn";
            this.AuthorSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.AuthorSearchBtn.TabIndex = 32;
            this.AuthorSearchBtn.Text = "Search";
            this.AuthorSearchBtn.UseVisualStyleBackColor = true;
            this.AuthorSearchBtn.Click += new System.EventHandler(this.AuthorSearchBtn_Click);
            // 
            // AuthorSearchTbx
            // 
            this.AuthorSearchTbx.Location = new System.Drawing.Point(339, 21);
            this.AuthorSearchTbx.Name = "AuthorSearchTbx";
            this.AuthorSearchTbx.Size = new System.Drawing.Size(157, 20);
            this.AuthorSearchTbx.TabIndex = 31;
            // 
            // AuthorRemoveBtn
            // 
            this.AuthorRemoveBtn.Location = new System.Drawing.Point(583, 354);
            this.AuthorRemoveBtn.Name = "AuthorRemoveBtn";
            this.AuthorRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.AuthorRemoveBtn.TabIndex = 30;
            this.AuthorRemoveBtn.Text = "Remove";
            this.AuthorRemoveBtn.UseVisualStyleBackColor = true;
            this.AuthorRemoveBtn.Click += new System.EventHandler(this.AuthorRemoveBtn_Click);
            // 
            // AuthorChangeBtn
            // 
            this.AuthorChangeBtn.Location = new System.Drawing.Point(583, 325);
            this.AuthorChangeBtn.Name = "AuthorChangeBtn";
            this.AuthorChangeBtn.Size = new System.Drawing.Size(75, 23);
            this.AuthorChangeBtn.TabIndex = 29;
            this.AuthorChangeBtn.Text = "Change";
            this.AuthorChangeBtn.UseVisualStyleBackColor = true;
            this.AuthorChangeBtn.Click += new System.EventHandler(this.AuthorChangeBtn_Click);
            // 
            // AuthorSaveBtn
            // 
            this.AuthorSaveBtn.Location = new System.Drawing.Point(264, 330);
            this.AuthorSaveBtn.Name = "AuthorSaveBtn";
            this.AuthorSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.AuthorSaveBtn.TabIndex = 28;
            this.AuthorSaveBtn.Text = "Save";
            this.AuthorSaveBtn.UseVisualStyleBackColor = true;
            this.AuthorSaveBtn.Click += new System.EventHandler(this.AuthorSaveBtn_Click);
            // 
            // AuthorGenreLbl
            // 
            this.AuthorGenreLbl.AutoSize = true;
            this.AuthorGenreLbl.Location = new System.Drawing.Point(7, 317);
            this.AuthorGenreLbl.Name = "AuthorGenreLbl";
            this.AuthorGenreLbl.Size = new System.Drawing.Size(36, 13);
            this.AuthorGenreLbl.TabIndex = 27;
            this.AuthorGenreLbl.Text = "Genre";
            // 
            // AuthorStartYearLbl
            // 
            this.AuthorStartYearLbl.AutoSize = true;
            this.AuthorStartYearLbl.Location = new System.Drawing.Point(188, 280);
            this.AuthorStartYearLbl.Name = "AuthorStartYearLbl";
            this.AuthorStartYearLbl.Size = new System.Drawing.Size(49, 13);
            this.AuthorStartYearLbl.TabIndex = 26;
            this.AuthorStartYearLbl.Text = "Startyear";
            // 
            // AuthorHomeTownLbl
            // 
            this.AuthorHomeTownLbl.AutoSize = true;
            this.AuthorHomeTownLbl.Location = new System.Drawing.Point(7, 280);
            this.AuthorHomeTownLbl.Name = "AuthorHomeTownLbl";
            this.AuthorHomeTownLbl.Size = new System.Drawing.Size(58, 13);
            this.AuthorHomeTownLbl.TabIndex = 25;
            this.AuthorHomeTownLbl.Text = "Hometown";
            // 
            // AuthorAgeLbl
            // 
            this.AuthorAgeLbl.AutoSize = true;
            this.AuthorAgeLbl.Location = new System.Drawing.Point(188, 241);
            this.AuthorAgeLbl.Name = "AuthorAgeLbl";
            this.AuthorAgeLbl.Size = new System.Drawing.Size(26, 13);
            this.AuthorAgeLbl.TabIndex = 24;
            this.AuthorAgeLbl.Text = "Age";
            // 
            // AuthorNameLbl
            // 
            this.AuthorNameLbl.AutoSize = true;
            this.AuthorNameLbl.Location = new System.Drawing.Point(7, 241);
            this.AuthorNameLbl.Name = "AuthorNameLbl";
            this.AuthorNameLbl.Size = new System.Drawing.Size(38, 13);
            this.AuthorNameLbl.TabIndex = 23;
            this.AuthorNameLbl.Text = "Author";
            // 
            // AuthorGenreTbx
            // 
            this.AuthorGenreTbx.Location = new System.Drawing.Point(10, 333);
            this.AuthorGenreTbx.Name = "AuthorGenreTbx";
            this.AuthorGenreTbx.Size = new System.Drawing.Size(147, 20);
            this.AuthorGenreTbx.TabIndex = 22;
            // 
            // AuthorStartYearTbx
            // 
            this.AuthorStartYearTbx.Location = new System.Drawing.Point(188, 293);
            this.AuthorStartYearTbx.Name = "AuthorStartYearTbx";
            this.AuthorStartYearTbx.Size = new System.Drawing.Size(151, 20);
            this.AuthorStartYearTbx.TabIndex = 21;
            // 
            // AuthorAgeTbx
            // 
            this.AuthorAgeTbx.Location = new System.Drawing.Point(188, 257);
            this.AuthorAgeTbx.Name = "AuthorAgeTbx";
            this.AuthorAgeTbx.Size = new System.Drawing.Size(151, 20);
            this.AuthorAgeTbx.TabIndex = 20;
            // 
            // AuthorHomeTownTbx
            // 
            this.AuthorHomeTownTbx.Location = new System.Drawing.Point(10, 293);
            this.AuthorHomeTownTbx.Name = "AuthorHomeTownTbx";
            this.AuthorHomeTownTbx.Size = new System.Drawing.Size(147, 20);
            this.AuthorHomeTownTbx.TabIndex = 19;
            // 
            // AuthorNameTbx
            // 
            this.AuthorNameTbx.Location = new System.Drawing.Point(10, 257);
            this.AuthorNameTbx.Name = "AuthorNameTbx";
            this.AuthorNameTbx.Size = new System.Drawing.Size(147, 20);
            this.AuthorNameTbx.TabIndex = 18;
            // 
            // AuthorDGV
            // 
            this.AuthorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorDGV.Location = new System.Drawing.Point(7, 48);
            this.AuthorDGV.Name = "AuthorDGV";
            this.AuthorDGV.Size = new System.Drawing.Size(651, 190);
            this.AuthorDGV.TabIndex = 17;
            // 
            // AuthorsNBooksTab2
            // 
            this.AuthorsNBooksTab2.Controls.Add(this.BooksAuthorNameCbx);
            this.AuthorsNBooksTab2.Controls.Add(this.BooksClearBtn);
            this.AuthorsNBooksTab2.Controls.Add(this.BooksSearchBtn);
            this.AuthorsNBooksTab2.Controls.Add(this.BooksSrchTbx);
            this.AuthorsNBooksTab2.Controls.Add(this.BooksRemoveBtn);
            this.AuthorsNBooksTab2.Controls.Add(this.BooksChangeBtn);
            this.AuthorsNBooksTab2.Controls.Add(this.BooksSaveBtn);
            this.AuthorsNBooksTab2.Controls.Add(this.BooksReleaseYearLbl);
            this.AuthorsNBooksTab2.Controls.Add(this.BooksLanguageLbl);
            this.AuthorsNBooksTab2.Controls.Add(this.BooksBookNameLbl);
            this.AuthorsNBooksTab2.Controls.Add(this.BooksAuthorNameLbl);
            this.AuthorsNBooksTab2.Controls.Add(this.BooksReleaseYearTbx);
            this.AuthorsNBooksTab2.Controls.Add(this.BooksBookNameTbx);
            this.AuthorsNBooksTab2.Controls.Add(this.BooksLanguageTbx);
            this.AuthorsNBooksTab2.Controls.Add(this.BooksDGV);
            this.AuthorsNBooksTab2.Location = new System.Drawing.Point(4, 22);
            this.AuthorsNBooksTab2.Name = "AuthorsNBooksTab2";
            this.AuthorsNBooksTab2.Padding = new System.Windows.Forms.Padding(3);
            this.AuthorsNBooksTab2.Size = new System.Drawing.Size(667, 384);
            this.AuthorsNBooksTab2.TabIndex = 1;
            this.AuthorsNBooksTab2.Text = "Books";
            this.AuthorsNBooksTab2.UseVisualStyleBackColor = true;
            // 
            // BooksAuthorNameCbx
            // 
            this.BooksAuthorNameCbx.FormattingEnabled = true;
            this.BooksAuthorNameCbx.Location = new System.Drawing.Point(11, 250);
            this.BooksAuthorNameCbx.Name = "BooksAuthorNameCbx";
            this.BooksAuthorNameCbx.Size = new System.Drawing.Size(147, 21);
            this.BooksAuthorNameCbx.TabIndex = 51;
            // 
            // BooksClearBtn
            // 
            this.BooksClearBtn.Location = new System.Drawing.Point(584, 13);
            this.BooksClearBtn.Name = "BooksClearBtn";
            this.BooksClearBtn.Size = new System.Drawing.Size(75, 23);
            this.BooksClearBtn.TabIndex = 50;
            this.BooksClearBtn.Text = "Clear";
            this.BooksClearBtn.UseVisualStyleBackColor = true;
            this.BooksClearBtn.Click += new System.EventHandler(this.BooksClearBtn_Click);
            // 
            // BooksSearchBtn
            // 
            this.BooksSearchBtn.Location = new System.Drawing.Point(503, 13);
            this.BooksSearchBtn.Name = "BooksSearchBtn";
            this.BooksSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.BooksSearchBtn.TabIndex = 49;
            this.BooksSearchBtn.Text = "Search";
            this.BooksSearchBtn.UseVisualStyleBackColor = true;
            this.BooksSearchBtn.Click += new System.EventHandler(this.BooksSearchBtn_Click);
            // 
            // BooksSrchTbx
            // 
            this.BooksSrchTbx.Location = new System.Drawing.Point(340, 15);
            this.BooksSrchTbx.Name = "BooksSrchTbx";
            this.BooksSrchTbx.Size = new System.Drawing.Size(157, 20);
            this.BooksSrchTbx.TabIndex = 48;
            // 
            // BooksRemoveBtn
            // 
            this.BooksRemoveBtn.Location = new System.Drawing.Point(584, 348);
            this.BooksRemoveBtn.Name = "BooksRemoveBtn";
            this.BooksRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.BooksRemoveBtn.TabIndex = 47;
            this.BooksRemoveBtn.Text = "Remove";
            this.BooksRemoveBtn.UseVisualStyleBackColor = true;
            this.BooksRemoveBtn.Click += new System.EventHandler(this.BooksRemoveBtn_Click);
            // 
            // BooksChangeBtn
            // 
            this.BooksChangeBtn.Location = new System.Drawing.Point(584, 319);
            this.BooksChangeBtn.Name = "BooksChangeBtn";
            this.BooksChangeBtn.Size = new System.Drawing.Size(75, 23);
            this.BooksChangeBtn.TabIndex = 46;
            this.BooksChangeBtn.Text = "Change";
            this.BooksChangeBtn.UseVisualStyleBackColor = true;
            this.BooksChangeBtn.Click += new System.EventHandler(this.BooksChangeBtn_Click);
            // 
            // BooksSaveBtn
            // 
            this.BooksSaveBtn.Location = new System.Drawing.Point(265, 324);
            this.BooksSaveBtn.Name = "BooksSaveBtn";
            this.BooksSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.BooksSaveBtn.TabIndex = 45;
            this.BooksSaveBtn.Text = "Save";
            this.BooksSaveBtn.UseVisualStyleBackColor = true;
            this.BooksSaveBtn.Click += new System.EventHandler(this.BooksSaveBtn_Click);
            // 
            // BooksReleaseYearLbl
            // 
            this.BooksReleaseYearLbl.AutoSize = true;
            this.BooksReleaseYearLbl.Location = new System.Drawing.Point(189, 274);
            this.BooksReleaseYearLbl.Name = "BooksReleaseYearLbl";
            this.BooksReleaseYearLbl.Size = new System.Drawing.Size(71, 13);
            this.BooksReleaseYearLbl.TabIndex = 43;
            this.BooksReleaseYearLbl.Text = "Release Year";
            // 
            // BooksLanguageLbl
            // 
            this.BooksLanguageLbl.AutoSize = true;
            this.BooksLanguageLbl.Location = new System.Drawing.Point(8, 274);
            this.BooksLanguageLbl.Name = "BooksLanguageLbl";
            this.BooksLanguageLbl.Size = new System.Drawing.Size(55, 13);
            this.BooksLanguageLbl.TabIndex = 42;
            this.BooksLanguageLbl.Text = "Language";
            // 
            // BooksBookNameLbl
            // 
            this.BooksBookNameLbl.AutoSize = true;
            this.BooksBookNameLbl.Location = new System.Drawing.Point(189, 235);
            this.BooksBookNameLbl.Name = "BooksBookNameLbl";
            this.BooksBookNameLbl.Size = new System.Drawing.Size(63, 13);
            this.BooksBookNameLbl.TabIndex = 41;
            this.BooksBookNameLbl.Text = "Book Name";
            // 
            // BooksAuthorNameLbl
            // 
            this.BooksAuthorNameLbl.AutoSize = true;
            this.BooksAuthorNameLbl.Location = new System.Drawing.Point(8, 235);
            this.BooksAuthorNameLbl.Name = "BooksAuthorNameLbl";
            this.BooksAuthorNameLbl.Size = new System.Drawing.Size(38, 13);
            this.BooksAuthorNameLbl.TabIndex = 40;
            this.BooksAuthorNameLbl.Text = "Author";
            // 
            // BooksReleaseYearTbx
            // 
            this.BooksReleaseYearTbx.Location = new System.Drawing.Point(189, 287);
            this.BooksReleaseYearTbx.Name = "BooksReleaseYearTbx";
            this.BooksReleaseYearTbx.Size = new System.Drawing.Size(151, 20);
            this.BooksReleaseYearTbx.TabIndex = 38;
            // 
            // BooksBookNameTbx
            // 
            this.BooksBookNameTbx.Location = new System.Drawing.Point(189, 251);
            this.BooksBookNameTbx.Name = "BooksBookNameTbx";
            this.BooksBookNameTbx.Size = new System.Drawing.Size(151, 20);
            this.BooksBookNameTbx.TabIndex = 37;
            // 
            // BooksLanguageTbx
            // 
            this.BooksLanguageTbx.Location = new System.Drawing.Point(11, 287);
            this.BooksLanguageTbx.Name = "BooksLanguageTbx";
            this.BooksLanguageTbx.Size = new System.Drawing.Size(147, 20);
            this.BooksLanguageTbx.TabIndex = 36;
            // 
            // BooksDGV
            // 
            this.BooksDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDGV.Location = new System.Drawing.Point(8, 42);
            this.BooksDGV.Name = "BooksDGV";
            this.BooksDGV.Size = new System.Drawing.Size(651, 190);
            this.BooksDGV.TabIndex = 34;
            // 
            // AuthorBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 411);
            this.Controls.Add(this.AuthorsNBooks);
            this.Name = "AuthorBook";
            this.Text = "Authors And Books";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AuthorBS)).EndInit();
            this.AuthorsNBooks.ResumeLayout(false);
            this.AuthorsNBooksTab.ResumeLayout(false);
            this.AuthorsNBooksTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorDGV)).EndInit();
            this.AuthorsNBooksTab2.ResumeLayout(false);
            this.AuthorsNBooksTab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource AuthorBS;
        private System.Windows.Forms.TabControl AuthorsNBooks;
        private System.Windows.Forms.TabPage AuthorsNBooksTab;
        private System.Windows.Forms.Button AuthorClearBtn;
        private System.Windows.Forms.Button AuthorSearchBtn;
        private System.Windows.Forms.TextBox AuthorSearchTbx;
        private System.Windows.Forms.Button AuthorRemoveBtn;
        private System.Windows.Forms.Button AuthorChangeBtn;
        private System.Windows.Forms.Button AuthorSaveBtn;
        private System.Windows.Forms.Label AuthorGenreLbl;
        private System.Windows.Forms.Label AuthorStartYearLbl;
        private System.Windows.Forms.Label AuthorHomeTownLbl;
        private System.Windows.Forms.Label AuthorAgeLbl;
        private System.Windows.Forms.Label AuthorNameLbl;
        private System.Windows.Forms.TextBox AuthorGenreTbx;
        private System.Windows.Forms.TextBox AuthorStartYearTbx;
        private System.Windows.Forms.TextBox AuthorAgeTbx;
        private System.Windows.Forms.TextBox AuthorHomeTownTbx;
        private System.Windows.Forms.TextBox AuthorNameTbx;
        private System.Windows.Forms.DataGridView AuthorDGV;
        private System.Windows.Forms.TabPage AuthorsNBooksTab2;
        private System.Windows.Forms.ComboBox BooksAuthorNameCbx;
        private System.Windows.Forms.Button BooksClearBtn;
        private System.Windows.Forms.Button BooksSearchBtn;
        private System.Windows.Forms.TextBox BooksSrchTbx;
        private System.Windows.Forms.Button BooksRemoveBtn;
        private System.Windows.Forms.Button BooksChangeBtn;
        private System.Windows.Forms.Button BooksSaveBtn;
        private System.Windows.Forms.Label BooksReleaseYearLbl;
        private System.Windows.Forms.Label BooksLanguageLbl;
        private System.Windows.Forms.Label BooksBookNameLbl;
        private System.Windows.Forms.Label BooksAuthorNameLbl;
        private System.Windows.Forms.TextBox BooksReleaseYearTbx;
        private System.Windows.Forms.TextBox BooksBookNameTbx;
        private System.Windows.Forms.TextBox BooksLanguageTbx;
        private System.Windows.Forms.DataGridView BooksDGV;
        private System.Windows.Forms.BindingSource BooksBS;
    }
}

