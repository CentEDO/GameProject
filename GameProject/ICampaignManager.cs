using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignManager
    {
        void AddCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);
        void RemoveCampaign(Campaign campaign);
    }
}
