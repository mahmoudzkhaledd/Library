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
    public partial class Frm_BorrowBook : Form, BorrowBookInterFace
    {
        BorrowBookPresenter presenter;
        string note = "";
        public Frm_BorrowBook()
        {
            InitializeComponent();
            dateStartDate.Value = DateTime.Now;
            dateEndDate.Value = DateTime.Now.AddDays(1);
            presenter = new BorrowBookPresenter(this);
            dataGridView1.Columns["TotalPrice"].DefaultCellStyle.ForeColor = Color.Red;
            /*if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns["NeddedNumber"].DefaultCellStyle.NullValue = "0";
                dataGridView1.Columns["TotalPrice"].DefaultCellStyle.NullValue = "0";
            }*/
        }

        public int id
        { get => Convert.ToInt32(txtBorrowBookId.Text); set => txtBorrowBookId.Text = value.ToString(); }
        public int BorrowerID
        {
            get => Convert.ToInt32(txtBorrowBookId.Text);
            set
            {
                txtBorrowBookId.Text = value.ToString();
            }
        }
        public string StartDate
        {
            get => dateStartDate.Value.ToString();
            set => dateStartDate.Value = DateTime.Parse((string)value);
        }
        public string EndDate
        {
            get => dateEndDate.Value.ToString();
            set => dateEndDate.Value = DateTime.Parse((string)value);
        }
        public string Note
        { get => note; set => note = value; }
        public object DataGridDataSource
        {
            get => dataGridView1.DataSource; set
            {
                dataGridView1.DataSource = value;
            }
        }

        public object cmbBorrowersDataSource
        {
            get => cmbBorrowers.DataSource;
            set
            {
                cmbBorrowers.DataSource = value;
                cmbBorrowers.DisplayMember = "الاسم";
                cmbBorrowers.ValueMember = "رقم المستعير";
            }
        }

        public int RowCount { get => dataGridView1.Rows.Count; set { } }

        public int cmbBorrowersSelectedValue { get => Convert.ToInt32(cmbBorrowers.SelectedValue); set { cmbBorrowers.SelectedValue = value; } }
        public decimal price
        {
            get => Convert.ToDecimal(txtPrice.Text);
            set
            {
               txtPrice.Text = value.ToString();
            }
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            presenter.Insert();
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control != null && e.Control is TextBox)
            {
                e.Control.KeyPress += delegate (object se, KeyPressEventArgs k)
                {
                    k.Handled = !char.IsDigit(k.KeyChar) && !char.IsControl(k.KeyChar);
                };
            }
        }

        public DataGridViewRow GetRow(int id)
        {
            return dataGridView1.Rows[id];
        }
        public decimal TotalRowPrice
        {
            get => Convert.ToDecimal(dataGridView1.CurrentRow.Cells["TotalPrice"].Value);
            set
            { 
                int NeededNumber;
                try { 
                    NeededNumber = Convert.ToInt32(dataGridView1.CurrentRow.Cells["NeddedNumber"].Value);
                } 
                catch { 
                    NeededNumber = 0;
                }
                decimal BorrowPrice = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["BorrowPrice"].Value);
                dataGridView1.CurrentRow.Cells["TotalPrice"].Value = NeededNumber * BorrowPrice;
            }
        }

        public bool ShowUnAvailable { get => checkBox1.Checked; set => checkBox1.Checked = value; }
        public bool btnBorrowEnabled { get => btnBorrow.Enabled; 
            set => btnBorrow.Enabled = value; }

        private void cmbBorrowers_SelectedValueChanged(object sender, EventArgs e)
        {

        }
        void AddNote(string n)
        {
            Note = n;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            using (Frm_BookNotes frm = new Frm_BookNotes(AddNote, Note))
            {
                frm.ShowDialog();
                frm.Dispose();
                if (Note == "")
                {
                    lblNotes.Text = "لا توجد ملاحظات";
                }
                else { lblNotes.Text = "تم اضافة ملاحظات"; }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Frm_AddBorrow frm = new Frm_AddBorrow())
            {
                frm.ShowDialog();
                frm.Dispose();
                presenter.UpdateBorrowers();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(cmbBorrowers.Items.Count > 0)
                 presenter.ViewClientBorrows(Convert.ToInt32(cmbBorrowers.SelectedValue));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Frm_AddBook frm = new Frm_AddBook())
            {
                frm.ShowDialog();
                presenter.LoadData();
                frm.Dispose();
            }
        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            string? NeededNumber = Convert.ToString(dataGridView1.CurrentRow.Cells["NeddedNumber"].Value);
            string? AvailableNumber = Convert.ToString(dataGridView1.CurrentRow.Cells["AvailableBookNumber"].Value);
            string? BorrowPrice = Convert.ToString(dataGridView1.CurrentRow.Cells["BorrowPrice"].Value);
            if (NeededNumber != null && NeededNumber != "")
            {
                int nedded = Convert.ToInt32(NeededNumber);
                int available = Convert.ToInt32(AvailableNumber);
                if (nedded > available)
                { 
                    MessageBox.Show("عدد المطلوب اكبر من العدد المتوفر");
                    dataGridView1.CurrentRow.Cells["NeddedNumber"].Value = "0";
                }
                TotalRowPrice = 0;
            }
            else if(NeededNumber != null && NeededNumber == "") {
                TotalRowPrice = 0;
                dataGridView1.CurrentRow.Cells["NeddedNumber"].Value = "0";
            }
            price = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells["TotalPrice"].Value));
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try { dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index; }
            catch { }
        }

        
    }
}
