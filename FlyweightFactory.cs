using System.Collections.Generic;

namespace FlyweightPattern
{
    public class FlyweightFactory
    {
        private Dictionary<string,Flyweight> flyweights;

        public FlyweightFactory()
        {
            flyweights = new Dictionary<string, Flyweight>();
        }

        public Flyweight GetFlyweight(string key)
        {
            if(!flyweights.ContainsKey(key))
            {
                Flyweight flyweight = createFlyweight(key);
                flyweights.Add(key,flyweight);
            }
            return flyweights[key];
        }

        private Flyweight createFlyweight(string key)
        {
            switch (key)
            {
                case "related":
                    return new ConcreteFlyweight();
                case "unrelated":
                    return new UnrelatedFlyweight();
                default:
                    throw new KeyNotFoundException("Key not found: " + key);
            }
        }
    }
}