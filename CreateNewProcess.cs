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
    
    public partial class CreateNewProcess : Form
    {
        private Random rnd;
        public CreateNewProcess()
        {

            InitializeComponent();
            Button_Top_Brighty.Visible = false;
            Button_Bottom_Bright.Visible = false;
            Panel_Generate_Random_P.Visible = false;
            Panel_Specific_Process.Visible = false;

            //TIMEFRIEND.Text = GetRandomBoolean().ToString();

        }

        public bool GetRandomBoolean()
        {
            rnd = new Random();
            return rnd.Next(0, 2) == 0;
        }

        public bool GetRandomBoolean2()
        {
            rnd = new Random();
            return rnd.Next(0, 2) == 0;
        }

        public int GetRandomIntBro()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 3);
            return randomNumber;
        }

        private void Button_Top_Click(object sender, EventArgs e)
        {
            Panel_Generate_Random_P.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel_Generate_Random_P.Visible = true;
        }

        private void Button_Top_MouseEnter(object sender, EventArgs e)
        {
            Button_Top_Brighty.Visible = true;
        }

        private void Button_Top_MouseLeave(object sender, EventArgs e)
        {
            Button_Top_Brighty.Visible = false;
        }

        private void Button_Top_Brighty_MouseEnter(object sender, EventArgs e)
        {
            Button_Top_Brighty.Visible = true;
        }

        private void Button_Top_Brighty_MouseLeave(object sender, EventArgs e)
        {
            Button_Top_Brighty.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Panel_Generate_Random_P.Visible = true;
        }

        private void Button_Top_Continue_MouseEnter(object sender, EventArgs e)
        {
            Button_Top_Brighty.Visible = true;
        }

        private void Button_Bottom_Dark_MouseEnter(object sender, EventArgs e)
        {
            Button_Bottom_Bright.Visible = true;
        }

        private void Button_Bottom_Dark_MouseLeave(object sender, EventArgs e)
        {
            Button_Bottom_Bright.Visible = false;
        }

        private void Button_Bottom_Bright_MouseEnter(object sender, EventArgs e)
        {
            Button_Bottom_Bright.Visible = true;
        }

        private void Button_Bottom_Bright_MouseLeave(object sender, EventArgs e)
        {
            Button_Bottom_Bright.Visible = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Panel_Specific_Process.Visible = true;
        }

        private void Panel_Generate_Random_P_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Textbox_ProcessName_Enter(object sender, EventArgs e)
        {
            if (Textbox_ProcessName.Text == "PROCESS QUANTITY")
            {
                Textbox_ProcessName.Text = "";
                Textbox_ProcessName.ForeColor = Color.Red;

            }
        }

        private void Textbox_ProcessName_Leave(object sender, EventArgs e)
        {
            if (Textbox_ProcessName.Text == "PROCESS QUANTITY")
            {
                Textbox_ProcessName.Text = "";
                Textbox_ProcessName.ForeColor = Color.Red;

            }
        }

        private void SPG_TextBox_Name_Enter(object sender, EventArgs e)
        {
            if (SPG_TextBox_Name.Text == "NAME")
            {
                SPG_TextBox_Name.Text = "";
                SPG_TextBox_Name.ForeColor = Color.Red;

            }
        }

        private void SPG_TextBox_Name_Leave(object sender, EventArgs e)
        {
            if (SPG_TextBox_Name.Text == "")
            {
                SPG_TextBox_Name.Text = "NAME";
                SPG_TextBox_Name.ForeColor = Color.Red;

            }
        }

        private void Button_Generate_Click(object sender, EventArgs e)
        {
            string unused = "UNUSED";

            Date daty = new Date(DateTime.Now.Day.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString());
            //ProcessClass processes = new ProcessClass(Textbox_ProcessName.Text, daty, used, SPG_ComboBox_Priority.Text, GetRandomBoolean(), GetRandomBoolean());
            //Label_Test.Text = processes.ToString();
            int total = int.Parse(Textbox_ProcessName.Text);

            for (int i = 1; i <= total; i++)
            {
                ProcessClass processes = new ProcessClass(Data.getNextID(),"Process" + i, daty, unused, GetRandomIntBro().ToString(), GetRandomBoolean(), bool.Parse("false"));
                Data.addProcess(processes);
            }

            Label_Process_Generated.Text = "Succesfully Generated";
            
        }

        private void SPG_Button_Generate_Click(object sender, EventArgs e)
        {
            string used2 = "UNUSED";
            Date daty2 = new Date(DateTime.Now.Day.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString());
            ProcessClass processes = new ProcessClass(Data.getNextID(),SPG_TextBox_Name.Text, daty2, used2, SPG_ComboBox_Priority.Text, bool.Parse(SPG_ComboBox_NeedResources.Text), bool.Parse("false"));
            Data.addProcess(processes);
            SPG_Label_ProcessGenerated.Text = "Succesfully Generated";

        }

        









        //Button Top Changing From Dark to Bright





    }
}
