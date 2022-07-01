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
using System.IO;



namespace ProcessSchedulerProyect
{
    public partial class SplashScreen : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public SplashScreen()
        {
            InitializeComponent();
            Helper.loadProcess();
        }

        private void SplashScreen_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
            //SplashScreen sistema = new SplashScreen();
            //sistema.ShowDialog();
            this.Close();
        }

        private void Icon_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button_Continue_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu sistema = new MainMenu();
            sistema.ShowDialog();
            this.Close();
        }
    }
}
