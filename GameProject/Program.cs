using System;
using GameProject.Entities;
using GameProject.Concreate;
using GameProject.Adapter;
namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Member member1 = new Member();
            member1.Id = 1;
            member1.TcNo = "11111111111";
            member1.FirstName = "Ali";
            member1.LastName = "Can";
            member1.DateOfBirth = new DateTime(1996,10,2);

            Member member2 = new Member() {
                Id = 2, TcNo = "2222222222",
                FirstName = "Mehmet",
                LastName = "Can",
                DateOfBirth = new DateTime(1999, 10, 29) 
            };

            MemberManager memberManager = new MemberManager(new MernisServiceAdapter());
            Console.WriteLine("MemberManager");
            memberManager.Add(member1);
            memberManager.Delete(member1);
            memberManager.Update(member1);
            Console.WriteLine("------------------------------------");

            SteamMemberManager steamMemberManager = new SteamMemberManager(new MernisServiceAdapter());
            Console.WriteLine("SteamMemberManager");
            steamMemberManager.Add(member2);
            steamMemberManager.Delete(member2);
            steamMemberManager.Update(member2);
            Console.WriteLine("------------------------------------");

            EpicMemberManager epicMemberManager = new EpicMemberManager(new MernisServiceAdapter());
            Console.WriteLine("EpicMemberManager");
            epicMemberManager.Add(member2);
            epicMemberManager.Delete(member2);
            epicMemberManager.Update(member2);
            Console.WriteLine("------------------------------------");


            Game game1 = new Game() { Id = 1, GameName = "ETS2", Price = 38 };
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Delete(game1);
            gameManager.Update(game1);

            Campaign campaign1 = new Campaign() {Id=1,CampaignName="Yıl Başı",CampaignType="İndirim"};
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign1);
            campaignManager.Update(campaign1);

            OrderManager orderManager = new OrderManager();
            //Kampanyasız
            orderManager.Sale(member1,game1);
            //Kampanyalı
            orderManager.Sale(member2,game1,campaign1);
        }
    }
}
