using MagicDestroyers.Enums;
using MagicDestroyers.Interfaces;

namespace MagicDestroyers.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        private const int MinLevel = 1;
        private const int MaxLevel = 10;
        private const int MinHealthPoints = 1;
        private const int MaxHealthPoints = 200;
        private const int MinNameLength = 3;
        private const int MaxNameLength = 15;

        private Faction _faction;
        private string _name;
        private int _healthPoints;
        private int _level;

        public Faction Faction
        {
            get => _faction;
            set { _faction = value; }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < MinNameLength || value.Length > MaxNameLength)
                {
                    throw new ArgumentException(
                        string.Empty,
                        $"Name should be between {MinNameLength} and {MaxNameLength} characters.");
                }
                _name = value;
            }
        }

        public int Level
        {
            get => _level;
            set
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value, MinLevel);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value, MaxLevel);
                _level = value;
            }
        }

        public virtual int HealthPoints
        {
            get => _healthPoints;
            set
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value, MinHealthPoints);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value, MaxHealthPoints);
                _healthPoints = value;
            }
        }

        public abstract void Attack();

        public abstract void SpecialAttack();

        public abstract void Defend();

    }
}
