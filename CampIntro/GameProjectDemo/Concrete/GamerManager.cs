using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        IVerificationService _verificationService;

        public GamerManager(IVerificationService verificationService)
        {
            _verificationService = verificationService;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " deleted player");
        }

        public void Save(Gamer gamer)
        {
            if (_verificationService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " added player");
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " updated player");
        }
    }
}
