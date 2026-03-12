using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Melee
{
    public class Knight : Melee
    {
        private const Faction DefaultFaction = Faction.Melee;
        private const string DefaultName = "Knight";
        private const int DefaultCombatPoints = 50;
        private const int DefaultHealthPoints = 50;
        private const int DefaultLevel = 1;

        private readonly Chainlink DefaultBodyArmor = new();
        private readonly Hammer DefaultWeapon = new();

        private Chainlink _bodyArmor;
        private Hammer _weapon;

        public Chainlink BodyArmor
        {
            get => _bodyArmor;
            set { _bodyArmor = value; }
        }

        public Hammer Weapon
        {
            get => _weapon;
            set { _weapon = value; }
        }

        public Knight(string name, int level, int healthPoints)
        {
            Name = name;
            Level = level;
            HealthPoints = healthPoints;

            CombatPoints = DefaultCombatPoints;
            BodyArmor = DefaultBodyArmor;
            Faction = DefaultFaction;
            Weapon = DefaultWeapon;
        }

        public Knight(string name, int level): this(name, level, DefaultHealthPoints) { }

        public Knight(): this(DefaultName, DefaultLevel) { }

        public void HolyBlow()
        {
            throw new NotImplementedException();
        }

        public void PurifySoul()
        {
            throw new NotImplementedException();
        }

        public void RighteousWings()
        {
            throw new NotImplementedException();
        }
    }
}
