namespace MagicDestroyers.Equipment.Weapons
{
    public class Sword
    {
        private int _damage;

        public int Damage
        {
            get { return _damage; }
            set { _damage = (value > 1) ? value : throw new ArgumentOutOfRangeException("Damage"); }
        }

        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }
    }
}
