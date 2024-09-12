using DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_
{
    internal class List
    {
        private Node headNode;

        public List()
        {
            headNode = new Node();
            headNode.Next = headNode;
            headNode.Priv = headNode;
        }

        public void InsertAtBegin(int data)
        {
            Node newNode = new Node(data);
            GenericInsert(headNode, newNode, headNode.Next);
        }

        public void InsertAtEnd(int data)
        {
            Node newNode = new Node(data);
            GenericInsert(headNode.Priv, newNode, headNode);
        }

        public void InsertAtPos(int data, int pos)
        {
            Node newNode = new Node(data);
            int counter = 1;
            Node tempNode;

            tempNode = headNode.Next;
            while (tempNode != headNode && counter < pos)
            {
                counter += 1;
                tempNode = tempNode.Next;
            }
            GenericInsert(tempNode.Priv, newNode, tempNode);
        }

        public int RemoveAtBegin()
        {
            int removedData;

            removedData = headNode.Next.Data;
            GenericDelete(headNode.Next);
            return removedData;
        }

        public void Total_length()
        {
            int counter = 1;
            Node tempNode;
            tempNode = headNode.Next;
            while (tempNode != headNode )
            {
                counter += 1;
                tempNode = tempNode.Next;
            }
            Console.WriteLine("Length of List is " + counter);
        }

        public bool ToFind(int data)
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

        public void InsertAfter(int currentData, int newData)
        {
            Node tempNode = headNode.Next;


            while (tempNode != headNode)
            {
                if (tempNode.Data == currentData)
                {

                    Node newNode = new Node(newData);
                    GenericInsert(tempNode, newNode, tempNode.Next);
                    return;
                }
                tempNode = tempNode.Next;
            }


            Console.WriteLine("Node with data " + currentData + " not found.");
        }

        public bool RemoveData(int data)
        {
            Node tempNode = headNode.Next;

            while (tempNode != headNode)
            {
                if (tempNode.Data == data)
                {
                    GenericDelete(tempNode);
                    return true;
                }
                tempNode = tempNode.Next;
            }

            Console.WriteLine("Node with data " + data + " not found.");
            return false;


        }

        public int RemoveAtEnd()
        {
            int removedData;

            removedData = headNode.Priv.Data;
            GenericDelete(headNode.Priv);
            return removedData;
        }



        private static void GenericInsert(Node start, Node mid, Node end)
        {
            start.Next = mid;
            mid.Next = end;
            end.Priv = mid;
            mid.Priv = start;
        }

        private static void GenericDelete(Node deleteNode)
        {
            deleteNode.Priv.Next = deleteNode.Next;
            deleteNode.Next.Priv = deleteNode.Priv;
        }

        public void PrintList()
        {
            Node tempNode = headNode.Next;

            while (tempNode != headNode)
            {
                Console.Write("[" + tempNode.Data + "]");
                tempNode = tempNode.Next;
            }
            Console.WriteLine(" ");
        }

        

    }
}
