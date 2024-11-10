
namespace GameEngine.Models
{
    public class PlayerCharacter
    {
        private int _health;

        public bool IsNoob { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Nickname { get; set; }
        public int Health
        {
            get => _health;
            set
            {
                _health = value;
            }
        }


        public PlayerCharacter()
        {
            Health = 100;
            IsNoob = true;
        }

        public void Sleep()
        {
            var heathIncrease = CalculateHealthIncrease();
            Health += heathIncrease;
        }

        private int CalculateHealthIncrease()
        {
            var rnd = new Random();
            return rnd.Next(1, 101);
        }
    }
}
