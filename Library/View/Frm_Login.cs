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
using System.Xaml;
using System.Xml;
namespace Library.View
{
    public partial class Frm_Login : Form ,LoginInterFace
    {
        LoginPresenter presenter;
        public Frm_Login()
        {
            InitializeComponent();
            presenter = new LoginPresenter(this);
            label3.Text = Properties.Settings.Default.programName;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        public string userName { get => txtUserName.Text; set => txtUserName.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }
        public bool Remember { get => checkBox1.Checked; set => checkBox1.Checked = value; }

        bool LoginInterFace.Show { 
            get { return true; } 
            set {
                if (!value) Hide();
                else Show();
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.DBNAME == "" 
                || Properties.Settings.Default.serverName == "" 
                || Properties.Settings.Default.DBUserName == "" 
                || Properties.Settings.Default.DBPassword =="")
            { 
                MessageBox.Show("من فضلك تاكد من اعدادات السيرفر");
                return; 
            }
            presenter.CheckLogin();
            
                
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Frm_ServerSettings frm = new Frm_ServerSettings()) {
                frm.ShowDialog();
                frm.Dispose();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                e.Handled = true;
                presenter.CheckLogin();
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                presenter.CheckLogin();
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
