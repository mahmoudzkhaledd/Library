using Library.Logic.Presenters;
using Library.Model;
using Library.View.InterFaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.View
{
    public partial class Frm_ViewClientBorrows : Form , ViewClientBorrowsInterFace
    {
        ViewClientBorrowsPresenter presenter;
        public Frm_ViewClientBorrows(int id = -1)
        {   
            InitializeComponent();
            presenter = new ViewClientBorrowsPresenter(this, id);
        }
        
        public object dataSource { get => dataGridView1.DataSource; set => dataGridView1.DataSource = value; }
        public int id { get { return Convert.ToInt32(txtBorrowBookId.Text); } set => txtBorrowBookId.Text = value.ToString(); }
        public string name { get => txtName.Text ; set => txtName.Text = value; }
        public string phone_1 { get => txtPhone1.Text; set => txtPhone1.Text = value; }
        public string phone_2 { get => txtPhone2.Text; set => txtPhone2.Text = value; }
        public DataGridViewRow CurrentRow { get => dataGridView1.SelectedRows[0]; set { }}
        int Row = 0;
        public int SelectedIndex { get => dataGridView1.CurrentRow.Index ; set => dataGridView1.Rows[value].Selected = true; }
        public int SelectedRow { get =>Row ; set =>Row = value; }
        bool ViewClientBorrowsInterFace.btnSave { get => btnSave.Enabled; set => btnSave.Enabled = value; }
        bool ViewClientBorrowsInterFace.btnDelete { get => btnDelete.Enabled; set => btnDelete.Enabled = value; }
        bool ViewClientBorrowsInterFace.btnDeleteAll { get => btnDeleteAll.Enabled; set => btnDeleteAll.Enabled = value; }
        public int RowCount { get => dataGridView1.Rows.Count; set { } }

        public int BorrowID { get => Convert.ToInt32(txtBorrowBookId.Text); set => txtBorrowBookId.Text = value.ToString(); }
        public string StartDate { get =>dateStartDate.Value.ToString() ; 
            set => dateStartDate.Value = DateTime.Parse((string)value); }
        public string EndDate
        {
            get => dateEndDate.Value.ToString();
            set => dateEndDate.Value = DateTime.Parse((string)value);
        }
        public string Note { get => txtNote.Text; set => txtNote.Text = value; }
        public int BooksNumber 
        { get =>Convert.ToInt32(numericUpDown1.Value); set => numericUpDown1.Value = value; }
        public int BookID { get => Convert.ToInt32(cmbBooks.SelectedValue); set => cmbBooks.SelectedValue = value; }
        public object BooksDataSource { 
            get => cmbBooks.DataSource; 
            set {
                cmbBooks.DataSource = value;
                cmbBooks.DisplayMember = "اسم الكتاب";
                cmbBooks.ValueMember = "رقم الكتاب";
            } }

        private void double_arrow_right_Click(object sender, EventArgs e)
        {
            presenter.ToLastBorrower();
        }

        private void double_arrow_left_Click(object sender, EventArgs e)
        {
            presenter.ToFirstBorrower();
        }

        private void arrow_right_Click(object sender, EventArgs e)
        {
            presenter.StepForward();
        }

        private void arrow_left_Click(object sender, EventArgs e)
        {
            presenter.StepBack();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try { dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index; }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbBooks.SelectedValue.ToString());
            if (txtBorrowBookId.Text != "" && dataGridView1.Rows.Count > 0)
                presenter.Update();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtBorrowBookId.Text != "" && dataGridView1.Rows.Count > 0)
                presenter.Delete();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (txtBorrowBookId.Text != "" && dataGridView1.Rows.Count > 0)
                presenter.DeleteAll();
        }
    }
}
