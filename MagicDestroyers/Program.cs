namespace MagicDestroyers
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior theGoodGuy = new("The Good Guy", 190, 80);
            Warrior theBadGuy = new("The Bad Guy", 200, 100);

            theGoodGuy.Greet(theBadGuy);
            theBadGuy.Greet(theGoodGuy);
        }
    }
}
