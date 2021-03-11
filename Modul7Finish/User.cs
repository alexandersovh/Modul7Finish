using System;
using System.Collections.Generic;
using System.Text;

namespace Modul7Finish
{
    class User
    {
        protected string Name { get; set; }
        protected string Adress { get; set; }
        protected double Balance { get; set; }
        private int age;
        protected int Age
        {
            get { return age; }
            set
            {
                if (value < 14)
                {
                    Console.WriteLine("Возраст должен быть больше 14");
                    Order.UserDisplay();
                }
                else
                {
                    age = value;
                }
            }
            
        }

        public double LogicBuyUser(double prise, double balanse)
        {
            Balance = balanse;
            if (prise <= Balance)
            {
                return Balance -= prise;
                balanse = Balance;
            }
            else
            {
                Console.WriteLine("недостаточно средств");
                return Balance;
            }

        }

    }
    class UserWrite : User
    {
        /// <summary>
        /// св-ва
        /// </summary>
        /// <summary>
        /// конструсторы
        /// </summary>
        public UserWrite()
        {
            Console.Write("введите Имя: ");
            Name = Console.ReadLine();

            Console.Write("введите адрес: ");
            Adress = Console.ReadLine();

            Console.Write("введите баланс: ");
            Balance = double.Parse(Console.ReadLine());

            Console.Write("введите возраст: ");
            Age = int.Parse(Console.ReadLine());

            //WriteSet();
        }
        public UserWrite(string name, string adress, double balance, int age)
        {
            Name = name;
            Adress = adress;
            Balance = balance;
            Age = age;
        }
        public (string, string, double, int) WriteSet()
        {
            Console.WriteLine($"Это ваши данные: \n{Name}, \n{Adress}, \n{Balance}, \n{Age}");
            var dataUser = (Name, Adress, Balance, Age);
            return dataUser;
        }
        //public int CheckYears()
        //{
        //    int age;
        //    bool cycle = default;

        //    while (cycle != true)
        //    {
        //        age = int.Parse(Console.ReadLine());
        //        if ((age < 18))
        //        {
        //            cycle = false; string s = "Вам не хватает лет, нужно бльше 18";
        //            Console.WriteLine(s);
        //        }
        //        else
        //        {
        //            cycle = true;
        //            this.Age = age;
        //        }
        //    }
        //    return this.Age;
        //}
    }
    /// <summary>
    /// индексация
    /// </summary>
    class UserCollection
    {
        private UserData[] users;
        public UserCollection(UserData[] users)
        {
            this.users = users;
        }
        public UserData this[int index]
        {
            get
            {
                if (index >= 0 && index < users.Length)
                {
                    return users[index];
                }
                return null;
            }
            set
            {
                if (index >= 0 && index < users.Length)
                {
                    users[index] = value;
                }
            }
        }
    }
    class UserData : User
    {
        public (string, string, double, int) UserSetData(int i)
        {

            var arrUser = UserData.UserDataSet();

            UserCollection userCollection = new UserCollection(arrUser);
            UserData userData = new UserData();
            userData = userCollection[i];

            UserWrite userWrite = new UserWrite(userData.Name, userData.Adress, userData.Balance, userData.Age);
            Console.Write($"Это ваши данные: {i + 1} \n{userData.Name},\n{userData.Adress},\n{userData.Balance},\n{userData.Age}\n\n");
            var dataUser = (userData.Name, userData.Adress, userData.Balance, userData.Age);
            return dataUser;
        }
        /// <summary>
        /// здесь массив с людьм
        /// </summary>
        /// <returns></returns>
        public static UserData[] UserDataSet()
        {
            var DataUserGet = new UserData[]
            {
                new UserData
                {
                   Name = "Никола",
                   Adress = "улица 1 Мая дом 5",
                   Balance = 15060,
                   Age = 19
                },
                new UserData
                {
                   Name = "Павел",
                   Adress = "3-я улица Строителей, дом 25",
                   Balance = 5970,
                   Age = 25
                },
                new UserData
                {
                   Name = "Эдвард",
                   Adress = "Централ, дом 11",
                   Balance = 30000,
                   Age = 100
                }
            };
            return DataUserGet;
        }
    }
}