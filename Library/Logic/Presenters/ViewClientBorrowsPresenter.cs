using Library.Logic.Services;
using Library.Model;
using Library.View.InterFaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic.Presenters
{
    public class ViewClientBorrowsPresenter
    {
        ViewClientBorrowsInterFace interFace;
        AddBorrowerModel model;
        BorrowBookModel bookModel = new BorrowBookModel();
        int id;
        public ViewClientBorrowsPresenter(ViewClientBorrowsInterFace i, int id)
        {
            this.id = id;
            interFace = i;
            UpdateDataSource();
            ToFirstBorrower();
        }
        void ConnectModelInterFace()
        {
            bookModel.id = interFace.BorrowID;
        }

        void UpdateDataSource()
        {
            DataTable dt;
            if (id != -1)
            {
                dt = ViewClientBorrowsServices.GetClientData(id);
                try
                {
                    DataRow dr = AddBorrowerServices.GetDataByID(id).Rows[0];
                    model = new AddBorrowerModel(
                       Convert.ToInt32(dr[0]),
                       Convert.ToString(dr[1]),
                       Convert.ToString(dr[3]),
                       Convert.ToString(dr[4]));
                    interFace.dataSource = ViewClientBorrowsServices.GetClientData(id);
                }
                catch { }
                LoadModel();
            }
            else
            {
                dt = ViewClientBorrowsServices.GetAllData();
            }
            interFace.BooksDataSource = BookServices.GetAllData();
            interFace.dataSource = dt;
        }
        public void Update()
        {
            bool b = false;
            DataGridViewRow dg;
            dg = interFace.CurrentRow;
            b = BorrowBookServices.Update(
                id: interFace.BorrowID,
                BorrowerId: interFace.id,
                bookID: interFace.BookID,
                BooksNumber: interFace.BooksNumber,
                startDate: interFace.StartDate,
                endDate: interFace.EndDate,
                note: interFace.Note);
            if (b) MessageBox.Show("نجحت العمليه");
            else MessageBox.Show("فشلت");
            UpdateDataSource();
        }
        public void Delete()
        {
            if (ViewClientBorrowsServices.Delete(interFace.BorrowID))
            {
                MessageBox.Show("تم الحذف بنجاح");
                UpdateDataSource();
            }
            else { MessageBox.Show("فشلت العمليه"); }
        }
        public void DeleteAll()
        {


            if (ViewClientBorrowsServices.DeleteAll(id))
            {
                MessageBox.Show("تم الحذف بنجاح");
                UpdateDataSource();
            }
            else { MessageBox.Show("فشلت العمليه"); }


        }
        void SetData()
        {
            DataGridViewRow row = interFace.CurrentRow;
            interFace.BorrowID = Convert.ToInt32(row.Cells["Column1"].Value);
            interFace.StartDate = Convert.ToString(row.Cells["Column6"].Value);
            interFace.EndDate = Convert.ToString(row.Cells["Column7"].Value);
            interFace.BooksNumber = Convert.ToInt32(row.Cells["Column5"].Value);
            interFace.Note = Convert.ToString(row.Cells["Column8"].Value);
            interFace.BookID = Convert.ToInt32(row.Cells["book_id"].Value);
        }
        public void LoadModel()
        {
            interFace.id = model.id;
            interFace.name = model.name;
            interFace.phone_1 = model.phone_1;
            interFace.phone_2 = model.phone_2;
        }
        public void ToLastBorrower()
        {
            if (interFace.RowCount > 0)
            {
                interFace.SelectedRow = interFace.RowCount - 1;
                interFace.SelectedIndex = interFace.SelectedRow;
                SetData();
            }
        }
        public void ToFirstBorrower()
        {
            if (interFace.RowCount > 0)
            {
                interFace.SelectedRow = 0;
                interFace.SelectedIndex = interFace.SelectedRow;
                SetData();
            }
        }
        public void StepForward()
        {
            if (interFace.RowCount > 0)
            {
                if (interFace.SelectedRow < interFace.RowCount - 1)
                {
                    interFace.SelectedRow++;
                    interFace.SelectedIndex = interFace.SelectedRow; SetData();
                }
                else
                {
                    interFace.SelectedRow = 0;
                    interFace.SelectedIndex = interFace.SelectedRow; SetData();
                }
                SetData();
            }

        }
        public void StepBack()
        {
            if (interFace.RowCount > 0)
            {
                if (interFace.SelectedRow > 0)
                {
                    interFace.SelectedRow--;
                    interFace.SelectedIndex = interFace.SelectedRow; SetData();
                }
                else
                {
                    interFace.SelectedRow = interFace.RowCount - 1;
                    interFace.SelectedIndex = interFace.SelectedRow; SetData();
                }
                SetData();
            }
        }
    }
}
