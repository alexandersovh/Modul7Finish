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
            var arrUser = UserData.UserDataSet();

            UserCollection userCollection = new UserCollection(arrUser);

            User user;

            Console.WriteLine("здравствуйте вы впервые в магазине (введите да/нет)");
            string q = Console.ReadLine();
            if (q == "нет")
            {
                for (int i = 0; i < arrUser.Length; i++)
                {
                    user = userCollection[i];
                    Console.WriteLine($"{i + 1}) {user.Name}, {user.Adress}, {user.Balance},{user.Age}");
                }
                int ires;
                Console.Write("укажите ваше № вашего имени: ");

                ires = int.Parse(Console.ReadLine());

                user = userCollection[ires - 1];
                Console.Write($"Это ваши данные: {user.Name}, \n\t\t{user.Adress}, \n\t\t{user.Balance}, \n\t\t{user.Age}");
            }
            else
            {
                UserWrite userWrite = new UserWrite();
                Console.Write($"Это ваши данные: {userWrite.Name}, \n\t\t{userWrite.Adress}, \n\t\t{userWrite.Balance}, \n\t\t{userWrite.Age}");

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
