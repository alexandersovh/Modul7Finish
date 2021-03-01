using System;

namespace Modul7Finish
{
    class Program
    {
        static void Main(string[] args)
        {
            ///// Men
            //Console.Write("ввдите имя: ");
            //string name = Console.ReadLine();

            //Console.Write("ввдите возраст: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.Write("ввдите адрес: ");
            //string addressMen = Console.ReadLine();

            /////Order
            //int idOrder;
            //string nameOrder;
            //Console.Write("ввдите Id: ");
            //idOrder = int.Parse(Console.ReadLine());

            //Console.Write("или название товара: ");
            //nameOrder = Console.ReadLine();

            //Console.WriteLine("можете взять товар но адресу {0}", addressMen);

            /// Men

            //Men mene = new Men("asdfg", 12, "156486");

            //Console.WriteLine("nad {0}", mene.name);
            //Console.WriteLine("nad {0}", mene.age);
            //Console.WriteLine("nad {0}", mene.addressMen);

            HomeDelivery homeDelivery = new HomeDelivery("6847");

            Console.ReadLine();
        }
    }
    //class Men
    //{
    //    public string name;
    //    public int age;
    //    public string addressMen;

    //    public Men()
    //    {
    //        Console.WriteLine("No data");
    //    }
    //    public Men(string name)
    //    {
    //        this.name = name;
    //    }
    //    public Men(string name, int age) : this(name)
    //    {
    //        //this.name = name;
    //        this.age = age;
    //    }
    //    public Men(string name, int age, string addressMen) : this(name,age)
    //    {
    //        //this.name = name;
    //        //this.age = age;
    //        this.addressMen = addressMen;
    //    }
    //    public void CheckYears()
    //    {
    //        int age;
    //        bool cycle = default;

    //        while (cycle != true)
    //        {
    //            age = int.Parse(Console.ReadLine());
    //            if ((age < 18))
    //            {
    //                cycle = false; string s = "нужно больше 18 лет";
    //                Console.WriteLine(s);
    //            }
    //            else
    //            {
    //                cycle = true;
    //                this.age = age;
    //            }
    //        }
    //    }
    //    public void EnterData()
    //    {
    //        string name = Console.ReadLine();
    //        int age = int.Parse(Console.ReadLine());
    //        CheckYears();
    //        string addressMen = Console.ReadLine();

    //    }

    //}
    abstract class Delivery
    {
        public string address;

        public Delivery()
        {
            
        }
        public Delivery(string address)
        {
            this.address = address;
        }
        public abstract void Deliverytoo();
    }
    class HomeDelivery : Delivery
    {
        public HomeDelivery()
        {
            this.address = "no address";
            Console.WriteLine(this.address);
        }

        public HomeDelivery(string address) : base(address)
        {
            this.address = address;
            Deliverytoo();
        }


        public override void Deliverytoo()
        {
            Console.WriteLine("доствавка домой на адрес {0}", address);
        }
    }
    class PickpointDelivery : Delivery
    {
        public override void Deliverytoo()
        {
            Console.WriteLine("доствавка в пункт выдочи на адрес{0}");
        }
    }
    class ShopDelivery : Delivery
    {
        public override void Deliverytoo()
        {
            Console.WriteLine("доствавка в магазин на адрес{0}", address);
        }
    }
    class Order<Tdelivery, Tstruct> where Tdelivery : Delivery
    {
        public Tdelivery delivery;
        public int number;
        public string description;

        public void displayaddress()
        {
            //Console.WriteLine(delivery.address);
        }
    }
}