using System;
using System.Collections.Generic;
using System.Text;

namespace Modul7Finish
{
    abstract class Product
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
        public double Prise { get; protected set; }
        protected string Monufacturer { get; set; }
        //public abstract void Сharacteristic();
        public virtual double Discount()
        {
            return Prise;
        }
        public virtual (int, string, double, string) Display()
        {
            Console.WriteLine($" Id:{Id}, \n Name: {Name}, \n Prise: {Prise},\n Monufacturer: " +
                   $"{Monufacturer},\n:^)");
            var dataUser = (Id, Name, Prise, Monufacturer);
            return dataUser;
        }
        public double LogicBuyProd()
        {
            return Prise;
        }
        abstract public void Read();
        //{
        //    Console.WriteLine($" Id:{Id}, \n Name: {Name}, \n Prise: {Prise},\n Monufacturer: " +
        //                       $"{Monufacturer},\n\n:^)");
        //}

    }
    class Game : Product
    {
        /// <summary>
        /// добовляем возрастной ценз
        /// </summary>
        protected int AgeRating { get; set; }
        public override double Discount()
        {
            return Prise * 0.2;
        }
        public ( int[], double[] ) Display(Game[] array)
        {
            
            ProductCollection<Game> coll = new ProductCollection<Game>(array);
            Game prod;
            //Game game = new Game();

            int[] id = new int[array.Length];
            double[] prise = new double[array.Length];
            //var dataUser = (Id, Name, Prise, Monufacturer);
            for (int i = 0; i < array.Length; i++)
            {

                prod = coll[i];
                prod.Read();
                id[i] = prod.Id;
                prise[i] = prod.Prise;
            }
            return (id, prise);
        }
        public override void Read()
        {
            Game game = new Game();
            Console.WriteLine($" Id:{Id}, \n Name: {Name}, \n Prise: {Prise},\n Monufacturer: " +
                               $"{Monufacturer},\n AgeRating: {AgeRating}\n:^)");
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
        public (int[], double[]) Display(Matherbord[] array)
        {


            ProductCollection<Matherbord> coll = new ProductCollection<Matherbord>(array);
            Matherbord prod;

            double[] prise = new double[array.Length];

            int[] id = new int[array.Length];
            //var dataUser = (Id, Name, Prise, Monufacturer);
            for (int i = 0; i < array.Length; i++)
            {
                prod = coll[i];
                prod.Read();
                id[i] = prod.Id;
                prise[i] = prod.Prise;

            }
            return (id, prise);
        }
        public override void Read()
        {
            Matherbord read = new Matherbord();
            Console.WriteLine($" Id:{Id}, \n Name: {Name}, \n Prise: {Prise},\n Monufacturer: " +
                               $"{Monufacturer},\n AgeRating: {Socet}\n:^)");
        }
    }
    /// <summary>
    /// проц
    /// </summary>
    class CPU : Hardware
    {
        protected string Chipset { get; set; }
        protected int CPUFrequency { get; set; }
        public (int[], double[]) Display(CPU[] array)
        {

            ProductCollection<CPU> coll = new ProductCollection<CPU>(array);
            CPU prod;

            double[] prise = new double[array.Length];

            int[] id = new int[array.Length];
            //var dataUser = (Id, Name, Prise, Monufacturer);
            for (int i = 0; i < array.Length; i++)
            {
                prod = coll[i];
                prod.Read();
                id[i] = prod.Id;
                prise[i] = prod.Prise;

            }
            return (id, prise);
        }

        public override void Read()
        {
            CPU read = new CPU();
            Console.WriteLine($" Id:{Id}, \n Name: {Name}, \n Prise: {Prise},\n Monufacturer: " +
                               $"{Monufacturer},\n Chipset: {Chipset}\n:^)");
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
        public (int[], double[]) Display(GPU[] array)
        {
            ProductCollection<GPU> coll = new ProductCollection<GPU>(array);
            GPU prod;
            double[] prise = new double[array.Length];

            int[] id = new int[array.Length];
            //var dataUser = (Id, Name, Prise, Monufacturer);
            for (int i = 0; i < array.Length; i++)
            {
                prod = coll[i];
                prod.Read();
                id[i] = prod.Id;
                prise[i] = prod.Prise;

            }
            return (id, prise);
        }

        public override void Read()
        {
            GPU read = new GPU();
            Console.WriteLine($" Id:{Id}, \n Name: {Name}, \n Prise: {Prise},\n Monufacturer: " +
                               $"{Monufacturer},\n VidioMemory: {VidioMemory}\n:^)");
        }
    }


    /// <summary>
    /// источник притания БП
    /// </summary>
    class PowerSupply : Hardware
    {
        protected int Power { get; set; }
        public (int[], double[]) Display(PowerSupply[] array)
        {
            ProductCollection<PowerSupply> coll = new ProductCollection<PowerSupply>(array);
            PowerSupply prod;
            double[] prise = new double[array.Length];

            int[] id = new int[array.Length];
            //var dataUser = (Id, Name, Prise, Monufacturer);
            for (int i = 0; i < array.Length; i++)
            {
                prod = coll[i];
                prod.Read();
                id[i] = prod.Id;
                prise[i] = prod.Prise;



            }
            return (id, prise);
        }

        public override void Read()
        {
            PowerSupply read = new PowerSupply();
            Console.WriteLine($" Id:{Id}, \n Name: {Name}, \n Prise: {Prise},\n Monufacturer: " +
                               $"{Monufacturer},\n Power: {Power}\n:^)");
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
        public (int[], double[]) Display(Laptops[] array)
        {
            ProductCollection<Laptops> coll = new ProductCollection<Laptops>(array);
            Laptops prod;

            double[] prise = new double[array.Length];
            int[] id = new int[array.Length];
            //var dataUser = (Id, Name, Prise, Monufacturer);
            for (int i = 0; i < array.Length; i++)
            {
                prod = coll[i];
                prod.Read();
                id[i] = prod.Id;
                prise[i] = prod.Prise;

            }
            return (id, prise);
        }

        public override void Read()
        {
            Laptops read = new Laptops();
            Console.WriteLine($" Id:{Id}, \n Name: {Name}, \n Prise: {Prise},\n Monufacturer: " +
                               $"{Monufacturer},\n Weight: {Weight}\n:^)");
        }
    }
}
