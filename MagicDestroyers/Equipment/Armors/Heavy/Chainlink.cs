namespace MagicDestroyers.Equipment.Armors.Heavy
{
    public class Chainlink : HeavyArmor
    {
        private const int DefaultArmorPoints = 10;

        public Chainlink(int armorPoints)
        {
            ArmorPoints = armorPoints;
        }

        public Chainlink() : this(DefaultArmorPoints) { }
    }
}
