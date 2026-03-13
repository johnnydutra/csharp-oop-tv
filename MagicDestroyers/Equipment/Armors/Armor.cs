namespace MagicDestroyers.Equipment.Armors
{
    public abstract class Armor
    {
        private int _armorPoints;

        public int ArmorPoints
        {
            get => _armorPoints;
            set
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value, 1);
                _armorPoints = value;
            }
        }
    }
}
