namespace MagicDestroyers.Equipment.Armors.Leather
{
    public class LightLeatherVest : LeatherArmor
    {
        private const int DefaultArmorPoints = 10;

        public LightLeatherVest(int armorPoints)
        {
            ArmorPoints = armorPoints;
        }

        public LightLeatherVest() : this(DefaultArmorPoints) { }
    }
}
