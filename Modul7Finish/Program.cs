using System;

namespace Modul7Finish
{
    class Program
    {
        static void Main(string[] args)
        {
            //Order order = new Order();

            //Hardware hardware = new Hardware();
            ////hardware.
            //order.UserCall();
            var PGArray = ProductData.GametDataBase();
            var Marray = ProductData.MatherbordDataBase();
            var CPUarray = ProductData.CPUDataBase();
            var GPUarray = ProductData.GPUDataBase();
            var PSMarray = ProductData.PowerSupplyDataBase();
            var Larray = ProductData.LaptopsDataBase();



            ProductCollection<Game> PG = new ProductCollection<Game>(PGArray);
            ProductCollection<Matherbord> mather = new ProductCollection<Matherbord>(Marray);

            Game game = new Game();

            

            Console.WriteLine(game.Id);

            Console.ReadLine();
        }
    }
}