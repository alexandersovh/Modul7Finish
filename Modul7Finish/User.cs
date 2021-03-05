using System;
using System.Collections.Generic;
using System.Text;

namespace Modul7Finish
{
    class User
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public double Balance { get; set; }
        public int Age { get; set; }

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
            Age = CheckYears();
        }
        public UserWrite(string name, string adress, int balance, int age)
        {
            Name = name;
            Adress = adress;
            Balance = balance;
            Age = age;
            //var arrayUser = UserData.UserDataSet();
        }
        /// <summary>
        /// проверка возроста
        /// </summary>
        /// <returns></returns>
        public int CheckYears()
        {
            int age;
            bool cycle = default;

            while (cycle != true)
            {
                age = int.Parse(Console.ReadLine());
                if ((age < 18))
                {
                    cycle = false; string s = "Вам не хватает лет, нужно бльше 18";
                    Console.WriteLine(s);
                }
                else
                {
                    cycle = true;
                    this.Age = age;
                }
            }
            return this.Age;
        }
    }
    /// <summary>
    /// индексация
    /// </summary>
    class UserCollection
    {
        private User[] users;
        public UserCollection(User[] users)
        {
            this.users = users;
        }
        public User this[int index]
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
    static class UserData
    {
        /// <summary>
        /// здесь массив с людьм
        /// </summary>
        /// <returns></returns>
        public static User[] UserDataSet()
        {
            var DataUserGet = new User[]
            {
                new User
                {
                   Name = "Никола",
                   Adress = "улица 1 Мая дом 5",
                   Balance = 1506,
                   Age = 19
                },
                new User
                {
                   Name = "Павел",
                   Adress = "3-я улица Строителей, дом 25",
                   Balance = 597,
                   Age = 25
                },
                new User
                {
                   Name = "Эдвард",
                   Adress = "Централ, дом 11",
                   Balance = 3000,
                   Age = 100
                }
            };
            return DataUserGet;
        }
    }
}