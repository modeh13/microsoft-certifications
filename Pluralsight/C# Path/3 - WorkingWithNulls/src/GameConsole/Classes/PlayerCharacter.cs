using System;
using GameConsole.Abstractions;

namespace GameConsole.Classes
{
    class PlayerCharacter
    {
        private ISpecialDefence _specialDefence;
        private SpecialDefence _specialDefenceWithBaseClass;

        public string Name { get; set; }
        public int DaysSinceLastLogin { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Health { get; set; }

        public PlayerCharacter(ISpecialDefence specialDefence)
        {
            // Magic number are defined in order to represent null values for ValueTypes.
            DaysSinceLastLogin = -1;
            DateOfBirth = DateTime.MinValue;            
            Health = 100;
            _specialDefence = specialDefence;
        }

        public PlayerCharacter(SpecialDefence specialDefence)
        {
            _specialDefenceWithBaseClass = specialDefence;
        }

        public void Hit(int damage)
        {
            int totalDamageTaken = 0;
            int damageReduction = 0;

            damageReduction = _specialDefence.CalculateDamageReduction(damage);
            totalDamageTaken = damage - damageReduction;
            
            Health -= totalDamageTaken;

            Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Health}");
        }
    }
}