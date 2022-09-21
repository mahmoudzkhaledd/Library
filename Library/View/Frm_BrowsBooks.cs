using Library.Logic.Presenters;
using Library.Logic.Services;
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
    public partial class Frm_BrowsBooks : Form , BrowseBooksInterFace
    {
        BrowsePresenter presenter;
        public Frm_BrowsBooks()
        {
            InitializeComponent();
            presenter = new BrowsePresenter(this);
        }

        public object DataGridDataSource { get => dataGridView1.DataSource; set
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = value;

            } }

        public bool All { get => rdioAllBooks.Checked; set => rdioAllBooks.Checked = value; }
        public bool ID { get => rdioBookNumber.Checked; set => rdioBookNumber.Checked = value; }
        public bool name { get =>rdioBookName.Checked ; set => rdioBookName.Checked = value; }
        public bool Cat { get => rdioCat.Checked; set => rdioCat.Checked = value; }
        public bool Dar { get =>rdioDar.Checked ; set => rdioDar.Checked =value; }
        public bool Country { get =>rdioCountry.Checked ; set => rdioCountry.Checked = value; }
        public bool Author { get =>rdioAuthor.Checked ; set => rdioAuthor.Checked = value; }
        public bool Place { get =>rdioPlace.Checked ; set => rdioPlace.Checked = value; }
        public bool subCat { get =>rdioSub.Checked ; set => rdioSub.Checked =value; }
        public bool Date { get => rdioDate.Checked; set => rdioDate.Checked = value; }

        public object CatDataSource { get => cmbGeneralCat.DataSource; 
            set { 
                cmbGeneralCat.DataSource = value;
                cmbGeneralCat.DisplayMember = "اسم التصنيف";
                cmbGeneralCat.ValueMember = "رقم التصنيف";
            } }
        public object DarDataSource { get => cmbDar.DataSource;
            set  { 
                cmbDar.DataSource = value;
                cmbDar.DisplayMember = "اسم الدار";
                cmbDar.ValueMember = "رقم دار النشر";
            } }
        public object CountryDataSource { get => cmbCountry.DataSource; 
            set {
                cmbCountry.DataSource = value;
                cmbCountry.DisplayMember = "اسم الدوله";
                cmbCountry.ValueMember = "رقم الدوله";
            } }
        public object AuthorDataSource { get => cmbAuthor.DataSource;
            set {
                cmbAuthor.DataSource = value;
                cmbAuthor.DisplayMember = "name";
                cmbAuthor.ValueMember = "id";
            } }
        public object PlaceDataSource { get => cmbPlace.DataSource; 
            set {
                cmbPlace.DataSource = value;
                cmbPlace.DisplayMember = "عنوان المكان";
                cmbPlace.ValueMember = "رقم المكان";
            } }

        public int CatSelectedValue { get => Convert.ToInt32(cmbGeneralCat.SelectedValue); set => cmbGeneralCat.SelectedValue = value; }
        public int DarSelectedValue { get => Convert.ToInt32(cmbDar.SelectedValue); set => cmbDar.SelectedValue = value; }
        public int CountrySelectedValue { get => Convert.ToInt32(cmbCountry.SelectedValue); set => cmbCountry.SelectedValue = value; }
        public int AuthorSelectedValue { get => Convert.ToInt32(cmbAuthor.SelectedValue); set => cmbAuthor.SelectedValue = value; }
        public int PlaceSelectedValue { get => Convert.ToInt32(cmbPlace.SelectedValue); set => cmbPlace.SelectedValue = value; }
        public int SelectedBookId { get => Convert.ToInt32(numID.Value); set => numID.Value = value; }
        public string SelectedBookName { get => txtName.Text; set => txtName.Text = value; }
        public string SelectedsubCat { get => txtSubCat.Text; set => txtSubCat.Text = value; }
        public string SelectedDate { get => dateTimePicker1.Text; set => dateTimePicker1.Value = DateTime.Parse((string)value); }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Frm_AddBook frm_AddBook = new Frm_AddBook()) {frm_AddBook.ShowDialog();frm_AddBook.Dispose(); }    
        }

        private void button2_Click(object sender, EventArgs e)
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
