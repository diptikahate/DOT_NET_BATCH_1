using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Node
    {
        public int data;
        public Node prev;
        public Node next;

        #region constructor
        public Node() {
            data = -1;
            prev = null;
            next = null;
        }
        public Node(int _data)
        {
            data = _data;
            prev = null;
            next = null;

        }
        #endregion

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
