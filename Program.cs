using System;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyweightFactory factory = new FlyweightFactory();            
            Flyweight flyweight1 = factory.GetFlyweight("related");
            flyweight1.Operation("hello world");
            Flyweight flyweight2 = factory.GetFlyweight("unrelated");
            flyweight2.Operation("hello second world");
            Flyweight flyweight3 = factory.GetFlyweight("related");
            flyweight3.Operation("hello super world");
            Flyweight flyweight4 = factory.GetFlyweight("unrelated");
            flyweight4.Operation("Bye");
        }
    }
}
