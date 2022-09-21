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
    public class CountryPresenter
    {
        CountryModel countryModel = new CountryModel();
        CountryInterFace interFace;
        public CountryPresenter(CountryInterFace i) { 
            interFace = i;
        }
        public void Disable(bool x) {
            if (x)
            {
                interFace.btnSave = false;
                interFace.btnDelete = false;
                interFace.btnDeleteAll = false;
                interFace.btnAdd = true;
            }
            else {
                interFace.btnSave = true;
                interFace.btnDelete = true;
                interFace.btnDeleteAll = true;
                interFace.btnAdd = false;
            }
        }



        public void SetData(int id,string txt) {
            interFace.id = id;
            interFace.name = txt;
        }
        public void NextCountry() { 
            interFace.id = CountriesServices.GetLastID() + 1;
            interFace.name = "";
            Disable(true);
        }

        public void GetFirstID()
        {
            DataTable dt = CountriesServices.GetAllData();
            interFace.id = Convert.ToInt32(dt.Rows[0][0]);
            interFace.Row = 0;
            interFace.name = Convert.ToString(dt.Rows[0][1]);
            interFace.btnAdd = false;
            dt.Dispose();
            Disable(false);
            interFace.selectedRow = interFace.Row;
        }
        public void GetLastID()
        {
            DataTable dt = CountriesServices.GetAllData();
            int count = dt.Rows.Count - 1;
            interFace.id = Convert.ToInt32(dt.Rows[count][0]);
            interFace.name = Convert.ToString(dt.Rows[count][1]);
            interFace.Row = count;
            dt.Dispose();
            Disable(false);
            interFace.selectedRow = interFace.Row;
        }
        public void StepBack()
        {
            DataTable dt = CountriesServices.GetAllData();
            if (interFace.Row > 0)
            {
                interFace.Row--;
                interFace.id = Convert.ToInt32(dt.Rows[interFace.Row][0]);
                interFace.name = Convert.ToString(dt.Rows[interFace.Row][1]);
                interFace.selectedRow = interFace.Row;
            }
            else {
                interFace.Row = dt.Rows.Count-1;
                interFace.id = Convert.ToInt32(dt.Rows[interFace.Row][0]);
                interFace.name = Convert.ToString(dt.Rows[interFace.Row][1]);
                interFace.selectedRow = interFace.Row;
            }
            dt.Dispose();
            Disable(false);
        }

        public void StepForward()
        {
            DataTable dt = CountriesServices.GetAllData();
            if (interFace.Row < dt.Rows.Count - 1)
            {
                interFace.Row++;
                interFace.id = Convert.ToInt32(dt.Rows[interFace.Row][0]);
                interFace.name = Convert.ToString(dt.Rows[interFace.Row][1]);
                interFace.selectedRow = interFace.Row;
            }
            else {
                interFace.Row = 0;
                interFace.id = Convert.ToInt32(dt.Rows[interFace.Row][0]);
                interFace.name = Convert.ToString(dt.Rows[interFace.Row][1]);
                interFace.selectedRow = interFace.Row;
            }
            dt.Dispose();
            Disable(false);
            
        }



        public void ConnectModelInterFace() {
            countryModel.id = interFace.id;
            countryModel.Name = interFace.name;

        }
        public bool Insert()
        {
            
            ConnectModelInterFace();
            bool x = CountriesServices.InsertData(countryModel.id, countryModel.Name);
            GetData();
            NextCountry();
            return x;
        }

        public bool Update()
        {
            ConnectModelInterFace();
            bool x = CountriesServices.Update(countryModel.id, countryModel.Name);
            GetData();
            NextCountry();
            return x;
        }
        public bool Delete()
        {
            ConnectModelInterFace();
            bool x = CountriesServices.Delete(countryModel.id);
            GetData();
            NextCountry();
            return x;
        }

        public bool DeleteAll()
        {
            bool x = CountriesServices.DeleteAll();
            GetData();
            NextCountry();
            return x;
        }

        public void New() {
            interFace.id = 1;
            interFace.name = "";
            Disable(true);
        }
        public void GetData() {
            interFace.Data = CountriesServices.GetAllData();
           
        }
    }
}
