using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public abstract class BaseMemberService : IMemberService
    {
        public virtual void Add(Member member)
        {
            Console.WriteLine($"{member.FirstName} oyunumuza üye oldu.");
        }

        public virtual void Delete(Member member)
        {
            Console.WriteLine($"{member.FirstName} oyunumuzu terk etti.");
        }

        public virtual void Update(Member member)
        {
            Console.WriteLine($"{member.FirstName} bilgilerini güncelledi.");
        }
    }
}
