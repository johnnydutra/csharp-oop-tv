namespace MagicDestroyers.Characters.Spellcasters
{
    public abstract class Spellcaster : Character
    {
        private const int MinManaPoints = 0;
        private const int MaxManaPoints = 20;

        private int _manaPoints;

        public int ManaPoints
        {
            get => _manaPoints;
            set
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value, MinManaPoints);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value, MaxManaPoints);
                _manaPoints = value;
            }
        }
    }
}
