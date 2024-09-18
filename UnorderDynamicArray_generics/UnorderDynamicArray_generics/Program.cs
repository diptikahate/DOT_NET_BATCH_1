
using System;

namespace Program
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DynamicArrays.UnorderedIntDynamicArray<int> unDArr = new DynamicArrays.UnorderedIntDynamicArray<int>();
            const int numberOfDataEntry = 10;

            for (int i = 0; i < numberOfDataEntry; i++)
            {
                unDArr.Add((i + 1) * 2);
            }

            Console.WriteLine(unDArr.ToString());

            Console.WriteLine("-------------Generic type of String--------------");
            DynamicArrays.UnorderedIntDynamicArray<string> stringDArr = new DynamicArrays.UnorderedIntDynamicArray<string>();
            stringDArr.Add("Dipti");
            stringDArr.Add("Dipu");
            stringDArr.Add("Anju");

            Console.WriteLine(stringDArr.ToString());

            Console.ReadLine();
        }
    }
}

