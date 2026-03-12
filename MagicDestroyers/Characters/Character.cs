using MagicDestroyers.Enums;

namespace MagicDestroyers.Characters
{
    public class Character
    {
        private const int MinLevel = 1;
        private const int MaxLevel = 10;
        private const int MinHealthPoints = 0;
        private const int MaxHealthPoints = 200;
        private const int MinNameLength = 3;
        private const int MaxNameLength = 15;

        private Faction _faction;
        private string _name;
        private int _level;
        private int _healthPoints;

        public Faction Faction
        {
            get => _faction;
            set
            {
                if (value != Faction.Melee || value != Faction.Spellcaster)
                {
                    throw new ArgumentException(string.Empty, "The faction should be either Melee or Spellcaster");
                }
                _faction = value;
            }
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


    }
}
