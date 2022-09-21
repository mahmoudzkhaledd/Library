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
    public partial class Frm_Reset : Form
    {
        public Frm_Reset()
        {
            InitializeComponent();
            textBox1.Select();
        }
        void Check() {
            if (textBox1.Text == Properties.Settings.Default.Password)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else { MessageBox.Show("كلمة المرور خاطئه"); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13) {
                e.Handled = true;
                Check();
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void Frm_Reset_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
