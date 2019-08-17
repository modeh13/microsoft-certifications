namespace GameConsole.Abstractions
{
    abstract class SpecialDefence
    {
        public static SpecialDefence Null { get; } = new NullDefence();

        public abstract int CalculateDamageReduction(int totalDamage);

        private class NullDefence : SpecialDefence
        {
            public override int CalculateDamageReduction(int totalDamage)
            {
                return 0; // No operation - "do nothing" behavior.
            }
        }
    }
}