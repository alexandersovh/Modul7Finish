using System;

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
        public static string UserDisplay()
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
                userData2.UserSetData(ires - 1);

                return userData2.UserSetData(ires - 1);
            }
            else
            {
                UserWrite userWrite = new UserWrite();
                return userWrite.WriteSet();
            }

        }
        public static void DisplayProductAll()
        {
            string name;
            Console.WriteLine("Здравствуйте, {0}, выберете категорию, для продолжния пакупки:", name = UserDisplay());
            Console.WriteLine();
            Console.WriteLine("наипишите на русском с мальнькой буквы или укажите номер");

        }
        public static void СhooseCat<T>(T ch)
        {



            switch (ch)
            {
                case "игры":
                    var ga = GameData.DataBase();
                    Game game = new Game();
                    game.DisplayAll(ga);
                    break;
                case "материнские платы":
                    var mData = MatherbordData.DataBase();
                    Matherbord matherbord = new Matherbord();
                    matherbord.DisplayAll(mData);
                    break;
                case "процессоры":
                    var cpuData = CPUData.DataBase();
                    CPU cpu = new CPU();
                    cpu.DisplayAll(cpuData);
                    break;
                case "видеокарты":
                    var gpuData = GPUData.DataBase();
                    GPU gpu = new GPU();
                    gpu.DisplayAll(gpuData);
                    break;
                case "блоки питения":
                    var psData = PowerSupplyData.DataBase();
                    PowerSupply powerSupply = new PowerSupply();
                    powerSupply.DisplayAll(psData);
                    break;
                case "ноутбуки":
                    var lData = LaptopsData.DataBase();
                    Laptops laptops = new Laptops();
                    laptops.DisplayAll(lData);
                    break;
            }
            switch (ch)
            {
                case 1:
                    var ga = GameData.DataBase();
                    Game game = new Game();
                    game.DisplayAll(ga);
                    break;
                case 2:
                    var mData = MatherbordData.DataBase();
                    Matherbord matherbord = new Matherbord();
                    matherbord.DisplayAll(mData);
                    break;
                case 3:
                    var cpuData = CPUData.DataBase();
                    CPU cpu = new CPU();
                    cpu.DisplayAll(cpuData);
                    break;
                case 4:
                    var gpuData = GPUData.DataBase();
                    GPU gpu = new GPU();
                    gpu.DisplayAll(gpuData);
                    break;
                case 5:
                    var psData = PowerSupplyData.DataBase();
                    PowerSupply powerSupply = new PowerSupply();
                    powerSupply.DisplayAll(psData);
                    break;
                case 6:
                    var lData = LaptopsData.DataBase();
                    Laptops laptops = new Laptops();
                    laptops.DisplayAll(lData);
                    break;
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
