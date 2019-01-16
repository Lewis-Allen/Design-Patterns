using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{

    public class CharacterFlyweightFactory
    {
        private Dictionary<char, Character> flyweightPool;

        public CharacterFlyweightFactory()
        {
            flyweightPool = new Dictionary<char, Character>();
        }

        public Character GetFlyweight(char key)
        {
            if (flyweightPool.ContainsKey(key))
            {
                return flyweightPool[key];
            }
            else
            {
                flyweightPool.Add(key, new Character(key));
                return flyweightPool[key];
            }
        }
    }
}
