using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessSchedulerProyect
{
    class ProcessClass
    {
        // These are the parameters for the process.
        public string Name, State, Priority;
        public Date DateOfCreation;
        public int id;
        //These is the option NeedResourcess so, when a process goes to the running queue if it need to share resourcess
        //  it is going to be moved to the waiting state. And when a process is completed the process is going ot be terminated.
        public bool NeedResourcess, Completed;

        public ProcessClass(int id_,string Name_, Date DateOfCreation_, string State_, string Priority_, bool NeedResourcess_, bool Completed_)
        {
            int id = id_;
            Name = Name_;
            DateOfCreation = DateOfCreation_;
            State = State_;
            Priority = Priority_;
            NeedResourcess = NeedResourcess_;
            Completed = Completed_;
        }

        public ProcessClass(string line)
        {
            string[] parts = line.Split(',');
            id = int.Parse(parts[0]);
            Name = parts[1];
            DateOfCreation = new Date(parts[2]);
            State = parts[3];
            Priority = parts[4];
            NeedResourcess = bool.Parse(parts[5]);
            Completed = bool.Parse(parts[6]);

           
            

        }

        public string serialize()
        {
            return id.ToString() + ","+ Name + "," + DateOfCreation.serlialize() + "," + State + "," + Priority + "," + NeedResourcess + "," + Completed;
        }

        public override string ToString()
        {
            return this.serialize();
        }
    }
}
