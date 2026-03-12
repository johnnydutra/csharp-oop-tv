using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage
    {
        private int _abilityPoints;
        private int _healthPoints;
        private int _level;

        private string _faction;
        private string _name;

        private ClothRobe _bodyArmor;
        private Staff _weapon;

        public int AbilityPoints
        {
            get => _abilityPoints;
            set
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value, 0);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value, 100);
                _abilityPoints = value;
            }
        }

        public int HealthPoints
        {
            get => _healthPoints;
            set
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value, 0);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value, 100);
                _healthPoints = value;
            }
        }

        public int Level
        {
            get => _level;
            set
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value, 1);
                _level = value;
            }
        }

        public string Faction
        {
            get => _faction;
            set
            {
                if (value != "Melee" && value != "Spellcaster")
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

        public ClothRobe BodyArmor
        {
            get => _bodyArmor;
            set { _bodyArmor = value; }
        }

        public Staff Weapon
        {
            get => _weapon;
            set { _weapon = value; }
        }

        public Mage(string name, int level, int healthPoints)
        {
            Name = name;
            Level = level;
            HealthPoints = healthPoints;

            AbilityPoints = 100;
            BodyArmor = new ClothRobe();
            Faction = "Spellcaster";
            Weapon = new Staff();
        }

        public Mage(string name, int level) : this(name, level, 100) { }

        public Mage() : this("Unnamed Mage", 1) { } 

        public void ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public void Firewall()
        {
            throw new NotImplementedException();
        }

        public void Meditation()
        {
            throw new NotImplementedException();
        }
    }
}
