using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Exam
{
    internal class DoublyCircularLinkList : IlinkList
    {
        protected Node headNode;
        public DoublyCircularLinkList()
        {
            headNode = new Node();
            headNode.prev = headNode;
            headNode.next = headNode;
        }

        public void displayMethod()
        {
            Console.Write(" LinkList : ");
            Node tempNode = headNode.next;
            while (tempNode != headNode)
            {
                Console.Write("[" + tempNode.data + "]->");
                tempNode = tempNode.next;
            }
            Console.WriteLine("[END]");
        }

        public bool findData(int data)
        {
            Node tempNode = headNode.next;
            while (tempNode != headNode)
            {
                if (tempNode.data == data)
                {
                    return true;
                }
                tempNode = tempNode.next;
            }
            return false;
        }


        public void arrayMethod()
        {
            Console.Write("Converting a given list in array : ");
            Node tempNode = headNode.next;
            int count = 0;
           
            //for adding data in aaray
            while (tempNode != headNode)
            {
                count = count + 1;
                tempNode = tempNode.next;

            }
            int[] arr = new int[count];

            //for printing data of array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[" + arr[i]+"]");
            }
            Console.WriteLine("[End]");


        }

        public void reverseList()
        {
            Console.Write("Printing  a given list in reverse order :  ");
            Node tempNode = headNode.prev;
            while (tempNode != headNode)
            {
                Console.Write("[" + tempNode.data + "]->");
                tempNode = tempNode.prev;
            }
            
        }
        public void InsertAtBegin(int data)  //Complete
        {
            Node newNode = new Node(data);
            GenericInsert(headNode, newNode, headNode.next);
        }

        public void InsertAtEnd(int data)  //Complete
        {
            Node newNode = new Node(data);
            GenericInsert(headNode.prev, newNode, headNode);
        }

        public void InsertBefore(int data, int newref)  //Complete
        {
            Node tempNode = headNode.next;
            while (tempNode != headNode)
            {
                if (tempNode.data == data)
                {
                    Node newNode = new Node(newref);
                    GenericInsert(tempNode.prev, newNode, tempNode);
                    return;
                }
            }
        }

        protected static void GenericInsert(Node start, Node mid, Node end)
        {
            start.next = mid;
            mid.next = end;
            end.prev = mid;
            mid.prev = start;
        }

      
    }
}
