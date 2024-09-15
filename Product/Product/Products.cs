using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{

    //Product no1
    #region TV
    public class TV
    {

        public string Brand;
        public string Model;
        public float ScreenSize;
        public float Price;



        public TV(string brand, string model, float screenSize, float price)
        {
            Brand = brand;
            Model = model;
            ScreenSize = screenSize;
            Price = price;

        }


        public void PrintDetails()
        {
            Console.WriteLine("TV Details:");
            Console.WriteLine("Brand:{0}", Brand);
            Console.WriteLine("Model:{0} ",Model);
            Console.WriteLine("Screen Size:{0}", ScreenSize," inches");
            Console.WriteLine("Price:{0} ", Price);

        }


        public void UpdatePrice(float newPrice)
        {
            if (newPrice >= 0)
            {
                Price = newPrice;
                Console.WriteLine("Price updated to {0}",Price);
            }
            else
            {
                Console.WriteLine("Invalid price. Price cannot be negative.");
            }
        }


        public void SetScreenSize(float newSize)
        {
            if (newSize > ScreenSize)
            {
                ScreenSize = newSize;
                Console.WriteLine("Screen size updated to {0}",ScreenSize," inches");
            }
            else
            {
                Console.WriteLine("Invalid screen size. Size must be positive.");
            }
        }

    }
    #endregion

    #region Laptop

    //Product no2
    public class Laptop
    {
     
        public string Brand;
        public string Model;
        public float Price;
        public int RamSize;
        public int StorageSize;

        // Constructor
        public Laptop(string brand, string model, float price, int ramSize, int storageSize)
        {
            Brand = brand;
            Model = model;
            Price = price;
            RamSize = ramSize;
            StorageSize = storageSize;
        }


        public void PrintDetails()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("Laptop Details:");
            Console.WriteLine("Brand:{0}", Brand);
            Console.WriteLine("Model:{0}", Model);
            Console.WriteLine("Price: {0}",Price);
            Console.WriteLine("RAM Size:{0}", RamSize," GB");
            Console.WriteLine("Storage Size:{0} ",StorageSize," GB");
        }


        public void UpdatePrice(float newPrice)
        {
            if (newPrice >= 0)
            {
                Price = newPrice;
                Console.WriteLine("Price updated to {0}",Price);
            }
            else
            {
                Console.WriteLine("Invalid price. Price cannot be negative.");
            }
        }


        public void UpgradeRam(int additionalRam)
        {
            if (additionalRam > 0)
            {
                RamSize += additionalRam;
                Console.WriteLine("RAM upgraded by{0}", additionalRam," GB. New RAM size:{0}", RamSize," GB");
            }
            else
            {
                Console.WriteLine("Invalid RAM upgrade. Must be positive.");
            }
        }

        public void UpgradeStorage(int additionalStorage)
        {
            if (additionalStorage > 0)
            {
                StorageSize += additionalStorage;
                Console.WriteLine("Storage upgraded by{0}", additionalStorage," GB. New storage size:{0}", StorageSize," GB");
            }
            else
            {
                Console.WriteLine("Invalid storage upgrade. Must be positive.");
            }
        }
    }

    #endregion

    #region CeilingFan

    //Product no3
    public class CeilingFan
    {
        private string brand;
        private int speed;
        private bool isOn;

        public CeilingFan(string brand)
        {
            this.brand = brand;
            this.speed = 0;
            this.isOn = false;
        }

        public void DisplaySpecifications()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("CeilingFan Details:");
            Console.WriteLine("Brand:{0}", brand, " Speed:{0}", speed);
        }

        public void TurnOn()
        {   
            if (!isOn)
            {
                isOn = true;
                speed = 1;
                Console.WriteLine(brand,"{0} Ceiling Fan is now ON at speed{0}", speed);
            }
            else
            {
                Console.WriteLine("Fan is already ON.");
            }
        }

        public void TurnOff()
        {
            if (isOn)
            {
                isOn = false;
                speed = 0;
                Console.WriteLine("Ceiling Fan is now OFF.");
            }
        }

      
    }
    #endregion

    #region WashingMachine

    //Product no4
    public class WashingMachine
    {
        private string brand;
        private int capacity;
        private string washMode;


        public WashingMachine(string brand, int capacity, string washMode)
        {
            this.brand = brand;
            this.capacity = capacity;
            this.washMode = washMode;
        }

        public void DisplaySpecifications()
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("WashingMachine Details:");
            Console.WriteLine("Brand: {0}", brand, " Capacity:{0}", capacity, " kg, Current Wash Mode: {0}", washMode);
        }
        public void StartWashCycle()
        {
            Console.WriteLine("Starting wash cycle in {0}",washMode," mode.");
        }


        public void StopWashCycle()
        {
            Console.WriteLine("Wash cycle stopped.");
        }

       
    }
    #endregion


    #region  Refrigerator

    //Product no5
    public class Refrigerator
    {
        private string brand;
        private int capacity; 
        private float price;

        public Refrigerator(string brand, int capacity, float price)
        {
            this.brand = brand;
            this.capacity = capacity;
            this.price = price;
        }

        public void PrintDetails()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("Refrigerator Details:");
            Console.WriteLine("Brand:{0}", brand);
            Console.WriteLine("Capacity: {0}",capacity," liters");
            Console.WriteLine("Price:{0}", price);
        }

        public void UpdatePrice(float newPrice)
        {
            if (newPrice >= 0)
            {
                price = newPrice;
                Console.WriteLine($"Price updated to ${price}");
            }
            else
            {
                Console.WriteLine("Invalid price. Price cannot be negative.");
            }
        }

    }
    #endregion

    #region Microwave

    //Product no6
    public class Microwave
    {
        private string brand;
        private int power; // in watts
        private float price;

        public Microwave(string brand, int power, float price)
        {
            this.brand = brand;
            this.power = power;
            this.price = price;
        }

        public void PrintDetails()
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("Microwave Details:");
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Power: {power} watts");
            Console.WriteLine($"Price: ${price}");
        }

        public void UpdatePrice(float newPrice)
        {
            if (newPrice >= 0)
            {
                price = newPrice;
                Console.WriteLine($"Price updated to ${price}");
            }
            else
            {
                Console.WriteLine("Invalid price. Price cannot be negative.");
            }
        }

        public void StartCooking()
        {
            Console.WriteLine("Microwave started cooking...");
        }

        public void StopCooking()
        {
            Console.WriteLine("Microwave stopped cooking.");
        }
    }

    #endregion

    #region Air Conditioner
    //Product no7
    public class AirConditioner
    {
        private string brand;
        private int tonnage;
        private float price;
        private bool isOn;

        public AirConditioner(string brand, int tonnage, float price)
        {
            this.brand = brand;
            this.tonnage = tonnage;
            this.price = price;
            this.isOn = false;
        }

        public void PrintDetails()
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("Air Conditioner Details:");
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Tonnage: {tonnage} tons");
            Console.WriteLine($"Price: ${price}");
        }

        public void UpdatePrice(float newPrice)
        {
            if (newPrice >= 0)
            {
                price = newPrice;
                Console.WriteLine($"Price updated to ${price}");
            }
            else
            {
                Console.WriteLine("Invalid price. Price cannot be negative.");
            }
        }

        public void TogglePower()
        {
            isOn = !isOn;
            Console.WriteLine($"Air Conditioner is now {(isOn ? "ON" : "OFF")}");
        }
    }

    #endregion

    #region SmartPhone
    //Product no8
    public class Smartphone
    {
        public string Brand;
        public string Model;
        public int StorageSize;
        public float Price;
        public string OS; 

        public Smartphone(string brand, string model, int storageSize, float price, string os)
        {
            Brand = brand;
            Model = model;
            StorageSize = storageSize;
            Price = price;
            OS = os;
        }

        public void PrintDetails()
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("Smartphone Details:");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Storage: {StorageSize} GB");
            Console.WriteLine($"Operating System: {OS}");
            Console.WriteLine($"Price: ${Price}");
        }

        public void UpdatePrice(float newPrice)
        {
            if (newPrice >= 0)
            {
                Price = newPrice;
                Console.WriteLine($"Price updated to ${Price}");
            }
            else
            {
                Console.WriteLine("Invalid price. Price cannot be negative.");
            }
        }

        public void InstallApp(string appName)
        {
            Console.WriteLine($"App '{appName}' installed successfully.");
        }
    }

    #endregion

    #region Blender
    //Product no9
    public class Blender
    {
        private string brand;
        private int power; 
        private int speedSettings;
        private float price;

        public Blender(string brand, int power, int speedSettings, float price)
        {
            this.brand = brand;
            this.power = power;
            this.speedSettings = speedSettings;
            this.price = price;
        }

        public void PrintDetails()
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("Blender Details:");
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Power: {power} watts");
            Console.WriteLine($"Speed Settings: {speedSettings}");
            Console.WriteLine($"Price: ${price}");
        }

        public void UpdatePrice(float newPrice)
        {
            if (newPrice >= 0)
            {
                price = newPrice;
                Console.WriteLine($"Price updated to ${price}");
            }
            else
            {
                Console.WriteLine("Invalid price. Price cannot be negative.");
            }
        }

        public void Blend()
        {
            Console.WriteLine("Blender is now blending...");
        }
    }

    #endregion

    #region CoffeeMaker
    //Product No10
    public class CoffeeMaker
    {
        private string brand;
        private int cupCapacity;
        private bool isBrewing;
        private float price;

        public CoffeeMaker(string brand, int cupCapacity, float price)
        {
            this.brand = brand;
            this.cupCapacity = cupCapacity;
            this.isBrewing = false;
            this.price = price;
        }

        public void PrintDetails()
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("Coffee Maker Details:");
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Cup Capacity: {cupCapacity} cups");
            Console.WriteLine($"Price: ${price}");
        }

        public void UpdatePrice(float newPrice)
        {
            if (newPrice >= 0)
            {
                price = newPrice;
                Console.WriteLine($"Price updated to ${price}");
            }
            else
            {
                Console.WriteLine("Invalid price. Price cannot be negative.");
            }
        }

        public void StartBrewing()
        {
            if (!isBrewing)
            {
                isBrewing = true;
                Console.WriteLine("Brewing started...");
            }
            else
            {
                Console.WriteLine("Already brewing.");
            }
        }

        public void StopBrewing()
        {
            if (isBrewing)
            {
                isBrewing = false;
                Console.WriteLine("Brewing stopped.");
            }
            else
            {
                Console.WriteLine("Coffee maker is not brewing.");
            }
        }
    }

    #endregion
}



