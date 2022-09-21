namespace Library.View
{
    partial class Frm_ShowUsers
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
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.CheckBox();
            this.Date = new System.Windows.Forms.CheckBox();
            this.CardNumber = new System.Windows.Forms.CheckBox();
            this.Address = new System.Windows.Forms.CheckBox();
            this.Age = new System.Windows.Forms.CheckBox();
            this.UserName = new System.Windows.Forms.CheckBox();
            this.Email = new System.Windows.Forms.CheckBox();
            this.LastName = new System.Windows.Forms.CheckBox();
            this.MiddleName = new System.Windows.Forms.CheckBox();
            this.FirstName = new System.Windows.Forms.CheckBox();
            this.id = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1708, 495);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteAll);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Type);
            this.groupBox1.Controls.Add(this.Date);
            this.groupBox1.Controls.Add(this.CardNumber);
            this.groupBox1.Controls.Add(this.Address);
            this.groupBox1.Controls.Add(this.Age);
            this.groupBox1.Controls.Add(this.UserName);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.LastName);
            this.groupBox1.Controls.Add(this.MiddleName);
            this.groupBox1.Controls.Add(this.FirstName);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.txtCardNumber);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtMiddleName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1708, 256);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فلاتر البحث";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Image = global::Library.Properties.Resources.icons8_cancel_48;
            this.btnDeleteAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAll.Location = new System.Drawing.Point(6, 194);
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
            this.btnDelete.Location = new System.Drawing.Point(151, 194);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnDelete.Size = new System.Drawing.Size(115, 55);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "مسح";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 55);
            this.button2.TabIndex = 37;
            this.button2.Text = "تعديل البيانات";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(806, 156);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(66, 35);
            this.Type.TabIndex = 36;
            this.Type.Text = "النوع";
            this.Type.UseVisualStyleBackColor = true;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(746, 94);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(127, 35);
            this.Date.TabIndex = 35;
            this.Date.Text = "تاريخ التسجيل";
            this.Date.UseVisualStyleBackColor = true;
            // 
            // CardNumber
            // 
            this.CardNumber.AutoSize = true;
            this.CardNumber.Location = new System.Drawing.Point(758, 37);
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.Size = new System.Drawing.Size(115, 35);
            this.CardNumber.TabIndex = 34;
            this.CardNumber.Text = "رقم البطاقه";
            this.CardNumber.UseVisualStyleBackColor = true;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(1200, 205);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(83, 35);
            this.Address.TabIndex = 33;
            this.Address.Text = "العنوان";
            this.Address.UseVisualStyleBackColor = true;
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(1213, 156);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(69, 35);
            this.Age.TabIndex = 32;
            this.Age.Text = "العمر";
            this.Age.UseVisualStyleBackColor = true;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(1145, 96);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(137, 35);
            this.UserName.TabIndex = 31;
            this.UserName.Text = "اسم المستخدم";
            this.UserName.UseVisualStyleBackColor = true;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(1200, 37);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(82, 35);
            this.Email.TabIndex = 30;
            this.Email.Text = "الايميل";
            this.Email.UseVisualStyleBackColor = true;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(1586, 205);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(116, 35);
            this.LastName.TabIndex = 29;
            this.LastName.Text = "الاسم الاخير";
            this.LastName.UseVisualStyleBackColor = true;
            // 
            // MiddleName
            // 
            this.MiddleName.AutoSize = true;
            this.MiddleName.Location = new System.Drawing.Point(1570, 156);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(132, 35);
            this.MiddleName.TabIndex = 28;
            this.MiddleName.Text = "الاسم الاوسط";
            this.MiddleName.UseVisualStyleBackColor = true;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(1587, 96);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(115, 35);
            this.FirstName.TabIndex = 27;
            this.FirstName.Text = "الاسم الاول";
            this.FirstName.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(1570, 37);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(132, 35);
            this.id.TabIndex = 26;
            this.id.Text = "رقم المستخدم";
            this.id.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Library.Properties.Resources.icons8_search_150;
            this.pictureBox2.Location = new System.Drawing.Point(6, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = global::Library.Properties.Resources.file;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(162, 28);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(305, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(473, 154);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(254, 38);
            this.txtType.TabIndex = 23;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(473, 92);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(254, 38);
            this.txtDate.TabIndex = 22;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(473, 35);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(254, 38);
            this.txtCardNumber.TabIndex = 21;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(884, 203);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(254, 38);
            this.txtAddress.TabIndex = 20;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(886, 154);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(254, 38);
            this.txtAge.TabIndex = 19;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(886, 92);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(254, 38);
            this.txtUserName.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(886, 35);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(254, 38);
            this.txtEmail.TabIndex = 17;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(1311, 203);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(249, 38);
            this.txtLastName.TabIndex = 16;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(1311, 154);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(254, 38);
            this.txtMiddleName.TabIndex = 15;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(1311, 94);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(254, 38);
            this.txtFirstName.TabIndex = 14;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(1311, 35);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(254, 38);
            this.txtid.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library.Properties.Resources.icons8_cancel_48;
            this.pictureBox1.Location = new System.Drawing.Point(1693, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Frm_ShowUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1732, 797);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ShowUsers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المستخدمين";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_ShowUsers_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox txtType;
        private TextBox txtDate;
        private TextBox txtCardNumber;
        private TextBox txtAddress;
        private TextBox txtAge;
        private TextBox txtUserName;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtMiddleName;
        private TextBox txtFirstName;
        private TextBox txtid;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CheckBox Type;
        private CheckBox Date;
        private CheckBox CardNumber;
        private CheckBox Address;
        private CheckBox Age;
        private CheckBox UserName;
        private CheckBox Email;
        private CheckBox LastName;
        private CheckBox MiddleName;
        private CheckBox FirstName;
        private CheckBox id;
        private Button button2;
        private Button btnDeleteAll;
        private Button btnDelete;
    }
}