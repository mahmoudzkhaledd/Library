using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;
using Library.Logic.Services;
using Library.View.InterFaces;

namespace Library.Logic.Presenters
{
    public class AuthorPresenter
    {
        AuthorInterFace interFace;
        AuthorModel model = new AuthorModel();
        public AuthorPresenter(AuthorInterFace i)
        {
            interFace = i;
            Disable(true);
        }

        public void ConnectModelInterFace()
        {
            model.Id = interFace.id;
            model.Name = interFace.name;
            model.countryIndex = interFace.CountryIndex;
            model.Date = interFace.AuthorDate;
        }

        public void GetData()
        {
            DataTable dt = AuthorServices.GetAllData();
            dt.Columns.RemoveAt(4);
            interFace.Data = dt;
        }
        public bool Insert()
        {
            ConnectModelInterFace();
            bool x = AuthorServices.InsertData(model.Id, model.Name, model.countryIndex, model.Date);
            GetData();
            New();
            return x;
        }
        public bool Update()
        {
            ConnectModelInterFace();
            bool x = AuthorServices.Update(model.Id, model.Name, model.countryIndex, model.Date);
            GetData();
            return x;
        }

        public bool Delete()
        {
            ConnectModelInterFace();
            bool x = AuthorServices.Delete(model.Id);
            GetData();
            return x;
        }
        public bool DeleteAll()
        {
            bool x = AuthorServices.DeleteAll();
            GetData();
            return x;
        }
        public void New()
        { 
            if (LoadCountries()) {
                interFace.id = AuthorServices.GetLastID() + 1;
                interFace.name = "";
                interFace.CountryIndex = 0;
                interFace.AuthorDate = DateTime.Now.ToString();
                Disable(true);
            }
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
        public void DisableAll()
        {
            interFace.btnSave = false;
            interFace.btnDelete = false;
            interFace.btnDeleteAll = false;
            interFace.btnAdd = false;
            interFace.btnNew = false;
        }
        public void NextAuthor()
        {
            interFace.id = AuthorServices.GetLastID() + 1;
            interFace.name = "";

            Disable(true);
        }

        public void GetFirstID()
        {
            DataTable dt = AuthorServices.GetAllData();
            int count = dt.Rows.Count - 1;
            if (count + 1 > 0)
            {
                interFace.id = Convert.ToInt32(dt.Rows[0][0]);
                interFace.Row = 0;
                interFace.name = Convert.ToString(dt.Rows[0][1]);
                interFace.CountryIndex = Convert.ToInt32(dt.Rows[0][4]);
                interFace.AuthorDate = Convert.ToString(dt.Rows[0][3]);
                interFace.btnAdd = false;
                Disable(false);
                interFace.selectedRow = interFace.Row;
            }
            dt.Dispose();
        }
        public void GetLastID()
        {
            DataTable dt = AuthorServices.GetAllData();
            int count = dt.Rows.Count - 1;
            if (count + 1 > 0)
            {
                interFace.id = Convert.ToInt32(dt.Rows[count][0]);
                interFace.name = Convert.ToString(dt.Rows[count][1]);
                interFace.Row = count;
                interFace.AuthorDate = Convert.ToString(dt.Rows[count][3]);
                Disable(false);
                interFace.selectedRow = interFace.Row;
                interFace.CountryIndex = Convert.ToInt32(dt.Rows[count][4]);
            }
            dt.Dispose();
        }

        public void StepBack()
        {
            DataTable dt = AuthorServices.GetAllData();
            if (interFace.Row > 0 && dt.Rows.Count > 0)
            {
                interFace.Row--;
                interFace.id = Convert.ToInt32(dt.Rows[interFace.Row][0]);
                interFace.name = Convert.ToString(dt.Rows[interFace.Row][1]);
                interFace.selectedRow = interFace.Row;
                interFace.CountryIndex = Convert.ToInt32(dt.Rows[interFace.Row][4]);
                interFace.AuthorDate = Convert.ToString(dt.Rows[interFace.Row][3]);
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
                    interFace.CountryIndex = Convert.ToInt32(dt.Rows[interFace.Row][4]);
                    interFace.AuthorDate = Convert.ToString(dt.Rows[interFace.Row][3]);
                    Disable(false);
                }
            }
            dt.Dispose();
        }

        public void StepForward()
        {
            DataTable dt = AuthorServices.GetAllData();
            if (interFace.Row < dt.Rows.Count - 1 && dt.Rows.Count > 0)
            {
                interFace.Row++;
                interFace.id = Convert.ToInt32(dt.Rows[interFace.Row][0]);
                interFace.name = Convert.ToString(dt.Rows[interFace.Row][1]);
                interFace.selectedRow = interFace.Row;
                interFace.CountryIndex = Convert.ToInt32(dt.Rows[interFace.Row][4]);
                interFace.AuthorDate = Convert.ToString(dt.Rows[interFace.Row][3]);
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
                    interFace.CountryIndex = Convert.ToInt32(dt.Rows[interFace.Row][4]);
                    interFace.AuthorDate = Convert.ToString(dt.Rows[interFace.Row][3]);
                    Disable(false);
                }

            }
            dt.Dispose();

        }

        public void Search()
        {
            
        }

        public bool LoadCountries()
        {
            bool x = false;
            DataTable dt = AuthorServices.GetAllCountries();
            if (dt.Rows.Count > 0)x = true;
            else x = false;

            interFace.CountryData = dt;
            return x;
        }

    }
}
