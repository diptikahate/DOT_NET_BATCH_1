using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Datatype
{

    class MyInt
    {
        public int Value;

        public MyInt(int value)
        {
            Value = value;
            Console.WriteLine("Initial MyInt value:{0}", Value);
        }

        public void Addition(int number)
        {
            Value += number;
            Console.WriteLine("After adding 5:{0} ", Value);
        }

        public void Subtraction(int number)
        {
            Value -= number;
            Console.WriteLine("After subtracting 3:{0} ", Value);
        }

    }

    class MyDouble
    {
        public double Value;

        public MyDouble(double value)
        {
            Value = value;
            Console.WriteLine("\nInitial MyDouble value:{0} ", Value);
        }

        public void Multiplication(double number)
        {
            Value *= number;
            Console.WriteLine("After multiplying by 2: {0} ", Value);
        }

        public void Divide(double number)
        {
            if (number != 0)
            {
                Value /= number;
                Console.WriteLine("After dividing by 3: {0} ", Value);
            }
            else
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }
    }
}
