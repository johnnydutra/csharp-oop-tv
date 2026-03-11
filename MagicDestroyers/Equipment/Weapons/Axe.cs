namespace MagicDestroyers.Equipment.Weapons
{
    public class Axe
    {
        private int _damage;

        public int Damage
        {
            get { return _damage; }
            set { _damage = (value > 1) ? value : 1; }
        }

        public void HackNSlash()
        {
            throw new NotImplementedException();
        }
    }
}
