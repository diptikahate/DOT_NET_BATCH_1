using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  DataStructure
{
    internal abstract class List
    {
        protected Node headNode;
        #region Constructor

        protected List()
        {
            headNode = new Node();
            headNode.Prev=headNode;
            headNode.Next=headNode;
        }
        #endregion

        #region abstractMethod
        protected abstract void InsertAtBegin(int data);
        protected abstract void InsertAtEnd(int data);
        protected abstract void InsertAfter(int data,int newref);
        protected abstract void InsertBefore(int data,int newref);
        protected abstract int RemoveEnd();
        protected abstract int RemoveBegin();
        protected abstract void Remove(int data);

        #endregion

        #region publicMethod
        public void PrintList()
        {
            Node tempNode = headNode.Next;

            while (tempNode != headNode)
            {
                Console.Write("[" + tempNode.Data + "]->");
                tempNode = tempNode.Next;
            }
            Console.WriteLine("[END]");

        }
        public void Length()
        {
            int counter = 1;
            Node tempNode;
            tempNode = headNode.Next;
            while (tempNode != headNode)
            {
                counter += 1;
                tempNode = tempNode.Next;
            }
            Console.WriteLine("Length of List is " + counter);

        }
        public bool Find(int data)
        {

            Node tempNode = headNode.Next;

            while (tempNode != headNode)
            {
                if (tempNode.Data == data)
                {
                    return true;
                }
                tempNode = tempNode.Next;
            }

            return false;

        }
        #endregion
        protected static void GenericInsert(Node start, Node mid, Node end)
        {
            start.Next = mid;
            mid.Next = end;
            end.Prev = mid;
            mid.Prev = start;
        }

        protected static void GenericDelete(Node deleteNode)
        {
            deleteNode.Prev.Next = deleteNode.Next;
            deleteNode.Next.Prev = deleteNode.Prev;
        }
    }
}
