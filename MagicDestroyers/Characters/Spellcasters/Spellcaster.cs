namespace MagicDestroyers.Characters.Spellcasters
{
    public class Spellcaster : Character
    {
        private const int MinManaPoints = 0;
        private const int MaxManaPoints = 10;

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
