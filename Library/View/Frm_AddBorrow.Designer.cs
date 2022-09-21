namespace Library.View
{
    partial class Frm_AddBorrow
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrowName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBrowPhone2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrowPhone1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrowID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.double_arrow_left = new System.Windows.Forms.Button();
            this.arrow_left = new System.Windows.Forms.Button();
            this.arrow_right = new System.Windows.Forms.Button();
            this.double_arrow_right = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(682, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم المستعير";
            // 
            // txtBrowName
            // 
            this.txtBrowName.Location = new System.Drawing.Point(6, 37);
            this.txtBrowName.Name = "txtBrowName";
            this.txtBrowName.Size = new System.Drawing.Size(273, 38);
            this.txtBrowName.TabIndex = 3;
            this.txtBrowName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtBrowPhone2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBrowPhone1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBrowName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBrowID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(701, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(795, 192);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المستعير";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "عرض الاستعارات";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtBrowPhone2
            // 
            this.txtBrowPhone2.Location = new System.Drawing.Point(6, 92);
            this.txtBrowPhone2.Name = "txtBrowPhone2";
            this.txtBrowPhone2.Size = new System.Drawing.Size(273, 38);
            this.txtBrowPhone2.TabIndex = 7;
            this.txtBrowPhone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBrowPhone2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(285, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "رقم التليفون الثانى";
            // 
            // txtBrowPhone1
            // 
            this.txtBrowPhone1.Location = new System.Drawing.Point(438, 95);
            this.txtBrowPhone1.Name = "txtBrowPhone1";
            this.txtBrowPhone1.Size = new System.Drawing.Size(200, 38);
            this.txtBrowPhone1.TabIndex = 5;
            this.txtBrowPhone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBrowPhone1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(647, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "رقم التليفون الاول";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(320, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم المستعير";
            // 
            // txtBrowID
            // 
            this.txtBrowID.Location = new System.Drawing.Point(438, 37);
            this.txtBrowID.Name = "txtBrowID";
            this.txtBrowID.ReadOnly = true;
            this.txtBrowID.Size = new System.Drawing.Size(200, 38);
            this.txtBrowID.TabIndex = 1;
            this.txtBrowID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(683, 411);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.Controls.Add(this.btnDeleteAll);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Location = new System.Drawing.Point(781, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(661, 105);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحه";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Image = global::Library.Properties.Resources.icons8_cancel_48;
            this.btnDeleteAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAll.Location = new System.Drawing.Point(6, 44);
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
            this.btnDelete.Image = global::Library.Properties.Resources.icons8_trash_48;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(170, 44);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnDelete.Size = new System.Drawing.Size(110, 55);
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
            this.btnSave.Location = new System.Drawing.Point(286, 44);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnSave.Size = new System.Drawing.Size(117, 55);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Library.Properties.Resources.icons8_add_48;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(409, 44);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 55);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "اضافه";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::Library.Properties.Resources.icons8_new_file_48;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(537, 44);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(115, 55);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "جديد";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.double_arrow_left);
            this.groupBox3.Controls.Add(this.arrow_left);
            this.groupBox3.Controls.Add(this.arrow_right);
            this.groupBox3.Controls.Add(this.double_arrow_right);
            this.groupBox3.Location = new System.Drawing.Point(968, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(290, 105);
            this.groupBox3.TabIndex = 27;
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
            // Frm_AddBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 431);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AddBorrow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "اضافة مستعير";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private TextBox txtBrowName;
        private GroupBox groupBox1;
        private TextBox txtBrowPhone2;
        private Label label4;
        private TextBox txtBrowPhone1;
        private Label label3;
        private Label label2;
        private TextBox txtBrowID;
        private DataGridView dataGridView1;
        private Button button1;
        private GroupBox groupBox2;
        private Button btnDeleteAll;
        private Button btnDelete;
        private Button btnSave;
        private Button btnAdd;
        private Button btnNew;
        private GroupBox groupBox3;
        private Button double_arrow_left;
        private Button arrow_left;
        private Button arrow_right;
        private Button double_arrow_right;
    }
}