using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Datatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create MyInt object
            MyInt myInt = new MyInt(10);
            myInt.Addition(5);
            myInt.Subtraction(3);
          
            // Create MyDouble object
            MyDouble myDouble = new MyDouble(4.5);
            myDouble.Multiplication(2);
            myDouble.Divide(3);
            Console.ReadLine();
        }
    }
}
