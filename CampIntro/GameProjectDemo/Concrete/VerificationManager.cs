﻿using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    public class VerificationManager : IVerificationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            if(gamer.NationalityId.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
