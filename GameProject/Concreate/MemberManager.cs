using GameProject.Abstract;
using GameProject.Adapter;
using GameProject.Entities;
using System;

namespace GameProject.Concreate
{
    public class MemberManager : IMemberService
    {
        IMemberCheckService _memberCheckServiceAdapter;

        public MemberManager(IMemberCheckService memberCheckServiceAdapter)
        {
            _memberCheckServiceAdapter = memberCheckServiceAdapter;
        }

        public void Add(Member member)
        {
            if (_memberCheckServiceAdapter.CheckIfRealPerson(member))
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
            if (_memberCheckServiceAdapter.CheckIfRealPerson(member))
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
            if (_memberCheckServiceAdapter.CheckIfRealPerson(member))
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
