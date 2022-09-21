namespace Library.View
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnPlaces = new System.Windows.Forms.Button();
            this.btnDar = new System.Windows.Forms.Button();
            this.btnCountry = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnBrowseBooks = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddBorrow = new System.Windows.Forms.Button();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.btnViewBorrows = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 41);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1330, 137);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(1322, 93);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "الرئيسيه";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddCat);
            this.flowLayoutPanel1.Controls.Add(this.btnAuthor);
            this.flowLayoutPanel1.Controls.Add(this.btnPlaces);
            this.flowLayoutPanel1.Controls.Add(this.btnDar);
            this.flowLayoutPanel1.Controls.Add(this.btnCountry);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1312, 83);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnAddCat
            // 
            this.btnAddCat.Image = global::Library.Properties.Resources.app;
            this.btnAddCat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddCat.Location = new System.Drawing.Point(1139, 3);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(170, 80);
            this.btnAddCat.TabIndex = 1;
            this.btnAddCat.Text = "تصنيفات الكتب";
            this.btnAddCat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAuthor
            // 
            this.btnAuthor.Image = global::Library.Properties.Resources.icons8_crowd_40;
            this.btnAuthor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAuthor.Location = new System.Drawing.Point(967, 3);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(166, 80);
            this.btnAuthor.TabIndex = 2;
            this.btnAuthor.Text = "المؤلفين";
            this.btnAuthor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAuthor.UseVisualStyleBackColor = true;
            this.btnAuthor.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPlaces
            // 
            this.btnPlaces.Image = global::Library.Properties.Resources.icons8_book_shelf_48;
            this.btnPlaces.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlaces.Location = new System.Drawing.Point(797, 3);
            this.btnPlaces.Name = "btnPlaces";
            this.btnPlaces.Size = new System.Drawing.Size(164, 80);
            this.btnPlaces.TabIndex = 3;
            this.btnPlaces.Text = "اماكن الكتب";
            this.btnPlaces.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlaces.UseVisualStyleBackColor = true;
            this.btnPlaces.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDar
            // 
            this.btnDar.Image = global::Library.Properties.Resources.icons8_bookshop_48;
            this.btnDar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDar.Location = new System.Drawing.Point(634, 3);
            this.btnDar.Name = "btnDar";
            this.btnDar.Size = new System.Drawing.Size(157, 80);
            this.btnDar.TabIndex = 4;
            this.btnDar.Text = "دور النشر";
            this.btnDar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDar.UseVisualStyleBackColor = true;
            this.btnDar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCountry
            // 
            this.btnCountry.Image = global::Library.Properties.Resources.icons8_earth_planet_48;
            this.btnCountry.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCountry.Location = new System.Drawing.Point(479, 3);
            this.btnCountry.Name = "btnCountry";
            this.btnCountry.Size = new System.Drawing.Size(149, 80);
            this.btnCountry.TabIndex = 5;
            this.btnCountry.Text = "الدول";
            this.btnCountry.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCountry.UseVisualStyleBackColor = true;
            this.btnCountry.Click += new System.EventHandler(this.button5_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.flowLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage3.Size = new System.Drawing.Size(1322, 93);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "الكتب";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnAddBook);
            this.flowLayoutPanel3.Controls.Add(this.btnBrowseBooks);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1312, 83);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Image = global::Library.Properties.Resources.icons8_add_48__1_1;
            this.btnAddBook.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddBook.Location = new System.Drawing.Point(1158, 3);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(151, 80);
            this.btnAddBook.TabIndex = 2;
            this.btnAddBook.Text = "اضافة كتاب";
            this.btnAddBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnBrowseBooks
            // 
            this.btnBrowseBooks.Image = global::Library.Properties.Resources.icons8_book_40;
            this.btnBrowseBooks.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseBooks.Location = new System.Drawing.Point(1001, 3);
            this.btnBrowseBooks.Name = "btnBrowseBooks";
            this.btnBrowseBooks.Size = new System.Drawing.Size(151, 80);
            this.btnBrowseBooks.TabIndex = 3;
            this.btnBrowseBooks.Text = "تصفح الكتب";
            this.btnBrowseBooks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBrowseBooks.UseVisualStyleBackColor = true;
            this.btnBrowseBooks.Click += new System.EventHandler(this.button7_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutPanel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage2.Size = new System.Drawing.Size(1322, 93);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "الاستعارات";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.btnAddBorrow);
            this.flowLayoutPanel4.Controls.Add(this.btnBorrowBook);
            this.flowLayoutPanel4.Controls.Add(this.btnViewBorrows);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1312, 83);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // btnAddBorrow
            // 
            this.btnAddBorrow.Image = global::Library.Properties.Resources.icons8_crowd_40;
            this.btnAddBorrow.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddBorrow.Location = new System.Drawing.Point(1158, 3);
            this.btnAddBorrow.Name = "btnAddBorrow";
            this.btnAddBorrow.Size = new System.Drawing.Size(151, 80);
            this.btnAddBorrow.TabIndex = 7;
            this.btnAddBorrow.Text = "اضافة مستعيرين";
            this.btnAddBorrow.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddBorrow.UseVisualStyleBackColor = true;
            this.btnAddBorrow.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.Image = global::Library.Properties.Resources.icons8_borrow_book_40;
            this.btnBorrowBook.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBorrowBook.Location = new System.Drawing.Point(1001, 3);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(151, 80);
            this.btnBorrowBook.TabIndex = 4;
            this.btnBorrowBook.Text = "استعارة كتاب";
            this.btnBorrowBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrowBook.UseVisualStyleBackColor = true;
            this.btnBorrowBook.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnViewBorrows
            // 
            this.btnViewBorrows.Image = global::Library.Properties.Resources.file;
            this.btnViewBorrows.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewBorrows.Location = new System.Drawing.Point(831, 3);
            this.btnViewBorrows.Name = "btnViewBorrows";
            this.btnViewBorrows.Size = new System.Drawing.Size(164, 80);
            this.btnViewBorrows.TabIndex = 8;
            this.btnViewBorrows.Text = "عرض الاستعارات";
            this.btnViewBorrows.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewBorrows.UseVisualStyleBackColor = true;
            this.btnViewBorrows.Click += new System.EventHandler(this.button11_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.flowLayoutPanel5);
            this.tabPage4.Location = new System.Drawing.Point(4, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage4.Size = new System.Drawing.Size(1292, 93);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "المزيد";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.btnSettings);
            this.flowLayoutPanel5.Controls.Add(this.btnUsers);
            this.flowLayoutPanel5.Controls.Add(this.button1);
            this.flowLayoutPanel5.Controls.Add(this.btnLogout);
            this.flowLayoutPanel5.Controls.Add(this.btnReset);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(1282, 83);
            this.flowLayoutPanel5.TabIndex = 3;
            // 
            // btnSettings
            // 
            this.btnSettings.Image = global::Library.Properties.Resources.icons8_settings_45;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSettings.Location = new System.Drawing.Point(1138, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(141, 80);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "اعدادات";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Image = global::Library.Properties.Resources.icons8_users_48;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsers.Location = new System.Drawing.Point(991, 3);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(141, 80);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "المستخدمون";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.button14_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Library.Properties.Resources.icons8_search_45;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(790, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 80);
            this.button1.TabIndex = 5;
            this.button1.Text = "اظهار كل المستخدمين";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.Image = global::Library.Properties.Resources.icons8_exit_40;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(614, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(170, 80);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "تسجيل الخروج";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnReset
            // 
            this.btnReset.Image = global::Library.Properties.Resources.icons8_cancel_48;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReset.Location = new System.Drawing.Point(472, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 80);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "اعادة الضبط";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button13_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library.Properties.Resources.icons8_close_48;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Library.Properties.Resources.icons8_maximize_window_48;
            this.pictureBox2.Location = new System.Drawing.Point(39, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnMaxmize_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Library.Properties.Resources.icons8_minimize_window_48;
            this.pictureBox3.Location = new System.Drawing.Point(74, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = global::Library.Properties.Resources.icons8_literature;
            this.pictureBox4.Location = new System.Drawing.Point(545, 367);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(281, 250);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(478, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 92);
            this.label1.TabIndex = 3;
            this.label1.Text = "برنامج ادارة المكتبه";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(207)))));
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1330, 178);
            this.panel2.TabIndex = 5;
            this.panel2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDoubleClick);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(589, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "برنامج ادارة المكتبه";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1330, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.Name = "Frm_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ادارة المكتبه";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAddCat;
        private Button btnAuthor;
        private Button btnPlaces;
        private TabPage tabPage3;
        private TabPage tabPage2;
        private Button btnDar;
        private Button btnCountry;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnAddBook;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button btnBrowseBooks;
        private FlowLayoutPanel flowLayoutPanel4;
        private TabPage tabPage4;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button btnReset;
        private Button btnBorrowBook;
        private Button btnAddBorrow;
        private Button btnLogout;
        private Button btnViewBorrows;
        private PictureBox pictureBox4;
        private Button btnSettings;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Button btnUsers;
        private Button button1;
    }
}