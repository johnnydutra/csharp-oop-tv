namespace MagicDestroyers.Equipment.Weapons
{
    public class Hammer
    {
        private int _damage;

        public int Damage
        {
            get { return _damage; }
            set { _damage = (value > 1) ? value : 1; }
        }

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
