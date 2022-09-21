namespace Library.View
{
    partial class Frm_Countries
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
            this.double_arrow_left = new System.Windows.Forms.Button();
            this.arrow_left = new System.Windows.Forms.Button();
            this.double_arrow_right = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.arrow_right = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCountryID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // double_arrow_left
            // 
            this.double_arrow_left.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.double_arrow_left.Image = global::Library.Properties.Resources.icons8_double_left_48;
            this.double_arrow_left.Location = new System.Drawing.Point(11, 43);
            this.double_arrow_left.Name = "double_arrow_left";
            this.double_arrow_left.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.double_arrow_left.Size = new System.Drawing.Size(67, 54);
            this.double_arrow_left.TabIndex = 4;
            this.double_arrow_left.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.double_arrow_left.UseVisualStyleBackColor = true;
            this.double_arrow_left.Click += new System.EventHandler(this.double_arrow_left_Click);
            // 
            // arrow_left
            // 
            this.arrow_left.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.arrow_left.Image = global::Library.Properties.Resources.icons8_back_48;
            this.arrow_left.Location = new System.Drawing.Point(79, 43);
            this.arrow_left.Name = "arrow_left";
            this.arrow_left.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.arrow_left.Size = new System.Drawing.Size(57, 54);
            this.arrow_left.TabIndex = 3;
            this.arrow_left.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.arrow_left.UseVisualStyleBackColor = true;
            this.arrow_left.Click += new System.EventHandler(this.arrow_left_Click);
            // 
            // double_arrow_right
            // 
            this.double_arrow_right.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.double_arrow_right.Image = global::Library.Properties.Resources.icons8_double_right_48;
            this.double_arrow_right.Location = new System.Drawing.Point(206, 43);
            this.double_arrow_right.Name = "double_arrow_right";
            this.double_arrow_right.Size = new System.Drawing.Size(67, 54);
            this.double_arrow_right.TabIndex = 1;
            this.double_arrow_right.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.double_arrow_right.UseVisualStyleBackColor = true;
            this.double_arrow_right.Click += new System.EventHandler(this.double_arrow_right_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.double_arrow_left);
            this.groupBox3.Controls.Add(this.double_arrow_right);
            this.groupBox3.Controls.Add(this.arrow_left);
            this.groupBox3.Controls.Add(this.arrow_right);
            this.groupBox3.Location = new System.Drawing.Point(214, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(279, 103);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "اسهم التنقل";
            // 
            // arrow_right
            // 
            this.arrow_right.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.arrow_right.Image = global::Library.Properties.Resources.icons8_forward_48;
            this.arrow_right.Location = new System.Drawing.Point(143, 43);
            this.arrow_right.Name = "arrow_right";
            this.arrow_right.Size = new System.Drawing.Size(57, 54);
            this.arrow_right.TabIndex = 2;
            this.arrow_right.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.arrow_right.UseVisualStyleBackColor = true;
            this.arrow_right.Click += new System.EventHandler(this.arrow_right_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 346);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(702, 416);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDeleteAll.Image = global::Library.Properties.Resources.icons8_cancel_48;
            this.btnDeleteAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAll.Location = new System.Drawing.Point(16, 45);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnDeleteAll.Size = new System.Drawing.Size(158, 55);
            this.btnDeleteAll.TabIndex = 5;
            this.btnDeleteAll.Text = "مسح الكل";
            this.btnDeleteAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.Image = global::Library.Properties.Resources.icons8_trash_48;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(180, 45);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnDelete.Size = new System.Drawing.Size(116, 55);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "مسح";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Image = global::Library.Properties.Resources.icons8_save_close_48;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(302, 45);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnSave.Size = new System.Drawing.Size(116, 55);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.Image = global::Library.Properties.Resources.icons8_add_48;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(424, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 55);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "اضافه";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNew.Image = global::Library.Properties.Resources.icons8_new_file_48;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(556, 45);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(108, 55);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "جديد";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtCountryName
            // 
            this.txtCountryName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCountryName.Location = new System.Drawing.Point(12, 39);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(316, 38);
            this.txtCountryName.TabIndex = 3;
            this.txtCountryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCountryName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCountryName_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم الدوله";
            // 
            // txtCountryID
            // 
            this.txtCountryID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCountryID.Location = new System.Drawing.Point(456, 39);
            this.txtCountryID.Name = "txtCountryID";
            this.txtCountryID.ReadOnly = true;
            this.txtCountryID.Size = new System.Drawing.Size(125, 38);
            this.txtCountryID.TabIndex = 1;
            this.txtCountryID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الدوله";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.btnDeleteAll);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Location = new System.Drawing.Point(34, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(670, 107);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحه";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtCountryName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCountryID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(703, 106);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الدوله";
            // 
            // Frm_Countries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 774);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Countries";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الدول";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button double_arrow_left;
        private Button arrow_left;
        private Button double_arrow_right;
        private GroupBox groupBox3;
        private Button arrow_right;
        private DataGridView dataGridView1;
        private Button btnDeleteAll;
        private Button btnDelete;
        private Button btnSave;
        private Button btnAdd;
        private Button btnNew;
        private TextBox txtCountryName;
        private Label label2;
        private TextBox txtCountryID;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
    }
}