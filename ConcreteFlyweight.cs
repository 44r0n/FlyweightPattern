namespace FlyweightPattern
{
    public class ConcreteFlyweight : Flyweight
    {
        private string intrinsicState;

        public ConcreteFlyweight()
        {
            intrinsicState = "ConcreteFlyweight says: ";
        }

        public void Operation(string context)
        {
            System.Console.WriteLine(intrinsicState + context);
        }
    }
}