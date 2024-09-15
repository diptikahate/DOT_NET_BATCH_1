using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TV mytv = new TV("Chroma","LED",32.0f,9990);
            mytv.PrintDetails();
            mytv.UpdatePrice(10000);
            mytv.SetScreenSize(52.0f);
            
            Laptop mylaptop = new Laptop("hp", "i9", 98000.89f, 4, 64);

            mylaptop.PrintDetails();
            mylaptop.UpdatePrice(99000);
            mylaptop.UpgradeRam(8);
            mylaptop.UpgradeStorage(124);

            CeilingFan myFan = new CeilingFan("Havells");

            myFan.DisplaySpecifications();
            myFan.TurnOn();
            myFan.TurnOff();


            WashingMachine myWashingMachine = new WashingMachine("LG", 5, "Lenon");

            myWashingMachine.DisplaySpecifications();
            myWashingMachine.StartWashCycle();
            myWashingMachine.StopWashCycle();
            

            Refrigerator myrefrigerator = new Refrigerator("Samsung", 800, 49900.99f);
            myrefrigerator.PrintDetails();
            myrefrigerator.UpdatePrice(50000.0f);

            Microwave mymicrowave = new Microwave("Panasonic", 1200, 5990.99f);
            mymicrowave.PrintDetails();
            mymicrowave.UpdatePrice(5000.0f);
            mymicrowave.StartCooking();

            AirConditioner myairConditioner = new AirConditioner("Chroma",1,15000.0f);
            myairConditioner.PrintDetails();
            myairConditioner.TogglePower();

            Smartphone mysmartphone = new Smartphone("Redmi","Redmi9",4,10000, "Android");
            mysmartphone.PrintDetails();
            mysmartphone.UpdatePrice(11000.0f);
            mysmartphone.InstallApp("Instagram");

            Blender myblender = new Blender("Havells",5,5,5000.0f);
            myblender.PrintDetails();
            myblender.Blend();

            CoffeeMaker coffeeMaker = new CoffeeMaker("Havells",2,10500.0f);
            coffeeMaker.PrintDetails();
            coffeeMaker.StartBrewing();
            coffeeMaker.StopBrewing();

            Console.ReadLine();





        }
    }
}
