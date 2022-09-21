using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Library.Logic.Services;
using Library.Model;
using Library.Logic.Presenters;

namespace Library.View
{
    public partial class Frm_Main : Form
    {
        UserPermissions permissions = new UserPermissions();
       public static int MyID;
        void ExecutePermission() {
            btnAddCat.Visible = permissions.Cat;
            btnAuthor.Visible = permissions.Authors;
            btnPlaces.Visible = permissions.Places;
            btnDar.Visible = permissions.Dar;
            btnCountry.Visible = permissions.Country;
            btnAddBook.Visible = permissions.AddBook;
            btnBrowseBooks.Visible = permissions.BrowseBoooks;
            btnAddBorrow.Visible = permissions.AddBorrowers;
            btnBorrowBook.Visible = permissions.BorrowBook;
            btnViewBorrows.Visible = permissions.ViewBorrows;
            btnSettings.Visible = permissions.Settings;
            btnReset.Visible = permissions.Reset;
            btnUsers.Visible = permissions.CreateUser;
        }
        void LoadPermission() {
            DataTable dt = UserServices.GetUserPermissions(MyID);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                string? s = Convert.ToString(dt.Rows[i][1]);
                if(s!=null)
                     permissions.AddCheck(s);
            }
        }
        public Frm_Main(int id)
        {
            MyID = id;
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            label1.Text = Properties.Settings.Default.programName;
            label1.Location = new Point(Width / 2 - label1.Width / 2, label1.Location.Y);
            label2.Text = Properties.Settings.Default.programName;
            LoadPermission();
            ExecutePermission();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);


        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Category frm_Category = new Frm_Category();
            frm_Category.ShowDialog();
            frm_Category.Close();
            frm_Category.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Frm_Authors frm_Authors = new Frm_Authors())
            {
                frm_Authors.ShowDialog();
                frm_Authors.Dispose();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Frm_BooksPlace frm_booksplace = new Frm_BooksPlace())
            {
                frm_booksplace.ShowDialog();
                frm_booksplace.Dispose();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Frm_Dar frm_Dar = new Frm_Dar())
            {
                frm_Dar.ShowDialog();
                frm_Dar.Dispose();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Frm_Countries frm_Countries = new Frm_Countries())
            {
                frm_Countries.ShowDialog();
                frm_Countries.Dispose();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaxmize_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void flowLayoutPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (Frm_AddBook frm = new Frm_AddBook())
            {
                frm.ShowDialog();
                frm.Dispose();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (Frm_BrowsBooks frm = new Frm_BrowsBooks())
            {
                frm.ShowDialog();
                frm.Dispose();
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            using (Frm_Reset frm = new Frm_Reset()) {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    bool y = false;
                    y = UserServices.Update(1, "admin", "admin", "admin", "admin@domain.com", "admin", "admin", 20, "address", "123", "123", "123", 1000, DateTime.Now.ToString(), "مدير");
                    

                    
                    bool x = true;
                    if (BookServices.DeleteAll() && x) x = true;
                    else x = false;
                    if (AuthorServices.DeleteAll() && x) x = true;
                    else x = false;
                    if (DarServices.DeleteAll() && x) x = true;
                    else x = false;
                    if (BoockPlaceServices.DeleteAll() && x) x = true;
                    else x = false;
                    if (CatServices.DeleteAll() && x) x = true;
                    else x = false;
                    if (CountriesServices.DeleteAll() && x) x = true;
                    else x = false;
                    if (ViewClientBorrowsServices.DeleteAll(-1) && x) x = true;
                    else x = false;
                    if (AddBorrowerServices.DeleteAll() && x) x = true;
                    else x = false;
                    if (BorrowBookServices.DeleteAll() && x) x = true;
                    else x = false;
                    if (UserServices.DeleteAlluserPermissions() && x) x = true;
                    else x = false;
                    if (SearchUserServices.DeleteAll() && x) x = true;
                    else x = false;
                    



                    Properties.Settings.Default.programName = "برنامج ادارة المكتبه";
                    Properties.Settings.Default.LoginRemember = false;
                    Properties.Settings.Default.userName = "";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.DBNAME = "";
                    Properties.Settings.Default.serverName = "";
                    Properties.Settings.Default.DBUserName = "";
                    Properties.Settings.Default.DBPassword = "";
                    Properties.Settings.Default.FirstTime = true;
                    Properties.Settings.Default.Save();

                    if (x && y) { MessageBox.Show("تم حذف جميع البيانات بنجاح"); Application.Exit(); }
                    else MessageBox.Show("فشلت العمليه");
                    
                }
                frm.Dispose();
            }
                
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (Frm_AddBorrow frm = new Frm_AddBorrow())
            {
                frm.ShowDialog();
                frm.Dispose();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("هل انت متاكد من تسجيل الخروج","",MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                Properties.Settings.Default.LoginRemember = false;
                Properties.Settings.Default.userName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
                Close();
                Thread th = new Thread(()=>Application.Run(new Frm_Login()));
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (Frm_ViewClientBorrows frm =new Frm_ViewClientBorrows()) {
                try { frm.ShowDialog(); }catch { }
                frm.Dispose();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (Frm_BorrowBook frm = new Frm_BorrowBook()) { 
                frm.ShowDialog();
                frm.Dispose();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            using (Frm_Settings frm = new Frm_Settings())
            {
                frm.ShowDialog();
                frm.Dispose();
                label1.Text = Properties.Settings.Default.programName;
                label1.Location = new Point(Width/2-label1.Width/2 ,label1.Location.Y);
                label2.Text = Properties.Settings.Default.programName;
                label2.Location = new Point(Width / 2 - label2.Width / 2, label2.Location.Y);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             if (WindowState == FormWindowState.Normal)
                    WindowState = FormWindowState.Maximized;
             else
                    WindowState = FormWindowState.Normal;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            using (Frm_Users frm = new Frm_Users()) {
                frm.ShowDialog();
                frm.Dispose();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (Frm_ShowUsers frm = new Frm_ShowUsers()) {
                frm.ShowDialog();
                frm.Dispose();
            }
        }
    }
}
