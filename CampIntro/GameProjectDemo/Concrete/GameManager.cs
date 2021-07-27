using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    public class GameManager : IGameService
    {
        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " deleted game!");
        }

        public void Save(Game game)
        {
            Console.WriteLine(game.Name + " added game!");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " updated game!");
        }
    }
}
