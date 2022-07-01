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
    public partial class Example : Form
    {
        public Example()
        {
            InitializeComponent();
            //foreach(var item in Data.Processes)
           // {
             //   ListView_ProceessList.Items.Add(new ListViewItem(new (item)));
            
           // }

            //ListView_ProceessList.Items.Add(new ListViewItem(new[] 
           // { , "1", "100", "B", "A", "2", "A" }));

            //var lvNewData = new ListView();
            //foreach (var item in Data.Processes)
           // {
            //    ListView_ProceessList.Items.Add(item.Name);
           // }

            foreach(var item in Data.Processes)
            {
                string[] row = {item.Name, item.DateOfCreation.serlialize(), item.State, item.Priority,
                    item.NeedResourcess.ToString(), item.Completed.ToString()};
                ListViewItem lv1 = new ListViewItem(row);
                ListView_ProceessList.Items.Add(lv1);


            }
            

        }
    }
}
