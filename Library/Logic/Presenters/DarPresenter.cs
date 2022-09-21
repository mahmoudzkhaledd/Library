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
    public class DarPresenter
    {
        DarModel model = new DarModel();
        DarInterFace interFace;
        public DarPresenter(DarInterFace i) {
            interFace = i;
            GetData();
            SetNewData();
            Disable(true);
        }
        void ChangeArrows(bool x) {
            interFace.btnArrowLeft = x;
            interFace.btnArrowRight = x;
            interFace.btnDoubleArrowLeft = x;
            interFace.btnDoubleArrowRight = x;
        }
        public void DisableAll(bool withNew)
        {
            interFace.btnSave = false;
            interFace.btnDelete = false;
            interFace.btnDeleteAll = false;
            interFace.btnAdd = false;
            if(withNew) interFace.btnNew = false;
            else interFace.btnNew = true;
            ChangeArrows(false);
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

                interFace.btnArrowLeft = true;
                interFace.btnArrowRight = true;
                interFace.btnDoubleArrowLeft = true;
                interFace.btnDoubleArrowRight = true;
            }
            else
            {
                interFace.btnSave = true;
                interFace.btnDelete = true;
                interFace.btnDeleteAll = true;

                interFace.btnAdd = false;
                interFace.btnNew = true;

                interFace.btnArrowLeft = true;
                interFace.btnArrowRight = true;
                interFace.btnDoubleArrowLeft = true;
                interFace.btnDoubleArrowRight = true;
            }
        }

        void SetData(int id, string name ,int country) {
            interFace.id = id;
            interFace.name = name;
            interFace.SelectedCountryValue = country;
            ConnectModelInterFace();
        }

       public void SetNewData()
        { 
            SetData(GetNextID(), "", -1);
            Disable(true);
        }


       public void GetData()
        {
            DataTable dt = DarServices.GetAllData();
            dt.Columns.RemoveAt(3);
            interFace.DataGridDataSource = dt;
            DataTable data = AuthorServices.GetAllCountries();
            interFace.cmbDataSource = data;
            
            
            SetData(GetNextID(), "", -1);

            if (data.Rows.Count > 0)
            { SetNewData(); Disable(true); }
            else { DisableAll(true); }
            
        }

        void ConnectModelInterFace()
        {
            model.id = interFace.id;
            model.name = interFace.name;
            model.country = interFace.SelectedCountryValue;
        }
        public void Insert()
        {
            ConnectModelInterFace();
            if (interFace.name != "")
            {
                bool x = DarServices.Intert(model.id, model.name, model.country);
                GetData();

                if (x)
                    MessageBox.Show("تم الاضافه بنجاح");
                else
                    MessageBox.Show("فشلت العمليه");
            }
            else
            {
                MessageBox.Show("من فضلك ادخل اسم الدار");
            }
        }


        public void Update()
        {
            ConnectModelInterFace();
            bool x = DarServices.Update(model.id, model.name, model.country);
            GetData();

            if (x)
                MessageBox.Show("تم التعديل بنجاح");
            else
                MessageBox.Show("فشلت العمليه");
        }



        public void Delete()
        {
            ConnectModelInterFace();
            bool x = DarServices.Delete(model.id);
            GetData();
            if (x)
                MessageBox.Show("تم الحذف بنجاح");
            else
                MessageBox.Show("فشلت العمليه");
        }
        public void DeleteAll()
        {
            ConnectModelInterFace();
            bool x = DarServices.DeleteAll();
            if(x)
            { MessageBox.Show("تم الحذف بنجاح"); GetData(); SetData(1,"",-1); }
            else
                MessageBox.Show("فشلت العمليه");
        }


        public void GetFirstDar()
        {
            DataTable dt = DarServices.GetAllData();
            int count = dt.Rows.Count - 1;
            if (count + 1 > 0)
            {
                SetData(Convert.ToInt32(dt.Rows[0][0]), Convert.ToString(dt.Rows[0][1]), Convert.ToInt32(dt.Rows[0][3]));
                interFace.SelectedDataGridRow = 0;
                interFace.CurrentRow = 0;
                Disable(false);
            }
            dt.Dispose();
        }
        public void GetLastDar()
        {
            DataTable dt = DarServices.GetAllData();
            int count = dt.Rows.Count - 1;
            if (count + 1 > 0)
            {
                
                SetData(Convert.ToInt32(dt.Rows[count][0]), Convert.ToString(dt.Rows[count][1]), Convert.ToInt32(dt.Rows[count][3]));
                interFace.SelectedDataGridRow = count;
                interFace.CurrentRow = count;
                Disable(false);
            }
            dt.Dispose();
        }

        public void StepBack()
        {
            DataTable dt = DarServices.GetAllData();
            if (interFace.CurrentRow  > 0 && dt.Rows.Count > 0)
            {
                interFace.CurrentRow--;  
                interFace.SelectedDataGridRow = interFace.CurrentRow;
                SetData(Convert.ToInt32(dt.Rows[interFace.CurrentRow][0]), Convert.ToString(dt.Rows[interFace.CurrentRow][1]), Convert.ToInt32(dt.Rows[interFace.CurrentRow][3]));
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    interFace.CurrentRow = dt.Rows.Count - 1;
                    interFace.SelectedDataGridRow = interFace.CurrentRow;
                    SetData(Convert.ToInt32(dt.Rows[interFace.CurrentRow][0]), Convert.ToString(dt.Rows[interFace.CurrentRow][1]), Convert.ToInt32(dt.Rows[interFace.CurrentRow][3]));
                }
            }
            Disable(false);
            dt.Dispose();
        }


        public void StepForward()
        {
            DataTable dt = DarServices.GetAllData();
            int x = 0;
            if (interFace.CurrentRow < dt.Rows.Count - 1 && dt.Rows.Count > 0)
            {
                interFace.CurrentRow++;
                interFace.SelectedDataGridRow = interFace.CurrentRow;
                SetData(Convert.ToInt32(dt.Rows[interFace.CurrentRow][0]), Convert.ToString(dt.Rows[interFace.CurrentRow][1]), Convert.ToInt32(dt.Rows[interFace.CurrentRow][3]));
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    interFace.SelectedDataGridRow = 0;
                    interFace.CurrentRow = 0;
                    SetData(Convert.ToInt32(dt.Rows[interFace.CurrentRow][0]), Convert.ToString(dt.Rows[interFace.CurrentRow][1]), Convert.ToInt32(dt.Rows[interFace.CurrentRow][3]));
                }
            }
            Disable(false);
            dt.Dispose();
        }


        int GetNextID()
        {
            return DarServices.GetLastId() + 1;
        }

    }
}
