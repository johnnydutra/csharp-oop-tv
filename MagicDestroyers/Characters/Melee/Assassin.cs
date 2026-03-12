using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Melee
{
    public class Assassin : Melee
    {
        private const Faction DefaultFaction = Faction.Melee;
        private const string DefaultName = "Assassin";
        private const int DefaultCombatPoints = 20;
        private const int DefaultHealthPoints = 50;
        private const int DefaultLevel = 1;

        private readonly LightLeatherVest DefaultBodyArmor = new();
        private readonly Sword DefaultWeapon = new();

        private LightLeatherVest _bodyArmor;
        private Sword _weapon;

        public LightLeatherVest BodyArmor
        {
            get => _bodyArmor;
            set { _bodyArmor = value; }
        }

        public Sword Weapon
        {
            get => _weapon;
            set { _weapon = value; }
        }

        public Assassin(string name, int level, int healthPoints)
        {
            Name = name;
            Level = level;
            HealthPoints = healthPoints;

            CombatPoints = DefaultCombatPoints;
            BodyArmor = DefaultBodyArmor;
            Faction = DefaultFaction;
            Weapon = DefaultWeapon;
        }

        public Assassin(string name, int level): this(name, level, DefaultHealthPoints) { }

        public Assassin() : this(DefaultName, DefaultLevel) { }

        public void Raze()
        {
            throw new NotImplementedException();
        }

        public void BleedToDeath()
        {
            throw new NotImplementedException();
        }

        public void Survival()
        {
            throw new NotImplementedException();
        }
    }
}
