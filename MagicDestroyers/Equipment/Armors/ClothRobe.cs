namespace MagicDestroyers.Equipment.Armors
{
    public class ClothRobe
    {
        private int _armorPoints;

        public int ArmorPoints
        {
            get { return _armorPoints; }
            set { _armorPoints = (value > 1) ? value : 1; }
        }
    }
}
