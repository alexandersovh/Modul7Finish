using System;
using System.Collections.Generic;
using System.Text;

namespace Modul7Finish
{
    //class Order<Tdelivery, Tstruct> where Tdelivery : Delivery
    //{
    //    public Tdelivery delivery;
    //    public int number;
    //    public string description;

    //    public void displayaddress()
    //    {
            
    //    }
    class Order
    {
        public static void UserCall()
        {
            var arrUser = UserData.UserDataSet();

            UserCollection userCollection = new UserCollection(arrUser);

            UserData userData;

            Console.WriteLine("здравствуйте вы впервые в магазине (введите да/нет)");
            string q = Console.ReadLine();
            if (q == "нет")
            {
                for (int i = 0; i < arrUser.Length; i++)
                {
                    userData = userCollection[i];
                    UserData userData1 = new UserData();
                    userData1.UserSetData(i);
                }
                int ires;
                Console.Write("укажите ваше № вашего имени: ");

                ires = int.Parse(Console.ReadLine());

                userData = userCollection[ires - 1];
                userData = new UserData();
            }
            else
            {
                UserWrite userWrite = new UserWrite();
            }
        }
        public static void ProductB()
        {

            //Branhcing;

            //ProductCollection<Game> game = new ProductCollection<Game>(GArray);
            //ProductCollection<Matherbord> matherbord = new ProductCollection<Matherbord>(Marray);
            //ProductCollection<CPU> cpu = new ProductCollection<CPU>(CPUarray);
            //ProductCollection<GPU> gpu = new ProductCollection<GPU>(GPUarray);
            //ProductCollection<PowerSupply> powerSupply = new ProductCollection<PowerSupply>(PSMarray);
            //ProductCollection<Laptops> mather = new ProductCollection<Laptops>(Larray);
        }
        public void DeliviriCall(string a)
        {
            if (a == "home")
            {
                Informer.FimalReport();

            }
            else if (a == "poin")
            {
                Informer.FimalReport();
            }
            else if (a == "shop")
            {
                Informer.FimalReport();
            }
        }
    }
}
