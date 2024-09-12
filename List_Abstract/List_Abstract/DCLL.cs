using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class DoublyCircularLinkList : List
    {
        DoublyCircularLinkList():base()
        {
        }
        protected override void InsertAfter(int data, int newref)
        {
            Node newNode = new Node(data);
            int count = 1;
            Node tempNode;
            tempNode = headNode.Next;
            while(tempNode !=headNode && count < newref)
            {
                count += 1;
                tempNode = tempNode.Next;
            }
            GenericInsert(tempNode.prev, newNode, tempNode);
        }
    

        protected override void InsertAtBegin(int data)
        {
            Node newNode = new Node(data);
            GenericInsert(headNode, newNode, headNode.Next);
        }

        protected override void InsertAtEnd(int data)
        {
            Node newNode = new Node(data);
            GenericInsert(headNode.Prev, newNode, headNode);
           
        }

        protected override void InsertBefore(int data, int newref)
        {
            Node tempNode = headNode.Next;


            while (tempNode != headNode)
            {
                if (tempNode.Data == data)
                {

                    Node newNode = new Node(newref);
                    GenericInsert(tempNode.prev, newNode, tempNode);
                    return;
                }
                tempNode = tempNode.Next;
            }
        }

        protected override void Remove(int data)
        {
            Node tempNode = headNode.Next;
            while (tempNode != headNode)
            {
                if(tempNode.Data == data)
                {
                    GenericDelete(tempNode);
                }
                tempNode = tempNode.Next;
            }
        
        }

        protected override int RemoveBegin()
        {
            Node tempNode = headNode.next;
            while (tempNode == headNode.Next)
            {
                GenericDelete(tempNode);
            }
            return tempNode.Data;
            
        }

        protected override int RemoveEnd()
        {
            Node tempNode = headNode.next;
            while (tempNode == headNode.prev)
            {
                GenericDelete(tempNode);
            }
            return tempNode.Data;
        }
    }
}
