using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class Character : ICharacter
    {
        public char character;

        public Character(char character)
        {
            this.character = character;
        }

        public void PrintCharacter()
        {
            Console.Write(character);
        }
    }
}
