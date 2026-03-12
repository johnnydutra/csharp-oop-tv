using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior : Melee
    {
        private const Faction DefaultFaction = Faction.Melee;
        private const string DefaultName = "Warrior";
        private const int DefaultCombatPoints = 50;
        private const int DefaultHealthPoints = 50;
        private const int DefaultLevel = 1;

        private readonly Chainlink DefaultBodyArmor = new();
        private readonly Axe DefaultWeapon = new();

        private Chainlink _bodyArmor;
        private Axe _weapon;

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

            CombatPoints = DefaultCombatPoints;
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
