namespace Library.View
{
    partial class Frm_BrowsBooks
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numID = new System.Windows.Forms.NumericUpDown();
            this.rdioBookNumber = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSubCat = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbPlace = new System.Windows.Forms.ComboBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.cmbDar = new System.Windows.Forms.ComboBox();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.cmbGeneralCat = new System.Windows.Forms.ComboBox();
            this.rdioPlace = new System.Windows.Forms.RadioButton();
            this.rdioDate = new System.Windows.Forms.RadioButton();
            this.rdioCountry = new System.Windows.Forms.RadioButton();
            this.rdioDar = new System.Windows.Forms.RadioButton();
            this.rdioSub = new System.Windows.Forms.RadioButton();
            this.rdioAuthor = new System.Windows.Forms.RadioButton();
            this.rdioCat = new System.Windows.Forms.RadioButton();
            this.rdioBookName = new System.Windows.Forms.RadioButton();
            this.rdioAllBooks = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 269);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1394, 414);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.numID);
            this.groupBox1.Controls.Add(this.rdioBookNumber);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtSubCat);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.cmbPlace);
            this.groupBox1.Controls.Add(this.cmbCountry);
            this.groupBox1.Controls.Add(this.cmbDar);
            this.groupBox1.Controls.Add(this.cmbAuthor);
            this.groupBox1.Controls.Add(this.cmbGeneralCat);
            this.groupBox1.Controls.Add(this.rdioPlace);
            this.groupBox1.Controls.Add(this.rdioDate);
            this.groupBox1.Controls.Add(this.rdioCountry);
            this.groupBox1.Controls.Add(this.rdioDar);
            this.groupBox1.Controls.Add(this.rdioSub);
            this.groupBox1.Controls.Add(this.rdioAuthor);
            this.groupBox1.Controls.Add(this.rdioCat);
            this.groupBox1.Controls.Add(this.rdioBookName);
            this.groupBox1.Controls.Add(this.rdioAllBooks);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1394, 251);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فلترة البحث";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(292, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 40);
            this.button2.TabIndex = 22;
            this.button2.Text = "بحث";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 38);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // numID
            // 
            this.numID.Location = new System.Drawing.Point(952, 92);
            this.numID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numID.Name = "numID";
            this.numID.Size = new System.Drawing.Size(273, 38);
            this.numID.TabIndex = 20;
            this.numID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rdioBookNumber
            // 
            this.rdioBookNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdioBookNumber.AutoSize = true;
            this.rdioBookNumber.Location = new System.Drawing.Point(1283, 92);
            this.rdioBookNumber.Name = "rdioBookNumber";
            this.rdioBookNumber.Size = new System.Drawing.Size(105, 35);
            this.rdioBookNumber.TabIndex = 19;
            this.rdioBookNumber.Text = "رقم الكتاب";
            this.rdioBookNumber.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 40);
            this.button1.TabIndex = 18;
            this.button1.Text = "اضافة كتاب جديد";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSubCat
            // 
            this.txtSubCat.Location = new System.Drawing.Point(6, 37);
            this.txtSubCat.Name = "txtSubCat";
            this.txtSubCat.Size = new System.Drawing.Size(298, 38);
            this.txtSubCat.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(952, 147);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(273, 38);
            this.txtName.TabIndex = 16;
            // 
            // cmbPlace
            // 
            this.cmbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlace.FormattingEnabled = true;
            this.cmbPlace.Location = new System.Drawing.Point(472, 200);
            this.cmbPlace.Name = "cmbPlace";
            this.cmbPlace.Size = new System.Drawing.Size(276, 39);
            this.cmbPlace.TabIndex = 14;
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(472, 92);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(276, 39);
            this.cmbCountry.TabIndex = 12;
            // 
            // cmbDar
            // 
            this.cmbDar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDar.FormattingEnabled = true;
            this.cmbDar.Location = new System.Drawing.Point(472, 36);
            this.cmbDar.Name = "cmbDar";
            this.cmbDar.Size = new System.Drawing.Size(276, 39);
            this.cmbDar.TabIndex = 11;
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(472, 144);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(276, 39);
            this.cmbAuthor.TabIndex = 10;
            // 
            // cmbGeneralCat
            // 
            this.cmbGeneralCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneralCat.FormattingEnabled = true;
            this.cmbGeneralCat.Location = new System.Drawing.Point(952, 196);
            this.cmbGeneralCat.Name = "cmbGeneralCat";
            this.cmbGeneralCat.Size = new System.Drawing.Size(273, 39);
            this.cmbGeneralCat.TabIndex = 9;
            // 
            // rdioPlace
            // 
            this.rdioPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdioPlace.AutoSize = true;
            this.rdioPlace.Location = new System.Drawing.Point(754, 201);
            this.rdioPlace.Name = "rdioPlace";
            this.rdioPlace.Size = new System.Drawing.Size(115, 35);
            this.rdioPlace.TabIndex = 8;
            this.rdioPlace.Text = "مكان الكتاب";
            this.rdioPlace.UseVisualStyleBackColor = true;
            // 
            // rdioDate
            // 
            this.rdioDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdioDate.AutoSize = true;
            this.rdioDate.Location = new System.Drawing.Point(348, 92);
            this.rdioDate.Name = "rdioDate";
            this.rdioDate.Size = new System.Drawing.Size(105, 35);
            this.rdioDate.TabIndex = 7;
            this.rdioDate.Text = "تاريخ النشر";
            this.rdioDate.UseVisualStyleBackColor = true;
            // 
            // rdioCountry
            // 
            this.rdioCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdioCountry.AutoSize = true;
            this.rdioCountry.Location = new System.Drawing.Point(764, 93);
            this.rdioCountry.Name = "rdioCountry";
            this.rdioCountry.Size = new System.Drawing.Size(105, 35);
            this.rdioCountry.TabIndex = 6;
            this.rdioCountry.Text = "دولة النشر";
            this.rdioCountry.UseVisualStyleBackColor = true;
            // 
            // rdioDar
            // 
            this.rdioDar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdioDar.AutoSize = true;
            this.rdioDar.Location = new System.Drawing.Point(778, 37);
            this.rdioDar.Name = "rdioDar";
            this.rdioDar.Size = new System.Drawing.Size(91, 35);
            this.rdioDar.TabIndex = 5;
            this.rdioDar.Text = "دار النشر";
            this.rdioDar.UseVisualStyleBackColor = true;
            // 
            // rdioSub
            // 
            this.rdioSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdioSub.AutoSize = true;
            this.rdioSub.Location = new System.Drawing.Point(310, 37);
            this.rdioSub.Name = "rdioSub";
            this.rdioSub.Size = new System.Drawing.Size(143, 35);
            this.rdioSub.TabIndex = 4;
            this.rdioSub.Text = "التصنيف الفرعى";
            this.rdioSub.UseVisualStyleBackColor = true;
            // 
            // rdioAuthor
            // 
            this.rdioAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdioAuthor.AutoSize = true;
            this.rdioAuthor.Location = new System.Drawing.Point(786, 145);
            this.rdioAuthor.Name = "rdioAuthor";
            this.rdioAuthor.Size = new System.Drawing.Size(83, 35);
            this.rdioAuthor.TabIndex = 3;
            this.rdioAuthor.Text = "المؤلف";
            this.rdioAuthor.UseVisualStyleBackColor = true;
            // 
            // rdioCat
            // 
            this.rdioCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdioCat.AutoSize = true;
            this.rdioCat.Location = new System.Drawing.Point(1261, 201);
            this.rdioCat.Name = "rdioCat";
            this.rdioCat.Size = new System.Drawing.Size(127, 35);
            this.rdioCat.TabIndex = 2;
            this.rdioCat.Text = "تصنيف الكتاب";
            this.rdioCat.UseVisualStyleBackColor = true;
            // 
            // rdioBookName
            // 
            this.rdioBookName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdioBookName.AutoSize = true;
            this.rdioBookName.Location = new System.Drawing.Point(1278, 148);
            this.rdioBookName.Name = "rdioBookName";
            this.rdioBookName.Size = new System.Drawing.Size(110, 35);
            this.rdioBookName.TabIndex = 1;
            this.rdioBookName.Text = "اسم الكتاب";
            this.rdioBookName.UseVisualStyleBackColor = true;
            // 
            // rdioAllBooks
            // 
            this.rdioAllBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdioAllBooks.AutoSize = true;
            this.rdioAllBooks.Checked = true;
            this.rdioAllBooks.Location = new System.Drawing.Point(1292, 37);
            this.rdioAllBooks.Name = "rdioAllBooks";
            this.rdioAllBooks.Size = new System.Drawing.Size(96, 35);
            this.rdioAllBooks.TabIndex = 0;
            this.rdioAllBooks.TabStop = true;
            this.rdioAllBooks.Text = "كل الكتب";
            this.rdioAllBooks.UseVisualStyleBackColor = true;
            // 
            // Frm_BrowsBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 695);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_BrowsBooks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "تصفح الكتب";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private RadioButton rdioBookName;
        private RadioButton rdioAllBooks;
        private RadioButton rdioCat;
        private RadioButton rdioAuthor;
        private RadioButton rdioPlace;
        private RadioButton rdioDate;
        private RadioButton rdioCountry;
        private RadioButton rdioDar;
        private RadioButton rdioSub;
        private TextBox txtSubCat;
        private TextBox txtName;
        private ComboBox cmbPlace;
        private ComboBox cmbCountry;
        private ComboBox cmbDar;
        private ComboBox cmbAuthor;
        private ComboBox cmbGeneralCat;
        private NumericUpDown numID;
        private RadioButton rdioBookNumber;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Button button2;
    }
}