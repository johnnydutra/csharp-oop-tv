namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Axe : SharpWeapon
    {
        private const int DefaultDamagePoints = 10;

        public Axe(int damagePoints)
        {
            DamagePoints = damagePoints;
        }

        public Axe() : this(DefaultDamagePoints) { }

        public override void Buff()
        {
            throw new NotImplementedException();
        }

        public void HackNSlash()
        {
            throw new NotImplementedException();
        }
    }
}
