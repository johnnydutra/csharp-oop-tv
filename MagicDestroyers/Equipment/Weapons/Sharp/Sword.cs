namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Sword : SharpWeapon
    {
        private const int DefaultDamagePoints = 10;

        public Sword(int damagePoints)
        {
            DamagePoints = damagePoints;
        }

        public Sword() : this(DefaultDamagePoints) { }

        public override void Buff()
        {
            throw new NotImplementedException();
        }

        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }
    }
}
