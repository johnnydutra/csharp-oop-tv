using MagicDestroyers.Interfaces;

namespace MagicDestroyers.Equipment.Weapons
{
    public abstract class Weapon : IBuff
    {
        private int _damagePoints;

        public int DamagePoints
        {
            get => _damagePoints;
            set
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value, 1);
                _damagePoints = value;
            }
        }

        public abstract void Buff();
    }
}
