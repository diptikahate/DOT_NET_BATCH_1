using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            DoublyCircularLinkList dcll=new DoublyCircularLinkList();
            dcll.InsertAtBegin(10);
            dcll.InsertAtEnd(30);
            dcll.InsertBefore(10, 20);
           
           
            PageDisplay<DoublyCircularLinkList> page = new PageDisplay<DoublyCircularLinkList>(dcll);
            page.ShowDetails();
            

            Console.ReadLine();
        }
    }
}
