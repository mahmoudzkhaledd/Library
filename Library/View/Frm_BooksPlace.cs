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
    public partial class Frm_BooksPlace : Form , BoockPlaceInterFace
    {
        int BoockPlaceInterFace.id { get => Int32.Parse(txtPlaceID.Text); set => txtPlaceID.Text = value.ToString(); }
        string BoockPlaceInterFace.name { get => txtPlaceName.Text; set => txtPlaceName.Text = value; }
        public int Row { get => row; set => row = value; }

        object BoockPlaceInterFace.btnNew { get => btnNew.Enabled; set => btnNew.Enabled = Convert.ToBoolean(value); }
        object BoockPlaceInterFace.btnAdd { get => btnAdd.Enabled; set => btnAdd.Enabled = Convert.ToBoolean(value); }
        object BoockPlaceInterFace.btnSave { get => btnSave.Enabled; set => btnSave.Enabled = Convert.ToBoolean(value); }
        object BoockPlaceInterFace.btnDelete { get => btnDelete.Enabled; set => btnDelete.Enabled = Convert.ToBoolean(value); }
        object BoockPlaceInterFace.btnDeleteAll { get => btnDeleteAll.Enabled; set => btnDeleteAll.Enabled = Convert.ToBoolean(value); }
        public object Data
        {
            get
            {
                return dataGridView1.DataSource;
            }
            set
            {
                dataGridView1.DataSource = value;
            }
        }

        public int selectedRow { get => dataGridView1.CurrentRow.Index; set => dataGridView1.Rows[Convert.ToInt32(value)].Selected = true; }


        int row = 0;

        BoockPlacePresenter presenter;

        public Frm_BooksPlace()
        {
            InitializeComponent();
            presenter = new BoockPlacePresenter(this);
            txtPlaceName.Select();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            presenter.NextBoockPlace();
            txtPlaceName.Select();

        }
        void Add()
        {
            if (presenter.Insert())
            {
                MessageBox.Show("تم الاضافه بنجاح");

                presenter.NextBoockPlace();
                txtPlaceName.Select();
            }
            else
                MessageBox.Show("لم يتم الاضافه");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPlaceName.Text != "")
                Add();
            else
                MessageBox.Show("من فضلك ادخل اسم المكان");
            txtPlaceName.Select();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPlaceName.Text != "")
            {
                if (presenter.Update())
                    MessageBox.Show("تم الحفظ بنجاح");
                else
                    MessageBox.Show("لم يتم الحفظ");
            }
            else { MessageBox.Show("من فضلك ادخل كل البيانات"); }
            txtPlaceName.Select();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متاكد من عملية المسح ؟", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (presenter.Delete())
                {

                    presenter.NextBoockPlace();
                    txtPlaceName.Select();
                }
                else
                    MessageBox.Show("فشلت العمليه");


            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متاكد من مسح جميع الاماكن ؟", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (presenter.DeleteAll())
                {
                    presenter.New();
                    txtPlaceName.Select();
                }
                else
                    MessageBox.Show("فشلت العمليه");
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

        private void txtPlaceName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                Add();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try { dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index; }
            catch { }
        }
    }
}
