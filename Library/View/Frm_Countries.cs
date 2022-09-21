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
    public partial class Frm_Countries : Form , CountryInterFace
    {
        CountryPresenter presenter;
        public Frm_Countries()
        {
            InitializeComponent();
            presenter = new CountryPresenter(this);
            presenter.GetData();
            txtCountryName.Select();
            presenter.NextCountry();
            presenter.Disable(true);
        }

        int CountryInterFace.id { get => Int32.Parse(txtCountryID.Text); set => txtCountryID.Text = value.ToString(); }
        string CountryInterFace.name { get => txtCountryName.Text; set => txtCountryName.Text = value; }
        public int Row { get => row; set => row = value; }

        object CountryInterFace.btnNew { get => btnNew.Enabled; set => btnNew.Enabled = Convert.ToBoolean(value); }
        object CountryInterFace.btnAdd { get => btnAdd.Enabled; set => btnAdd.Enabled = Convert.ToBoolean(value); }
        object CountryInterFace.btnSave { get => btnSave.Enabled; set => btnSave.Enabled = Convert.ToBoolean(value); }
        object CountryInterFace.btnDelete { get => btnDelete.Enabled; set => btnDelete.Enabled = Convert.ToBoolean(value); }
        object CountryInterFace.btnDeleteAll { get => btnDeleteAll.Enabled; set => btnDeleteAll.Enabled = Convert.ToBoolean(value); }


        int row = 0;


        public object Data { 
            get {
                return dataGridView1.DataSource; 
            } 
            set {
                dataGridView1.DataSource = value; 
            } 
        }

        public int selectedRow { get => dataGridView1.CurrentRow.Index; set => dataGridView1.Rows[Convert.ToInt32(value)].Selected = true; }

        private void btnNew_Click(object sender, EventArgs e)
        {
            presenter.NextCountry();
            txtCountryName.Select();

        }
        void Add() {
            if (presenter.Insert())
            {
                MessageBox.Show("تم الاضافه بنجاح");

                presenter.NextCountry();
                txtCountryName.Select();
            }
            else
                MessageBox.Show("لم يتم الاضافه");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCountryName.Text != "")
                Add();
            else
                MessageBox.Show("من فضلك ادخل اسم الدوله");
            txtCountryName.Select();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCountryName.Text != "")
                if (presenter.Update())
                     MessageBox.Show("تم الحفظ بنجاح");
                else
                     MessageBox.Show("لم يتم الحفظ");
            txtCountryName.Select();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متاكد من عملية المسح ؟", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (presenter.Delete())
                {
                    
                    presenter.NextCountry();
                    txtCountryName.Select();
                }
                else
                    MessageBox.Show("فشلت العمليه");
                

            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متاكد من مسح جميع الدول ؟", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (presenter.DeleteAll())
                {
                    presenter.New();
                    txtCountryName.Select();
                }
                else
                    MessageBox.Show("فشلت العمليه");
                
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try { dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index; }
            catch { }
        }

        private void txtCountryName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                e.Handled = true;
                Add();
            }
        }

        private void double_arrow_left_Click(object sender, EventArgs e)
        {
            presenter.GetFirstID();
        }

        private void arrow_left_Click(object sender, EventArgs e)
        {
            presenter.StepBack();
            
        }

        private void double_arrow_right_Click(object sender, EventArgs e)
        {
            presenter.GetLastID();
        }

        private void arrow_right_Click(object sender, EventArgs e)
        {
            presenter.StepForward();
        }
    }
}
