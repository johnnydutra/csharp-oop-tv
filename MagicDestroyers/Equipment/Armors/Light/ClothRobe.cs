namespace MagicDestroyers.Equipment.Armors.Light
{
    public class ClothRobe : LightArmor
    {
        private const int DefaultArmorPoints = 10;

        public ClothRobe(int armorPoints)
        {
            ArmorPoints = armorPoints;
        }

        public ClothRobe() : this(DefaultArmorPoints) { }
    }
}
