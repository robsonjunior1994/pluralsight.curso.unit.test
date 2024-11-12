namespace GameEngine.Models
{
    public class NormalEnemy : Enemy
    {
        public string Name { get; set; }

        public override double TotalSpecialPower => 100;

        public override double SpecialPowerUses => 2;
    }
}