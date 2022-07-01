using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessSchedulerProyect
{
    class Node
    {
        public Node prievious, next;
        public object value;
        public Node(object o)
        {
            value = o;
        }
    }
}
