using Library.Logic.Services;
using Library.Model;
using Library.View;
using Library.View.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic.Presenters
{
    public class LoginPresenter
    {
        LoginModel model = new LoginModel();
        LoginInterFace interFace;
        public LoginPresenter(LoginInterFace interFace)
        {
            this.interFace = interFace;
        }
        void ConnectModelInterFace()
        {
            model.userName = interFace.userName;
            model.Password = interFace.Password;
        }

        public void CheckLogin()
        {
            ConnectModelInterFace();
            int id = LoginServices.Login(model.userName, model.Password);
            if (id != -1)
            {
                if (interFace.Remember)
                {
                    Properties.Settings.Default.LoginRemember = true;
                    Properties.Settings.Default.userName = model.userName;
                    Properties.Settings.Default.Password = model.Password;
                }
                else
                    Properties.Settings.Default.LoginRemember = false;

                Properties.Settings.Default.Save();

                Properties.Settings.Default.userName = model.userName;
                Properties.Settings.Default.Password = model.Password;
                Frm_Main frm = new Frm_Main(id);
                frm.Show();
                interFace.Show = false;
            }
            else MessageBox.Show("الرجاء التاكد من اسم المستخدم وكلمة المرور");
        }

        public int CheckLoginByUserPassword(string user, string pass)
        {
            model.userName = user;
            model.Password = pass;
            return LoginServices.Login(model.userName, model.Password);
        }
    }
}
