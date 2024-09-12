using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_program
{
    internal class Arrays
    {
        int[] items;
        int index;
        public const int MAX_ITEM = 10;


        public Arrays()
        {
             items = new int[MAX_ITEM];
            index = 0;
        }

        public void Add(int data)
        {
            if (index == items.Length)
            {
                return;
            }

            items[index++] = data;
        }

        public bool Remove(int data)
        {
                int itemIndex = Indexof(data);
            if (itemIndex == -1)
            {
                return false;
            }
            else
            {
                items[itemIndex] = items[MAX_ITEM - 1];
                index--;
                return true;
            }

        }

        public void Print()
        {
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(items[i]);
            }

        }

        public int Indexof(int data)
        {
            for (int i = 0; i < MAX_ITEM; i++)
            {
                if (items[i] == data)
                {
                    return i;
                }  
            }
            return -1;

        }
    }
}
