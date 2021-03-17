using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface IMemberService
    {
        public void Add(Member member);
        public void Delete(Member member);
        public void Update(Member member);
    }
}
