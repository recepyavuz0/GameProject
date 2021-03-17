using GameProject.Abstract;

namespace GameProject.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public int Price { get; set; }
    }
}
