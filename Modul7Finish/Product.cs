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
        public abstract double Choise(int[] id, double[] prise);
        
    }
    class Game : Product
    {
        /// <summary>
        /// добовляем возрастной ценз
        /// </summary>
        /// 
        protected int ageRating;
        protected int AgeRating
        {
            ///проверка при получении
            get
            {
                Order order = new Order();
                if (ageRating > order.ResultAge)
                {
                    return 0;
                }
                return ageRating;
            }
            set
            {

            }
        }

        public override double Discount()
        {
            return Prise * 0.2;
        }
        public double Display(Game[] array)
        {
            ///if (AgeRating == 0)
            //{
            //    int[] defId = default;
            //    double[] defPrise = default;
            //    return (defId, defPrise);
            //}

            ProductCollection<Game> coll = new ProductCollection<Game>(array);
            Game prod = new Game();

            int[] id = new int[array.Length];
            double[] prise = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                prod = coll[i];
                prod.Read();
                id[i] = prod.Id;
                prise[i] = prod.Prise;
            }
            return Choise(id, prise);
        }

        public override void Read()
        {
            Game game = new Game();
            Console.WriteLine($" Id:{Id}, \n Name: {Name}, \n Prise: {Prise},\n Monufacturer: " +
                               $"{Monufacturer},\n AgeRating: {AgeRating}\n:^)");
        }
        public override double Choise(int[] id, double[] prise)
        {
            Console.Write("введите Id тавара для которое хотите приобрести:");
            int idProduct = int.Parse(Console.ReadLine());
            int iArray = -1;
            int idNum = default;
            double priseNum = default;
            if (ageRating == 0)
            {
                Console.WriteLine("вы не можите купить этот тавар");
                return priseNum;
            }

            do
            {
                iArray++;
                idNum = id[iArray];
                priseNum = prise[iArray];
            } while (id[iArray] != idProduct && iArray < id.Length);
            Console.WriteLine("Ваш тавар с id {0} и ценой {1}", idNum, priseNum);
            return priseNum;
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
        public double Display(Matherbord[] array)
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
            return Choise(id, prise);
        }
        public override void Read()
        {
            Matherbord read = new Matherbord();
            Console.WriteLine($" Id:{Id}, \n Name: {Name}, \n Prise: {Prise},\n Monufacturer: " +
                               $"{Monufacturer},\n AgeRating: {Socet}\n:^)");
        }
        public override double Choise(int[] id, double[] prise)
        {
            Console.Write("введите Id тавара для которое хотите приобрести:");
            int idProduct = int.Parse(Console.ReadLine());
            int iArray = -1;
            int idNum = default;
            double priseNum = default;

            do
            {
                iArray++;
                idNum = id[iArray];
                priseNum = prise[iArray];
            } while (id[iArray] != idProduct && iArray < id.Length);
            Console.WriteLine("Ваш тавар с id {0} и ценой {1}", idNum, priseNum);
            return priseNum;

        }
    }
    /// <summary>
    /// проц
    /// </summary>
    class CPU : Hardware
    {
        protected string Chipset { get; set; }
        protected int CPUFrequency { get; set; }
        public double Display(CPU[] array)
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
            return Choise(id, prise);
        }

        public override void Read()
        {
            CPU read = new CPU();
            Console.WriteLine($" Id:{Id}, \n Name: {Name}, \n Prise: {Prise},\n Monufacturer: " +
                               $"{Monufacturer},\n Chipset: {Chipset}\n:^)");
        }
        public override double Choise(int[] id, double[] prise)
        {
            Console.Write("введите Id тавара для которое хотите приобрести:");
            int idProduct = int.Parse(Console.ReadLine());
            int iArray = -1;
            int idNum = default;
            double priseNum = default;

            do
            {
                iArray++;
                idNum = id[iArray];
                priseNum = prise[iArray];
            } while (id[iArray] != idProduct && iArray < id.Length);
            Console.WriteLine("Ваш тавар с id {0} и ценой {1}", idNum, priseNum);
            return priseNum;

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
        public double Display(GPU[] array)
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
            return Choise(id, prise);

        }
        public override void Read()
        {
            GPU read = new GPU();
            Console.WriteLine($" Id:{Id}, \n Name: {Name}, \n Prise: {Prise},\n Monufacturer: " +
                               $"{Monufacturer},\n VidioMemory: {VidioMemory}\n:^)");
        }
        public override double Choise(int[] id, double[] prise)
        {
            Console.Write("введите Id тавара для которое хотите приобрести:");
            int idProduct = int.Parse(Console.ReadLine());
            int iArray = -1;
            int idNum = default;
            double priseNum = default;

            do
            {
                iArray++;
                idNum = id[iArray];
                priseNum = prise[iArray];
            } while (id[iArray] != idProduct && iArray < id.Length);
            Console.WriteLine("Ваш тавар с id {0} и ценой {1}", idNum, priseNum);
            return priseNum;

        }
    }

    /// <summary>
    /// источник притания БП
    /// </summary>
    class PowerSupply : Hardware
    {
        protected int Power { get; set; }
        public double Display(PowerSupply[] array)
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
            return Choise(id, prise);
        }

        public override void Read()
        {
            PowerSupply read = new PowerSupply();
            Console.WriteLine($" Id:{Id}, \n Name: {Name}, \n Prise: {Prise},\n Monufacturer: " +
                               $"{Monufacturer},\n Power: {Power}\n:^)");
        }
        public override double Choise(int[] id, double[] prise)
        {
            Console.Write("введите Id тавара для которое хотите приобрести:");
            int idProduct = int.Parse(Console.ReadLine());
            int iArray = -1;
            int idNum = default;
            double priseNum = default;

            do
            {
                iArray++;
                idNum = id[iArray];
                priseNum = prise[iArray];
            } while (id[iArray] != idProduct && iArray < id.Length);
            Console.WriteLine("Ваш тавар с id {0} и ценой {1}", idNum, priseNum);
            return priseNum;

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
        public double Display(Laptops[] array)
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
            return Choise(id, prise);
        }

        public override void Read()
        {
            Laptops read = new Laptops();
            Console.WriteLine($" Id:{Id}, \n Name: {Name}, \n Prise: {Prise},\n Monufacturer: " +
                               $"{Monufacturer},\n Weight: {Weight}\n:^)");
        }
        public override double Choise(int[] id, double[] prise)
        {
            Console.Write("введите Id тавара для которое хотите приобрести:");
            int idProduct = int.Parse(Console.ReadLine());
            int iArray = -1;
            int idNum = default;
            double priseNum = default;

            do
            {
                iArray++;
                idNum = id[iArray];
                priseNum = prise[iArray];
            } while (id[iArray] != idProduct && iArray < id.Length);
            Console.WriteLine("Ваш тавар с id {0} и ценой {1}", idNum, priseNum);
            return priseNum;
        }
    }
}
