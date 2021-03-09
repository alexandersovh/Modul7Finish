using System;

namespace Modul7Finish
{
    class Program
    {
        static void Main(string[] args)
        {
            //Order.UserDisplay();
            //var a = Console.ReadLine();
            ////Order.Сhoose<string>(a);
            //int b = int.Parse(Console.ReadLine());
            
            string str = Console.ReadLine();
            int num;
            bool isNum = int.TryParse(str, out num);
            if (isNum)
            {
                Order.СhooseCat<int>(num);
            }
            else
            {
                Order.СhooseCat<string>(str);
            }

            Console.ReadLine();
        }
    }
}