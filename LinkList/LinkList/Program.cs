using List_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            list.InsertAtBegin(10);
            list.InsertAtBegin(20);
            list.InsertAtBegin(30);

            list.PrintList();

            list.InsertAtEnd(40);
            list.PrintList();

            list.InsertAtPos(50, 3);
            list.PrintList();

            list.Total_length();
            list.PrintList();

            list.ToFind(20);

            list.InsertAfter(20, 90);
            list.PrintList();

            list.RemoveData(90);
            list.PrintList();

            list.RemoveAtEnd();
            list.PrintList();
            Console.ReadLine();
        }
    }
}
