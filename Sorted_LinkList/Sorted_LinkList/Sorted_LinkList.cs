using CSharp_Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_LinkList
{
    internal class Sorted_LinkList
    {
        protected Node headNode;
        public Sorted_LinkList()
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

        public void Insert(int data)
        {
            Node tempNode = headNode.next;
            while (tempNode != headNode)
            {
               
                    Node newNode = new Node(data);
                if (tempNode.data < data)
                {
                    GenericInsert(tempNode.prev, newNode, tempNode);
                }
                else
                {
                    GenericInsert(tempNode, newNode, tempNode.next);
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
