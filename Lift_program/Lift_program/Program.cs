using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice");
            Console.WriteLine("enter 1 for car");
            Console.WriteLine("enter 2 for bus");
            Console.WriteLine("enter 3 for train");
            Console.WriteLine("enter 4 for auto");
            Console.WriteLine("enter 5 for bike");
            int choice=int .Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine("He/She can get lift from car");
                    break;

                case 2:
                    Console.WriteLine("He/She can get lift from bus");
                    break;

                case 3:
                    Console.WriteLine("He/She can get lift from trani");
                    break;

                case 4:
                    Console.WriteLine("He/She can get lift from auto");
                    break;
                case 5:
                    Console.WriteLine("He/She can get lift from bike");
                    break;
                default:
                    Console.WriteLine("He/She can not get lift from any one ");
                    break;
            }
            Console.ReadLine();
        }
    }
}
