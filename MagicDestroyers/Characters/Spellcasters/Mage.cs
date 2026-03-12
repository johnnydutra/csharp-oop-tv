using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage : Spellcaster
    {
        private const Faction DefaultFaction = Faction.Spellcaster;
        private const int DefaultManaPoints = 50;
        private const int DefaultHealthPoints = 50;
        private const int DefaultLevel = 1;
        private const string DefaultName = "Mage";

        private readonly ClothRobe DefaultBodyArmor = new();
        private readonly Staff DefaultWeapon = new();

        private ClothRobe _bodyArmor;
        private Staff _weapon;

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

            ManaPoints = DefaultManaPoints;
            BodyArmor = DefaultBodyArmor;
            Faction = DefaultFaction;
            Weapon = DefaultWeapon;
        }

        public Mage(string name, int level) : this(name, level, DefaultHealthPoints) { }

        public Mage() : this(DefaultName, DefaultLevel) { } 

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
