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
    public partial class Frm_AddBorrow : Form , AddBorrowerInterFace
    {
        AddBorrowerPresenter presenter;
        public int id { get => Convert.ToInt32(txtBrowID.Text); set => txtBrowID.Text = value.ToString(); }
        public string name { get =>txtBrowName.Text ; set =>txtBrowName.Text = value ; }
        public string phone_1 { get => txtBrowPhone1.Text; set => txtBrowPhone1.Text = value; }
        public string phone_2 { get => txtBrowPhone2.Text; set => txtBrowPhone2.Text = value; }
        bool AddBorrowerInterFace.btnNew { get => btnNew.Enabled; set => btnNew.Enabled = value; }
        bool AddBorrowerInterFace.btnAdd { get => btnAdd.Enabled; set => btnAdd.Enabled = value; }
        bool AddBorrowerInterFace.btnSave { get => btnSave.Enabled; set => btnSave.Enabled = value; }
        bool AddBorrowerInterFace.btnDelete { get => btnDelete.Enabled; set => btnDelete.Enabled = value; }
        bool AddBorrowerInterFace.btnDeleteAll { get => btnDeleteAll.Enabled; set => btnDeleteAll.Enabled = value; }
        public object DataGridDataSource { get =>dataGridView1.DataSource ; set =>dataGridView1.DataSource = value ; }
        public int SelectedIndex { get =>dataGridView1.CurrentRow.Index ; set => dataGridView1.Rows[value].Selected = true ; }
        public int ItemsCount { get => dataGridView1.Rows.Count; set { } }

        public int SelectedRow { get => row; set => row = value; }
        int row = 0;
        public Frm_AddBorrow()
        {
            InitializeComponent();
            presenter = new AddBorrowerPresenter(this);
            txtBrowName.Select();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            presenter.NewBorrow();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtBrowName.Text != "" && txtBrowPhone1.Text != "" && txtBrowPhone2.Text != "")
                presenter.Insert();
            else { MessageBox.Show("من فضلك ادخل كل البيانات"); }
            txtBrowName.Select();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBrowName.Text != "" && txtBrowPhone1.Text != "" && txtBrowPhone2.Text != "")
                presenter.Update();
            else { MessageBox.Show("من فضلك ادخل كل البيانات"); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            presenter.Delete();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            presenter.DeleteAll();
        }

        private void double_arrow_right_Click(object sender, EventArgs e)
        {
            presenter.ToLastBorrow();
        }

        private void double_arrow_left_Click(object sender, EventArgs e)
        {
            presenter.ToFirstBorrow();
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
    }
}
