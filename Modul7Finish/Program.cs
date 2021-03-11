using System;

namespace Modul7Finish
{
    class Program
    {
        static void Main(string[] args)
        {
            //Order.DisplayProductAll();
            
            Order.LogicBuy(Order.UserDisplay());
            Console.WriteLine("спасибо за покупку, досвидани");

            Console.ReadLine();
        }
    }
}