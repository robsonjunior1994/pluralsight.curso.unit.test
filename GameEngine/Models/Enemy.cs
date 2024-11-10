﻿namespace GameEngine.Models
{
    public abstract class Enemy
    {
        public string Name { get; set; }
        public abstract double TotalSpecialPower { get; }
        public abstract double SpecialPowerUses { get; }
        public double SpecialSttackPower => TotalSpecialPower / SpecialPowerUses;
    }
}
