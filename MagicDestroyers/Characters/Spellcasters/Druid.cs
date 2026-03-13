using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Leather;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Druid : Spellcaster
    {
        private const Faction DefaultFaction = Faction.Spellcaster;
        private const int DefaultManaPoints = 50;
        private const int DefaultHealthPoints = 50;
        private const int DefaultLevel = 1;
        private const string DefaultName = "Druid";

        private readonly LightLeatherVest DefaultBodyArmor = new();
        private readonly Staff DefaultWeapon = new();

        private LightLeatherVest _bodyArmor;
        private Staff _weapon;

        public LightLeatherVest BodyArmor
        {
            get => _bodyArmor;
            set { _bodyArmor = value; }
        }

        public Staff Weapon
        {
            get => _weapon;
            set { _weapon = value; }
        }

        public Druid(string name, int level, int healthPoints)
        {
            Name = name;
            Level = level;
            HealthPoints = healthPoints;

            ManaPoints = DefaultManaPoints;
            BodyArmor = DefaultBodyArmor;
            Faction = DefaultFaction;
            Weapon = DefaultWeapon;
        }

        public Druid(string name, int level): this(name, level, DefaultHealthPoints) { }

        public Druid() : this(DefaultName, DefaultLevel) { }

        public void Moonfire()
        {
            throw new NotImplementedException();
        }

        public void Starburst()
        {
            throw new NotImplementedException();
        }

        public void OneWithTheNature()
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void SpecialAttack()
        {
            throw new NotImplementedException();
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }
    }
}
