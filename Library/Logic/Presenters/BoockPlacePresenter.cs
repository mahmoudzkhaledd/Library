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
    public class BoockPlacePresenter
    {
        BoockPlaceModel PlaceModel = new BoockPlaceModel();
        BoockPlaceInterFace interFace;
        public BoockPlacePresenter(BoockPlaceInterFace i)
        {
            interFace = i;
            GetData();
            NextBoockPlace();
            Disable(true);
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
        public void NextBoockPlace()
        {
            interFace.id = BoockPlaceServices.GetLastID() + 1;
            interFace.name = "";
            Disable(true);
        }

        public void GetFirstID()
        {
            DataTable dt = BoockPlaceServices.GetAllData();
            if (dt.Rows.Count > 0)
            {
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
            DataTable dt = BoockPlaceServices.GetAllData();
            int count = dt.Rows.Count - 1;
            if (count + 1 > 0)
            {
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
            DataTable dt = BoockPlaceServices.GetAllData();
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
            DataTable dt = BoockPlaceServices.GetAllData();
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
            PlaceModel.id = interFace.id;
            PlaceModel.Name = interFace.name;
        }
        public bool Insert()
        {

            ConnectModelInterFace();
            bool x = BoockPlaceServices.InsertData(PlaceModel.id, PlaceModel.Name);
            GetData();
            NextBoockPlace();
            return x;
        }

        public bool Update()
        {
            ConnectModelInterFace();
            bool x = BoockPlaceServices.Update(PlaceModel.id, PlaceModel.Name);
            GetData();
            NextBoockPlace();
            return x;
        }
        public bool Delete()
        {
            ConnectModelInterFace();
            bool x = BoockPlaceServices.Delete(PlaceModel.id);
            GetData(); NextBoockPlace();
            return x;
        }

        public bool DeleteAll()
        {
            bool x = BoockPlaceServices.DeleteAll();
            GetData();
            NextBoockPlace();
            return x;
        }

        public void New()
        {
            interFace.id = 1;
            interFace.name = "";
            
        }
        public void GetData()
        {
            interFace.Data = BoockPlaceServices.GetAllData();
        }

    }
}

