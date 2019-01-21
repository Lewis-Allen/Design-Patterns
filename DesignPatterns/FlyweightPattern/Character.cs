using System;

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
