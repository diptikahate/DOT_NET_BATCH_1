using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Exam
{
   
        class PageDisplay<T> where T : IlinkList
        {
            T LinkList;
            public PageDisplay(T LinkList)
            {
                this.LinkList = LinkList;
            }

            public void ShowDetails()
            {
                LinkList.displayMethod();
                LinkList.reverseList();
                LinkList.arrayMethod();
              
           
            }
        }
    }

