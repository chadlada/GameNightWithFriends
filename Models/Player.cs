namespace GameNightWithFriends.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Foreign Key
        public int GameNightId { get; set; }
        // Gives back associated GameNight for this player
        public GameNight GameNight { get; set; }
    }
}