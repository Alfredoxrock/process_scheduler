using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProcessSchedulerProyect
{
    class Data
    {
        public static List<ProcessClass> Processes = new List<ProcessClass>();
        

        public static void addProcess(ProcessClass process)
        {
            Processes.Add(process);
            Helper.saveProcess(Processes);
        }

        public static void deleteProcess(int index)
        {
            Processes.RemoveAt(index);
            Helper.saveProcess(Processes);
        }

        public static int getNextID()
        {
            if (Processes.Count == 0) return 0;

            return Processes[Processes.Count - 1].id + 1;
        }

        public static int getIDForUser(string loginID)
        {
            foreach (ProcessClass process in Processes)
            {
                if (process.Name == loginID) return process.id;

            }

            return -1;
        }
    }
}
