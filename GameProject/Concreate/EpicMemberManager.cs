using GameProject.Abstract;
using GameProject.Adapter;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concreate
{
    class EpicMemberManager:BaseMemberService
    {
        IMemberCheckService _memberCheckServiceAdapter;

        public EpicMemberManager(IMemberCheckService memberCheckServiceAdapter)
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
