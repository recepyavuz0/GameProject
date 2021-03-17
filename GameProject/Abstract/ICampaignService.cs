using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface ICampaignService
    {
        public void Add(Campaign campaign);
        public void Delete(Campaign campaign);
        public void Update(Campaign campaign);
    }
}
