namespace Library.View
{
    partial class Frm_BorrowBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBorrowBookId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateEndDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateStartDate = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbBorrowers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableBookNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NeddedNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtBorrowBookId);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateEndDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateStartDate);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbBorrowers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1197, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات العميل";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library.Properties.Resources.icons8_bookmark;
            this.pictureBox1.Location = new System.Drawing.Point(63, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // txtBorrowBookId
            // 
            this.txtBorrowBookId.Location = new System.Drawing.Point(860, 31);
            this.txtBorrowBookId.Name = "txtBorrowBookId";
            this.txtBorrowBookId.ReadOnly = true;
            this.txtBorrowBookId.Size = new System.Drawing.Size(215, 38);
            this.txtBorrowBookId.TabIndex = 15;
            this.txtBorrowBookId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1081, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 31);
            this.label10.TabIndex = 14;
            this.label10.Text = "رقم الاستعاره";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(642, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 31);
            this.label8.TabIndex = 11;
            this.label8.Text = "تاريخ تسليم الكتاب";
            // 
            // dateEndDate
            // 
            this.dateEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEndDate.Location = new System.Drawing.Point(389, 94);
            this.dateEndDate.Name = "dateEndDate";
            this.dateEndDate.Size = new System.Drawing.Size(229, 38);
            this.dateEndDate.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(672, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 31);
            this.label7.TabIndex = 9;
            this.label7.Text = "تاريخ البدء";
            // 
            // dateStartDate
            // 
            this.dateStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStartDate.Location = new System.Drawing.Point(389, 38);
            this.dateStartDate.Name = "dateStartDate";
            this.dateStartDate.Size = new System.Drawing.Size(229, 38);
            this.dateStartDate.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(860, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "اظهار الاستعارات السابقه";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Library.Properties.Resources.icons8_add_35;
            this.button1.Location = new System.Drawing.Point(810, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 39);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbBorrowers
            // 
            this.cmbBorrowers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBorrowers.FormattingEnabled = true;
            this.cmbBorrowers.Location = new System.Drawing.Point(860, 93);
            this.cmbBorrowers.Name = "cmbBorrowers";
            this.cmbBorrowers.Size = new System.Drawing.Size(215, 39);
            this.cmbBorrowers.TabIndex = 1;
            this.cmbBorrowers.SelectedValueChanged += new System.EventHandler(this.cmbBorrowers_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1104, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "المستعير";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.ForeColor = System.Drawing.Color.Red;
            this.lblNotes.Location = new System.Drawing.Point(1015, 269);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(127, 31);
            this.lblNotes.TabIndex = 13;
            this.lblNotes.Text = "لا توجد ملاحظات";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(964, 229);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(227, 37);
            this.button6.TabIndex = 12;
            this.button6.Text = "اضافة ملاحظه";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.lblNotes);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(18, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1197, 383);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات الكتب";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(410, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(208, 35);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "اظهار الكتب الغير متوفره";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1024, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "السعر الكلى";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Green;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.ForeColor = System.Drawing.SystemColors.Info;
            this.txtPrice.Location = new System.Drawing.Point(964, 174);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(221, 38);
            this.txtPrice.TabIndex = 16;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookName,
            this.AvailableBookNumber,
            this.NeddedNumber,
            this.BorrowPrice,
            this.TotalPrice});
            this.dataGridView1.Location = new System.Drawing.Point(6, 80);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(952, 297);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_RowValidating);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "رقم الكتاب";
            this.BookID.HeaderText = "رقم الكتاب";
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            this.BookID.Width = 152;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "اسم الكتاب";
            this.BookName.HeaderText = "اسم الكتاب";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            this.BookName.Width = 151;
            // 
            // AvailableBookNumber
            // 
            this.AvailableBookNumber.DataPropertyName = "عدد الكتب المتوفره";
            this.AvailableBookNumber.HeaderText = "عدد الكتب المتوفر";
            this.AvailableBookNumber.Name = "AvailableBookNumber";
            this.AvailableBookNumber.ReadOnly = true;
            this.AvailableBookNumber.Width = 152;
            // 
            // NeddedNumber
            // 
            this.NeddedNumber.DataPropertyName = "عدد الكتب المطلوب";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.NeddedNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.NeddedNumber.HeaderText = "عدد الكتب المطلوب";
            this.NeddedNumber.Name = "NeddedNumber";
            this.NeddedNumber.Width = 152;
            // 
            // BorrowPrice
            // 
            this.BorrowPrice.DataPropertyName = "سعر الاستعاره";
            this.BorrowPrice.HeaderText = "سعر الاستعاره";
            this.BorrowPrice.Name = "BorrowPrice";
            this.BorrowPrice.ReadOnly = true;
            this.BorrowPrice.Width = 151;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "السعر الكلى";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.TotalPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.TotalPrice.HeaderText = "السعر الكلى";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 151;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(964, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 39);
            this.button3.TabIndex = 8;
            this.button3.Text = "اضافة كتاب";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(536, 620);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(251, 48);
            this.btnBorrow.TabIndex = 2;
            this.btnBorrow.Text = "استعارة الكتب";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 620);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 48);
            this.button5.TabIndex = 3;
            this.button5.Text = "الغاء العمليه";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Frm_BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1227, 680);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_BorrowBook";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "استعارة كتاب";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private ComboBox cmbBorrowers;
        private Label label1;
        private Button button2;
        private GroupBox groupBox2;
        private Button button3;
        private Button btnBorrow;
        private Button button5;
        private Label label8;
        private DateTimePicker dateEndDate;
        private Label label7;
        private DateTimePicker dateStartDate;
        private Label lblNotes;
        private Button button6;
        private TextBox txtBorrowBookId;
        private Label label10;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox txtPrice;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn BookID;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn AvailableBookNumber;
        private DataGridViewTextBoxColumn NeddedNumber;
        private DataGridViewTextBoxColumn BorrowPrice;
        private DataGridViewTextBoxColumn TotalPrice;
    }
}