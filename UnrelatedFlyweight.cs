namespace FlyweightPattern
{
    public class UnrelatedFlyweight : Flyweight
    {

        public void Operation(string context)
        {
            System.Console.WriteLine("Unrelated does what it has to do.");
        }
    }
}