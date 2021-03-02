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
        //public double Spent { get; private set; }
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
    class UserData
    {
        public User[] UserDataSet()
        {
            User[] DataArray;
            DataArray[1] = new User("Никола", "улица 1Мая, дом 5", 1506, 19);
            DataArray[] = new User("Павел", "3-я улица Строителей, дом 25", 597, 25);
            DataArray[1] = new User("Эдвард", "Централ, дом 11", 3000, 100);

             

            return DataArray;
        }
    }
}
