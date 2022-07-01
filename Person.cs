using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessSchedulerProyect
{
    public class Person
    {
        public Person()
        {
            Id = new Random().Next(1, 10000); // Generate New ID Randomly
            
        }

       public int Id { get; set; }

       public string FirstName { get; set; }
    
       public string LastName { get; set; }

    }

    
}
