using GameConsole.Abstractions;

namespace GameConsole.Classes
{
    class NullDefence : ISpecialDefence
    {
        public int CalculateDamageReduction(int totalDamage)
        {
            return 0; // No operation - "do nothing" behavior.
        }
    }
}