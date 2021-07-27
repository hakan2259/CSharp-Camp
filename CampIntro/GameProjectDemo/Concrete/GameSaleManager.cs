using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    public class GameSaleManager : IGameSaleService
    {
        public void Sale(Gamer gamer, Game game, Campaign campaign)
        {
            double discountedPrice = game.Price - (game.Price*(campaign.Discount / 100));
            Console.WriteLine(game.Name + " game sold to " + gamer.FirstName + " " + gamer.LastName);
            Console.WriteLine("Price without discount => " + game.Price);
            Console.WriteLine("Discount rate => %" + campaign.Discount);
            Console.WriteLine("Discounted price of the game => " + discountedPrice);



        }
    }
}
