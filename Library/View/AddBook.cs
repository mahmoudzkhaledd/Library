using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Library;
using Library.View;
using Library.View.InterFaces;
using Library.Model;
using Library.Logic.Presenters;
using Library.Logic.Services;
using System.Data.SqlClient;
namespace Library.View
{
    public partial class Frm_AddBook : Form, BookInterFace
    {
        BookPresenter presenter;
        Frm_BrowsBooks? frm = null;
        public string note = "";
        public void UpdateNote(string data)
        {
            note = data;
        }
        public int id { get => Convert.ToInt32(txtID.Text); set => txtID.Text = value.ToString(); }
        public string name { get => txtBookName.Text; set => txtBookName.Text = value; }
        public int CatID { get => Convert.ToInt32(cmbGeneralCat.SelectedValue); set => cmbGeneralCat.SelectedValue = value; }
        public int AuthorID { get => Convert.ToInt32(cmbAuthor.SelectedValue); set => cmbAuthor.SelectedValue = value; }
        public int CountryID { get => Convert.ToInt32(cmbCountry.SelectedValue); set => cmbCountry.SelectedValue = value; }
        public int DarID { get => Convert.ToInt32(cmbDar.SelectedValue); set => cmbDar.SelectedValue = value; }
        public string SubCar { get => txtSubCat.Text; set => txtSubCat.Text = value; }
        string BookInterFace.Date { get => datePublish.Value.ToString(); set => datePublish.Value = DateTime.Parse((string)value); }
        public int PageNumber { get => Convert.ToInt32(numericPageNumber.Value); set => numericPageNumber.Value = value; }
        public int PlaceId { get => Convert.ToInt32(cmbPlace.SelectedValue); set { 
                cmbPlace.SelectedValue = value;
                cmbPlace.DisplayMember = "عنوان المكان";
                cmbPlace.ValueMember = "رقم المكان";
            } }
        public string BookStat
        {
            get => rdioBorrowed.Checked ? "معار" : "متوفر"; set
            {
                string x = value;
                if (x == "معار") { rdioBorrowed.Checked = true; rdioNotBorrowed.Checked = false; }
                else { rdioBorrowed.Checked = false; rdioNotBorrowed.Checked = true; }
            }
        }
        public decimal BookPrice { get => numbericPrice.Value; set => numbericPrice.Value = value; }
        public string Note { get => note; set  {
                note = value;
                if (note == "") { lblNotes.Text = "لا توجد ملاحظات"; btnAddNotes.Text = "اضافة ملاحظه"; }
                else { lblNotes.Text = "تم اضافة ملاحظه"; btnAddNotes.Text = "عرض الملاحظه"; }
            }}
        bool BookInterFace.btnNew { get => btnNew.Enabled; set => btnNew.Enabled = value; }
        bool BookInterFace.btnAdd { get => btnAdd.Enabled; set => btnAdd.Enabled = value; }
        bool BookInterFace.btnSave { get => btnSave.Enabled; set => btnSave.Enabled = value; }
        bool BookInterFace.btnDelete { get => btnDelete.Enabled; set => btnDelete.Enabled = value; }
        bool BookInterFace.btnDeleteAll { get => btnDeleteAll.Enabled; set => btnDeleteAll.Enabled = value; }

        public object cmbCountriesValue { get => cmbCountry.SelectedValue; set => cmbCountry.SelectedValue = value; }
        public object cmbCatValue { get => cmbGeneralCat.SelectedValue; set => cmbGeneralCat.SelectedValue = value; }
        public object cmbAuthorValue { get => cmbAuthor.SelectedValue; set => cmbAuthor.SelectedValue = value; }
        public object cmbDarValue { get => cmbDar.SelectedValue; set => cmbDar.SelectedValue = value; }
        public object cmbPlaceValue { get => cmbPlace.SelectedValue; set => cmbPlace.SelectedValue = value; }
        public object cmbBooksValue { get => cmbBooks.SelectedValue; set => cmbBooks.SelectedValue = value; }
        
        public int BookSelectedIndex { get => cmbBooks.SelectedIndex; set { 
                if(value != -1)
                    cmbBooks.SelectedIndex = value; 
                else
                    cmbBooks.SelectedIndex = cmbBooks.Items.Count - 1;
            } }
        public int BookSelectedValue { get => Convert.ToInt32(cmbBooks.SelectedValue) ; 
            set => cmbBooks.SelectedValue = value; }

        public int BookItemCount { get => cmbBooks.Items.Count; set  { } }



