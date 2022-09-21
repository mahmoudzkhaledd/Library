using Library.Logic.Presenters;
using Library.Model;
using Library.View.InterFaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.View
{
    public partial class Frm_Users : Form ,UsersInterFace
    {
        UserPresenter presenter;
        UserPermissions GetPermissions() {
            UserPermissions p = new UserPermissions();
            foreach (string s in chkPermissions.CheckedItems)
                p.AddCheck(s);
            return p;
        }
        public Frm_Users(UserModel? model = null)
        {
            InitializeComponent();
            presenter = new UserPresenter(this ,model,chkPermissions.Items, chkPermissions.CheckedItems);
            if(model != null) { button1.Text = "تعديل"; }
        }
        public string FirstName { get => firstName.Text; set => firstName.Text = value; }
        string UsersInterFace.MiddleName { get => MiddleName.Text; set => MiddleName.Text = value; }
        public string LastName { get => lastName.Text; set => lastName.Text = value; }
        int UsersInterFace.age { get => Convert.ToInt32(age.Value); set => age.Value = value; }
        string UsersInterFace.address { get => address.Text; set =>address.Text = value ; }
        public string CardID { get => cardID.Text; set =>cardID.Text = value ; }
        string UsersInterFace.phone1 { get => phone1.Text; set =>phone1.Text = value ; }
        string UsersInterFace.phone2 { get => phone2.Text; set => phone2.Text = value; }
        public decimal salary { get =>Convert.ToInt32(Salary.Value) ; set =>Salary.Value = value ; }
        public string Date { get => lblDate.Text; set =>lblDate.Text = value ; }
        public int ID { get => Convert.ToInt32(txtID.Text); set =>txtID.Text = value.ToString() ; }
        public bool IsAdmin { get =>rdioManager.Checked ; 
            set { 
                rdioManager.Checked = value;
                rdioNormal.Checked = !value;
            } }
        public string UserName { get => txtUserName.Text ; set =>txtUserName.Text = value ; }
        public string Password { get => txtPassword.Text; set =>txtPassword.Text = value ; }
        public UserPermissions permissions { get => GetPermissions(); set { } }

        public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string UserTaken { get => lblTaken.Text; set => lblTaken.Text = value; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void phone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void phone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cardID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <groupBox1.Controls.Count; i++)
            {
                if (groupBox1.Controls[i] is TextBox) {
                    TextBox? t = groupBox1.Controls[i] as TextBox;
                    if (t != null && t.Text == "") {
                        MessageBox.Show("من فضلط ادخل كل البيانات");
                        return;
                    }
                }
            }
            for (int i = 0; i < groupBox2.Controls.Count; i++)
            {
                if (groupBox2.Controls[i] is TextBox)
                {

                    TextBox? t = groupBox2.Controls[i] as TextBox;
                    if (t != null && t.Text == "")
                    {
                        MessageBox.Show("من فضلط ادخل كل البيانات");
                        return;
                    }
                }
            }
            if (chkPermissions.CheckedItems.Count == 0) {
                MessageBox.Show("من فضلك ادخل صلاحيات للمستخدم");
                return;
            }

            presenter.ExecuteAction();
            
            LblLocation();
        }
        void LblLocation() {
            lblTaken.Location = new Point(button3.Location.X - lblTaken.Width - 10, lblTaken.Location.Y);
            if (lblTaken.Text == "اسم المستخدم ماخوذ")
                lblTaken.ForeColor = Color.Red;
            else
                lblTaken.ForeColor = Color.Blue;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            presenter.CheckUserName();
            LblLocation();
        }

        public void CheckItem(int index, bool b)
        {
            chkPermissions.SetItemChecked(index,b);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void Frm_Users_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
