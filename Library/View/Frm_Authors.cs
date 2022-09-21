using Library.Logic.Presenters;
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
    public partial class Frm_Authors : Form, AuthorInterFace
    {
        AuthorPresenter presenter;
        public Frm_Authors()
        {
            InitializeComponent();
            presenter = new AuthorPresenter(this);
            dateTimePicker1.Value = DateTime.Now;
            presenter.GetData();
            if (!presenter.LoadCountries())
            {
                presenter.DisableAll();
            }
            else { presenter.New(); }
            try { cmbCountries.SelectedIndex = 0; } catch { }
        }
        int row = 0;

        public int id { get => Convert.ToInt32(txtAuthorId.Text); set => txtAuthorId.Text = value.ToString(); }
        public int Row { get => row; set => row = value; }
        public string name { get => txtAuthorName.Text; set => txtAuthorName.Text = value; }
        public object CountryData
        {
            get => cmbCountries.DataSource; set
            {
                cmbCountries.DataSource = value;
                cmbCountries.DisplayMember = "اسم الدوله";
                cmbCountries.ValueMember = "رقم الدوله";
            }
        }
        public object Data { get => dataGridView1.DataSource; set => dataGridView1.DataSource = value; }
        object AuthorInterFace.btnNew { get => btnNew.Enabled; set => btnNew.Enabled = Convert.ToBoolean(value); }
        object AuthorInterFace.btnAdd { get => btnAdd.Enabled; set => btnAdd.Enabled = Convert.ToBoolean(value); }
        object AuthorInterFace.btnSave { get => btnSave.Enabled; set => btnSave.Enabled = Convert.ToBoolean(value); }
        object AuthorInterFace.btnDelete { get => btnDelete.Enabled; set => btnDelete.Enabled = Convert.ToBoolean(value); }
        object AuthorInterFace.btnDeleteAll { get => btnDeleteAll.Enabled; set => btnDeleteAll.Enabled = Convert.ToBoolean(value); }
        public string AuthorDate { get => dateTimePicker1.Value.ToString(); set => dateTimePicker1.Value = DateTime.Parse((string)value); }
        public int CountryIndex
        {
            get => Convert.ToInt32(cmbCountries.SelectedValue);
            set
            {
                if (value != 0)
                    cmbCountries.SelectedValue = Convert.ToInt32(value);
                else if (value == 0)
                    cmbCountries.SelectedIndex = 0;
                else if (value == -1)
                {

                    cmbCountries.DataSource = null;
                    cmbCountries.Items.Clear();
                }
            }
        }

        public int selectedRow { get => dataGridView1.CurrentRow.Index; set => dataGridView1.Rows[Convert.ToInt32(value)].Selected = true; }

        private void double_arrow_left_Click(object sender, EventArgs e)
        {
            presenter.GetFirstID();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            presenter.New();
        }

        private void arrow_left_Click(object sender, EventArgs e)
        {
            presenter.StepBack();
        }

        private void arrow_right_Click(object sender, EventArgs e)
        {
            presenter.StepForward();
        }

        private void double_arrow_right_Click(object sender, EventArgs e)
        {
            presenter.GetLastID();
        }
        void Add()
        {
            if (txtAuthorName.Text != "" && cmbCountries.Items.Count > 0)
            {
                if (presenter.Insert())
                {
                    MessageBox.Show("تم الاضافه");
                }
                else
                {
                    MessageBox.Show("لم يتم الاضافه");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtAuthorName.Text != "")
                Add();
            else { MessageBox.Show("من فضلك ادخل كل البيانات"); }
            txtAuthorName.Select();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متاكد من مسح جميع المؤلفين ؟", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (presenter.DeleteAll())
                {
                    presenter.New();
                    txtAuthorName.Select();
                }
                else
                    MessageBox.Show("فشلت العمليه");
            }
        }

        private void txtAuthorName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                Add();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtAuthorName.Text != "")
            {
                if (presenter.Update())
                    MessageBox.Show("تم الحفظ بنجاح");
                else
                    MessageBox.Show("لم يتم الحفظ");
            }
            else { MessageBox.Show("من فضلك ادخل كل البيانات"); }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متاكد من عملية مسح ؟", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (presenter.Delete())
                {
                    presenter.New();
                    txtAuthorName.Select();
                }
                else
                    MessageBox.Show("فشلت العمليه");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Countries frm = new Frm_Countries();
            frm.ShowDialog();
            if (!presenter.LoadCountries())
            {
                presenter.DisableAll();
            }
            else { presenter.LoadCountries(); presenter.Disable(true); }
            try { cmbCountries.SelectedIndex = 0; } catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            presenter.Search();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try { dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index; }
            catch { }
        }
    }
}
