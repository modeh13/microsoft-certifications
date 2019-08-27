using GameConsole.Abstractions;

namespace GameConsole.Classes
{
    class DiamondSkinDefence : ISpecialDefence
    {
        public int CalculateDamageReduction(int totalDamage)
        {
            return 1;
        }
    }
}