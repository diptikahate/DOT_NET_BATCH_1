using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_LinkList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Sorted_LinkList sll = new Sorted_LinkList();
            sll.Insert(2);
            sll.displayMethod();
            Console.ReadLine();
        }
    }
}

