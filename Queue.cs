using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessSchedulerProyect
{
    class Queue
    {
        public uint count = 0;
        public Node head, tail;
        public bool Empty()
        {
            return count == 0;
        }

        public void enQueue(Node n)
        {
            if (Empty())
                head = tail = n;
            else
            {
                tail.prievious = n;
                n.next = tail;
                tail = n;
            }
            count++;
        }

        public Node deQueue()
        {
            if (Empty())
                return null;
            Node temp = head;
            if (count > 1)
            {
                head = head.prievious;
                temp.prievious = null;
                head.next = null;
            }
            else
            {
                tail = null;
                head = null;
            }
            count--;
            return temp;
        }

        public Node Peek()
        {
            if (Empty())
                return null;
            return head;
        }
    }
}
