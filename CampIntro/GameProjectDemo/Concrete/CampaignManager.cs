using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " promotion deleted!");
        }

        public void Save(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " promotion added!");
            Console.WriteLine("Campaign discount : %" + campaign.Discount);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " promotion updated!");
            Console.WriteLine("New campaign discount : %" + campaign.Discount);
        }
    }
}
