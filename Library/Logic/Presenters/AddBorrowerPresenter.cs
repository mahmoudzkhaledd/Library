using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Library.Model;
using Library.View.InterFaces;
using Library.Logic.Services;

namespace Library.Logic.Presenters
{
    public class AddBorrowerPresenter
    {
        AddBorrowerModel model = new AddBorrowerModel();
        AddBorrowerInterFace interFace;
        public AddBorrowerPresenter(AddBorrowerInterFace i)
        {
            interFace = i;
            NewBorrow();
            LoadData();
        }

        public void Disable(bool x)
        {
            if (x)
            {
                interFace.btnSave = false;
                interFace.btnDelete = false;
                interFace.btnDeleteAll = false;
                interFace.btnAdd = true;
                interFace.btnNew = true;
            }
            else
            {
                interFace.btnSave = true;
                interFace.btnDelete = true;
                interFace.btnDeleteAll = true;
                interFace.btnAdd = false;
                interFace.btnNew = true;
            }
        }

        void LoadData()
        {
            interFace.DataGridDataSource = AddBorrowerServices.GetAllData();
            NewBorrow();
        }
        int GetNextID() { return AddBorrowerServices.GetLastID() + 1; }
        public void NewBorrow()
        {
            SetValue(GetNextID(), "", "", "");
            Disable(true);
        }
        void ConnectModelinterFace()
        {
            model.id = interFace.id;
            model.name = interFace.name;
            model.phone_1 = interFace.phone_1;
            model.phone_2 = interFace.phone_2;
        }
        public void Insert()
        {
            ConnectModelinterFace();
            if (AddBorrowerServices.Insert(model.id, model.name, model.phone_1, model.phone_2))
            {
                MessageBox.Show("تمت العمليه بنجاح");
            }
            else { MessageBox.Show("فشلت العمليه"); }
            LoadData();
            Disable(true);
        }
        public void Update()
        {
            ConnectModelinterFace();
            if (AddBorrowerServices.Update(model.id, model.name, model.phone_1, model.phone_2))
            {
                MessageBox.Show("تمت العمليه بنجاح");
            }
            else { MessageBox.Show("فشلت العمليه"); }
            LoadData();
        }
        public void Delete()
        {
            ConnectModelinterFace();
            if (AddBorrowerServices.Delete(model.id))
            {
                MessageBox.Show("تمت العمليه بنجاح");
            }
            else { MessageBox.Show("فشلت العمليه"); }
            LoadData();
        }
        public void DeleteAll()
        {
            ConnectModelinterFace();
            if (AddBorrowerServices.DeleteAll())
            {
                MessageBox.Show("تمت العمليه بنجاح");
            }
            else { MessageBox.Show("فشلت العمليه"); }
            LoadData();
        }
        void SetValue(int id, string name, string phone1, string phone2)
        {
            interFace.id = id;
            interFace.name = name;
            interFace.phone_1 = phone1;
            interFace.phone_2 = phone2;
        }
        public void ToFirstBorrow()
        {
            try
            {
                interFace.SelectedIndex = 0;
                interFace.SelectedRow = 0;
                DataTable dt = interFace.DataGridDataSource as DataTable;
                SetValue(Convert.ToInt32(dt.Rows[0][0]), Convert.ToString(dt.Rows[0][1]), Convert.ToString(dt.Rows[0][3]), Convert.ToString(dt.Rows[0][4]));
                Disable(false);
            }
            catch { Disable(true); }
        }
        public void ToLastBorrow()
        {
            try
            {
                int x = interFace.ItemsCount - 1;
                interFace.SelectedRow = x;
                interFace.SelectedIndex = x;
                DataTable dt = interFace.DataGridDataSource as DataTable;
                SetValue(Convert.ToInt32(dt.Rows[x][0]), Convert.ToString(dt.Rows[x][1]), Convert.ToString(dt.Rows[x][3]), Convert.ToString(dt.Rows[x][4]));
                Disable(false);
            }
            catch { Disable(true); }
        }
        public void StepForward()
        {
            
            try
            {
                int x = interFace.SelectedRow;
                DataTable dt = interFace.DataGridDataSource as DataTable;
                if (x < dt.Rows.Count -1)
                {
                    interFace.SelectedRow++;
                    x = interFace.SelectedRow;
                    interFace.SelectedIndex = x;
                    SetValue(Convert.ToInt32(dt.Rows[x][0]), Convert.ToString(dt.Rows[x][1]), Convert.ToString(dt.Rows[x][3]), Convert.ToString(dt.Rows[x][4]));

                }
                else
                {
                    interFace.SelectedIndex = 0;
                    interFace.SelectedRow = 0;
                    x = interFace.SelectedRow;
                    SetValue(Convert.ToInt32(dt.Rows[x][0]), Convert.ToString(dt.Rows[x][1]), Convert.ToString(dt.Rows[x][3]), Convert.ToString(dt.Rows[x][4]));
                }
                Disable(false);
            }
            catch { Disable(true); }
        }
        public void StepBack() {
            try
            {
                int x = interFace.SelectedRow;
                DataTable dt = interFace.DataGridDataSource as DataTable;
                if (x > 0)
                {
                    interFace.SelectedRow--;
                    x = interFace.SelectedRow;
                    interFace.SelectedIndex = x;
                    SetValue(Convert.ToInt32(dt.Rows[x][0]), Convert.ToString(dt.Rows[x][1]), Convert.ToString(dt.Rows[x][3]), Convert.ToString(dt.Rows[x][4]));
                }
                else
                {
                    interFace.SelectedIndex = dt.Rows.Count - 1;
                    interFace.SelectedRow = dt.Rows.Count - 1;
                    x = interFace.SelectedRow;
                    SetValue(Convert.ToInt32(dt.Rows[x][0]), Convert.ToString(dt.Rows[x][1]), Convert.ToString(dt.Rows[x][3]), Convert.ToString(dt.Rows[x][4]));
                }
                Disable(false);
            }
            catch { Disable(true); }
        }
    }
}
