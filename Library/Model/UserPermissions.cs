using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class UserPermissions
    {
        
        public bool Cat = false;
        public bool Authors = false;
        public bool Places = false;
        public bool Dar = false;
        public bool Country = false;
        public bool AddBook = false;
        public bool BrowseBoooks = false;
        public bool AddBorrowers = false;
        public bool BorrowBook = false;
        public bool ViewBorrows = false;
        public bool Settings = false;
        public bool CreateUser = false;
        public bool BrowseUsers = false;
        public bool Reset = false;
        public void AddCheck(string s) {
            switch (s) {
                case "تصنيفات الكتب":
                    Cat = true;
                    break;
                case "المؤلفين":
                    Authors = true;
                    break;
                case "اماكن الكتب":
                    Places = true;
                    break;
                case "دور النشر":
                    Dar = true;
                    break;
                case "الدول":
                    Country = true;
                    break;
                case "اضافة كتاب":
                    AddBook = true;
                    break;
                case "تصفح الكتب":
                    BrowseBoooks = true;
                    break;
                case "اضافة مستعيرين":
                    AddBorrowers = true;
                    break;
                case "استعارة كتاب":
                    BorrowBook = true;
                    break;
                case "عرض الاستعارات":
                    ViewBorrows = true;
                    break;
                case "اعدادات":
                    Settings = true;
                    break;
                case "انشاء مستخدم":
                    CreateUser = true;
                    break;
                case "تصفح المستخدمين":
                    BrowseUsers = true;
                    break;
                case "اعادة الضبط":
                    Reset = true;
                    break;
                default:
                    break;
            }         
        }
        public Dictionary<string ,bool> GetChecked() {
            Dictionary<string, bool> CheckedItems = new Dictionary<string, bool>();
            CheckedItems.Add("تصنيفات الكتب", Cat);
            CheckedItems.Add("المؤلفين", Authors);
            CheckedItems.Add("اماكن الكتب", Places);
            CheckedItems.Add("دور النشر", Dar);
            CheckedItems.Add("الدول", Country);
            CheckedItems.Add("اضافة كتاب", AddBook);
            CheckedItems.Add("تصفح الكتب", BrowseBoooks);
            CheckedItems.Add("اضافة مستعيرين", AddBorrowers);
            CheckedItems.Add("استعارة كتاب", BorrowBook);
            CheckedItems.Add("عرض الاستعارات", ViewBorrows);
            CheckedItems.Add("اعدادات", Settings);
            CheckedItems.Add("انشاء مستخدم", CreateUser);
            CheckedItems.Add("تصفح المستخدمين", BrowseUsers);
            CheckedItems.Add("اعادة الضبط", Reset);
            return CheckedItems;
        }
    }
}
