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
            

            ProductCollection<Game> PG = new ProductCollection<Game>(PGArray);

            for(int i = 0; i < PGArray.Length; i++ )
            {
                Game game = PG[i];
                Console.WriteLine($" {i + 1}) {game.Id}, {game.Name}, {game.Prise}, {game.Monufacturer}, {game.AgeRating} :^)");
                Console.WriteLine(game.Id.GetHashCode());
            }
            Console.ReadLine();
        }
    }

}