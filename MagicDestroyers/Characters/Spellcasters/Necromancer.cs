using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Leather;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Necromancer : Spellcaster
    {
        private const Faction DefaultFaction = Faction.Spellcaster;
        private const int DefaultHealthPoints = 50;
        private const int DefaultManaPoints = 50;
        private const int DefaultLevel = 1;
        private const string DefaultName = "Necromancer";

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

        public Necromancer(string name, int level, int healthPoints)
        {
            Name = name;
            Level = level;
            HealthPoints = healthPoints;

            ManaPoints = DefaultManaPoints;
            BodyArmor = DefaultBodyArmor;
            Faction = DefaultFaction;
            Weapon = DefaultWeapon;
        }

        public Necromancer(string name, int level) : this(name, level, DefaultHealthPoints) { }

        public Necromancer() : this(DefaultName, DefaultLevel) { }

        public void ShadowRage()
        {
            throw new NotImplementedException();
        }

        public void VampireTouch()
        {
            throw new NotImplementedException();
        }

        public void BoneShield()
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
