using System;
using System.Collections.Generic;
using System.Text;

namespace Modul7Finish
{
    abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Prise { get; set; }
        public string Monufacturer { get; set; }
        public virtual double Discount()
        {
            return Prise;
        }
    }
    class Game : Product
    {
        /// <summary>
        /// добовляем возрастной ценз
        /// </summary>
        public int AgeRating { get; set; }
        public override double Discount()
        {
            return Prise * 0.2;
        }
    }
    /// <summary>
    /// прочее железо
    /// </summary>
    class Hardware : Product
    {

        public override double Discount()
        {
            return Prise * 0.5;
        }
    }
    /// <summary>
    /// мать плата
    /// </summary>
    class Matherbord : Hardware
    {
        public string Chipset { get; set; }
        public string FormFactor { get; set; }

    }
    /// <summary>
    /// проц
    /// </summary>
    class CPU : Hardware
    {
        public string Chipset { get; set; }

        public int CPUFrequency { get; set; }
    }
    /// <summary>
    /// видюха
    /// </summary>
    class GPU : Hardware
    {
        public int VidioMemory { get; set; }
        public override double Discount()
        {
            return Prise * 1000;
        }


    }
    /// <summary>
    /// источник притания БП
    /// </summary>
    class PowerSupply : Hardware
    {
        public int Power { get; set; }
    }
    /// <summary>
    /// ноутбуки
    /// </summary>
    class Laptops : Product
    {
        /// <summary>
        /// масса
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// емкость батареи
        /// </summary>
        public double VolumeBattery { get; set; }
    }
    class ProductCollection<T>
    {
        private T[] Pcollection;

        public ProductCollection(T[] pcollection)
        {
            Pcollection = pcollection;
        }
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < Pcollection.Length)
                {
                    return Pcollection[index];
                }
                return default;
            }
            private set
            {
                if (index >= 0 && index < Pcollection.Length)
                {
                    Pcollection[index] = value;
                }
            }
        }

    }
    static class ProductData
    {
        /// <summary>
        /// здесь массив с людьм
        /// </summary>
        /// <returns></returns>
        public static Game[] GametDataBase()
        {
            var ArrayProduct0 = new Game[]
            {
                    new Game
                    {
                        Id = 1,
                        Name = "PlayerUnknown’s Battlegrounds",
                        Prise = 1400,
                        Monufacturer = "Microsoft",
                        AgeRating = 18
                    },
                    new Game
                    {
                        Id = 2,
                        Name = "PlayerUnknown’s Battlegrounds",
                        Prise = 1400,
                        Monufacturer = "Microsoft",
                        AgeRating = 18
                    },
                    new Game
                    {
                        Id = 3,
                        Name = "PlayerUnknown’s Battlegrounds",
                        Prise = 1400,
                        Monufacturer = "Microsoft",
                        AgeRating = 18
                    },
                    new Game
                    {
                        Id = 14,
                        Name = "PlayerUnknown’s Battlegrounds",
                        Prise = 1400,
                        Monufacturer = "Microsoft",
                        AgeRating = 18
                    }
            };
            return ArrayProduct0;
        }
        public static Matherbord[] MatherbordDataBase()
        {
            var ArrayProduct1 = new Matherbord[]
        {
                    new Matherbord
                    {
                        Id = 21,
                        Name = "Материнская плата GIGABYTE GA-B250 - FinTech",
                        Prise = 15440,
                        Monufacturer = "GIGABYTE",
                        Chipset = "LGA1151",
                        FormFactor = "ATX"
                    },
                    new Matherbord
                     {
                        Id = 22,
                        Name = "Материнская плата GIGABYTE GA-B250 - FinTech",
                        Prise = 15440,
                        Monufacturer = "GIGABYTE",
                        Chipset = "LGA1151",
                        FormFactor = "ATX"
                    },
                     new Matherbord
                      {
                        Id = 23,
                        Name = "Материнская плата GIGABYTE GA-B250 - FinTech",
                        Prise = 15440,
                        Monufacturer = "GIGABYTE",
                        Chipset = "LGA1151",
                        FormFactor = "ATX"
                    },
                      new Matherbord
                       {
                        Id = 24,
                        Name = "Материнская плата GIGABYTE GA-B250 - FinTech",
                        Prise = 15440,
                        Monufacturer = "GIGABYTE",
                        Chipset = "LGA1151",
                        FormFactor = "ATX"
                    }
        };
            return ArrayProduct1;
        }
        public static CPU[] CPUDataBase()
        {
            var ArrayProduct2 = new CPU[]
            {
                    new CPU
                    {
                        Id = 30,
                        Name = "Intel Core i7 Bloomfield",
                        Prise = 5500,
                        Monufacturer = "Intel",
                        CPUFrequency =  2667,
                        Chipset = " LGA1366"
                    },
                    new CPU
                    {
                        Id = 31,
                        Name = "Intel Core i7 Bloomfield",
                        Prise = 5500,
                        Monufacturer = "Intel",
                        CPUFrequency =  2667,
                        Chipset = " LGA1366"
                    },
                    new CPU
                    {
                        Id = 32,
                        Name = "Intel Core i7 Bloomfield",
                        Prise = 5500,
                        Monufacturer = "Intel",
                        CPUFrequency =  2667,
                        Chipset = " LGA1366"
                    }
                   };
            return ArrayProduct2;
        }
        public static GPU[] GPUDataBase()
        {
            var ArrayProduct3 = new GPU[]
            {
                    new GPU
                    {
                        Id = 41,
                        Name = "MSI Radeon RX 5500 XT Mech 8G OC",
                        Prise = 50419,
                        Monufacturer = "MSI",
                        VidioMemory = 8192
                    },
                    new GPU
                    {
                        Id = 42,
                        Name = "MSI Radeon RX 5500 XT Mech 8G OC",
                        Prise = 50419,
                        Monufacturer = "MSI",
                        VidioMemory = 8192
                    },
                    new GPU
                    {
                        Id = 43,
                        Name = "MSI Radeon RX 5500 XT Mech 8G OC",
                        Prise = 50419,
                        Monufacturer = "MSI",
                        VidioMemory = 8192
                    }
                   };
            return ArrayProduct3;
        }
        public static PowerSupply[] PowerSupplyDataBase()
        {
            var ArrayProduct4 = new PowerSupply[]
            {
                    new PowerSupply
                    {
                        Id = 51,
                        Name = "Cooler Master MasterWatt Lite 230V 500W",
                        Prise = 3900,
                        Monufacturer = "Cooler Master",
                        Power =  500
                    },
                      new PowerSupply
                    {
                        Id = 52,
                        Name = "Cooler Master MasterWatt Lite 230V 500W",
                        Prise = 3900,
                        Monufacturer = "Cooler Master",
                        Power =  500
                    },
                        new PowerSupply
                    {
                        Id = 53,
                        Name = "Cooler Master MasterWatt Lite 230V 500W",
                        Prise = 3900,
                        Monufacturer = "Cooler Master",
                        Power =  500
                    },
                          new PowerSupply
                    {
                        Id = 54,
                        Name = "Cooler Master MasterWatt Lite 230V 500W",
                        Prise = 3900,
                        Monufacturer = "Cooler Master",
                        Power =  500
                    },
                            new PowerSupply
                    {
                        Id = 55,
                        Name = "Cooler Master MasterWatt Lite 230V 500W",
                        Prise = 3900,
                        Monufacturer = "Cooler Master",
                        Power =  500
                    }
                   };
            return ArrayProduct4;
        }
        public static Laptops[] LaptopsDataBase()
        {
            var ArrayProduct5 = new Laptops[]
            {
                    new Laptops
                    {
                        Id = 74,
                        Name = "Acer ASPIRE 3 A315-22",
                        Prise = 29500,
                        Monufacturer = "Acer",
                        Weight = 1.94,
                        VolumeBattery = 4810,
                    },
                    new Laptops
                    {
                        Id = 71,
                        Name = "Acer ASPIRE 3 A315-22",
                        Prise = 29500,
                        Monufacturer = "Acer",
                        Weight = 1.94,
                        VolumeBattery = 4810,
                    },
                    new Laptops
                    {
                        Id = 72,
                        Name = "Acer ASPIRE 3 A315-22",
                        Prise = 29500,
                        Monufacturer = "Acer",
                        Weight = 1.94,
                        VolumeBattery = 4810,
                    },
                    new Laptops
                    {
                        Id = 73,
                        Name = "Acer ASPIRE 3 A315-22",
                        Prise = 29500,
                        Monufacturer = "Acer",
                        Weight = 1.94,
                        VolumeBattery = 4810,
                    },
                    new Laptops
                    {
                        Id = 75,
                        Name = "Acer ASPIRE 3 A315-22",
                        Prise = 29500,
                        Monufacturer = "Acer",
                        Weight = 1.94,
                        VolumeBattery = 4810,
                    },
                    new Laptops
                    {
                        Id = 76,
                        Name = "Acer ASPIRE 3 A315-22",
                        Prise = 29500,
                        Monufacturer = "Acer",
                        Weight = 1.94,
                        VolumeBattery = 4810,
                    }
            };
            return ArrayProduct5;
        }

            //string a = Console.ReadLine();

            //switch (a)
            //{
            //    case "Game":
            //        return ArrayProduct0;
            //        break;
            //    case "Matherbord":
            //        return ArrayProduct1;
            //        break;
            //    case "CPU":
            //        return ArrayProduct2;
            //        break;
            //    case "GPU":
            //        return ArrayProduct3;
            //        break;
            //    case "PowerSupply":
            //        return ArrayProduct4;
            //        break;
            //    case "Laptops":
            //        return ArrayProduct5;
            //        break;
            //    default:
            //        return ArrayProduct0;
            //        break;
            //}

        
        
        
    }
}
