namespace MagicDestroyers.Equipment.Weapons.Blunt.Blunt
{
    public class Staff : BluntWeapon
    {
        private const int DefaultDamagePoints = 10;

        public Staff(int damagePoints)
        {
            DamagePoints = damagePoints;
        }

        public Staff() : this(DefaultDamagePoints) { }

        public override void Buff()
        {
            throw new NotImplementedException();
        }

        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}
