using GameProject.Abstract;
using GameProject.Adapter;
using GameProject.Entities;
using System;

namespace GameProject.Concreate
{
    public class MemberManager : IMemberService
    {
        MernisServiceAdapter _mernisServiceAdapter;

        public MemberManager(MernisServiceAdapter mernisServiceAdapter)
        {
            _mernisServiceAdapter = mernisServiceAdapter;
        }

        public void Add(Member member)
        {
            if (_mernisServiceAdapter.CheckIfRealPerson(member))
            {
                Console.WriteLine($"{member.FirstName} oyunumuza üye oldu.");
            }
            else
            {
                Console.WriteLine("Girilen üye bilgilerini kontrol ediniz.");
            }
            
        }

        public void Delete(Member member)
        {
            if (_mernisServiceAdapter.CheckIfRealPerson(member))
            {
                Console.WriteLine($"{member.FirstName} oyunumuzu terk etti.");
            }
            else
            {
                Console.WriteLine("Girilen üye bilgilerini kontrol ediniz.");
            }
           
        }

        public void Update(Member member)
        {
            if (_mernisServiceAdapter.CheckIfRealPerson(member))
            {
                Console.WriteLine($"{member.FirstName} bilgilerini güncelledi.");
            }
            else
            {
                Console.WriteLine("Girilen üye bilgilerini kontrol ediniz.");
            }
        }
    }
}
