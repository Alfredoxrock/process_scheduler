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

namespace ProcessSchedulerProyect
{
    public partial class MainMenu : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public MainMenu()
        {
            InitializeComponent();
            PanelSmall_01.Visible = false;
            PanelSmall_02.Visible = false;
            PanelSmall_03.Visible = false;

            //Helper.loadProcess();

        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
            SplashScreen sistema = new SplashScreen();
            sistema.ShowDialog();
            this.Close();
        }

        private void Icon_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void Button_CreateNewProcess_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new CreateNewProcess());
        }

        private void Button_ProcessPool_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Example());
        }
    

        private void Button_CreateNewProcess_MouseCaptureChanged(object sender, EventArgs e)
        {
            PanelSmall_01.Visible = true;
            PanelSmall_03.Visible = false;
            PanelSmall_02.Visible = false;
        }

        private void Button_ProcessPool_MouseCaptureChanged(object sender, EventArgs e)
        {
            PanelSmall_01.Visible = false;
            PanelSmall_03.Visible = false;
            PanelSmall_02.Visible = true;
        }

        private void Button_ReadyProcesses_MouseCaptureChanged(object sender, EventArgs e)
        {
            PanelSmall_01.Visible = false;
            PanelSmall_02.Visible = false;
            PanelSmall_03.Visible = true;
        }

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Button_ReadyProcesses_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Example2());
        }
    }
}
