using GameProject.Abstract;
using GameProject.Entities;
using System;

namespace GameProject.Concreate
{
    public class OrderManager : IOrderService
    {
        public void Sale(Member member, Game game)
        {
            Console.WriteLine($"{member.FirstName} isimli üyemiz" +
                $" {game.GameName} isimli oyunu satın aldı");
        }

        public void Sale(Member member, Game game, Campaign campaign)
        {
            Console.WriteLine($"{member.FirstName} isimli üyemiz " +
                $"{campaign.CampaignName} kampanyası ile {game.GameName}" +
                $" isimli oyunu satın aldı");
        }
    }
}
