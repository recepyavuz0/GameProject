using GameProject.Abstract;
using System;

namespace GameProject.Entities
{
    public class Member:IEntity
    {
        public int Id { get; set; }
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
