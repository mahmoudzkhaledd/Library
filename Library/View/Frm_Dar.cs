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
    public partial class Frm_Dar : Form ,DarInterFace
    {
        DarPresenter presenter;
        public Frm_Dar()
        {
            InitializeComponent();
            presenter = new DarPresenter(this);
            txtDarName.Select();
            presenter.GetData();
            
            try { cmbContries.SelectedIndex = 0; dataGridView1.Rows[0].Selected = true; } catch { }
        }
        int row = 0;
        public int id { get => Convert.ToInt32(txtDarID.Text); set => txtDarID.Text = value.ToString(); }
        public string name { get => txtDarName.Text; set => txtDarName.Text = value; }
        public object DataGridDataSource { get => dataGridView1.DataSource; set => dataGridView1.DataSource = value; }
        public int CurrentRow { get => row; set => row = value; }
        object DarInterFace.btnNew { get => btnNew.Enabled; set => btnNew.Enabled = Convert.ToBoolean(value); }
        object DarInterFace.btnAdd { get => btnAdd.Enabled; set => btnAdd.Enabled = Convert.ToBoolean(value); }
        object DarInterFace.btnSave { get => btnSave.Enabled; set => btnSave.Enabled = Convert.ToBoolean(value); }
        object DarInterFace.btnDelete { get => btnDelete.Enabled; set => btnDelete.Enabled = Convert.ToBoolean(value); }
        object DarInterFace.btnDeleteAll { get => btnDeleteAll.Enabled; set => btnDeleteAll.Enabled = Convert.ToBoolean(value); }
        public object btnArrowLeft { get => arrow_left.Enabled; set => arrow_left.Enabled = Convert.ToBoolean(value); }
        public object btnArrowRight { get => arrow_right.Enabled; set => arrow_right.Enabled = Convert.ToBoolean(value); }
        public object btnDoubleArrowLeft { get => double_arrow_left.Enabled; set => double_arrow_left.Enabled = Convert.ToBoolean(value); }
        public object btnDoubleArrowRight { get => double_arrow_right.Enabled; set => double_arrow_right.Enabled = Convert.ToBoolean(value); }

        public object cmbDataSource { get {
                return dataGridView1.DataSource;
            } set {
                cmbContries.DataSource = value;
                cmbContries.DisplayMember = "اسم الدوله";
                cmbContries.ValueMember = "رقم الدوله";
            } }
        public int SelectedDataGridRow { get {
                try { return dataGridView1.CurrentRow.Index; } catch { return 0; }
            } 
            set => dataGridView1.Rows[Convert.ToInt32(value)].Selected = true; }

        public int SelectedCountryValue { get  
            { return Convert.ToInt32(cmbContries.SelectedValue); } 
            set { 
                if(value != -1)
                    cmbContries.SelectedValue = value; 
                else
                {
                    if(cmbContries.Items.Count > 0)
                        cmbContries.SelectedIndex = 0;
                }
            } }
        

        private void btnNew_Click(object sender, EventArgs e)
        {
            presenter.SetNewData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            presenter.Insert();
            txtDarName.Select();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtDarName.Text != "")
                presenter.Update();
            else { MessageBox.Show("من فضلك ادخل كل البيانات"); }
            txtDarName.Select();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            presenter.Delete();
            txtDarName.Select();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            presenter.DeleteAll();
            txtDarName.Select();
        }

        private void double_arrow_left_Click(object sender, EventArgs e)
        {
            presenter.GetFirstDar();
        }
        private void double_arrow_right_Click(object sender, EventArgs e)
        {
            presenter.GetLastDar();
        }
        private void arrow_left_Click(object sender, EventArgs e)
        {
            presenter.StepBack();
        }

        private void arrow_right_Click(object sender, EventArgs e)
        {
            presenter.StepForward();
           
        }

        private void txtDarName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                presenter.Insert();
                txtDarName.Select();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try { dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index; }
            catch { }
        }
    }
}
