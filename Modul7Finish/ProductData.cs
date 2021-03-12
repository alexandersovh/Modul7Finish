using System;
using System.Collections.Generic;
using System.Text;

namespace Modul7Finish
{
    /// <summary>
    /// Реализация индексаторов ч2
    /// </summary>
    /// <typeparam name="T"></typeparam>
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
    class GameData : Game
    {
        /// <summary>
        /// данные обо всех продуктах
        /// </summary>
        /// <returns></returns>
        public static Game[] DataBase()
        {
            Game[] gameArr = new Game[]
            {
                new GameData
                {
                    Id = 10,
                    Name = "PlayerUnknown’s Battlegrounds",
                    Prise = 1400,
                    Monufacturer = "Microsoft",
                    AgeRating = 18
                },
                new GameData
                {
                    Id = 11,
                    Name = "Battlefild",
                    Prise = 1400,
                    Monufacturer = "Microsoft",
                    AgeRating = 18
                }

            };
            return gameArr;
        }
    }
    class MatherbordData : Matherbord
    {
        public static Matherbord[] DataBase()
        {
            var matherbordArr = new Matherbord[]{
                 new MatherbordData{
                     Id = 20,
                    Name = "MSI GA-B250",
                    Prise = 15440,
                    Monufacturer = "MSI",
                    Socet = "LGA1111",
                    FormFactor = "ATX"
                 },
                 new MatherbordData{
                      Id = 21,
                    Name = "GIGABYTE GA-B250 - FinTech",
                    Prise = 15440,
                    Monufacturer = "GIGABYTE",
                    Socet = "LGA1151",
                    FormFactor = "ATX"}
            };
            return matherbordArr;
        }
    }
    class CPUData : CPU
    {
        public static CPU[] DataBase()
        {
            var CPUArr = new CPU[]
            {
                new CPUData
                {
                    Id = 30,
                    Name = "Intel Core i7",
                    Prise = 10500,
                    Monufacturer = "Intel",
                    CPUFrequency =  5667,
                    Chipset = " LGA1366"
                },
                new CPUData
                {
                    Id = 31,
                    Name = "Intel Core i3",
                    Prise = 5500,
                    Monufacturer = "Intel",
                    CPUFrequency =  2667,
                    Chipset = " LGA1366"
                }
                   };
            return CPUArr;
        }
    }
    class GPUData : GPU
    {
        public static GPU[] DataBase()
        {
            var GPUArr = new GPU[]
            {
                new GPUData
                {
                    Id = 40,
                    Name = "MSI Radeon RX 5500 XT Mech 8G OC",
                    Prise = 50419,
                    Monufacturer = "MSI",
                    VidioMemory = 8192
                },
                new GPUData
                {
                    Id = 41,
                    Name = "Nvidia RTX 3090 ref",
                    Prise = 100419,
                    Monufacturer = "Nvidia",
                    VidioMemory = 16000
                }
                   };
            return GPUArr;
        }
    }
    class PowerSupplyData : PowerSupply
    {
        public static PowerSupply[] DataBase()
        {
            var powerSupplyArr = new PowerSupply[]
            {
                new PowerSupplyData
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
    }
    class LaptopsData : Laptops
    {
        public static Laptops[] DataBase()
        {
            var laptopsArr = new Laptops[]
            {
                new LaptopsData
                {
                    Id = 60,
                    Name = "Acer ASPIRE 3 A315-22",
                    Prise = 29500,
                    Monufacturer = "Acer",
                    Weight = 1.94,
                    VolumeBattery = 4810,
                }, new LaptopsData
                {
                    Id = 61,
                    Name = "ASUS Expertbook B9450FA-BM0556",
                    Prise = 92990,
                    Monufacturer = "ASUS",
                    Weight = 0.88,
                    VolumeBattery = 66,
                }
            };
            return laptopsArr;
        }

    }

}
