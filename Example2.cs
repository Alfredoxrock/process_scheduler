using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessSchedulerProyect
{
    public partial class Example2 : Form
    {
        public Example2()
        {
            InitializeComponent();
            //label1.Text = Data.Processes.Count.ToString();       
            //label1.Text = DateTime.Now.ToLongTimeString().ToString();
            //for (int i = 0; i < 3; i++)
            //{
            //    Running.enQueue();
            //    Running.running();
                label1.Text = Data.Processes.Count.ToString();
            //    label2.Text = Running.readyQ.Count.ToString();
            //    label3.Text = Running.deadProcesses.Count.ToString();
            //    Label_CT.Text = Running.SysTime.ToString();
            //   // System.Threading.Thread.Sleep(500);
            //}

            //Running.SysTime = 0;
           

            //Running.enQueue();
           // Running.running();
            
            
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
           
                Running.enQueue();
                Running.running();
                label1.Text = Data.Processes.Count.ToString();
                label2.Text = Running.readyQ.Count.ToString();
                label3.Text = Running.deadProcesses.Count.ToString();
                Label_CT.Text = Running.SysTime.ToString();
                // System.Threading.Thread.Sleep(500);
           

            Running.SysTime = 0;
        }

        private void Button_QuickStart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                Running.enQueue();
                Running.running();
                label1.Text = Data.Processes.Count.ToString();
                label2.Text = Running.readyQ.Count.ToString();
                label3.Text = Running.deadProcesses.Count.ToString();
                Label_CT.Text = Running.SysTime.ToString();
                // System.Threading.Thread.Sleep(500);
            }

            Running.SysTime = 0;
        }
    }
}
