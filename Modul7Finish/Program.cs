using System;

namespace Modul7Finish
{       
    class Program
    {
        static void Main(string[] args)
        {
            Men men = new Men("alex", 12, "Yyroclavka");
            Console.ReadLine();
        }
    }
    class Men
    {
        public static string name;
        public static int age;
        public static string addressMen;

        public Men() 
        {
            Console.WriteLine("No data");
        }
        public Men(string name) 
        { 
            Console.WriteLine(name);
            ManSet(name);
        }
        public Men(string name, int age) 
        { 
            Console.WriteLine(name);
            Console.WriteLine(age);
            ManSet(name, age);
        }
        public Men(string name, int age, string addressMen) 
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(addressMen);
            MenSet(name, age, addressMen);
        }
        public static void MenSet(string nameS)
        {
            name = nameS;
        }
        public static void MenSet(string nameS, int ageS)
        {
            name = nameS;
            age = ageS;
        }
        public static void MenSet(string nameS, int ageS, string addressMeS)
        {
            name = nameS;
            age = ageS;
            addressMen = addressMeS;
        }
    }
    //abstract class Delivery
    //{
    //    public string Address;

    //    public Delivery()
    //    {

    //    }
    //    public Delivery(string Address)
    //    {
    //        this.Address = Address;
    //    }
    //    public abstract void DeliveryToo();
    //}
    //class HomeDelivery : Delivery
    //{
    //    public override void DeliveryToo()
    //    {
    //        Console.WriteLine("доствавка домой на адрес{0}", Men.addressMen);
    //    }
    //}
    //class PickPointDelivery : Delivery
    //{
    //    public override void DeliveryToo()
    //    {
    //        Console.WriteLine("доствавка в пункт выдочи на адрес{0}", Address);
    //    }
    //}
    //class ShopDelivery : Delivery
    //{
    //    public override void DeliveryToo()
    //    {
    //        Console.WriteLine("доствавка в магазин на адрес{0}", Address);
    //    }
    //}
    //class Order<TDelivery, TStruct> where TDelivery : Delivery
    //{
    //    public TDelivery Delivery;
    //    public int Number;
    //    public string Description;

    //    public void DisplayAddress()
    //    {
    //        Console.WriteLine(Delivery.Address);
    //    }
    //}

}