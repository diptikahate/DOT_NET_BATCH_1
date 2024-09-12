using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arrays refArray = new Arrays();
            for (int i = 0; i < Arrays.MAX_ITEM; i++){
                refArray.Add(i);
                refArray.Print();
                refArray.Remove(5);
                refArray.Print();
                Console.ReadLine();
            }
        }
    }
}
