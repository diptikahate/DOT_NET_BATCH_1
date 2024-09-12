
using System;

namespace Program
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DynamicArrays.UnorderedIntDynamicArray unDArr = new DynamicArrays.UnorderedIntDynamicArray();
            const int numberOfDataEntry = 10;

            for (int i = 0; i < numberOfDataEntry; i++)
            {
                unDArr.Add((i + 1) * 2);
            }
            Console.WriteLine("after Adding element in aaray");
            Console.WriteLine(unDArr.ToString());
            unDArr.Remove(2);
            Console.WriteLine("After Removing 2 from array");
            Console.WriteLine(unDArr.ToString());

            Console.WriteLine("Adding More element in array");
            for (int i = 0; i < numberOfDataEntry; i++)
            {
                unDArr.Add((i + 2) * 2);
            }
            Console.WriteLine(unDArr.ToString());
            Console.ReadLine();

        }
    }
}

