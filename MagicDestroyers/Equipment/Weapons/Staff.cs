namespace MagicDestroyers.Equipment.Weapons
{
    public class Staff
    {
        private int _damage;

        public int Damage
        {
            get { return _damage; }
            set { _damage = (value > 1) ? value : 1; }
        }

        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}
