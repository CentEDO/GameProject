using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.IDNumber = "1111111111";
            user1.Name = "Amy";
            user1.Surname = "Smith";
            user1.YearofBirth = 2000;

            User user2 = new User();
            user2.IDNumber = "2222222222";
            user2.Name = "Jack";
            user2.Surname = "Wilson";
            user2.YearofBirth = 1998;

            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "Winter";
            campaign1.DiscountRate = 25;
            
            Campaign campaign2 = new Campaign();
            campaign2.CampaignName = "Summer";
            campaign2.DiscountRate = 20;

            Market market1 = new Market();
            market1.ProductID = 1;
            market1.ProductName = "Wallet Key";
            market1.Price = 30;
            market1.Price_Summer = 24;
            market1.Price_Winter = 22;

            Market market2 = new Market();
            market2.ProductID = 2;
            market2.ProductName = "DLC";
            market2.Price = 10;
            market2.Price_Summer = 8;
            market2.Price_Winter = 7;

            UserManager userManager = new UserManager();
            userManager.Register(user2);
            userManager.Delete(user2);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.AddCampaign(campaign2);


        }
    }
}
