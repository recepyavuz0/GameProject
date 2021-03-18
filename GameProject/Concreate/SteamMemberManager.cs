using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;
using GameProject.Adapter ;
namespace GameProject.Concreate
{
    public class SteamMemberManager : BaseMemberService
    {
        IMemberCheckService _memberCheckServiceAdapter;

        public SteamMemberManager(IMemberCheckService memberCheckServiceAdapter)
        {
            _memberCheckServiceAdapter = memberCheckServiceAdapter;
        }

        public override void Add(Member member)
        {
            if (_memberCheckServiceAdapter.CheckIfRealPerson(member))
            {
                base.Add(member);
            }
            else
            {
                Console.WriteLine("Girilen üye bilgilerini kontrol ediniz.");
            }
        }

        public override void Delete(Member member)
        {
            if (_memberCheckServiceAdapter.CheckIfRealPerson(member))
            {
                base.Delete(member);
            }
            else
            {
                Console.WriteLine("Girilen üye bilgilerini kontrol ediniz.");
            }
        }

        public override void Update(Member member)
        {
            if (_memberCheckServiceAdapter.CheckIfRealPerson(member))
            {
                base.Update(member);
            }
            else
            {
                Console.WriteLine("Girilen üye bilgilerini kontrol ediniz.");
            }
        }
    }
}
