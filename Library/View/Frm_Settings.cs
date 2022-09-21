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
    public partial class Frm_Settings : Form
    {
        public Frm_Settings()
        {
            InitializeComponent();

            label2.Text = Properties.Settings.Default.programName;
            LabelLocation();
        }
        void LabelLocation() {
            label2.Location = new Point(
                  (Width - pictureBox1.Width)/2 - label2.Width/2,
                  label2.Location.Y
                );
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.programName = textBox1.Text;
            Properties.Settings.Default.Save();
            label2.Text = Properties.Settings.Default.programName;
            LabelLocation();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Frm_ServerSettings frm = new Frm_ServerSettings()) { 
                frm.ShowDialog();
                frm.Dispose();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);


        }

        private void Frm_Settings_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);

        }
    }
}
