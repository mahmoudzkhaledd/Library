using Library.Logic.Presenters;
using Library.Logic.Services;
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
    public partial class Frm_ShowUsers : Form , SearchUserInterFace
    {
        public object dgvDataSource { get => dataGridView1.DataSource; set => dataGridView1.DataSource = value; }
        public Dictionary<string, string> Filters { get =>LoadFilters(); set { } }
        SearchUserPresenter presenter;
        public Frm_ShowUsers()
        {
            InitializeComponent();
            presenter = new SearchUserPresenter(this);
            
        }
        Dictionary<string, string> LoadFilters()
        {
            Dictionary<string, string> Filters = new Dictionary<string, string>();
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                object o = groupBox1.Controls[i];
                if (o is CheckBox)
                {
                    CheckBox l = (CheckBox)o;
                    TextBox? t = null;
                    if (l.Checked) {
                        for (int j = 0; j < groupBox1.Controls.Count; j++)
                        {
                            object obj = groupBox1.Controls[j];
                            if (obj is TextBox)
                            {
                                TextBox text = (TextBox)obj;
                                if (text.Name == "txt" + l.Name)
                                {
                                    t = text;
                                    break;
                                }
                            }
                        }
                    }
                    if (t != null)
                    {
                        Filters.Add(l.Name, t.Text == "" ? "null" : t.Text);
                    }
                }
            }
            return Filters;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_ShowUsers_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.Search();
        }

        static UserPermissions LoadPermission(int id)
        {
            UserPermissions permissions = new UserPermissions();
            DataTable dt = UserServices.GetUserPermissions(id);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string? s = Convert.ToString(dt.Rows[i][1]);
                if (s != null)
                    permissions.AddCheck(s);
            }
            return permissions;
        }
        public static UserModel LoadModel(DataGridViewRow dr) {
            UserModel model = new UserModel();
            model.FirstName = dr.Cells["الاسم الاول"].Value.ToString();
            model.MiddleName = dr.Cells["الاسم الاوسط"].Value.ToString();
            model.LastName = dr.Cells["الاسم الاخير"].Value.ToString();
            model.address = dr.Cells["العنوان"].Value.ToString();
            model.CardID = dr.Cells["رقم البطاقه"].Value.ToString();
            model.phone1 = dr.Cells["تليفون 1"].Value.ToString();
            model.phone2 = dr.Cells["تليفون 2"].Value.ToString();
            model.Date = dr.Cells["التاريخ"].Value.ToString();
            model.age = Convert.ToInt32(dr.Cells["العمر"].Value);
            model.ID = Convert.ToInt32(dr.Cells["رقم المستخدم"].Value);
            model.salary = Convert.ToInt32(dr.Cells["المرتب"].Value);
            model.IsAdmin = dr.Cells["نوع الحساب"].Value.ToString() == "مدير";
            model.UserName = dr.Cells["اسم المستخدم"].Value.ToString();
            model.Password = dr.Cells["كلمة المرور"].Value.ToString();
            model.Email = dr.Cells["الايميل"].Value.ToString();
            model.permissions = LoadPermission(model.ID);
            return model;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (Frm_Users frm = new Frm_Users(LoadModel(dataGridView1.CurrentRow))) {
                frm.ShowDialog();
                frm.Dispose();
                presenter.UpdateDGV();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            presenter.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            presenter.DeleteAll();
        }
    }
}
