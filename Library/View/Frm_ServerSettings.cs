using Library.Logic.Presenters;
using Library.Logic.Services;
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
    public partial class Frm_ServerSettings : Form
    {
        public Frm_ServerSettings()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.DBNAME;
            textBox2.Text = Properties.Settings.Default.serverName;
            textBox3.Text = Properties.Settings.Default.DBUserName;
            textBox4.Text = Properties.Settings.Default.DBPassword;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);


        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DBNAME = textBox1.Text;
            Properties.Settings.Default.serverName = textBox2.Text;
            Properties.Settings.Default.DBUserName = textBox3.Text;
            Properties.Settings.Default.DBPassword = textBox4.Text;
            Properties.Settings.Default.Save();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DBHelper.TestConnection(textBox2.Text, textBox1.Text, textBox3.Text, textBox4.Text)) {
                MessageBox.Show("Connection succeeded","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Connection failed", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
