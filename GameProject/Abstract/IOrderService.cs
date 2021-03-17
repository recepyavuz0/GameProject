using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IOrderService
    {
        public void Sale(Member member,Game game);

        public void Sale(Member member, Game game,Campaign campaign);

    }
}
