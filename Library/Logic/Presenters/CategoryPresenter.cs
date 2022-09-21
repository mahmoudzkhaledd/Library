using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Logic.Services;
using Library.View.InterFaces;
using Library.Model;
using System.Data.SqlClient;
using System.Data;

namespace Library.Logic.Presenters
{
    public class CategoryPresenter
    {
        CatModel catModel = new CatModel();
        CatInterFace interFace;
        public CategoryPresenter(CatInterFace i) {
            interFace = i;
        }




        public void Disable(bool x)
        {
            if (x)
            {
                interFace.btnSave = false;
                interFace.btnDelete = false;
                interFace.btnDeleteAll = false;
                interFace.btnAdd = true;
            }
            else
            {
                interFace.btnSave = true;
                interFace.btnDelete = true;
                interFace.btnDeleteAll = true;
                interFace.btnAdd = false;
            }
        }

        public void SetData(int id, string txt)
        {
            interFace.id = id;
            interFace.name = txt;
        }
        public void NextCategory()
        {
            interFace.id = CatServices.GetLastID() + 1;
            interFace.name = "";
            Disable(true);
        }

        public void GetFirstID()
        {
            DataTable dt = CatServices.GetAllData();
            if (dt.Rows.Count > 0) {
                interFace.id = Convert.ToInt32(dt.Rows[0][0]);
                interFace.Row = 0;
                interFace.name = Convert.ToString(dt.Rows[0][1]);
                interFace.btnAdd = false;
                Disable(false);
                interFace.selectedRow = interFace.Row;
            }
            dt.Dispose();
        }
        public void GetLastID()
        {
            DataTable dt = CatServices.GetAllData();
            int count = dt.Rows.Count - 1;
            if (count + 1 > 0) {
                interFace.id = Convert.ToInt32(dt.Rows[count][0]);
                interFace.name = Convert.ToString(dt.Rows[count][1]);
                interFace.Row = count;
                Disable(false);
                interFace.selectedRow = interFace.Row;
            }
            dt.Dispose();
        }
        public void StepBack()
        {
            DataTable dt = CatServices.GetAllData();
            if (interFace.Row > 0 && dt.Rows.Count > 0)
            {
                interFace.Row--;
                interFace.id = Convert.ToInt32(dt.Rows[interFace.Row][0]);
                interFace.name = Convert.ToString(dt.Rows[interFace.Row][1]);
                interFace.selectedRow = interFace.Row;
                Disable(false);
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    interFace.Row = dt.Rows.Count - 1;
                    interFace.id = Convert.ToInt32(dt.Rows[interFace.Row][0]);
                    interFace.name = Convert.ToString(dt.Rows[interFace.Row][1]);
                    interFace.selectedRow = interFace.Row;
                    Disable(false);
                }
            }
            dt.Dispose();
            
        }

        public void StepForward()
        {
            DataTable dt = CatServices.GetAllData();
            if (interFace.Row < dt.Rows.Count - 1 && dt.Rows.Count > 0)
            {
                interFace.Row++;
                interFace.id = Convert.ToInt32(dt.Rows[interFace.Row][0]);
                interFace.name = Convert.ToString(dt.Rows[interFace.Row][1]);
                interFace.selectedRow = interFace.Row;
                Disable(false);
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    interFace.Row = 0;
                    interFace.id = Convert.ToInt32(dt.Rows[interFace.Row][0]);
                    interFace.name = Convert.ToString(dt.Rows[interFace.Row][1]);
                    interFace.selectedRow = interFace.Row;
                    Disable(false);
                }
            }
            dt.Dispose();
            
        }



        public void ConnectModelInterFace()
        {
            catModel.id = interFace.id;
            catModel.Name = interFace.name;

        }
        public bool Insert()
        {

            ConnectModelInterFace();
            bool x = CatServices.InsertData(catModel.id, catModel.Name);
            GetData();
            return x;
        }

        public bool Update()
        {
            ConnectModelInterFace();
            bool x = CatServices.Update(catModel.id, catModel.Name);
            GetData();
            New();
            return x;
        }
        public bool Delete()
        {
            ConnectModelInterFace();
            bool x = CatServices.Delete(catModel.id);
            GetData();
            New();
            return x;
        }

        public bool DeleteAll()
        {
            bool x = CatServices.DeleteAll();
            GetData();
            New();
            return x;
        }

        public void New()
        {
            interFace.id = 1;
            interFace.name = "";

        }
        public void GetData()
        {
            interFace.Data = CatServices.GetAllData();
        }

    }
}
