using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager:ICampaignManager
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine("Added the new" + campaign.CampaignName + "campaign!");
        }
        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " campaign has been updated! ");
        }
        public void RemoveCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " campaign has been removed!");
        }
    }
}
