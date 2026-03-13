namespace MagicDestroyers.Characters.Melee
{
    public abstract class Melee : Character
    {
        private const int MinCombatPoints = 0;
        private const int MaxCombatPoints = 20;

        private int _combatPoints;

        public int CombatPoints
        {
            get => _combatPoints;
            set
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value, MinCombatPoints);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value, MaxCombatPoints);
                _combatPoints = value;
            }
        }
    }
}
