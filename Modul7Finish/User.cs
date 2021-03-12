using System;
using System.Collections.Generic;
using System.Text;

namespace Modul7Finish
{
    class User
    {
        public string Name { get; set; }
        protected string Adress { get; set; }
        protected double Balance { get; set; }
        public int age;
        protected int Age
        {
            get 
            {  
                if (age < 18 )
                {
                    Console.WriteLine("Возраст меньше 18 лет, некоторые покупки будут недоступны\n");
                    return age;
                }
                return age; 
            }
            set { }
        }
        public double LogicBuyUser(double prise, double balanse)
        {
            Balance = balanse;
            if (prise <= Balance)
            {
                return Balance -= prise;
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
    class UserCollection : UserData
    {
        
        public UserData[] users = UserData.UserDataGet();
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
        public (string Name, string Adress, double Balance, int age) UserSetData(int i)
        {
            Console.Write($"Это ваши данные: {i + 1} \n{Name},\n{Adress},\n{Balance},\n{age}\n");

            return (Name, Adress, Balance, Age);
        }
        /// <summary>
        /// здесь массив с людьм
        /// </summary>
        /// <returns></returns>
        public static UserData[] UserDataGet()
        {
            var DataUserGet = new UserData[]
            {
                new UserData
                {
                   Name = "Никола",
                   Adress = "улица 1 Мая дом 5",
                   Balance = 15060,
                   age = 16
                },
                new UserData
                {
                   Name = "Павел",
                   Adress = "3-я улица Строителей, дом 25",
                   Balance = 5970,
                   age = 25
                },
                new UserData
                {
                   Name = "Эдвард",
                   Adress = "Централ, дом 11",
                   Balance = 30000,
                   age = 100
                }
            };
            return DataUserGet;
        }
    }
}