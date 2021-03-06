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
        //public abstract void Сharacteristic();
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
        public Game()
        {
            Console.WriteLine($" Id:{this.Id}, \n Name: {this.Name}, \n Prise: {this.Prise},\n Monufacturer: " +
                   $"{this.Monufacturer},\n AgeRating: {this.AgeRating},\n:^)");
        }
        public override double Discount()
        {
            return Prise * 0.2;
        }
    }
    /// <summary>
    /// прочее железо
    /// </summary>
    abstract class Hardware : Product
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
        public string Socet { get; set; }
        public string FormFactor { get; set; }
        public Matherbord()
        {
            Console.WriteLine($" Id:{this.Id}, \n Name: {this.Name}, \n Prise: {this.Prise},\n Monufacturer: " +
                   $"{this.Monufacturer},\n Socet: {this.Socet},\n FormFactor: {this.FormFactor},\n :^)");
        }


    }
    /// <summary>
    /// проц
    /// </summary>
    class CPU : Hardware
    {
        public string Chipset { get; set; }
        public int CPUFrequency { get; set; }
        public CPU()
        {
            Console.WriteLine($" Id:{this.Id}, \n Name: {this.Name}, \n Prise: {this.Prise},\n Monufacturer: " +
                   $"{this.Monufacturer},\n Chipset: {this.Chipset},\n CPUFrequency: {this.CPUFrequency},\n:^)");
        }
    }
    /// <summary>
    /// видюха
    /// </summary>
    class GPU : Hardware
    {
        public int VidioMemory { get; set; }
        public override double Discount()
        {
            return Prise * 2;
        }
        public GPU()
        {
            Console.WriteLine($" Id:{this.Id}, \n Name: {this.Name}, \n Prise: {this.Prise},\n Monufacturer: " +
                   $"{this.Monufacturer},\n VidioMemory: {this.VidioMemory},\n:^)");
        }

    }
    /// <summary>
    /// источник притания БП
    /// </summary>
    class PowerSupply : Hardware
    {
        public int Power { get; set; }
        public PowerSupply()
        {
            Console.WriteLine($" Id:{this.Id}, \n Name: {this.Name}, \n Prise: {this.Prise},\n Monufacturer: " +
                   $"{this.Monufacturer},\n Power: {this.Power},\n:^)");
        }
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
        public Laptops()
        {
            Console.WriteLine($" Id:{this.Id}, \n Name: {this.Name}, \n Prise: {this.Prise},\n Monufacturer: " +
                   $"{this.Monufacturer},\n Weight: {this.Weight},\n VolumeBattery: {this.VolumeBattery},\n:^)");
        }
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
    /// <summary>
    /// несколько методов с массивом соответствующие типу продукта
    /// </summary>
    static class ProductData
    {
        /// <summary>
        /// здесь массив с таварами
        /// </summary>
        /// <returns></returns>
        public static Game[] GametDataBase()
        {
            var gameArr = new Game[]
            {
                new Game
                {
                    Id = 10,
                    Name = "PlayerUnknown’s Battlegrounds",
                    Prise = 1400,
                    Monufacturer = "Microsoft",
                    AgeRating = 18
                }
            };
            return gameArr;
        }
        public static Matherbord[] MatherbordDataBase()
        {
            var matherbordArr = new Matherbord[]
            {
                 new Matherbord
                 {
                    Id = 20,
                    Name = "Материнская плата GIGABYTE GA-B250 - FinTech",
                    Prise = 15440,
                    Monufacturer = "GIGABYTE",
                    Socet = "LGA1151",
                    FormFactor = "ATX"
                 }
            };
            return matherbordArr;
        }
        public static CPU[] CPUDataBase()
        {
            var CPUArr = new CPU[]
            {
                new CPU
                {
                    Id = 30,
                    Name = "Intel Core i7 Bloomfield",
                    Prise = 5500,
                    Monufacturer = "Intel",
                    CPUFrequency =  2667,
                    Chipset = " LGA1366"
                }
                   };
            return CPUArr;
        }
        public static GPU[] GPUDataBase()
        {
            var GPUArr = new GPU[]
            {
                new GPU
                {
                    Id = 40,
                    Name = "MSI Radeon RX 5500 XT Mech 8G OC",
                    Prise = 50419,
                    Monufacturer = "MSI",
                    VidioMemory = 8192
                }
                   };
            return GPUArr;
        }
        public static PowerSupply[] PowerSupplyDataBase()
        {
            var powerSupplyArr = new PowerSupply[]
            {
                new PowerSupply
                    {
                        Id = 50,
                        Name = "Cooler Master MasterWatt Lite 230V 500W",
                        Prise = 3900,
                        Monufacturer = "Cooler Master",
                        Power =  500
                    }
            };
            return powerSupplyArr;
        }
        public static Laptops[] LaptopsDataBase()
        {
            var laptopsArr = new Laptops[]
            {
                new Laptops
                {
                    Id = 60,
                    Name = "Acer ASPIRE 3 A315-22",
                    Prise = 29500,
                    Monufacturer = "Acer",
                    Weight = 1.94,
                    VolumeBattery = 4810,
                }
            };
            return laptopsArr;
        }
        //public Product[] ProductBranhcing<U>(U array)
        //{ 
        //string[] a = default;

        //    switch (array)
        //    {
        //        case "игры":
        //            return GametDataBase();
        //            break;
        //        case "материнские платы":
        //            return MatherbordDataBase();
        //            break;
        //        case "CPU":
        //            return CPUDataBase();
        //            break;
        //        case "GPU":
        //            return GPUDataBase();
        //            break;
        //        case "блок питания":
        //            return PowerSupplyDataBase();
        //            break;
        //        case "ноутбуки":
        //            return LaptopsDataBase();
        //            break;
        //        default:
        //            return  null;
        //            break;
        //    }
        //}
    }
    static class Branhcing <T>
    {
        public static Product[] ProductBranhcing<U>(U array)
        {

            switch (array)
            {
                case "игры":
                    return ProductData.GametDataBase();
                    break;
                case "материнские платы":
                    return ProductData.MatherbordDataBase();
                    break;
                case "CPU":
                    return ProductData.CPUDataBase();
                    break;
                case "GPU":
                    return ProductData.GPUDataBase();
                    break;
                case "блок питания":
                    return ProductData.PowerSupplyDataBase();
                    break;
                case "ноутбуки":
                    return ProductData.LaptopsDataBase();
                    break;
                default:
                    return null;
                    break;
            }
            switch (array)
            {
                case 1:
                    return ProductData.GametDataBase();
                    break;
                case 2:
                    return ProductData.MatherbordDataBase();
                    break;
                case 3:
                    return ProductData.CPUDataBase();
                    break;
                case 4:
                    return ProductData.GPUDataBase();
                    break;
                case 5:
                    return ProductData.PowerSupplyDataBase();
                    break;
                case 6:
                    return ProductData.LaptopsDataBase();
                    break;https://www.youtube.com/watch?v=Qm5QPJbUmm0
                default:
                    return null;
                    break;
            }

        }
                    
    }
}
