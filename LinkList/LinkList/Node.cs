using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Node
    {
        int data;
        private Node priv;
        private Node next;

        public Node()
        {
            Data = -1;
            priv = null;
            next = null;
        }
        public Node(int _Data)
        {
            data = _Data;
            priv = null;
            next = null;
        }

        internal int Data
        {
            get { return data; }
            set { data = value; }
        }
        internal Node Priv
        {
            get { return priv; }
            set { priv = value; }

        }

        internal Node Next
        {
            get { return next; }
            set { next = value; }
        }

    }
}
