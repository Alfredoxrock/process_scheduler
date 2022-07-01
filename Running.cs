using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessSchedulerProyect
{
    class Running
    {
        public static ProcessClass currentRunningProcess;
        public static Queue<ProcessClass> PQHigh = new Queue<ProcessClass>();
        public static Queue<ProcessClass> PQMed = new Queue<ProcessClass>();
        public static Queue<ProcessClass> PQLow = new Queue<ProcessClass>();
        public static Queue<ProcessClass> readyQ = new Queue<ProcessClass>();
        public static List<ProcessClass> deadProcesses = new List<ProcessClass>();
        public static Queue<ProcessClass> waitingQ = new Queue<ProcessClass>();
        public static bool Empty = true;
        public static int SysTime = 0;

        public static void terminate()
        {
            deadProcesses.Add(currentRunningProcess);
        }
        public static void waiting()
        {
            waitingQ.Enqueue(currentRunningProcess);
            if (waitingQ.Count >= 2)
            {
                foreach(ProcessClass p in waitingQ)
                {
                    p.NeedResourcess = false;
                }
                 
                foreach (ProcessClass p in waitingQ)
                {
                    readyQ.Enqueue(p);
                }
                waitingQ.Clear();
            }
        }


        public static void enQueue()
        {
            deadProcesses.Clear();
            foreach(ProcessClass thatOne in Data.Processes)
            {
                readyQ.Enqueue(thatOne);
            }

            foreach (ProcessClass p in readyQ)
            {
                
                if (p.Priority == "0")
                {
                    PQLow.Enqueue(p);
                }

                else if (p.Priority == "1")
                {
                    PQMed.Enqueue(p);
                }

                else if (p.Priority == "2")
                {
                    PQHigh.Enqueue(p);
                }

            }
            Data.Processes.Clear();
            readyQ.Clear();

        }

        public static void running()
        {

            int count = 0;
            int count2 = 0;
            bool working = true;
            while (working)
            {
                SysTime++;
                count++;
                count2++;
                if (Empty == false)
                {
                    if (currentRunningProcess.NeedResourcess == true)
                    {
                        waiting();
                        Empty = true;
                    }
                    else if(currentRunningProcess.NeedResourcess == false && currentRunningProcess.Completed == false)
                    {
                        currentRunningProcess.Completed = true;
                    }
                    else if (currentRunningProcess.Completed == true)
                    {
                        terminate();
                        Empty = true;
                    }

                    else
                    {
                        working = true;
                    }

                }
                else if (PQHigh.Count > 0 && count <20 && count2 <10)
                {
                    currentRunningProcess = PQHigh.Dequeue();
                    Empty = false;
                }
                else if (PQMed.Count > 0 && count <20)
                {
                    currentRunningProcess = PQMed.Dequeue();
                    count2 = 0;
                    Empty = false;
                }
                else if (PQLow.Count > 0)
                {
                    currentRunningProcess = PQLow.Dequeue();
                    count = 0;
                    Empty = false;
                }
                else
                {
                    working = false;
                }
            }
        }
    }
}
