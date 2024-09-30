using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Exam
{
    internal class Node
    {
        public int data;
        public Node prev;
        public Node next;

        public Node(int data=-1)
        {
            this.data = data;
            this.next = null;
            this.prev = null;

        }
        internal int Data
        {
            get { return data; }
            set { data = value; }
        }
        internal Node Prev
        {
            get { return prev; }    
            set { prev = value; }
        }
        internal Node Next
        {
            get { return next; }        
            set { next = value; }
        }
    }
}
