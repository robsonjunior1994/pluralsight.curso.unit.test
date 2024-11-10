
namespace GameEngine.Models
{
    public class PlayerCharacter
    {
        private int _health;

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
                OnPropertyChanged();
            }
        }
        public bool IsNoob { get; set; }
        public List<string> Weapons { get; set; }

        public PlayerCharacter()
        {
            FirstName = GenerateRandomFirstName();
            IsNoob = true;
            CreateStatingWeapons();
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
        private void OnPropertyChanged()
        {
            //throw new NotImplementedException();
        }
        private void CreateStatingWeapons()
        {
            //throw new NotImplementedException();
        }

        private string? GenerateRandomFirstName()
        {
            //throw new NotImplementedException();
            return null;
        }
    }
}
