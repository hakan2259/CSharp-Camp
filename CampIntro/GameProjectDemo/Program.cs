using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer player1 = new Gamer();
            player1.Id = 1;
            player1.FirstName = "Hakan";
            player1.LastName = "Sandal";
            player1.NationalityId = "12002004477";
            player1.DateOfBirth = new DateTime(1996, 3, 13);


            Gamer player2 = new Gamer();
            player2.Id = 1;
            player2.FirstName = "Betul";
            player2.LastName = "Yesildag";
            player2.NationalityId = "13003003377";
            player2.DateOfBirth = new DateTime(1996, 11, 8);

            Game game1 = new Game
            {
                Id = 1,
                Name= "Fortnite",
                CategoryName="Battle Royale",
                Price=50
                
            };

            Game game2 = new Game
            {
                Id = 2,
                Name = "Grand Theft Auto V",
                CategoryName = "Action adventure",
                Price = 250
            };

            Campaign promotion1 = new Campaign();
            promotion1.Name = "Summer Sale";
            promotion1.Discount = 25;

            Campaign promotion2 = new Campaign();
            promotion2.Name = "Black Friday";
            promotion2.Discount = 50;

            GamerManager gamerManager = new GamerManager(new VerificationManager());
            gamerManager.Save(player1);
            gamerManager.Save(player2);
            gamerManager.Update(player1);
            gamerManager.Delete(player2);

            Console.WriteLine("--------------------------------");

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(player1, game2, promotion2);





        }
    }
}
