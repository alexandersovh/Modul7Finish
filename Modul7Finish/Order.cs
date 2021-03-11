﻿using System;

namespace Modul7Finish
{
    class Order
    {
        public static (string Name, string Adress, double Balance, int Age) UserDisplay()
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
                UserData userData2 = new UserData();

                return userData2.UserSetData(ires - 1);
            }
            else
            {
                UserWrite userWrite = new UserWrite();
                return userWrite.WriteSet();
            }

        }
        public static (int[], double[]) СhooseCat<T>(T ch)
        {
            switch (ch)
            {
                case "игры":
                    Console.WriteLine("игры");
                    var ga = GameData.DataBase();
                    Game game = new Game();
                    return game.Display(ga);
                    break;
                case "материнские платы":
                    Console.WriteLine("материнские платы");
                    var mData = MatherbordData.DataBase();
                    Matherbord matherbord = new Matherbord();
                    //matherbord.DisplayAll(mData);
                    return matherbord.Display(mData);
                    break;
                case "процессоры":
                    Console.WriteLine("процессоры");
                    var cpuData = CPUData.DataBase();
                    CPU cpu = new CPU();
                    return cpu.Display(cpuData);
                    break;
                case "видеокарты":
                    Console.WriteLine("видеокарты");
                    var gpuData = GPUData.DataBase();
                    GPU gpu = new GPU();
                    return gpu.Display(gpuData);
                    break;
                case "блоки питания":
                    Console.WriteLine("блоки питaния");
                    var psData = PowerSupplyData.DataBase();
                    PowerSupply powerSupply = new PowerSupply();

                    return powerSupply.Display(psData); ;
                    break;
                case "ноутбуки":
                    Console.WriteLine("ноутбуки");
                    var lData = LaptopsData.DataBase();
                    Laptops laptops = new Laptops();
                    return laptops.Display(lData);
                    break;
                case 1:
                    Console.WriteLine("игры");
                    var ga1 = GameData.DataBase();
                    Game game1 = new Game();
                    return game1.Display(ga1);
                    break;
                case 2:
                    Console.WriteLine("материнские платы");
                    var mData1 = MatherbordData.DataBase();
                    Matherbord matherbord1 = new Matherbord();
                    return matherbord1.Display(mData1);
                    break;
                case 3:
                    Console.WriteLine("процессоры");
                    var cpuData1 = CPUData.DataBase();
                    CPU cpu1 = new CPU();
                    return cpu1.Display(cpuData1);
                    break;
                case 4:
                    Console.WriteLine("видеокарты");
                    var gpuData1 = GPUData.DataBase();
                    GPU gpu1 = new GPU();
                    return gpu1.Display(gpuData1);
                    break;
                case 5:
                    Console.WriteLine("блоки питения");
                    var psData1 = PowerSupplyData.DataBase();
                    PowerSupply powerSupply1 = new PowerSupply();
                    return powerSupply1.Display(psData1);
                    break;
                case 6:
                    Console.WriteLine("ноутбуки");
                    var lData1 = LaptopsData.DataBase();
                    Laptops laptops1 = new Laptops();
                    return laptops1.Display(lData1);
                    break;
                default:
                    Console.WriteLine("Нет такой категории");
                    int[] a = default;
                    double[] b = default;
                    return (a, b);
                    break;
            }
        }
        public static (int Id, double Prise) LogicСhoice(string name)
        {
            //string name;
            int iCicle = 1;
            string[] categories = new string[] { "игры", "материнские платы", "процессоры", "видеокарты", "блоки питaния", "ноутбуки" };
            Console.WriteLine("Здравствуйте, {0}, выберете категорию, для продолжния пакупки:", name);
            foreach (string a in categories)
            {
                Console.WriteLine("№ " + iCicle++ + " " + a);
            }
            Console.WriteLine("наипишите на русском с мальнькой буквы или укажите номер категории");

            string str = Console.ReadLine();
            int num;
            int[] id;
            double[] prise;
            bool isNum = int.TryParse(str, out num);
            if (isNum)
            {
                (id, prise) = (Order.СhooseCat<int>(num));
            }
            else
            {
                (id, prise) = (Order.СhooseCat<string>(str));
            }
            Console.Write("введите Id тавара для которое хотите приобрести:");
            int idProduct = int.Parse(Console.ReadLine());
            int iArray = -1;
            int idNum = default;
            double priseNum = default;
            do
            {
                iArray++;
                idNum = id[iArray];
                priseNum = prise[iArray];
            } while (id[iArray] != idProduct && iArray < id.Length);

            Console.WriteLine("Ваш тавар с id {0} и ценой {1}", idNum, priseNum);
            return (idNum, priseNum);
        }
        public static void LogicBuy((string Name, string Adress, double Balance, int Age) userDisplay )
        {
            User user = new User();
            string n = userDisplay.Name;
            double balance = userDisplay.Balance;
            double prise = LogicСhoice(n).Prise;
            double sum = user.LogicBuyUser(prise, balance);
            Console.WriteLine("остаток: " + sum);
            Console.WriteLine("спасибо за покупку, досвидани");

        }
    }
}