        public int cmbCountriesItemCount { get => cmbCountry.Items.Count; set { } }
        public int cmbCatItemCount { get => cmbGeneralCat.Items.Count; set { } }
        public int cmbAuthorItemCount { get => cmbAuthor.Items.Count; set { } }
        public int cmbDarItemCount { get => cmbDar.Items.Count; set { } }
        public int cmbPlaceItemCount { get => cmbPlace.Items.Count; set { } }
        


        public object cmbCountriesDataSource
        {
            get => cmbCountry.DataSource; set
            {
                cmbCountry.DataSource = value;
                cmbCountry.DisplayMember = "اسم الدوله";
                cmbCountry.ValueMember = "رقم الدوله";
            }
        }
        public object cmbCatDataSource
        {
            get => cmbGeneralCat.DataSource; set
            {
                cmbGeneralCat.DataSource = value;
                cmbGeneralCat.DisplayMember = "اسم التصنيف";
                cmbGeneralCat.ValueMember = "رقم التصنيف";
            }
        }
        public object cmbAuthorDataSource
        {
            get => cmbAuthor.DataSource; set
            {
                cmbAuthor.DataSource = value;
                cmbAuthor.DisplayMember = "name";
                cmbAuthor.ValueMember = "id";
            }
        }
        public object cmbDarDataSource
        {
            get => cmbDar.DataSource; set
            {
                cmbDar.DataSource = value;
                cmbDar.DisplayMember = "اسم الدار";
                cmbDar.ValueMember = "رقم دار النشر";
            }
        }
        public object cmbPlaceDataSource
        {
            get => cmbPlace.DataSource; set
            {
                cmbPlace.DataSource = value;
                cmbPlace.DisplayMember = "عنوان المكان";
                cmbPlace.ValueMember = "رقم المكان";
            }
        }
        public object cmbBooksDataSource
        {
            get => cmbBooks.DataSource; set
            {
                cmbBooks.DataSource = value;
                cmbBooks.DisplayMember = "اسم الكتاب";
                cmbBooks.ValueMember = "رقم الكتاب";
            }
        }

        public int BooksNumber { get => Convert.ToInt32(numberBook.Value); set => numberBook.Value = value; }
        public decimal BorrowPrice { get => numBorrowPrice.Value; 
            set => numBorrowPrice.Value = value; }

        public Frm_AddBook()
        {
            InitializeComponent();
            presenter = new BookPresenter(this);
            txtBookName.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_BookNotes frm = new Frm_BookNotes(UpdateNote,note);
            frm.ShowDialog();
            frm.Dispose();
            if(note == "") { lblNotes.Text = "لا توجد ملاحظات"; }
            else { lblNotes.Text = "تم اضافة ملاحطه"; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            presenter.Insert();
            txtBookName.Select();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            presenter.Update();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            presenter.Delete();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            presenter.DeleteAll();
        }
         
        private void btnNew_Click(object sender, EventArgs e)
        {
            presenter.NewBook();
        }

        private void double_arrow_right_Click(object sender, EventArgs e)
        {
            if(cmbBooks.Items.Count > 0)
                presenter.ToLastBook();
        }

        private void arrow_right_Click(object sender, EventArgs e)
        {
            if (cmbBooks.Items.Count > 0)
                presenter.StepForward();
        }

        private void arrow_left_Click(object sender, EventArgs e)
        {
            if (cmbBooks.Items.Count > 0)
                presenter.StepBack();
        }

        private void double_arrow_left_Click(object sender, EventArgs e)
        {
            if (cmbBooks.Items.Count > 0)
                presenter.ToFirstBook();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(frm == null) {
                frm = new Frm_BrowsBooks();
                frm.ShowDialog();
                frm.Dispose();
                frm = null;
            }
        }

        private void Frm_AddBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frm != null)
                frm.Dispose();
            frm = null;
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            Frm_Category cat = new Frm_Category();
            cat.ShowDialog();
            cat.Dispose();
            presenter.UpdateCat();
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            Frm_Countries frm = new Frm_Countries();
            frm.ShowDialog();
            frm.Dispose();
            presenter.UpdateCountry();
        }

        private void btnAddPlace_Click(object sender, EventArgs e)
        {
            Frm_BooksPlace frm = new Frm_BooksPlace();
            frm.ShowDialog();
            frm.Dispose();
            presenter.UpdatePlace();
        }

        private void btnAddDar_Click(object sender, EventArgs e)
        {
            Frm_Dar frm = new Frm_Dar();
            frm.ShowDialog();
            frm.Dispose();
            presenter.UpdateDar();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            Frm_Authors frm = new Frm_Authors();
            frm.ShowDialog();
            frm.Dispose();
            presenter.UpdateAuthor();
        }
    }
}
