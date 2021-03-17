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
        MernisServiceAdapter _mernisServiceAdapter;

        public EpicMemberManager(MernisServiceAdapter mernisServiceAdapter)
        {
            _mernisServiceAdapter = mernisServiceAdapter;
        }

        public override void Add(Member member)
        {
            if (_mernisServiceAdapter.CheckIfRealPerson(member))
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
            if (_mernisServiceAdapter.CheckIfRealPerson(member))
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
            if (_mernisServiceAdapter.CheckIfRealPerson(member))
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
