namespace Library.View
{
    partial class Frm_ViewClientBorrows
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.double_arrow_left = new System.Windows.Forms.Button();
            this.arrow_left = new System.Windows.Forms.Button();
            this.arrow_right = new System.Windows.Forms.Button();
            this.double_arrow_right = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtBorrowBookId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateEndDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateStartDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.book_id});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1174, 308);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "رقم الاستعاره";
            this.Column1.HeaderText = "رقم الاستعاره";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "رقم العميل";
            this.Column2.HeaderText = "رقم العميل";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "اسم العميل";
            this.Column3.HeaderText = "اسم العميل";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "اسم الكتاب";
            this.Column4.HeaderText = "اسم الكتاب";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "عدد الكتب";
            this.Column5.HeaderText = "عدد الكتب";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "تاريخ الاستعاره";
            this.Column6.HeaderText = "تاريخ الاستعاره";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "تاريخ التسليم";
            this.Column7.HeaderText = "تاريخ التسليم";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ملاحظه";
            this.Column8.HeaderText = "ملاحظه";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // book_id
            // 
            this.book_id.DataPropertyName = "book_id";
            this.book_id.HeaderText = "book_id";
            this.book_id.Name = "book_id";
            this.book_id.ReadOnly = true;
            this.book_id.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "رقم العميل :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "الاسم :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 37);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(241, 38);
            this.txtName.TabIndex = 18;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(350, 37);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(207, 38);
            this.txtID.TabIndex = 19;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(6, 90);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.ReadOnly = true;
            this.txtPhone2.Size = new System.Drawing.Size(241, 38);
            this.txtPhone2.TabIndex = 21;
            this.txtPhone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "تليفون 1 :";
            // 
            // txtPhone1
            // 
            this.txtPhone1.Location = new System.Drawing.Point(350, 90);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.ReadOnly = true;
            this.txtPhone1.Size = new System.Drawing.Size(207, 38);
            this.txtPhone1.TabIndex = 23;
            this.txtPhone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 31);
            this.label4.TabIndex = 22;
            this.label4.Text = "تليفون 2 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPhone1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtPhone2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 143);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات العميل";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.double_arrow_left);
            this.groupBox3.Controls.Add(this.arrow_left);
            this.groupBox3.Controls.Add(this.arrow_right);
            this.groupBox3.Controls.Add(this.double_arrow_right);
            this.groupBox3.Location = new System.Drawing.Point(849, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(289, 105);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "اسهم التنقل";
            // 
            // double_arrow_left
            // 
            this.double_arrow_left.Image = global::Library.Properties.Resources.icons8_double_left_48;
            this.double_arrow_left.Location = new System.Drawing.Point(6, 37);
            this.double_arrow_left.Name = "double_arrow_left";
            this.double_arrow_left.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.double_arrow_left.Size = new System.Drawing.Size(70, 55);
            this.double_arrow_left.TabIndex = 4;
            this.double_arrow_left.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.double_arrow_left.UseVisualStyleBackColor = true;
            this.double_arrow_left.Click += new System.EventHandler(this.double_arrow_left_Click);
            // 
            // arrow_left
            // 
            this.arrow_left.Image = global::Library.Properties.Resources.icons8_back_48;
            this.arrow_left.Location = new System.Drawing.Point(82, 37);
            this.arrow_left.Name = "arrow_left";
            this.arrow_left.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.arrow_left.Size = new System.Drawing.Size(60, 55);
            this.arrow_left.TabIndex = 3;
            this.arrow_left.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.arrow_left.UseVisualStyleBackColor = true;
            this.arrow_left.Click += new System.EventHandler(this.arrow_left_Click);
            // 
            // arrow_right
            // 
            this.arrow_right.Image = global::Library.Properties.Resources.icons8_forward_48;
            this.arrow_right.Location = new System.Drawing.Point(146, 37);
            this.arrow_right.Name = "arrow_right";
            this.arrow_right.Size = new System.Drawing.Size(60, 55);
            this.arrow_right.TabIndex = 2;
            this.arrow_right.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.arrow_right.UseVisualStyleBackColor = true;
            this.arrow_right.Click += new System.EventHandler(this.arrow_right_Click);
            // 
            // double_arrow_right
            // 
            this.double_arrow_right.Image = global::Library.Properties.Resources.icons8_double_right_48;
            this.double_arrow_right.Location = new System.Drawing.Point(212, 37);
            this.double_arrow_right.Name = "double_arrow_right";
            this.double_arrow_right.Size = new System.Drawing.Size(70, 55);
            this.double_arrow_right.TabIndex = 1;
            this.double_arrow_right.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.double_arrow_right.UseVisualStyleBackColor = true;
            this.double_arrow_right.Click += new System.EventHandler(this.double_arrow_right_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteAll);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(795, 456);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(391, 104);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحه";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Image = global::Library.Properties.Resources.icons8_cancel_48;
            this.btnDeleteAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAll.Location = new System.Drawing.Point(6, 37);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnDeleteAll.Size = new System.Drawing.Size(139, 55);
            this.btnDeleteAll.TabIndex = 5;
            this.btnDeleteAll.Text = "مسح الكل";
            this.btnDeleteAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Library.Properties.Resources.icons8_trash_48;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(151, 37);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnDelete.Size = new System.Drawing.Size(108, 55);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "مسح";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Library.Properties.Resources.icons8_save_close_48;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(265, 37);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnSave.Size = new System.Drawing.Size(120, 55);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Controls.Add(this.cmbBooks);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtNote);
            this.groupBox4.Controls.Add(this.txtBorrowBookId);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.dateEndDate);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.dateStartDate);
            this.groupBox4.Location = new System.Drawing.Point(12, 475);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(777, 341);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "بيانات الاستعاره";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(489, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 31);
            this.label9.TabIndex = 29;
            this.label9.Text = "عدد الكتب";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(357, 242);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(215, 38);
            this.numericUpDown1.TabIndex = 28;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbBooks
            // 
            this.cmbBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(357, 157);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(215, 39);
            this.cmbBooks.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 31);
            this.label6.TabIndex = 26;
            this.label6.Text = "الكتاب";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 31);
            this.label5.TabIndex = 25;
            this.label5.Text = "ملاحظه";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(6, 53);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(343, 282);
            this.txtNote.TabIndex = 24;
            this.txtNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBorrowBookId
            // 
            this.txtBorrowBookId.Location = new System.Drawing.Point(588, 75);
            this.txtBorrowBookId.Name = "txtBorrowBookId";
            this.txtBorrowBookId.ReadOnly = true;
            this.txtBorrowBookId.Size = new System.Drawing.Size(166, 38);
            this.txtBorrowBookId.TabIndex = 15;
            this.txtBorrowBookId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(644, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 31);
            this.label10.TabIndex = 14;
            this.label10.Text = "رقم الاستعاره";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(612, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 31);
            this.label8.TabIndex = 11;
            this.label8.Text = "تاريخ تسليم الكتاب";
            // 
            // dateEndDate
            // 
            this.dateEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEndDate.Location = new System.Drawing.Point(588, 238);
            this.dateEndDate.Name = "dateEndDate";
            this.dateEndDate.Size = new System.Drawing.Size(166, 38);
            this.dateEndDate.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(671, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 31);
            this.label7.TabIndex = 9;
            this.label7.Text = "تاريخ البدء";
            // 
            // dateStartDate
            // 
            this.dateStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStartDate.Location = new System.Drawing.Point(588, 160);
            this.dateStartDate.Name = "dateStartDate";
            this.dateStartDate.Size = new System.Drawing.Size(166, 38);
            this.dateStartDate.TabIndex = 8;
            // 
            // Frm_ViewClientBorrows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1198, 830);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ViewClientBorrows";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاستعارات السابقه";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtID;
        private TextBox txtPhone2;
        private Label label3;
        private TextBox txtPhone1;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button double_arrow_left;
        private Button arrow_left;
        private Button arrow_right;
        private Button double_arrow_right;
        private GroupBox groupBox2;
        private Button btnDeleteAll;
        private Button btnDelete;
        private Button btnSave;
        private GroupBox groupBox4;
        private TextBox txtBorrowBookId;
        private Label label10;
        private Label label8;
        private DateTimePicker dateEndDate;
        private Label label7;
        private DateTimePicker dateStartDate;
        private Label label5;
        private TextBox txtNote;
        private Label label6;
        private Label label9;
        private NumericUpDown numericUpDown1;
        private ComboBox cmbBooks;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn book_id;
    }
}