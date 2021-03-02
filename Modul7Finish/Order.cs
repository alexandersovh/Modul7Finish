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
        public void UserCall()
        {
            User user;

            Console.WriteLine("здравствуйте вы впервые в магазине (введите да/нет)");
            string q = Console.ReadLine();
            if (q == "нет")
            {
                for (int i = 0; i < UserData.UserDataSet().Length; i++)
                {

                    string ist = Convert.ToString(i + 1);
                    Console.WriteLine(ist + ") " + UserData.UserArray[i].Name);
                }
                int ires;
                Console.Write("укажите ваше № вашего имени: ");
                ires = int.Parse(Console.ReadLine());

                User.DataUser(ires);
            }
            else
            {
                user = new User();
                user.DataUser();
            }

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
