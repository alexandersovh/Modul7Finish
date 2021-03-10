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

                return userData2.UserSetData(ires - 1).Item1;
            } 
            else
            {
                UserWrite userWrite = new UserWrite();
                return userWrite.WriteSet().Item1;
            }

        }
        public static void DisplayProductAll()
        {
            string name;
            int i = 1;
            string[] categories = new string[] { "игры", "материнские платы", "процессоры", "видеокарты", "блоки питaния", "ноутбуки" };
            Console.WriteLine("Здравствуйте, {0}, выберете категорию, для продолжния пакупки:", name = UserDisplay());
            foreach(string a in categories)
            {
                Console.WriteLine("№ " + i++ + " " + a);
            }
            Console.WriteLine();
            Console.WriteLine("наипишите на русском с мальнькой буквы или укажите номер категории");
        }
        public static int[] СhooseCat<T>(T ch)
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
                    
                    return powerSupply.Display(psData);;
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
                    int[] a = new int[] { 0 };
                    return a;
                    break;
            }
        }
        public static void LogicBuy()
        {
            string str = Console.ReadLine();
            int num;
            int[] id;
            bool isNum = int.TryParse(str, out num);
            if (isNum)
            {
                //Order.СhooseCat<int>(num);
                id = (Order.СhooseCat<int>(num));
            }
            else
            {
                //Order.СhooseCat<string>(str);
                id = (Order.СhooseCat<string>(str));
            }
            Console.Write("введите Id тавара для которое хотите приобрести:");
            int idProduct = int.Parse(Console.ReadLine());
            int i = 0;
            while (id[i] != idProduct && i < id.Length)
            {
                i++;
            } 



            Console.WriteLine("Ваш тавар");
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
