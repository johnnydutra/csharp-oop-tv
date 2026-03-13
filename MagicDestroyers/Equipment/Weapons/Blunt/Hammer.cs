namespace MagicDestroyers.Equipment.Weapons.Blunt.Blunt
{
    public class Hammer : BluntWeapon
    {
        private const int DefaultDamagePoints = 10;

        public Hammer(int damagePoints)
        {
            DamagePoints = damagePoints;
        }

        public Hammer() : this(DefaultDamagePoints) { }

        public override void Buff()
        {
            throw new NotImplementedException();
        }

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
