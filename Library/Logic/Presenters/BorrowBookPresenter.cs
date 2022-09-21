using Library.Logic.Services;
using Library.Model;
using Library.View.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.View;
using System.Data;

namespace Library.Logic.Presenters
{
    public class BorrowBookPresenter
    {
        BorrowBookInterFace interFace;
        BorrowBookModel model = new BorrowBookModel();
        bool cmbBorrowers = false;
        bool dgv = false;
        AddBorrowerModel Borrowermodel = new AddBorrowerModel();
        public BorrowBookPresenter(BorrowBookInterFace i)
        {
            interFace = i;
            UpdateBorrowers();
            LoadData();
            
        }
        public void UpdateBorrowers() 
        {
            DataTable dt = AddBorrowerServices.GetAllData();
            interFace.cmbBorrowersDataSource = dt;
            cmbBorrowers = dt.Rows.Count > 0;
            btnBorrowEnabled();
        }
        public void LoadData()
        {
            GetNextID();
            DataTable dt = BorrowBookServices.GetAllData(interFace.ShowUnAvailable);
            interFace.DataGridDataSource = dt;
            interFace.price = 0;
            dgv = dt.Rows.Count > 0; 
            btnBorrowEnabled();
        }
        void btnBorrowEnabled() {
            if (dgv && cmbBorrowers)
                interFace.btnBorrowEnabled = true;
            else
                interFace.btnBorrowEnabled = false;
        }
        void ConnectModelInterFace()
        {
            model.id = interFace.id;
            model.BorrowerID = interFace.BorrowerID;
            model.StartDate = interFace.StartDate;
            model.EndDate = interFace.EndDate;
            model.TotalPrice = interFace.TotalRowPrice;
            model.Note = interFace.Note;
        }
        public void ViewClientBorrows(int id)
        {
            using (Frm_ViewClientBorrows frm = new Frm_ViewClientBorrows(Convert.ToInt32(id)))
            {
                frm.ShowDialog(); 
                frm.Dispose();
            }
        }
        public void Insert()
        {
            ConnectModelInterFace();
            bool b = false; DataGridViewRow dg;
            for (int i = 0; i < interFace.RowCount; i++)
            {
                dg = interFace.GetRow(i);
                string? x = Convert.ToString(dg.Cells["NeddedNumber"].Value);
                if (x != null && x != "" && Int32.Parse(x) != 0)
                {
                    b = BorrowBookServices.Insert(
                    id: interFace.id,
                    BorrowerId: interFace.cmbBorrowersSelectedValue,
                    bookID: Convert.ToInt32(dg.Cells["BookID"].Value),
                    BooksNumber: Convert.ToInt32(dg.Cells["NeddedNumber"].Value),
                    startDate: interFace.StartDate,
                    endDate: interFace.EndDate,
                    Total: interFace.TotalRowPrice,
                    note: interFace.Note);
                    MessageBox.Show(dg.Cells["AvailableBookNumber"].Value.ToString());
                    MessageBox.Show(dg.Cells["NeddedNumber"].Value.ToString());
                    BookServices.UpdateBooksNumber(Convert.ToInt32(
                        dg.Cells["AvailableBookNumber"].Value)-Convert.ToInt32(dg.Cells["NeddedNumber"].Value),
                        Convert.ToInt32(dg.Cells["BookID"].Value)
                        );

                    GetNextID();


                }
            }
            if (b)
            {
                MessageBox.Show("تمت الاستعاره");
                LoadData();

            }
            else
            {
                MessageBox.Show("فشلت العمليه");
            }
        }
        public void Delete()
        {
            ConnectModelInterFace();
            if (BorrowBookServices.Delete(model.id))
            {
                MessageBox.Show("تمت العمليه بنجاح");
            }
            else
            {
                MessageBox.Show("فشلت العمليه");
            }
        }
        public void DeleteAll()
        {
            ConnectModelInterFace();
            if (BorrowBookServices.DeleteAll())
            {
                MessageBox.Show("تمت العمليه بنجاح");
            }
            else
            {
                MessageBox.Show("فشلت العمليه");
            }
        }
        public void GetNextID()
        {
            interFace.id = BorrowBookServices.GetLastID() + 1;
        }
    }
}
