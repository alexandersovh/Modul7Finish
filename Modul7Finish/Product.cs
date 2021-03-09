using System;
using System.Collections.Generic;
using System.Text;

namespace Modul7Finish
{
    abstract class Product
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected double Prise { get; set; }
        protected string Monufacturer { get; set; }
        //public abstract void Сharacteristic();
        public virtual double Discount()
        {
            return Prise;
        }
        public virtual void Display()
        {
            Console.WriteLine($" Id:{Id}, \n Name: {Name}, \n Prise: {Prise},\n Monufacturer: " +
                   $"{Monufacturer},\n:^)");
        }
    }
    class Game : Product
    {
        /// <summary>
        /// добовляем возрастной ценз
        /// </summary>
        protected int AgeRating { get; set; }

        public override void Display()
        {
            Console.WriteLine($" Id:{Id}, \n Name: {Name}, \n Prise: {Prise},\n Monufacturer: " +
                   $"{Monufacturer},\n AgeRating: {AgeRating},\n:^)");
        }
        public override double Discount()
        {
            return Prise * 0.2;
        }
        public void DisplayAll(Game[] array)
        {
            ProductCollection<Game> coll = new ProductCollection<Game>(array);
            Game prod;
            for (int i = 0; i < array.Length; i++)
            {
                prod = coll[i];
                prod.Display();
            }
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
        protected string Socet { get; set; }
        protected string FormFactor { get; set; }
        public override void Display()
        {
            Console.WriteLine($" Id:{Id}, \n Name: {Name}, \n Prise: {Prise},\n Monufacturer: " +
                   $"{Monufacturer},\n Socet: {Socet},\n FormFactor: {FormFactor},\n :^)");
        }
        public void DisplayAll(Matherbord[] array)
        {
            ProductCollection<Matherbord> coll = new ProductCollection<Matherbord>(array);
            Matherbord prod;
            for (int i = 0; i < array.Length; i++)
            {
                prod = coll[i];
                prod.Display();
            }
        }

    }
    /// <summary>
    /// проц
    /// </summary>
    class CPU : Hardware
    {
        protected string Chipset { get; set; }
        protected int CPUFrequency { get; set; }
        public override void Display()
        {
            Console.WriteLine($" Id:{Id}, \n Name: {Name}, \n Prise: {Prise},\n Monufacturer: " +
                   $"{Monufacturer},\n Chipset: {Chipset},\n CPUFrequency: {CPUFrequency},\n:^)");
        }
        public void DisplayAll(CPU[] array)
        {
            ProductCollection<CPU> coll = new ProductCollection<CPU>(array);
            CPU prod;
            for (int i = 0; i < array.Length; i++)
            {
                prod = coll[i];
                prod.Display();
            }
        }

    }
    /// <summary>
    /// видюха
    /// </summary>
    class GPU : Hardware
    {
        protected int VidioMemory { get; set; }
        public override double Discount()
        {
            return Prise * 2;
        }
        public override void Display()
        {
            Console.WriteLine($" Id:{Id}, \n Name: {Name}, \n Prise: {Prise},\n Monufacturer: " +
                   $"{Monufacturer},\n VidioMemory: {VidioMemory},\n:^)");
        }
        public void DisplayAll(GPU[] array)
        {
            ProductCollection<GPU> coll = new ProductCollection<GPU>(array);
            GPU prod;
            for (int i = 0; i < array.Length; i++)
            {
                prod = coll[i];
                prod.Display();
            }
        }

    }
    /// <summary>
    /// источник притания БП
    /// </summary>
    class PowerSupply : Hardware
    {
        protected int Power { get; set; }
        public override void Display()
        {
            Console.WriteLine($" Id:{Id}, \n Name: {Name}, \n Prise: {Prise},\n Monufacturer: " +
                   $"{Monufacturer},\n Power: {Power},\n:^)");
        }

        public void DisplayAll(PowerSupply[] array)
        {
            ProductCollection<PowerSupply> coll = new ProductCollection<PowerSupply>(array);
            PowerSupply prod;
            for (int i = 0; i < array.Length; i++)
            {
                prod = coll[i];
                prod.Display();
            }
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
        protected double Weight { get; set; }
        /// <summary>
        /// емкость батареи
        /// </summary>
        protected double VolumeBattery { get; set; }
        public override void Display()
        {
            Console.WriteLine($" Id:{Id}, \n Name: {Name}, \n Prise: {Prise},\n Monufacturer: " +
                   $"{Monufacturer},\n Weight: {Weight},\n VolumeBattery: {VolumeBattery},\n:^)");
        }
        public void DisplayAll(Laptops[] array)
        {
            ProductCollection<Laptops> coll = new ProductCollection<Laptops>(array);
            Laptops prod;
            for (int i = 0; i < array.Length; i++)
            {
                prod = coll[i];
                prod.Display();
            }
        }

    }
}
