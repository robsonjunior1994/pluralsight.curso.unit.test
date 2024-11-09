using System;

namespace pluralsight.curso.unit.test.Models
{
    public class PlayerCharacter
    {
        public int Health { get; set; }

        public PlayerCharacter()
        {
            Health = 100;
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
