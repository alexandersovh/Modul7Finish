using System;

namespace Modul7Finish
{
    class Program
    {
        static void Main(string[] args)
        {
            //Order.DisplayProductAll();
            var usre = Order.UserDisplay();
            Order.LogicBuy(usre);
            Console.WriteLine("спасибо за покупку, досвидани");

            Console.ReadLine();
        }
    }
}