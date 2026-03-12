using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior
    {
        private const int DefaultAbilityPoints = 50;
        private const int DefaultHealthPoints = 50;
        private const int DefaultLevel = 1;

        private const int MinAbilityPoints = 0;
        private const int MinHealthPoints = 0;
        private const int MinLevel = 1;

        private const int MaxAbilityPoints = 100;
        private const int MaxHealthPoints = 100;
        private const int MaxLevel = 100;

        private const string DefaultName = "Warrior";
        private const Faction DefaultFaction = Faction.Melee;

        private readonly Chainlink DefaultBodyArmor = new();
        private readonly Axe DefaultWeapon = new();

        private int _abilityPoints;
        private int _healthPoints;
        private int _level;

        private Faction _faction;

        private string _name;

        private Chainlink _bodyArmor;
        private Axe _weapon;

        public int AbilityPoints
        {
            get => _abilityPoints;
            set
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value, MinAbilityPoints);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value, MaxAbilityPoints);
                _abilityPoints = value;
            }
        }

        public int HealthPoints
        {
            get => _healthPoints;
            set
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value, MinHealthPoints);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value, MaxHealthPoints);
                _healthPoints = value;
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

        public Faction Faction
        {
            get => _faction;
            set
            {
                if (value != Faction.Melee)
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
                if (value.Length < 3 || value.Length > 12)
                {
                    throw new ArgumentException(string.Empty, "Inappropriate length of name, name should be between 3 and 12 characters.");
                }
                _name = value;
            }
        }

        public Chainlink BodyArmor
        {
            get => _bodyArmor;
            set { _bodyArmor = value; }
        }

        public Axe Weapon
        {
            get => _weapon;
            set { _weapon = value; }
        }

        public Warrior(string name, int level, int healthPoints)
        {
            Name = name;
            Level = level;
            HealthPoints = healthPoints;

            AbilityPoints = DefaultAbilityPoints;
            BodyArmor = DefaultBodyArmor;
            Faction = DefaultFaction;
            Weapon = DefaultWeapon;
        }

        public Warrior(string name, int level) : this(name, level, DefaultHealthPoints) { }

        public Warrior() : this(DefaultName, DefaultLevel) { }

        public void Strike()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void SkinHarden()
        {
            throw new NotImplementedException();
        }
    }
}
