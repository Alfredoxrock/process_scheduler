using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProcessSchedulerProyect
{
    static class Helper
    {

        public static string ProcessPoolFile = "ProcessPool.txt";

        public static void saveProcess(List<ProcessClass> processes)
        {
            string[] processString = new string[processes.Count];

            for (int i = 0; i < processes.Count; i++)
            {
                processString[i] = processes[i].ToString();


            }

            File.WriteAllLines(ProcessPoolFile, processString);
        }

        public static void loadProcess()
        {
            string[] data = File.ReadAllLines(ProcessPoolFile);


            Data.Processes.Clear();
            foreach (string line in data)
            {

                Data.addProcess(new ProcessClass(line));

            }

            //usa.gov employment
        }


    }
}
