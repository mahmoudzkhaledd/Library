using Library.Logic.Services;
using Library.Model;
using Library.View;
using Library.View.InterFaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic.Presenters
{
    public class UserPresenter
    {
        UserModel model = new UserModel();
        UsersInterFace interFace;
        Action action;
        CheckedListBox.CheckedItemCollection collection;
        string username = "";
        public UserPresenter(UsersInterFace i , UserModel? model = null , CheckedListBox.ObjectCollection collection = null, CheckedListBox.CheckedItemCollection coll = null) {
            interFace = i;
            this.collection = coll;
            if (model == null)
            {
                interFace.ID = GetNextID();
                action = InsertUser;
            }
            else
            {
                this.model = model;
                username = model.UserName;
                LoadUser();
                LoadPermissions(collection);
                action = UpdateUser;
            }
        } 
        private void LoadPermissions(CheckedListBox.ObjectCollection collection) {
            Dictionary<string, bool> d = model.permissions.GetChecked();
            for (int i = 0; i < collection.Count; i++) {
                interFace.CheckItem(GetIndex(collection, d.Keys.ElementAt(i)), d[d.Keys.ElementAt(i)] );
            }
        }
        int GetIndex(CheckedListBox.ObjectCollection collection , string s) {
            int id = 0;
            for(int i = 0; i < collection.Count; i++) {
                if (collection[i] == s) {
                    id = i;
                }    
            }
            return id;
        }
        int GetNextID() => UserServices.GetLastID() + 1;
        
        void ConnectModelInterFace() {
            model.FirstName = interFace.FirstName;
            model.MiddleName = interFace.MiddleName;
            model.LastName = interFace.LastName;
            model.age = interFace.age;
            model.address = interFace.address;
            model.CardID = interFace.CardID;
            model.phone1 = interFace.phone1;
            model.phone2 = interFace.phone2;
            model.salary = interFace.salary;
            model.Date = interFace.Date;
            model.ID = interFace.ID;
            model.IsAdmin = interFace.IsAdmin;
            model.Password = interFace.Password;
            model.permissions = interFace.permissions;
            model.Email = interFace.Email;
            model.UserName = interFace.UserName;
        }

        void LoadUser()
        {
            interFace.FirstName = model.FirstName;
            interFace.MiddleName = model.MiddleName;
            interFace.LastName = model.LastName;
            interFace.age = model.age;
            interFace.address = model.address;
            interFace.CardID = model.CardID;
            interFace.phone1 = model.phone1;
            interFace.phone2 = model.phone2;
            interFace.salary = model.salary;
            interFace.Date = model.Date;
            interFace.ID = model.ID;
            interFace.IsAdmin = model.IsAdmin;
            interFace.Password = model.Password;
            interFace.permissions = model.permissions;
            interFace.Email = model.Email;
            interFace.UserName = model.UserName;
        }
        public void InsertUser() {
            if (CheckUserName())
            {
                bool b = false;
                b = UserServices.Insert(
                    model.ID
               , model.FirstName
               , model.MiddleName
               , model.LastName
               , model.Email
               , model.UserName
               , model.Password
               , model.age
               , model.address
               , model.CardID
               , model.phone1
               , model.phone2
               , model.salary
               , model.Date
               , model.IsAdmin ? "مدير" : "موظف"
                    );
                for(int i = 0; i < collection.Count; i++) {
                    UserServices.insertPermission(model.ID, GetPermissionID(collection[i].ToString()));
                }

                if (b) { MessageBox.Show("تم الاضافة بنجاح"); interFace.ID = GetNextID(); }
                else MessageBox.Show("فشلت العمليه");
            }
            else MessageBox.Show("اسم المستخدم ماخوذ من قبل"); }
        public void UpdateUser() {
            bool b = false;
            if (model.UserName != username) {
                if (!CheckUserName()) {
                    MessageBox.Show("اسم المستخدم ماخوذ من قبل");
                    return;
                }
            }

            b = UserServices.Update(
                model.ID
           , model.FirstName
           , model.MiddleName
           , model.LastName
           , model.Email
           , model.UserName
           , model.Password
           , model.age
           , model.address
           , model.CardID
           , model.phone1
           , model.phone2
           , model.salary
           , model.Date
           , model.IsAdmin ? "مدير" : "موظف"
                );
            if (b) {
                MessageBox.Show("تمت العمليه بنجاح");
                if (model.ID == Frm_Main.MyID) {
                    Properties.Settings.Default.userName = "";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.LoginRemember = false;
                    Properties.Settings.Default.Save();
                }
            }
            else MessageBox.Show("فشلت العمليه");
        }
        public void ExecuteAction() {
            ConnectModelInterFace();
            action.Invoke();
        }
        public int GetPermissionID(string name) {
           return UserServices.GetPermissionID(name);
        }
        public bool CheckUserName()
        {
            int f = 0;
            DBHelper.ExecuteCommand("GetUserName", 
                () => {
                    SqlCommand cmd = DBHelper.command;
                    cmd.Parameters.Add("@UserName",SqlDbType.NVarChar).Value = interFace.UserName;
                    var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;
                },
                () => {
                    SqlCommand cmd = DBHelper.command;
                    var returnParameter = cmd.Parameters["@ReturnVal"];
                    f = (int)returnParameter.Value;
                }
                );
            if (f == 0) interFace.UserTaken = "اسم المستخدم صالح";
            else if(f == 1) interFace.UserTaken = "اسم المستخدم ماخوذ";
            return f == 0;
        }
    }
}
