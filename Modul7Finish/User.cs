using System;
using System.Collections.Generic;
using System.Text;

namespace Modul7Finish
{
    class User
    {
        /// <summary>
        /// св-ва
        /// </summary>
        public string Name { get; private set; }
        public string Adress { get; private set; }
        public double Balance { get; private set; }
        public int Age { get; private set; }

        /// <summary>
        /// конструсторы
        /// </summary>
        public User()
        {
            Console.Write("введите Имя: ");
            Name = Console.ReadLine();

            Console.Write("введите адрес: ");
            Adress = Console.ReadLine();

            Console.Write("введите баланс: ");
            Balance = double.Parse(Console.ReadLine());

            Console.Write("введите возраст: ");
            Age = this.CheckYears();
        }

        public User(string name, string adress, int balance, int age)
        {
            Name = name;
            Adress = adress;
            Balance = balance;
            Age = age;
        }
        public void DataUser()
        {
            Console.Write("Здравствуйте {0} ваши данные: \n\t{1} \n\t{2} \n\t{3}",
                   Name,
                   Adress,
                   Balance,
                   Age);
        }
        public static void DataUser(int resalt)
        {
            Console.Write("Здравствуйте {0} ваши данные: \n\t{1} \n\t{2} \n\t{3}",
                   UserData.UserArray[resalt - 1].Name,
                   UserData.UserArray[resalt - 1].Adress,
                   UserData.UserArray[resalt - 1].Balance,
                   UserData.UserArray[resalt - 1].Age);
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
    static class UserData
    {
        public static User[] UserArray;
        public static User[] UserDataSet()
        {
            User[] DataArray = new User[3];

            DataArray[0] = new User("Никола", "улица 1 Мая, дом 5", 1506, 19);
            DataArray[1] = new User("Павел", "3-я улица Строителей, дом 25", 597, 25);
            DataArray[2] = new User("Эдвард", "Централ, дом 11", 3000, 100);

            UserArray = DataArray;

            return DataArray;
        }
    }
}
